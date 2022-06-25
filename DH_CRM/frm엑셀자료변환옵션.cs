using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DH_CRM
{
    public partial class frm엑셀자료변환옵션 : Form
    {
        private SQLServer _SQLServer;

        private bool IsMouseMoveStart;
        private Point mousePoint;

        private userInfo _userInfo;
        public frm엑셀자료변환옵션()
        {
            InitializeComponent();
            this._SQLServer = SQLServer.Instance();
            this._userInfo = userInfo.Instance();

            this.lblTopBar.Parent = this.picMain;
            this.lblClose.Parent = this.picMain;
            this.lblStart.Parent = this.picMain;

            this.lblTopBar.MouseDown += this.Form_MouseDown;
            this.lblTopBar.MouseMove += this.Form_MouseMove;
            this.lblTopBar.MouseUp += this.Form_MouseUp;
        }
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            this.mousePoint = new Point(e.X, e.Y);
            this.IsMouseMoveStart = true;
        }
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != MouseButtons.Left || !this.IsMouseMoveStart)
                return;
            this.Location = new Point(this.Left - (this.mousePoint.X - e.X), this.Top - (this.mousePoint.Y - e.Y));
        }
        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            this.IsMouseMoveStart = false;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm엑셀자료변환옵션_Load(object sender, EventArgs e)
        {
            this.settingComboData();
        }

        private void settingComboData()
        {
            DataTable dt = getConfig.getData사용자정보(this._SQLServer);
            this.cbo담당자.ItemsDataSource = dt;
            this.cbo담당자.ItemsDisplayMember = "이름";
            this.cbo담당자.ItemsValueMember = "사용자정보ID";
            this.cbo담당자.TranslateValue = true;
            DataRow row = dt.NewRow();
            row["사용자정보ID"] = 0;
            row["이름"] = "";
            dt.Rows.InsertAt(row, 0);
            if (this.cbo담당자.Items.Count > 0)
                this.cbo담당자.SelectedIndex = 0;

            DataTable dt1 = getConfig.getDt유입경로대분류(this._SQLServer);
            this.cbo유입경로대분류.ItemsDataSource = dt1;
            this.cbo유입경로대분류.ItemsDisplayMember = "대분류";
            this.cbo유입경로대분류.ItemsValueMember = "대분류ID";
            this.cbo유입경로대분류.TranslateValue = true;
            DataRow row1 = dt1.NewRow();
            row1["대분류ID"] = 0;
            row1["대분류"] = "";
            dt1.Rows.InsertAt(row1, 0);
            if (this.cbo유입경로대분류.Items.Count > 0)
                this.cbo유입경로대분류.SelectedIndex = 0;

            //DataTable dt2 = getConfig.getDt소속팀정보(this._SQLServer);
            //this.cbo소속팀.ItemsDataSource = dt2;
            //this.cbo소속팀.ItemsDisplayMember = "소속팀명";
            //this.cbo소속팀.ItemsValueMember = "소속팀정보ID";
            //this.cbo소속팀.TranslateValue = true;
            //DataRow row3 = dt2.NewRow();
            //row3["소속팀정보ID"] = 0;
            //row3["소속팀명"] = "";
            //dt2.Rows.InsertAt(row3, 0);
            //this.cbo소속팀.SelectedIndex = 0;

            //DataTable dt3 = getConfig.getData본부설정(this._SQLServer);
            //this.cbo소속본부.ItemsDataSource = dt3;
            //this.cbo소속본부.ItemsDisplayMember = "본부";
            //this.cbo소속본부.ItemsValueMember = "본부설정ID";
            //this.cbo소속본부.TranslateValue = true;
            //this.cbo소속본부.SelectedIndex = 0;
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            if (this.chk중복체크.Checked == true && (this.chk휴대전화.Checked == false && this.chk이름.Checked == false))
            {
                MessageBox.Show("중복체크 기준을 선택해 주시기 바랍니다.", "DH_CRM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.settingConfig();
            this.DialogResult = DialogResult.OK;
        }
        private void settingConfig()
        {
            this._userInfo.중복체크 = this.chk모두추가.Checked == true ? 0 : 1;
            if (this.opt중복체크1.Checked == true)
                    this._userInfo.중복체크1 = 0;
            else if (this.opt중복체크2.Checked == true)
                this._userInfo.중복체크1 = 1;
            else if (this.opt중복체크3.Checked == true)
                this._userInfo.중복체크1 = 2;

            this._userInfo.중복체크2 = this.chk공백초기화.Checked == true ? 1 : 0;
            if (this.chk이름.Checked == true)
                this._userInfo.중복체크기준 = 0;
            else
                this._userInfo.중복체크기준 = 1;

            this._userInfo.대분류ID = Convert.ToInt32(this.cbo유입경로대분류.SelectedItem);
            this._userInfo.담당자ID = Convert.ToInt32(this.cbo담당자.SelectedItem);
        }

        private void chk모두추가_CheckedChanged(object sender, EventArgs e)
        {
             if (this.chk중복체크.Checked == true && this.chk모두추가.Checked == true)
                this.chk중복체크.Checked = false;
        }

        private void chk중복체크_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk모두추가.Checked == true && this.chk중복체크.Checked == true)
                this.chk모두추가.Checked = false;
        }

        private void chk휴대전화_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk이름.Checked == true && this.chk휴대전화.Checked == true)
                this.chk이름.Checked = false;
        }

        private void chk이름_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk휴대전화.Checked == true && this.chk이름.Checked == true)
                this.chk휴대전화.Checked = false;
        }

        private void cbo소속본부_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTable dt2 = getConfig.getDt소속팀정보(this._SQLServer, Convert.ToInt32(this.cbo소속본부.SelectedItem));
            //this.cbo소속팀.ItemsDataSource = dt2;
            //this.cbo소속팀.ItemsDisplayMember = "소속팀명";
            //this.cbo소속팀.ItemsValueMember = "소속팀정보ID";
            //this.cbo소속팀.TranslateValue = true;
            //if (this.cbo소속팀.Items.Count > 0)
            //    this.cbo소속팀.SelectedIndex = 0;
        }

        private void cbo소속팀_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //DataTable dt = getConfig.getData소속사용자정보(this._SQLServer, Convert.ToInt32(this.cbo소속팀.SelectedItem));
                //if (dt.Rows.Count == 0)
                //{
                //    this.cbo담당자.ItemsDataSource = null;
                //    this.cbo담당자.Items.Clear();
                //    this.cbo담당자.Clear();
                //}
                //else
                //{
                //    this.cbo담당자.ItemsDataSource = dt;
                //    this.cbo담당자.ItemsDisplayMember = "이름";
                //    this.cbo담당자.ItemsValueMember = "사용자정보ID";
                //    this.cbo담당자.TranslateValue = true;
                //    this.cbo담당자.SelectedIndex = 0;
                //}
            }
            catch (Exception ex)
            {
            }
        }
    }
}
