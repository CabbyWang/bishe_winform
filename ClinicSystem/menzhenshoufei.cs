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
    public partial class menzhenshoufei : Form
    {
        public menzhenshoufei()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private sqlHelper sh = new sqlHelper();
        private int id; 

        private void button1_Click(object sender, EventArgs e)
        {
            // 收费, 状态shifoushoufei改变
            string sql = "update shoufei set shifoushoufei = 1 where id = '"+id+"'";
            Base.sql_update(sql);
        }

        private void txt_ptid_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 回车
            if (e.KeyChar == System.Convert.ToChar(13))
            {
                if (string.IsNullOrEmpty(txt_ptid.Text.ToString()))
                {
                    MessageBox.Show("请输入医疗证号!!");
                    return;
                }
                int patientid = Convert.ToInt32(txt_ptid.Text.ToString().Trim());
                // 获取id
                string id_sql = "select id from shoufei where shifoushoufei = '0' and patientid = '" + patientid + "'";
                string result = sh.ReturnSql(id_sql);
                if (string.IsNullOrEmpty(result)) {
                    MessageBox.Show("该用户没有收费项!!");
                    return;
                }
                int id = Convert.ToInt32(result); 
                // 总金额
                string zjine_sql = "select zongjine from shoufei where shifoushoufei = '0' and patientid = '" + patientid + "'";
                lb_zongjine.Text = sh.ReturnSql(zjine_sql);

                //  获取cfid(处方id)
                string sql = "select cfid from shoufei where shifoushoufei = '0' and patientid = '"+patientid+"'";
                int cfid = Convert.ToInt32(sh.ReturnSql(sql));

                // 绑定dgv
                string sel_sql = "select * from chufangmingxi where cfid = '"+cfid+"'";
                sh.BindDgv(dgv_yaopinxiangqing, sel_sql, "yaopinmingxi");
            }
        }
    }
}
