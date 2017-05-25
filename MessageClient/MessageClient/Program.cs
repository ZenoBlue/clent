/// <summary>
/// 六轴机器人远程故障与监测系统v1.0
/// ©韩山师范学院
/// provide by 赵亮(Zeno)
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageClient
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
            //Application.Run(new MessageClient());
            Application.Run(new login());
           //Application.Run(new show());
        }
    }
}
