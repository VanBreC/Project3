using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        static void ScholorshipBox_CheckedChanged(object sender, EventArgs e)
        {
            
            
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
        
        /*static void StudentDataTable()
        {

            DataTable table = GetTable();
        }
        static DataTable GetTable()
        {
            
            Random rnd = new Random();
            int StudentID = rnd.Next(100000, 1000000);

            if (ScholorshipBox.Checked())
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
        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<StudentList> ListAdd = new List<StudentList>();
            StudentList sbInfo;
            string FileRead = @"C:\Users\vanbrec\source\repos\Project3\StudentInfo.csv";
            const char DELIMITER = ',';
            string[] columns;
            string newFileWrite = @"C:\Users\vanbrec\source\repos\Project3\StudentInfo.csv";


            try
            {

                FileStream file = new FileStream(FileRead, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);
                //Skip headers
                reader.ReadLine();

                while (!reader.EndOfStream)
                {

                    columns = reader.ReadLine().Split(DELIMITER);
                    sbInfo = new StudentList(columns[0], columns[1], columns[2], columns[3], columns[4], columns[5]);

                    ListAdd.Add(sbInfo);

                }

                reader.Close();
                file.Close();


            }
            catch (Exception i)
            {
                Console.WriteLine(i.Message);
            }
        }
    }
    class StudentList
    {
        public string studentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string floor { get; set; }
        public string studentTitle { get; set; }
        public string payment { get; set; }
        



        public StudentList(string studentID, string firstName, string lastName, string floor, string studentTitle, string payment)
        {
            this.studentID = studentID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.floor = floor;
            this.studentTitle = studentTitle;
            this.payment = payment;
      


        }

    }

}
