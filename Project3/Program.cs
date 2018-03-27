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
    static class Data
    {
        static void StudentDataTable()
        {
            
            DataTable table = GetTable();
        }
        static DataTable GetTable()
        {
            Random rnd = new Random();
            int StudentID = rnd.Next(100000, 1000000);
            
            if(StudentTitle.Text() = "Athlete")
            {
                Random rndF = new Random();
                int Floor = rndF.Next(4, 7);
                int Payment = 1200;
            }
            if (StudentTitle.Text() = "Student Worker")
            {
                Random rndF = new Random();
                int Floor = rndF.Next(1, 4);
                int Hours = rndF.Next(10, 31);
                int Payment = 1245 - (14*Hours);
            }
            if (StudentTitle.Text() = "Scholorship")
            {
                Random rndF = new Random();
                int Floor = rndF.Next(7, 9);
                int Payment = 100;
            }

            DataTable table = new DataTable();
            table.Columns.Add("StudentID", typeof(int));
            table.Columns.Add("First Name", typeof(string));
            table.Columns.Add("Last Name", typeof(string));
            table.Columns.Add("Floor", typeof(string));
            table.Columns.Add("Student Title", typeof(string));
            table.Columns.Add("Payment", typeof(string));

            table.Rows.Add(123456, "David", "Smith", Floor, StudentTitle, Payment);

            return table;
        }
    }
}
// Ive created a data table to store the information for each student, only issue now is getting information
// to be added when different selections are made from different window/tabs, student id and floors have been
// randomized to work accurately for whats needed. as in certain students can only be assigned certain floors