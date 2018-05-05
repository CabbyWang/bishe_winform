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
using System.Data.SqlClient;

namespace ClinicSystem
{
    public partial class cx_keshixinxi : Form
    {
        public cx_keshixinxi()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String name = Base.getTextFrom(txt_name);
            String kszr = Base.getTextFrom(txt_kszr);
            String address = Base.getTextFrom(txt_address);
            String sql = "select * from department where name like '%"+name+"%' and kszr like '%"+kszr+"%' and address like '%"+address+"%'";
            sqlHelper sh = new sqlHelper();
            sh.BindDgv(dgv_keshixinxi, sql, "keshixinxi");
        }

        private void cx_keshixinxi_Load(object sender, EventArgs e)
        {
            String sql = "select * from department";
            sqlHelper sh = new sqlHelper();
            sh.BindDgv(dgv_keshixinxi, sql, "keshixinxi");
        }
    }
}
