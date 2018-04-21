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
    public partial class cx_yishengxinxi : Form
    {
        public cx_yishengxinxi()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String name = Base.getTextFrom(txt_name);
            String department = Base.getTextFrom(cb_department);
            String sex = Base.getTextFrom(cb_sex);
            String sql = "select * from operators where name like '%" + name + "%' and department like '%" + department + "%' and sex like '%" + sex + "%'";
            sqlHelper sh = new sqlHelper();
            sh.BindDgv(dgv_yishengxinxi, sql, "yishengxinxi");
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_name2.Clear();
            txt_zhicheng.Clear();
            txt_department2.Clear();
            txt_ID_number.Clear();
        }

        private void cx_yishengxinxi_Load(object sender, EventArgs e)
        {
            cb_sex.Items.Add("男");
            cb_sex.Items.Add("女");
            cb_sex2.Items.Add("男");
            cb_sex2.Items.Add("女");
            cb_sex.SelectedIndex = 0;
            cb_sex2.SelectedIndex = 0;
        }

        private void dgv_yishengxinxi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            //DataGridViewCell cell0 = dgv_yishengxinxi.Rows[e.RowIndex].Cells[0];
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            tj_yishengxinxi tj = new tj_yishengxinxi();
            tj.ShowDialog();
        }
    }
}
