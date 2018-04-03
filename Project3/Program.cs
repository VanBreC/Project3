using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

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
// Ive created a data table to store the information for each student, only issue now is getting information
// to be added when different selections are made from different window/tabs, student id and floors have been
// randomized to work accurately for whats needed. as in certain students can only be assigned certain floors