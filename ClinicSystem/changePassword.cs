using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSystem
{
    public partial class changePassword : Form
    {
        public changePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string old_pwd = txt_old_pwd.Text.ToString().Trim();
            string new_pwd = txt_new_pwd.Text.ToString().Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
