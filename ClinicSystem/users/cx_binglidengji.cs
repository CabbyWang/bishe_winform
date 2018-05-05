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

namespace ClinicSystem.users
{
    public partial class cx_binglidengji : Form
    {
        public cx_binglidengji()
        {
            InitializeComponent();
        }

        private void btn_searh_Click(object sender, EventArgs e)
        {
            string sql = "select * from bingli where id = '"+txt_id.Text+"' or patientid = '"+txt_yiliaozhenghao.Text+"'";
            sqlHelper sh = new sqlHelper();
            sh.BindDgv(dgv_bingli, sql, "binglixinxi");
        }
    }
}
