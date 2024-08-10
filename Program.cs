using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using Hangfire;
using Hangfire.SqlServer;


namespace Proyecto
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GlobalConfiguration.Configuration
               .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
               .UseColouredConsoleLogProvider()
               .UseSimpleAssemblyNameTypeSerializer()
               .UseRecommendedSerializerSettings()
               .UseSqlServerStorage("Data Source=DESKTOP-CUHOBBB\\MYSQL;Initial Catalog=Trivia;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


            
            using (var server = new BackgroundJobServer())
            {
                BackgroundJob.Enqueue(() => Console.WriteLine("Hello, world!"));
                Application.Run(new Form1());
            }


        }


    }
}
