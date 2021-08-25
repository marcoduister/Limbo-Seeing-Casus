using Limbo_Seeing.Models;
using System;
using Limbo_Seeing.Views;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Limbo_Seeing.DAL;

namespace Limbo_Seeing
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static DataSeeder seed = new DataSeeder();
        [STAThread]
        static void Main()
        {
            seed.Seeder();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartBase());
        }
    }
}
