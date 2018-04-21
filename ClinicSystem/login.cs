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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            int result = authentication();
            if (result == 0)
            {
                // 跳转管理员
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if (result == 1)
            {
                // 跳转医生
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if (result == 2)
            {
                // 跳转普通用户
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private int authentication()
        {
            String qx = cb_qx.Text.ToString().Trim();
            String name = txt_name.Text.ToString().Trim();
            String pwd = txt_pwd.Text.ToString().Trim();
            String sql = "";
            if (qx == "管理员")
            {
                sql = "select * from operators where name = '" + name + "' and password = '" + pwd + "' and role = 0";
            }
            if (qx == "医生")
            {
                sql = "select * from doctor where name = '" + name + "' and password = '" + pwd + "' and role = 1";
            }
            if (qx == "普通用户")
            {
                sql = "select * from users where username = '" + name + "' and password = '" + pwd + "'";
            }
            sqlHelper sh = new sqlHelper();
            String a = sh.ReturnSql(sql);
            if (a != null)
            {
                if (qx == "管理员")
                {
                    return 0;
                }
                else if (qx == "医生")
                {
                    return 1;
                }
                else if (qx == "普通用户")
                {
                    return 2;
                }
                else
                {
                    return -1;
                }
            }
            return -1;
        }

        private void login_Load(object sender, EventArgs e)
        {
            cb_qx.SelectedIndex = 0;
        }
    }
}
