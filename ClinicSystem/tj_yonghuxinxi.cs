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
    public partial class tj_yonghuxinxi : Form
    {
        public tj_yonghuxinxi()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String username = Base.getTextFrom(txt_username);
            String realname = Base.getTextFrom(txt_realname);
            String address = Base.getTextFrom(txt_address);
            String contact = Base.getTextFrom(txt_contact);
            String sex = Base.getTextFrom(cb_sex);
            String sql = "insert into users(username, realname, address, contact, sex) values('"+username+"', '"+realname+"', '"+address+"', '"+contact+"', '"+sex+"')";
            int a = Base.sql_insert(sql);
        }

        private void tj_yonghuxinxi_Load(object sender, EventArgs e)
        {
            cb_sex.Items.Add("男");
            cb_sex.Items.Add("女");
            cb_sex.SelectedIndex = 0;
        }
    }
}
