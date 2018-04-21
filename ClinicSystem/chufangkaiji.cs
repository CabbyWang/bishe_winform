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
    public partial class chufangkaiji : Form
    {
        public chufangkaiji()
        {
            InitializeComponent();
        }

        public int patientid;

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_guahaobianhao_Leave(object sender, EventArgs e)
        {
            
        }

        private void txt_guahaobianhao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == System.Convert.ToChar(13))
            {
                string sql = "select yiliaozhenghao from registation where id = " + Convert.ToInt32(txt_guahaobianhao.Text) + "";
                sqlHelper sh = new sqlHelper();
                try
                {
                    patientid = Convert.ToInt32(sh.ReturnSql(sql));
                }
                catch
                {
                    MessageBox.Show("该门诊编号没有对应挂号信息!!!");
                    return;
                }

                // 显示患者基本信息
                string pt_sql = "select * from bingrenxinxi where id = " + patientid + "";
                DataSet ds = sh.GetDs(pt_sql, "huanzhexinxi");
                txt_name.Text = ds.Tables[0].Rows[0]["name"].ToString();
                txt_ID_number.Text = ds.Tables[0].Rows[0]["ID_number"].ToString();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String sql = "insert into chufang(patientid, yaopinmingcheng, yaopinguige, danciyongliang, meiricishu, yongyaofangshi, zongshuliang) values (" + patientid + ", '" + txt_yaopinmingcheng.Text + "', '" + txt_yaopinguige.Text + "', '" + txt_danciyongliang.Text + "', '" + txt_meiricishu.Text + "', '" + cb_yongyaofangshi.Text + "', '" + txt_zongshuliang.Text + "')";
            Base.sql_insert(sql);
        }
    }
}
