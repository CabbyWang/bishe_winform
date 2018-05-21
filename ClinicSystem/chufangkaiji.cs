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
    public partial class chufangkaiji : Form
    {
        public chufangkaiji()
        {
            InitializeComponent();
        }

        private int patientid;
        private string cur_doctor;
        private int id;

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    return;
                }

                // 挂号编号 
                txt_guahaobianhao2.Text = txt_guahaobianhao.Text;

                // 显示患者基本信息
                string pt_sql = "select * from bingrenxinxi where id = " + patientid + "";
                DataSet ds = sh.GetDs(pt_sql, "huanzhexinxi");
                txt_name.Text = ds.Tables[0].Rows[0]["name"].ToString();
                txt_ID_number.Text = ds.Tables[0].Rows[0]["ID_number"].ToString();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_guahaobianhao.Text.ToString().Trim()))
            {
                MessageBox.Show("请输入挂号编号!!");
                return;
            }
            // 添加到处方明细表
            sqlHelper sh = new sqlHelper();
            int row_count = dgv_chufangmingxi.Rows.Count - 1;
            int cfid = Convert.ToInt32(txt_id.Text.ToString().Trim());
            float zongjine = 0;
            for (int i = 0; i < row_count; i++)
            {
                string yaopinmingcheng = dgv_chufangmingxi.Rows[i].Cells[0].Value.ToString();
                string yaopinguige = dgv_chufangmingxi.Rows[i].Cells[1].Value.ToString();
                string shuliang = dgv_chufangmingxi.Rows[i].Cells[2].Value.ToString();
                string danciyongliang = dgv_chufangmingxi.Rows[i].Cells[3].Value.ToString();
                string meiricishu = dgv_chufangmingxi.Rows[i].Cells[4].Value.ToString();
                string yongyaofangshi = dgv_chufangmingxi.Rows[i].Cells[5].Value.ToString();
                string add_sql = "insert into chufangmingxi(cfid, yaopinmingcheng, yaopinguige, danciyongliang, meiricishu, yongyaofangshi, shuliang) values('" + cfid + "', '" + yaopinmingcheng + "', '" + yaopinguige + "', '" + danciyongliang + "', '" + meiricishu + "', '" + yongyaofangshi + "', '" + shuliang + "')";
                sh.ExcuteNonQuery(add_sql);
                float price;
                // 获取药品价格
                string price_sql = "select DISTINCT price from yaopin where name = '" + yaopinmingcheng + "' and yaopinguige = '" + yaopinguige + "'";
                try
                {
                    price = float.Parse(sh.ReturnSql(price_sql));
                }
                catch
                {
                    price = 0;
                }

                float row_price = price * Convert.ToInt32(shuliang);
                zongjine += row_price;
            }

            // 添加处方
            String sql = "insert into chufang(patientid, guahaoid, doctor) values('"+patientid+"', '"+txt_guahaobianhao2.Text.ToString().Trim()+"', '"+cur_doctor+"')";
            Base.sql_insert(sql);

            // 添加收费
            string sf_sql = "insert into shoufei(patientid, cfid, zongjine) values('" + patientid + "', '" + cfid + "', '" + zongjine + "')";
            sh.ExcuteNonQuery(sf_sql);
        }

        private void chufangkaiji_Load(object sender, EventArgs e)
        {
            // 当前开单医生
            cur_doctor = UserInfo.getUsername();

            // 绑定cb_药品名称
            Base.loadYaopinming(cb_yaopinmingcheng);

            // 绑定药品规格
            Base.loadYaopinguige(cb_yaopinmingcheng.Text.ToString().Trim(), cb_yaopinguige);

            // 处方号
            string sql = "select * from chufang order by id desc";
            int id;
            sqlHelper sh = new sqlHelper();
            try
            {
                id = Convert.ToInt32(sh.ReturnSql(sql)) + 1;
            }
            catch {
                id = 0;
            }
            txt_id.Text = id.ToString();

            dgv_chufangmingxi.AutoGenerateColumns = false;
        }

        private void cb_yaopinmingcheng_TextChanged(object sender, EventArgs e)
        {
            // 药品变化时切换相应药品规格
            Base.loadYaopinguige(cb_yaopinmingcheng.Text.ToString().Trim(), cb_yaopinguige);
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

        private void btn_muban_Click(object sender, EventArgs e)
        {
            muban tm = new muban();
            if (tm.ShowDialog() == DialogResult.OK) {
                dgv_chufangmingxi.DataSource = tm.return_ds.Tables[0];
            }
        }
    }
}
