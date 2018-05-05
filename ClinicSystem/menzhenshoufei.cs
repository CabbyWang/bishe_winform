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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int patientid = Convert.ToInt32(txt_ptid.Text.ToString().Trim());
            if (e.KeyChar == System.Convert.ToChar(13))
            { 
                // 获取id
                string id_sql = "select id from shoufei where shifoushoufei = '0' and patientid = '" + patientid + "'";
                int id = Convert.ToInt32(sh.ReturnSql(id_sql)); 
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

        private void button1_Click(object sender, EventArgs e)
        {
            // 收费, 状态shifoushoufei改变
            string sql = "update shoufei set shifoushoufei = 1 where id = '"+id+"'";
            Base.sql_update(sql);
        }
    }
}
