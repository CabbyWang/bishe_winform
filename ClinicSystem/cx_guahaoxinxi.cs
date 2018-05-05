using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicSystem.App_Code;

namespace ClinicSystem
{
    public partial class cx_guahaoxinxi : Form
    {
        public cx_guahaoxinxi()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string sql = "select * from registation where id = '"+txt_id.Text.ToString().Trim()+"' or yiliaozhenghao = '"+txt_yiliaozhenghao.Text.ToString().Trim()+"'";
            sqlHelper sh = new sqlHelper();
            sh.BindDgv(dgv_guahaoxinxi, sql, "guahaoxinxi");
        }
    }
}
