using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new login());
            // 登录窗口作为主窗口
            login lg = new login();
            lg.ShowDialog();
            if (lg.DialogResult == DialogResult.OK){
                Application.Run(new parent_main());
            }
            else if (lg.DialogResult == DialogResult.Yes){
                Application.Run(new users.parent_users());
            };
        }
    }
}
