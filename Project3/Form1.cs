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
    public partial class DunwoodyResidenceHallFormUN : Form
    {
        public DunwoodyResidenceHallFormUN()
        {
            InitializeComponent();
        }

        private void SignInLabel_Click(object sender, EventArgs e)
        {

        }

        private void SignInUserName_TextChanged(object sender, EventArgs e)
        {
            if (SignInUserName.Text == "home")
            {
                Form2 passwordsignin = new Form2();
                passwordsignin.ShowDialog();
                
                
            }
            
        }
    }
}
