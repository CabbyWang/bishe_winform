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
            // 添加处方
            String sql = "insert into chufang(patientid, guahaoid, doctor) values('"+patientid+"', '"+txt_guahaobianhao2.Text.ToString().Trim()+"', '"+cur_doctor+"')";
            Base.sql_insert(sql);

            // 添加收费
            int cfid = Convert.ToInt32(txt_id.Text.ToString().Trim());
            float zongjine = 0;
            int i;
            for (i = 0; i < dgv_chufangmingxi.RowCount; i++)
            {
                string yaopinming = dgv_chufangmingxi.Rows[i].Cells[2].Value.ToString();
                string yaopinguige = dgv_chufangmingxi.Rows[i].Cells[3].Value.ToString();
                float price;
                // 获取药品价格
                string price_sql = "select DISTINCT price from yaopin where name = '"+yaopinming+"' and yaopinguige = '"+yaopinguige+"'";
                try
                {
                    sqlHelper sh = new sqlHelper();
                    price = float.Parse(sh.ReturnSql(price_sql));
                }
                catch {
                    price = 0;
                }

                // 药品数量
                int count = Convert.ToInt32(dgv_chufangmingxi.Rows[i].Cells[7].Value.ToString());

                // 计算单行金额
                float row_price = price * count;
                zongjine += row_price;
            }
            string sf_sql = "insert into shoufei(patientid, cfid, zongjine) values('" + patientid + "', '" + cfid + "', '" + zongjine + "')";
            Base.sql_insert(sf_sql);
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
        }

        private void cb_yaopinmingcheng_TextChanged(object sender, EventArgs e)
        {
            // 药品变化时切换相应药品规格
            Base.loadYaopinguige(cb_yaopinmingcheng.Text.ToString().Trim(), cb_yaopinguige);
        }

        private void btn_addmingxi_Click(object sender, EventArgs e)
        {
            // 添加处方明细
            string add_sql = "insert into chufangmingxi(cfid, yaopinmingcheng, yaopinguige, danciyongliang, meiricishu, yongyaofangshi, shuliang) values('" + id + "', '" + cb_yaopinmingcheng.Text.ToString().Trim() + "', '" + cb_yaopinguige.Text.ToString().Trim() + "', '" + txt_danciyongliang.Text.ToString().Trim() + "', '" + txt_meiricishu.Text.ToString().Trim() + "', '" + cb_yongyaofangshi.Text.ToString().Trim() + "', '" + Convert.ToDouble(txt_yaopinshuliang.Text.ToString()) + "')";
            Base.sql_insert(add_sql);

            // 刷新处方明细表
            string sql = "select * from chufangmingxi where cfid = '"+id+"'";
            sqlHelper sh = new sqlHelper();
            sh.BindDgv(dgv_chufangmingxi, sql, "chufangmingxi");
        }
    }
}
