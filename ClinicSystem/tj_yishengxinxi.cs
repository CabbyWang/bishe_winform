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
    public partial class tj_yishengxinxi : Form
    {
        public tj_yishengxinxi()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String name = txt_name.Text.ToString().Trim();
            // 检验医生姓名不为空
            if (string.IsNullOrEmpty(name)) {
                MessageBox.Show("医生姓名不能为空!!");
                txt_name.Focus();
                return;
            }

            // 检验身份证号
            if (!Valid.IsPersonID(txt_ID_number.Text))
            {
                MessageBox.Show("请输入有效的身份证号!");
                txt_ID_number.Focus();
                return;
            }

            String sex = cb_sex.Text.ToString().Trim();
            String department = cb_department.Text.ToString().Trim();
            String zhicheng = cb_zhicheng.Text.ToString().Trim();
            String ID_number = txt_ID_number.Text.ToString().Trim();
            String sql = "insert into operators(name, sex, department, zhicheng, ID_number) values('" + name + "', '" + sex + "', '" + department + "', '" + zhicheng + "', '" + ID_number + "')";
            int a = Base.sql_insert(sql);
        }

        private void tj_yishengxinxi_Load(object sender, EventArgs e)
        {
            cb_sex.Items.Add("男");
            cb_sex.Items.Add("女");
            cb_sex.SelectedIndex = 0;
            cb_zhicheng.Items.Add("无");
            cb_zhicheng.SelectedIndex = 0;

            // 加载科室信息
            String sql = "select DISTINCT name from department";
            sqlHelper sh = new sqlHelper();
            DataSet ds = sh.GetDs(sql, "keshimingcheng");
            cb_department.DataSource = ds.Tables[0];
            cb_department.DisplayMember = "name";
            cb_department.ValueMember = "name";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            //Application.Exit();
            this.Close();
        }

        private void clear_control()
        {
            txt_name.Text = "";
            cb_sex.SelectedIndex = 0;
            cb_department.SelectedIndex = 0;
            cb_zhicheng.SelectedIndex = 0;
            txt_ID_number.Text = "";
        }
    }
}
