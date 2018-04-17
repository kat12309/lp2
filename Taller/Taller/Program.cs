using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Taller
{
    static class Program
    {
        static void funcion2()
        {
            Console.WriteLine("World");
        }
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]        
        static void Main()
        {
            Class1 obj = new Class1();
            obj.funcion();
            funcion2();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
