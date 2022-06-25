using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;

namespace DH_CRM
{
    public partial class frm담당자변경 : Form
    {

        private SQLServer _SQLServer;
        private userInfo _userInfo;

        private int _int고객등록ID;

        private bool IsMouseMoveStart;
        private Point mousePoint;

        private frm고객정보 _f고객정보;
        public frm담당자변경(frm고객정보 f고객정보)
        {
            InitializeComponent();
            this._f고객정보 = f고객정보;

            this.picMain.MouseDown += this.picMain_MouseDown;
            this.picMain.MouseMove += this.picMain_MouseMove;
            this.picMain.MouseUp += this.picMain_MouseUp;

            this.lblTopBar.MouseDown += this.picMain_MouseDown;
            this.lblTopBar.MouseMove += this.picMain_MouseMove;
            this.lblTopBar.MouseUp += this.picMain_MouseUp;

            this.lbl저장.Click += this.lbl저장_Click;
        }
        private void picMain_MouseDown(object sender, MouseEventArgs e)
        {
            this.mousePoint = new Point(e.X, e.Y);
            this.IsMouseMoveStart = true;
        }
        private void picMain_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != MouseButtons.Left || !this.IsMouseMoveStart)
                return;
            this.Location = new Point(this.Left - (this.mousePoint.X - e.X), this.Top - (this.mousePoint.Y - e.Y));
        }
        private void picMain_MouseUp(object sender, MouseEventArgs e)
        {
            this.IsMouseMoveStart = false;
        }

        private void cbo현재담당자_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void settingComboData()
        {
            try
            {
                DataTable dt = getConfig.getData사용자정보(this._SQLServer);
                this.cbo현재담당자.ItemsDataSource = dt;
                this.cbo현재담당자.ItemsDisplayMember = "이름";
                this.cbo현재담당자.ItemsValueMember = "사용자정보ID";
                this.cbo현재담당자.TranslateValue = true;
                this.cbo현재담당자.SelectedIndex = 0;

                DataTable dt1 = getConfig.getData사용자정보(this._SQLServer);
                this.cbo새담당자.ItemsDataSource = dt1;
                this.cbo새담당자.ItemsDisplayMember = "이름";
                this.cbo새담당자.ItemsValueMember = "사용자정보ID";
                this.cbo새담당자.TranslateValue = true;
                this.cbo새담당자.SelectedIndex = 0;

                DataTable dt2 = getConfig.getData사용자정보(this._SQLServer);
                this.cbo리스트새담당자.ItemsDataSource = dt2;
                this.cbo리스트새담당자.ItemsDisplayMember = "이름";
                this.cbo리스트새담당자.ItemsValueMember = "사용자정보ID";
                this.cbo리스트새담당자.TranslateValue = true;
                this.cbo리스트새담당자.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
            }
        }

        private void lbl저장_Click(object sender, EventArgs e)
        {
            if (this.tabMain.SelectedIndex == 0)
                this.담당자update();
            else
                this.all담당자update();
        }

        private void 담당자update()
        {
            try
            {
                if (MessageBox.Show("담당자를 변경하시겠습니까?", "담당자변경", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;

                string sql = "update tb_고객등록 set 담당자=@담당자1  where 담당자=@담당자2 " + System.Environment.NewLine;

                this._SQLServer.paraClear();
                this._SQLServer.addPara("담당자1", this.cbo새담당자.SelectedItem, SqlDbType.Int);
                this._SQLServer.addPara("담당자2", this.cbo현재담당자.SelectedItem, SqlDbType.Int);
                this._SQLServer.Command_SQL(sql);

                MessageBox.Show("담당자가 변경 되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
            }
        }

        private void all담당자update()
        {
            this._f고객정보.update담당자(Convert.ToInt32(this.cbo리스트새담당자.SelectedItem));
            this.Close();
        }

        private void frm담당자변경_Load_1(object sender, EventArgs e)
        {
            this._SQLServer = SQLServer.Instance();
            this._userInfo = userInfo.Instance();

            this.settingComboData();

            this.lbl닫기.Parent = this.picMain;
            this.lbl저장.Parent = this.picMain;
            this.lblTopBar.Parent = this.picMain;
            this.lblClose.Parent = this.picMain;
        }

        private void lbl닫기_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
