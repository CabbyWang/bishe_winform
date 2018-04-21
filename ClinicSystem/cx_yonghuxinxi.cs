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
    public partial class cx_yonghuxinxi : Form
    {
        public cx_yonghuxinxi()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_contact.Clear();
            txt_realname2.Clear();
            txt_username2.Clear();
            cb_sex2.SelectedIndex = 0;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String username = Base.getTextFrom(txt_username);
            String realname = Base.getTextFrom(txt_realname);
            String sex = Base.getTextFrom(cb_sex);
            String sql = "select * from users where username like '%" + username + "%' and realname like '%" + realname + "%' and address like '%" + sex + "%'";
            sqlHelper sh = new sqlHelper();
            sh.BindDgv(dgv_yishengxinxi, sql, "yonghuxinxi");
        }
    }
}
