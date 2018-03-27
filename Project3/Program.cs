using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
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
            Application.Run(new DunwoodyResidenceHallFormUN());
        }
    }
}
// thinking of a way to create a data set that connects information together. like if i searched 1234
// it would search the name and information assigned to that number. the student number will be created
// from the random function but need to make it so that it cant use the same number twice.