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
    public partial class muban : Form
    {
        public muban()
        {
            InitializeComponent();
        }

        private sqlHelper sh = new sqlHelper();
        public DataSet return_ds;

        private void btn_apply_Click(object sender, EventArgs e)
        {
            return_ds = (DataSet)dgv_mingxi.DataSource;
            this.DialogResult = DialogResult.OK;
        }

        // radiobuuton状态改变
        private void rb_public_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_public.Checked == true)
            {
                update_muban();
            }
        }

        private void rb_private_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_private.Checked == true) { 
            update_muban();
            }
        }

        // 获取模板类型
        private int get_type() {
            if (rb_public.Checked == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        // 更新dgv_muban
        private void update_muban()
        {
            int type = get_type();
            string name = txt_name.Text.ToString().Trim();
            string sql = "select * from muban where type = '"+type+"' and name like '%"+name+"%'";
            sh.BindDgv(dgv_muban, sql, "muban");
        }

        // 更新dgv_mingxi
        private void update_mingxi(int mid)
        {
            int type = get_type();
            string name = txt_name.Text.ToString().Trim();
            string sql = "select * from chufangmingxi where mid = '" + mid + "'";
            sh.BindDgv(dgv_mingxi, sql, "mingxi");
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == System.Convert.ToChar(13))
            {
                update_muban();
            }
        }

        private void dgv_muban_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void muban_Load(object sender, EventArgs e)
        {
            update_muban();
        }

        private void dgv_muban_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int mid = Convert.ToInt32(dgv_muban.CurrentRow.Cells[0].Value.ToString());
            update_mingxi(mid);

        }

    }
}
