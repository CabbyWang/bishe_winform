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
    public partial class binglishuxie : Form
    {
        public binglishuxie()
        {
            InitializeComponent();
        }

        public int patientid;

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string sql = "insert into bingli(patientid, zhushu, jiwangshi, jiazushi, jianchaqingkuang, zhenliaojihua) values('"+patientid+"', '" + rb_zhushu.Text + "', '" + rb_jiwangshi.Text + "', '" + rb_jiazushi.Text + "', '" + rb_jianchaqingkuang.Text + "', '" + rb_zhenliaojihua.Text + "')";
            Base.sql_insert(sql);
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
                }

                // 显示患者基本信息
                string pt_sql = "select * from bingrenxinxi where id = " + patientid + "";
                DataSet ds = sh.GetDs(pt_sql, "huanzhexinxi");
                txt_name.Text = ds.Tables[0].Rows[0]["name"].ToString();
                txt_age.Text = ds.Tables[0].Rows[0]["age"].ToString();
                txt_sex.Text = ds.Tables[0].Rows[0]["sex"].ToString();
            }
        }
    }
}
