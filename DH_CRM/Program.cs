using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DH_CRM
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DialogResult result;
            using (var fLogin = new frmLogin())
                result = fLogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                Application.Run(new frmMain());
            }
        }
    }
}
