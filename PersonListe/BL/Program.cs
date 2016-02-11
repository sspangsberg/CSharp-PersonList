#region Imports

//C# imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

//Project imports
using PersonListe.GUI;

#endregion

namespace PersonListe.BL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PersonListeForm());
        }
    }
}
