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
    public partial class cx_yishengxinxi : Form
    {
        public cx_yishengxinxi()
        {
            InitializeComponent();
        }

        // private int id;

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

            Base.loadDepartment(cb_department2);
        }

        private void dgv_yishengxinxi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            tj_yishengxinxi tj = new tj_yishengxinxi();
            tj.ShowDialog();
        }

        private void dgv_yishengxinxi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            txt_name2.Text = dgv_yishengxinxi.Rows[e.RowIndex].Cells[1].Value.ToString();
            cb_sex2.SelectedText = dgv_yishengxinxi.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_zhicheng.Text = dgv_yishengxinxi.Rows[e.RowIndex].Cells[3].Value.ToString();
            cb_department2.SelectedText = dgv_yishengxinxi.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_ID_number.SelectedText = dgv_yishengxinxi.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgv_yishengxinxi.Rows[dgv_yishengxinxi.CurrentCell.RowIndex].Cells[0].Value.ToString());
            string sql = "delete operators where id = '"+id+"'";
            Base.sql_delete(sql);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgv_yishengxinxi.Rows[dgv_yishengxinxi.CurrentCell.RowIndex].Cells[0].Value.ToString());
            string sql = "update operators set name = '"+txt_name2.Text+"', sex = '"+cb_sex2.SelectedText+"', zhicheng = '"+txt_zhicheng.Text+"', department = '"+cb_department2.SelectedText+"', ID_number = '"+txt_ID_number+"' where role = '1' and id = '"+id+"'";
            Base.sql_update(sql);
        }
    }
}
