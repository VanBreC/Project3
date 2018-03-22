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
    public partial class SelectionTab : Form
    {
        public SelectionTab()
        {
            InitializeComponent();
        }

        private void SelectionTab_Load(object sender, EventArgs e)
        {

        }

        private void CreateStudent_Click(object sender, EventArgs e)
        {
            CreateStudentProfile createStudentProfile = new CreateStudentProfile();
            createStudentProfile.ShowDialog();
        }

        private void SearchStudent_Click(object sender, EventArgs e)
        {
            SearchStudentProfile searchStudentProfile = new SearchStudentProfile();
            searchStudentProfile.ShowDialog();
        }
    }
}
