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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void SignInPassword_TextChanged(object sender, EventArgs e)
        {
            if (SignInPassword.Text == "1234")
            {
                ProcessSelectionTab processSelectionTab = new ProcessSelectionTab();
                processSelectionTab.ShowDialog();
                

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
