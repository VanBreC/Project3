using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class ProcessSelectionTab : Form
    {

        public ProcessSelectionTab()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void CreateStudentPage_Click(object sender, EventArgs e)
        {

        }

        private void ScholorshipBox_CheckedChanged(object sender, EventArgs e)
        {
            string StudentTitle = "Scholorship";
            
        }

        private void AthleteBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StudentWorkerBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FirstNTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateStudent_Click(object sender, EventArgs e)
        {

        }

        static void StudentDataTable()
        {

            DataTable table = GetTable();
        }
        static DataTable GetTable()
        {
            Random rnd = new Random();
            int StudentID = rnd.Next(100000, 1000000);

            if (StudentTitle.String() = "Athlete")
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
                int Payment = 1245 - (14 * Hours);
                return Floor;
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
    /*static class Data
    {
        static void StudentDataTable()
        {

            DataTable table = GetTable();
        }
        static DataTable GetTable()
        {
            Random rnd = new Random();
            int StudentID = rnd.Next(100000, 1000000);

            if (StudentTitle.Text() = "Athlete")
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
                int Payment = 1245 - (14 * Hours);
                return Floor;
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
    }*/
}
