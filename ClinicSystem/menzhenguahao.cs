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
    public partial class menzhenguahao : Form
    {
        public menzhenguahao()
        {
            InitializeComponent();
        }

        private void chaxunbutton1_Click(object sender, EventArgs e)
        {
            String yiliaozhenghao = txt_yiliaozhenghao.Text.ToString().Trim();
            String sql = "";
            if (string.IsNullOrEmpty(yiliaozhenghao))
            {
                sql = "select * from bingrenxinxi where ID_number = '" + txt_ID_number.Text.ToString().Trim() + "'";
            }
            else { 
                sql = "select * from bingrenxinxi where ID_number = '"+txt_ID_number.Text.ToString().Trim()+"' or id = '"+txt_yiliaozhenghao.Text.ToString().Trim()+"'";
            }
            //if (!string.IsNullOrEmpty(txt_ID_number.Text))
            
            sqlHelper sh = new sqlHelper();
            DataSet ds = sh.GetDs(sql, "guahaoxinxi");
            try
            {
                txt_name.Text = ds.Tables[0].Rows[0]["name"].ToString();
                cb_sex.Text = ds.Tables[0].Rows[0]["sex"].ToString();
                cb_ismarried.Text = ds.Tables[0].Rows[0]["ismarried"].ToString();
                txt_zhiye.Text = ds.Tables[0].Rows[0]["zhiye"].ToString();
                txt_jiguan.Text = ds.Tables[0].Rows[0]["jiguan"].ToString();
                txt_contact.Text = ds.Tables[0].Rows[0]["contact"].ToString();
                txt_ID_number2.Text = ds.Tables[0].Rows[0]["ID_number"].ToString();
                txt_age.Text = ds.Tables[0].Rows[0]["age"].ToString();
                txt_address.Text = ds.Tables[0].Rows[0]["address"].ToString();
                txt_yiliaozhenghao2.Text = ds.Tables[0].Rows[0]["id"].ToString();
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("用户不存在, 请确认输入查询关键字!!");
            }

        }

        private void menzhenguahao_Load(object sender, EventArgs e)
        {
            sqlHelper sh = new sqlHelper();
            // 挂号科室
            string ks_sql = "select name from department";
            DataSet ks_ds = sh.GetDs(ks_sql, "keshi");
            cb_department.DataSource = ks_ds.Tables["keshi"];
            cb_department.DisplayMember = "name";
            cb_department.ValueMember = "name";

            // 挂号医生
            string ys_sql = "select name from operators where role = 1";
            DataSet ys_ds = sh.GetDs(ys_sql, "yisheng");
            cb_doctor.DataSource = ys_ds.Tables["yisheng"];
            cb_doctor.DisplayMember = "name";
            cb_doctor.ValueMember = "name";

            cb_sex.SelectedIndex = 0;
            cb_ismarried.SelectedIndex = 0;
            cb_fufeileixing.SelectedIndex = 0;
            cb_doctor.SelectedIndex = 0;
            cb_department.SelectedIndex = 0;
            cb_guahaojibie.SelectedIndex = 0;
            
            // 计算门诊编号
            String sql = "select id from registation";
            int id = Convert.ToInt32(sh.ReturnSql(sql));
            txt_menzhenbianhao.Text = (id + 1).ToString();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String yiliaozhenghao = txt_yiliaozhenghao2.Text.ToString().Trim();
            if (string.IsNullOrEmpty(yiliaozhenghao)){
                MessageBox.Show("病人信息不存在, 请检查是否进行挂号登记!!!");
                return;
            }
            string sql = "insert into registation(fufeileixing, department, guahaojine, doctor, yingshoujine, guahaojibie, yiliaozhenghao) values('" + cb_fufeileixing.Text + "', '" + cb_department.Text + "', '" + txt_guahaojine.Text + "', '" + cb_doctor + "', '" + txt_yingshoujine.Text + "', '" + cb_guahaojibie.Text + "', "+Convert.ToInt32(txt_yiliaozhenghao2.Text)+")";
            Base.sql_insert(sql);
        }
    }
}
