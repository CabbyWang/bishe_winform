using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        /// <summary>
        /// 执行insert语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>0 or 1</returns>
        public static int sql_insert(String sql)
        {
            sqlHelper sh = new sqlHelper();
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
            sqlHelper sh = new sqlHelper();
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
            sqlHelper sh = new sqlHelper();
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

    }
}
