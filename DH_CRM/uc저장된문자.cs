using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace DH_CRM
{
    public partial class uc저장된문자 : UserControl
    {
        private int _int문자저장ID;
        private SQLServer _SQLServer;
        private frm문자설정 f문자설정;
        public uc저장된문자(frm문자설정 f문자설정, string 문자저장ID, string 문자제목, string 문자내용)
        {
            InitializeComponent();

            this._SQLServer = SQLServer.Instance();
            this.f문자설정 = f문자설정;

            this._int문자저장ID = int.Parse(문자저장ID); 
            this.lblTopBar.Text = 문자제목;
            this.lblData.Text = 문자내용;

            this.lblTopBar.Parent = this.pictureBox1;
            this.lblClose.Parent = this.pictureBox1;
            this.lblData.Parent = this.pictureBox1;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택하신 문자설정을 삭제하시겠습니까?", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            string sql = "delete from tb_문자저장 where 문자저장ID=" + this._int문자저장ID + "" + System.Environment.NewLine;

            this._SQLServer.Command_SQL(sql);

            MessageBox.Show("삭제가 완료되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.f문자설정.settingUserControl();
        }
    }
}
