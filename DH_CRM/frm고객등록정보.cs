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
    public partial class frm고객등록정보 : Form
    {
        private SQLServer _SQLServer;
        private Point mousePoint;
        private userInfo _userInfo;
        private bool IsMouseMoveStart;
        public frm고객등록정보()
        {
            InitializeComponent();
            this.Load += this.f고객등록정보_Load;
            this.picMain.MouseDown += this.picMain_MouseDown;
            this.picMain.MouseMove += this.picMain_MouseMove;
            this.picMain.MouseUp += this.picMain_MouseUp;

            this.lblTopBar.MouseDown += this.picMain_MouseDown;
            this.lblTopBar.MouseMove += this.picMain_MouseMove;
            this.lblTopBar.MouseUp += this.picMain_MouseUp;

            this.lblTopBar.Parent = this.picMain;
            this.lblClose.Parent = this.picMain;
            this.lbl검색.Parent = this.picMain;
            this.lblCheck.Parent = this.picMain;
        }

        private void f고객등록정보_Load(object sender, EventArgs e)
        {
            this._SQLServer = SQLServer.Instance();
            this._userInfo = userInfo.Instance();
            this.viewData고객정보();
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

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl검색_Click(object sender, EventArgs e)
        {
            this.viewData고객정보();
        }

        private void  viewData고객정보()
        {
            try
            {
                //2021-02-19 임권호 (12)
                string sql = "";
                sql += "select 고객등록ID, 이름, 성별, 생년월일, 휴대전화 " + System.Environment.NewLine;
                sql += "from tb_고객등록 " + System.Environment.NewLine;
                sql += "where 이름 is not null " + System.Environment.NewLine;
                

                if (this.txt고객명.Text.Trim() != "")
                    sql += "and 이름 like '%" + this.txt고객명.Text.Trim() + "%'" + System.Environment.NewLine;
                if (this._userInfo.자료검색 == 1 && getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "입출금리스트") == "1")
                {
                    DataTable dt1 = new DataTable();
                    DataTable 소속팀정보 = new DataTable();
                    DataTable 담당자정보 = new DataTable();
                    int 본부설정ID = Convert.ToInt32(getConfig.getData사용자본부정보(this._SQLServer, _userInfo.소속팀정보ID).Rows[0][0]);
                    소속팀정보 = getConfig.getData소속팀정보(this._SQLServer, 본부설정ID);

                    for (int i = 0; i < 소속팀정보.Rows.Count; i++)
                    {
                        담당자정보 = getConfig.getData소속사용자정보(this._SQLServer, Convert.ToInt32(소속팀정보.Rows[i]["소속팀정보ID"]));
                        dt1.Merge(담당자정보);
                    }

                    sql += "and 담당자 in (";
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        if (i != 0) sql += ",";
                        sql += dt1.Rows[i]["사용자정보ID"];
                    }
                    sql += ")" + System.Environment.NewLine;
                }
                else if (this._userInfo.자료검색 == 2 && getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "입출금리스트") == "1")
                {
                    DataTable dt2 = getConfig.getData소속사용자정보(this._SQLServer, _userInfo.소속팀정보ID);
                    sql += "and 담당자 in (";
                    //소속팀담당자 전체삽입
                    for (int i = 0; i < dt2.Rows.Count; i++)
                    {
                        if (i != 0) sql += ",";
                        sql += dt2.Rows[i]["사용자정보ID"];
                    }
                    sql += ")" + System.Environment.NewLine;
                }
                else if (this._userInfo.자료검색 == 4 && getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "입출금리스트") == "1")
                    sql += "and 담당자 in (" + this._userInfo.사용자정보ID + "," + this._userInfo.검색범위사용자정보ID + ")" + System.Environment.NewLine;
                else if (this._userInfo.자료검색 != 0 || getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "입출금리스트") != "1")
                    sql += "and 담당자=" + this._userInfo.사용자정보ID + "" + System.Environment.NewLine;
                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                this.grdWork.DataSource = dt;
                this.grdWork.Cols[0].Visible = false;
                this.grdWork.Cols[1].Visible = false;
                this.grdWork[0, 4] = "기수";
            }
            catch (Exception ex)
            {
            }
        }

        private void grdWork_DoubleClick(object sender, EventArgs e)
        {
            int row = this.grdWork.MouseRow;
            if (row < 1)
                return;
            int int고객등록ID = Convert.ToInt32(this.grdWork[row, 1]);
            getConfig.고객등록ID = int고객등록ID;
            this.DialogResult = DialogResult.OK;
        }
    }
}
