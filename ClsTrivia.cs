using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hangfire;
using Newtonsoft.Json.Linq;
using static Hangfire.Storage.JobStorageFeatures;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using static Proyecto.ClsTrivia;
using System.Data.SqlClient;

namespace Proyecto
{
    public class ClsTrivia
    {
        private static HttpClient cliente = new HttpClient();
        private int categoria; // La categoría de la pregunta
        private String dificultad; // El nivel de dificultad de la pregunta
        public String pregunta = ""; // El texto de la pregunta//
        public String[] respuestas; // El arreglo de las posibles res
        private int respuestaCorrecta; // El índice de la res correcta
        private double puntos = 0, multiplicador = 0;
        public bool acerto = false;
        public int? respSeleccionada;
        public delegate void DelegadoImprimir(string cadena);
        public DelegadoImprimir delPrint;
        ProgressBar barra;
        string connectionString = "Data Source=DESKTOP-CUHOBBB\\MYSQL;Initial Catalog=Puntuaciones;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";





        public ClsTrivia(int categoria, string dificultad, ProgressBar barra)
        {
            this.categoria = categoria;
            this.dificultad = dificultad;
            this.barra = barra;
          
            
        }   

        public async Task JugarRonda()
        { 
            await GenerarPregunta();
            Desplegar();
            ElegirRespuesta(await EsperarRespuesta(barra));

        }

        public async Task GenerarPregunta()
        {
            string url = $"https://opentdb.com/api.php?amount=1&category={categoria}" +
                $"&difficulty={dificultad}&type=multiple";

            var respuesta = await cliente.GetStringAsync(url);
            var data = JObject.Parse(respuesta);

            this.pregunta = (string)data["results"][0]["question"];

            if (pregunta.Contains("&quot;"))
            {
                pregunta = pregunta.Replace("&quot;", "'");
            }
            if (pregunta.Contains("#039;s"))
            {
                pregunta = pregunta.Replace("#039;s", "'s");
            }
            if (pregunta.Contains("#039;"))
            {
                pregunta = pregunta.Replace("#039;", "'s");
            }


            this.respuestas = data["results"][0]["incorrect_answers"].ToObject<string[]>();
            this.respuestaCorrecta = new Random().Next(0, this.respuestas.Length);

            Array.Resize(ref this.respuestas, this.respuestas.Length + 1);
            Array.Copy(this.respuestas, this.respuestaCorrecta, this.respuestas, this.respuestaCorrecta + 1, this.respuestas.Length - this.respuestaCorrecta - 1);
            this.respuestas[this.respuestaCorrecta] = (string)data["results"][0]["correct_answer"];


        }

        public void Desplegar() 
        {
            delPrint(pregunta);
            delPrint(respuestas[0]);
            delPrint(respuestas[1]);
            delPrint(respuestas[2]);
            delPrint(respuestas[3]);
        }




        public async Task<int?> EsperarRespuesta(ProgressBar tiempo)
        {

            while (tiempo.Value > 0)
            {
                await Task.Delay(100); 
            }
            return respSeleccionada;
           
        }


        public void ElegirRespuesta(int? respuesta)
        {

            if (respuesta == respuestaCorrecta)
            {
                acerto = true;
            }
            else
                acerto = false;
            if (respSeleccionada == null)
            {

            }
        }

        public async Task ActualizarRanking(DataGridView data)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                // Obtener los usuarios
                SqlCommand commandUsuarios = new SqlCommand("SELECT Usuario FROM Puntuaciones", connection);
                SqlDataReader readerUsuarios = commandUsuarios.ExecuteReader();

                List<int> usuarios = new List<int>();
                while (await readerUsuarios.ReadAsync())
                {
                    usuarios.Add(readerUsuarios.GetInt32(0));
                }

                readerUsuarios.Close();

                // Obtener las puntuaciones
                SqlCommand commandPuntuaciones = new SqlCommand("SELECT Puntos FROM Puntuaciones", connection);
                SqlDataReader readerPuntuaciones = commandPuntuaciones.ExecuteReader();

                List<int> puntuaciones = new List<int>();
                while (await readerPuntuaciones.ReadAsync())
                {
                    puntuaciones.Add(readerPuntuaciones.GetInt32(0));
                }

                readerPuntuaciones.Close();

                // Combinar los usuarios con sus puntuaciones
                var usuariosConPuntuaciones = usuarios.Zip(puntuaciones, (usuario, puntos) => new { Usuario = usuario, Puntos = puntos }).ToList();

                // Ordenar y agregar a la tabla
                usuariosConPuntuaciones.Sort((p1, p2) => p2.Puntos.CompareTo(p1.Puntos));
                foreach (var puntuacion in usuariosConPuntuaciones)
                {
                    data.Rows.Add(puntuacion.Usuario, puntuacion.Puntos);
                }
            }
        }





        public async Task RegsitrarPuntuacion(int usuario, int puntos)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand(@"
            INSERT INTO Puntuaciones (Usuario, Puntos)
            VALUES (@usuario, @puntos)", connection);

                command.Parameters.AddWithValue("@usuario",usuario);
                command.Parameters.AddWithValue("@puntos", puntos);

                await command.ExecuteNonQueryAsync();
            }
        }
        public class Puntuacion
        {
            public int Usuario { get; set; }
            public int Puntos { get; set; }
        }

    }
}


    