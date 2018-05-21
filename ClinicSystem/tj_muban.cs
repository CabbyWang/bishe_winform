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
    public partial class tj_muban : Form
    {
        public tj_muban()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addmingxi_Click(object sender, EventArgs e)
        {
            // 添加处方明细
            int index = dgv_chufangmingxi.Rows.Add();
            dgv_chufangmingxi.Rows[index].Cells[0].Value = cb_yaopinmingcheng.Text.ToString().Trim();
            dgv_chufangmingxi.Rows[index].Cells[1].Value = cb_yaopinguige.Text.ToString().Trim();
            dgv_chufangmingxi.Rows[index].Cells[2].Value = txt_yaopinshuliang.Text.ToString().Trim();
            dgv_chufangmingxi.Rows[index].Cells[3].Value = txt_danciyongliang.Text.ToString().Trim();
            dgv_chufangmingxi.Rows[index].Cells[4].Value = txt_meiricishu.Text.ToString().Trim();
            dgv_chufangmingxi.Rows[index].Cells[5].Value = cb_yongyaofangshi.Text.ToString().Trim();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text.ToString().Trim();
            if (string.IsNullOrEmpty(name)) {
                MessageBox.Show("请输入模板名!!");
                return;
            }
            sqlHelper sh = new sqlHelper();
            int type = get_type();
            string doctor = UserInfo.getUsername();
            // 添加到模板表
            string muban_sql = "insert into muban (name, type, doctor) values ('"+name+"', '"+type+"', '"+doctor+"')";
            Base.sql_insert(muban_sql);

            string query_sql = "select id from muban order by id desc";
            int mid = 0;
            try
            {
                mid = Convert.ToInt32(sh.ReturnSql(query_sql));
            }
            catch { }
            // 添加到处方明细表
            int row_count = dgv_chufangmingxi.Rows.Count - 1;
            for (int i = 0; i < row_count; i++)
            {
                string yaopinmingcheng = dgv_chufangmingxi.Rows[i].Cells[0].Value.ToString();
                string yaopinguige = dgv_chufangmingxi.Rows[i].Cells[1].Value.ToString();
                string shuliang = dgv_chufangmingxi.Rows[i].Cells[2].Value.ToString();
                string danciyongliang = dgv_chufangmingxi.Rows[i].Cells[3].Value.ToString();
                string meiricishu = dgv_chufangmingxi.Rows[i].Cells[4].Value.ToString();
                string yongyaofangshi = dgv_chufangmingxi.Rows[i].Cells[5].Value.ToString();
                string add_sql = "insert into chufangmingxi(yaopinmingcheng, yaopinguige, danciyongliang, meiricishu, yongyaofangshi, shuliang, mid) values('" + yaopinmingcheng + "', '" + yaopinguige + "', '" + danciyongliang + "', '" + meiricishu + "', '" + yongyaofangshi + "', '" + shuliang + "', '" + mid + "')";
                sh.ExcuteNonQuery(add_sql);
            }
        }

        private int get_type(){
            if (rb_public.Checked == true) {
                return 1;
            }
            else{
                return 0;
            }
        }

        private void tj_muban_Load(object sender, EventArgs e)
        {
            // radiobutton
            rb_public.Checked = true;

            Base.loadYaopinming(cb_yaopinmingcheng);

            dgv_chufangmingxi.AutoGenerateColumns = false;
        }

        private void cb_yaopinmingcheng_SelectedIndexChanged(object sender, EventArgs e)
        {
            Base.loadYaopinguige(cb_yaopinmingcheng.Text, cb_yaopinguige);
        }

    }
}
