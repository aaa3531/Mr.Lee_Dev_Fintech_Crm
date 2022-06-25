using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdaterDotNET;


namespace DH_CRM
{
    public partial class frmLogin : Form
    {
        private SQLServer _SQLServer = null;

        public frmLogin()
        {
            InitializeComponent();
            this.Load += this.frmLogin_Load;
            this.lblLogin.Click += this.lblLogin_Click;
            this.lblClose.Click += this.lblClose_Click;
            this.txtPW.KeyDown += this.txtPW_KeyDown;
        }
        private void fileCheckUpdate()
        {
            AutoUpdater.Mandatory = true;
            AutoUpdater.UpdateMode = Mode.ForcedDownload;
            AutoUpdater.Start("http://moneycrm.cafe24.com/version.xml");
        }
        private void frmLogin_Load (object sender, EventArgs e)
        {
            this.fileCheckUpdate();

            _SQLServer = new SQLServer();
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.lblLogin_Click(sender, e);
            }
        }

        private void fnLogin()
        {
            if (_SQLServer.Check_Userinfo("TB_사용자정보", this.txtID.Text, this.txtPW.Text))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("사용자정보가 일치하지 않습니다.", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            fnLogin();
        }

        private void lblClose_Click (object sender, EventArgs e)
        {
            Close();
        }
    }
}
