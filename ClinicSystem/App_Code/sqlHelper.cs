using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicSystem.App_Code
{
    public class sqlHelper
    {
        //public static readonly string connstring = ConfigurationManager.AppSettings["ConnectionString"];
        //public static readonly string connstring = "data source=.;initial catalog=HIS;user id=sa;password=sa123456";
        public static readonly string connstring = "Data Source=.;Initial Catalog=HIS;Integrated Security=True";
        private static Hashtable parmCache = Hashtable.Synchronized(new Hashtable());
        private SqlConnection con;
        private SqlCommand cmd;

        private SqlDataAdapter sda;
        private SqlDataReader sdr;
        private DataSet ds;
        private DataView dv;

        public static SqlConnection getConnection()//定义成静态的，很重要！
        {
            return new SqlConnection(connstring);
        }
        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void OpenDataBase()
        {
            con = new SqlConnection(connstring);
            con.Open();
        }
        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void CloseDataBase()
        {

            con.Close();
            con.Dispose();

        }
        /// <summary>
        /// 返回DataSet数据集
        /// </summary>
        /// <param name="SqlStr">数据库查询字符串</param>
        /// <returns>dataset</returns>
        public DataSet GetDs(string SqlStr, string TableName)
        {
            OpenDataBase();
            sda = new SqlDataAdapter(SqlStr, con);
            ds = new DataSet();
            sda.Fill(ds, TableName);
            CloseDataBase();
            return ds;
        }
        public DataView GetDv(string SqlStr)
        {
            OpenDataBase();
            sda = new SqlDataAdapter(SqlStr, con);
            ds = new DataSet();
            sda.Fill(ds);
            dv = ds.Tables[0].DefaultView;
            CloseDataBase();
            return dv;

        }
        /// <summary>
        /// 返回Datareader对象
        /// </summary>
        /// <param name="Sqlstr">查询字符串</param>
        /// <returns>返回值</returns>
        public SqlDataReader GetDataReader(string Sqlstr)
        {
            OpenDataBase();
            cmd = new SqlCommand(Sqlstr, con);
            sdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            return sdr;


        }

        /// <summary>
        /// 执行Sql语句方法没有返回值
        /// </summary>
        /// <param name="SqlStr">传入的查询参数</param>
        public void RunSql(string SqlStr)
        {
            OpenDataBase();
            cmd = new SqlCommand(SqlStr, con);
            cmd.ExecuteNonQuery();
            CloseDataBase();
        }

        /// <summary>
        /// 返回查询结果的首行首列
        /// </summary>
        /// <param name="SqlStr">查询字符串</param>
        /// <returns>返回结果</returns>
        public string ReturnSql(string SqlStr)
        {
            OpenDataBase();
            string ReturnSql = "";
            try
            {
                cmd = new SqlCommand(SqlStr, con);
                ReturnSql = cmd.ExecuteScalar().ToString();
            }
            catch { }
            CloseDataBase();
            return ReturnSql;
        }
        public int ExcuteNonQuery(string sql)
        {
            OpenDataBase();
            cmd = new SqlCommand(sql, con);
            int n = cmd.ExecuteNonQuery();
            return n;
        }

        /// <summary>
        /// 绑定数据库
        /// </summary>
        /// <param name="dgv">datagridview object</param>
        /// <param name="sql">sql string</param>
        /// <param name="table_name">table name</param>
        public void BindDgv(DataGridView dgv, String sql, String table_name)
        {
            OpenDataBase();
            DataSet ds = new DataSet();
            //SqlHelper sh = new SqlHelper();
            //ds = sh.GetDs(sql, "temp_table");
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //sa.SelectCommand = cmd;
            da.Fill(ds, table_name);
            dgv.DataSource = ds;
            dgv.DataMember = table_name;
            //dgv_ksxx.DataSource = ds["temp_table"];
            CloseDataBase();
        }
    }
}
