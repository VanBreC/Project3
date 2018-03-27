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
    public partial class CreateStudentProfile : Form
    {
        public CreateStudentProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CreateStudentProfile_Load(object sender, EventArgs e)
        {

        }

        private void ScholarshipBox_CheckedChanged(object sender, EventArgs e)
        {
            string StudentTitle = "Scholarship";
        }

        private void AthleteBox_CheckedChanged(object sender, EventArgs e)
        {
            string StudentTitle = "Athlete";
        }

        private void StudentWorkerBox_CheckedChanged(object sender, EventArgs e)
        {
            string StudentTitle = "Student Worker";
        }
    }
}
