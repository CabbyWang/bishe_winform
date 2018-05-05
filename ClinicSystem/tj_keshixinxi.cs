using ClinicSystem.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSystem
{
    public partial class tj_keshixinxi : Form
    {
        public tj_keshixinxi()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String contact = txt_contact.Text.ToString().Trim();
            // 验证科室电话
            if (!Valid.IsContact(contact)) {
                MessageBox.Show("请输入有效的科室电话!!");
                txt_contact.Focus();
                return;
            }

            String name = txt_name.Text.ToString().Trim();
            String address = txt_address.Text.ToString().Trim();
            String kszr = txt_kszr.Text.ToString().Trim();
            String sql = "insert into department(name, address, contact, kszr) values('" + name + "', '" + address + "', '" + contact + "', '" + kszr + "')";
            Base.sql_insert(sql);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
