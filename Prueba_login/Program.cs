using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_login
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
           


            Dictionary<string, string> usuarios = new Dictionary<string, string>();

            usuarios.Add("admin", "1234");
            usuarios.Add("usuario1", "password1");
            usuarios.Add("usuario2", "password2");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(usuarios));


        }
    }
}
