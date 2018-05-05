using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ClinicSystem.App_Code
{
    public class Base
    {
        /// <summary>
        /// 获取当前日期
        /// </summary>
        /// <returns></returns>
        public static string getCurrentDate()
        {
            return DateTime.Now.Date.Year.ToString().Trim() + "-" + DateTime.Now.Date.Month.ToString().Trim() + "-" + DateTime.Now.Date.Day.ToString().Trim();
        }

        static sqlHelper sh = new sqlHelper();

        /// <summary>
        /// 执行insert语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>0 or 1</returns>
        public static int sql_insert(String sql)
        {
            int result = sh.ExcuteNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("添加成功!!");
                return 1;
            }
            else
            {
                MessageBox.Show("添加失败!!");
                return 0;
            }
        }

        /// <summary>
        /// 执行update语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>0 or 1</returns>
        public static int sql_update(String sql)
        {
            int result = sh.ExcuteNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("更新成功!!");
                return 1;
            }
            else
            {
                MessageBox.Show("更新失败!!");
                return 0;
            }
        }

        /// <summary>
        /// 执行delete语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>0 or 1</returns>
        public static int sql_delete(String sql)
        {
            int result = sh.ExcuteNonQuery(sql);
            if (result > 0)
            {
                MessageBox.Show("删除成功!!");
                return 1;
            }
            else
            {
                MessageBox.Show("删除失败!!");
                return 0;
            }
        }

        public static string getTextFrom(Control ct)
        {
            return ct.Text.ToString().Trim();
        }

        public static void checkContrlIsNotEmpty() { 
            
        }

        public static bool hasResultBySelect(string sql)
        {
            string result = sh.ReturnSql(sql);
            if (string.IsNullOrEmpty(result))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// combobox绑定科室信息
        /// </summary>
        /// <param name="cb">ComboBox</param>
        public static void loadDepartment(ComboBox cb)
        {
            // 加载cb_department
            string sql = "select DISTINCT name from department order by name desc";
            sqlHelper sh = new sqlHelper();
            DataSet ds = sh.GetDs(sql, "department");
            //DataTable dt = (DataTable)cb.DataSource;
            //DataRow dr = dt.NewRow();
            //dr[0] = "";
            //dt.Rows.InsertAt(dr, 0);
            //cb.DataSource = dt;
            //cb.DataSource = ds.Tables["department"];
            DataTable dt = ds.Tables["department"];
            DataRow dr = dt.NewRow();
            dr[0] = "";
            dt.Rows.InsertAt(dr, 0);
            cb.DataSource = dt;
            cb.DisplayMember = "name";
            cb.ValueMember = "name";
        }

        /// <summary>
        /// combobox绑定药品信息
        /// </summary>
        /// <param name="cb">ComboBox</param>
        public static void loadYaopinming(ComboBox cb)
        {
            // 加载cb_department
            string sql = "select DISTINCT name from yaopin order by name desc";
            sqlHelper sh = new sqlHelper();
            DataSet ds = sh.GetDs(sql, "yaopinming");
            DataTable dt = ds.Tables["yaopinming"];
            DataRow dr = dt.NewRow();
            dr[0] = "";
            dt.Rows.InsertAt(dr, 0);
            cb.DataSource = dt;
            cb.DisplayMember = "name";
            cb.ValueMember = "name";
        }

        /// <summary>
        /// combobox绑定药品规格
        /// </summary>
        /// <param name="yaopinming">药品名称</param>
        /// <param name="cb">ComboBox</param>
        public static void loadYaopinguige(string yaopinming, ComboBox cb)
        {
            // 加载cb_department
            string sql = "select DISTINCT yaopinguige from yaopin where name = '"+yaopinming+"' order by yaopinguige desc";
            sqlHelper sh = new sqlHelper();
            DataSet ds = sh.GetDs(sql, "yaopinguige");
            DataTable dt = ds.Tables["yaopinguige"];
            DataRow dr = dt.NewRow();
            dr[0] = "";
            dt.Rows.InsertAt(dr, 0);
            cb.DataSource = dt;
            cb.DataSource = ds.Tables["yaopinguige"];
            cb.DisplayMember = "yaopinguige";
            cb.ValueMember = "yaopinguige";
        }
    }
}
