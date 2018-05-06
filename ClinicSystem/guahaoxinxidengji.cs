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
    public partial class guahaoxinxidengji : Form
    {
        public guahaoxinxidengji()
        {
            InitializeComponent();
        }

        private void 保存button_Click(object sender, EventArgs e)
        {
            // 检验身份证号
            if (!Valid.IsPersonID(txt_ID_number.Text)) {
                MessageBox.Show("请输入有效的身份证号!");
                txt_ID_number.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_ID_number.Text))
            {
                //身份证号码不能为空，如果为空返回

                MessageBox.Show("身份证号码不能为空！");
                return;
            }

            string in_sql = "select * from bingrenxinxi where ID_number = '" + txt_ID_number.Text.ToString() + "'";
            sqlHelper sh = new sqlHelper();
            if (!string.IsNullOrEmpty(sh.ReturnSql(in_sql))) {
                MessageBox.Show("该身份证号已经登记!!");
                return;
            }

            // 验证电话号码
            if (!Valid.IsContact(txt_contact.Text))
            {
                MessageBox.Show("请输入有效的联系方式!");
                txt_contact.Focus();
                return;
            }
            //String id_number = txt_ID_number.Text.ToString().Trim();
            //this.dTP_birthday.CustomFormat = getBirthday(id_number);
            //this.dTP_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;//显示生日日期

            String sql = "insert into bingrenxinxi(ID_number, name, sex, ismarried, guoji, jiguan, minzu, address, contact, birth, age, zhiye) values('" + txt_ID_number.Text.ToString().Trim() + "', '" + txt_name.Text.ToString().Trim() + "', '" + cb_sex.Text.ToString().Trim() + "', '" + cb_hunfou.Text.ToString().Trim() + "', '" + txt_guoji.Text.ToString().Trim() + "', '" + txt_jiguan.Text.ToString().Trim() + "', '" + txt_minzu.Text.ToString().Trim() + "', '" + txt_address.Text.ToString().Trim() + "', '" + txt_contact.Text.ToString().Trim() + "', '" + dTP_birthday.Text.ToString().Trim() + "', '" + txt_age.Text.ToString().Trim() + "', '" + txt_zhiye.Text.ToString().Trim() + "')";
            Base.sql_insert(sql);
        }

        private string getBirthday(String id_number)
        {
            //身份证号码只能为15位或18位其它不合法
            //if (id_number.Length != 15 && id_number.Length != 18)
            //{
            //    MessageBox.Show("身份证号码为15位或18位，请检查！");
            //    return "";
            //}
            String birthday = "";
            //string sex = "";
            //处理18位的身份证号码从号码中得到生日和性别代码
            if (id_number.Length == 18)
            {
                birthday = id_number.Substring(6, 4) + "年" + id_number.Substring(10, 2) + "月" + id_number.Substring(12, 2) + "日";
                //sex = id_number.Substring(14, 3);
                return birthday;
            }
            //处理15位的身份证号码从号码中得到生日和性别代码
            if (id_number.Length == 15)
            {
                birthday = "19" + id_number.Substring(6, 2) + "年" + id_number.Substring(8, 2) + "月" + id_number.Substring(10, 2) + "日";
                //sex = id_number.Substring(12, 3);
                return birthday;
            }
            return "";
        }

        private void guahaoxinxidengji_Load(object sender, EventArgs e)
        {
            // txt_id显示医疗证号
            string sql = "select  id from bingrenxinxi order by id desc";
            sqlHelper sh = new sqlHelper();
            int id = Convert.ToInt32(sh.ReturnSql(sql)) + 1;
            txt_id.Text = id.ToString();
        }
    }
}
