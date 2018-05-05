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
            if (string.IsNullOrEmpty(old_pwd))
            {
                MessageBox.Show("请输入密码!!");
                return;
            }
            if (string.IsNullOrEmpty(new_pwd))
            {
                MessageBox.Show("新密码不能为空");
                return;
            }
            // 验证密码是否正确
            string cur_user = UserInfo.getUsername();
            int cur_role = UserInfo.getUserRole();
            
            // 管理员和医生修改
            if (cur_role == 0 || cur_role == 1)
            {
                string sql = "select * from operators where name = '"+cur_user+"' and password = '"+old_pwd+"'";
                if (!Base.hasResultBySelect(sql))
                {
                    MessageBox.Show("密码输入错误, 请重试!!");
                    return;
                }
                else { 
                    // 修改密码
                    string upd_sql = "update operators set password = '"+new_pwd+"' where name = '"+cur_user+"'";
                    Base.sql_update(upd_sql);
                }
            }

            // 普通用户修改
            if (cur_role == 2)
            {
                string sql = "select * from users where username = '" + cur_user + "' and password = '" + old_pwd + "'";
                if (!Base.hasResultBySelect(sql))
                {
                    MessageBox.Show("密码输入错误, 请重试!!");
                    return;
                }
                else
                {
                    // 修改密码
                    string upd_sql = "update users set password = '" + new_pwd + "' where username = '" + cur_user + "'";
                    Base.sql_update(upd_sql);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
