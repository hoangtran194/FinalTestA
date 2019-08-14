using FinalTestA.Objects;
using FinalTestA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * STUDENT NAME: Tran Huy Hoang
 * STUDENT ID: 300 979 272
 * DESCRIPTION: This is the main class of the program
 */
namespace FinalTestA
{
    static class Program
    {
        public static HeroGenerator heroGenerator;
        public static AboutBoxForm aboutBoxForm;

        public static Hero character;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            character = new Hero();

            heroGenerator = new HeroGenerator();
            aboutBoxForm = new AboutBoxForm();

            Application.Run(heroGenerator);
        }
    }
}
