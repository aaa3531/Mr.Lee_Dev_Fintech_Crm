using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Data.SqlClient;

namespace DH_CRM
{
    public partial class frm매출자료검색 : Form
    {
        private SQLServer _SQLServer;
        private userInfo _userInfo;
        private bool IsMouseMoveStart;
        private Point mousePoint;

        public frm매출자료검색()
        {
            InitializeComponent();
            this._SQLServer = SQLServer.Instance();
            this._userInfo = userInfo.Instance();

            this.lblTopBar.Parent = this.picMain;
            this.lblClose.Parent = this.picMain;

            this.lbl검색.Parent = this.picMain;

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

        private void lbl검색_Click(object sender, EventArgs e)
        {
            this.searchData매출정보();
        }
        private void searchData매출정보()
        {
            try
            {
                //2021-02-19 임권호 (1)
                getConfig.searchDt.Clear();
                string sql = "";
                sql += "select a.매출정보ID, 결제구분=isnull(a.결제구분,''), d.성별, a.이름, a.휴대폰, a.결제일자, 금액=case when a.결제구분<>'결변(결제변경)' then case when a.결제구분='환불' then a.금액*-1 else a.금액 end else '' end,  " + System.Environment.NewLine;
                sql += "       결제수단=case when a.결제수단='신용카드' then a.결제수단+'('+a.PG+')' else a.결제수단 end, a.할부개월, e.인바운드, 유입경로대분류=(select top 1 대분류 from tb_대분류 where 대분류ID=d.유입경로대분류), " + System.Environment.NewLine;
                sql += "       결제수단변경=case when a.결제구분='결변(결제변경)' then a.금액 else '' end, " + System.Environment.NewLine;
                sql += "       현금영수증=(case when a.현금영수증발행=1 then a.현금영수증번호 else '무' end), " + System.Environment.NewLine;
                sql += "       토스담당자=b.이름, 담당자=c.이름, a.환불, a.결제변경, " + System.Environment.NewLine;
                sql += "       유입경로=(select top 1 유입경로 from tb_유입경로설정 where 유입경로설정ID=e.가입경로), a.카드사, " + System.Environment.NewLine;
                sql += "       a.PG, e.예수금, e.증권사, " + System.Environment.NewLine;
                sql += "       리딩기간=e.리딩기간1+'~'+e.리딩기간2, 리딩개월=DATEDIFF(mm, e.리딩기간1, e.리딩기간2) + 1, e.가입반, d.고객등록ID" + System.Environment.NewLine;
                sql += "from tb_매출정보 a left join tb_사용자정보 b" + System.Environment.NewLine;
                sql += "on   a.토스건담당자=b.사용자정보id" + System.Environment.NewLine;
                sql += "left join tb_사용자정보 c" + System.Environment.NewLine;
                sql += "on   a.담당자=c. 사용자정보id" + System.Environment.NewLine;
                sql += "left join tb_고객등록 d" + System.Environment.NewLine;
                sql += "on   a.고객등록Id = d.고객등록id" + System.Environment.NewLine;
                sql += "left join tb_vip고객등록 e" + System.Environment.NewLine;
                sql += "on   a.고객등록ID=e.고객등록ID" + System.Environment.NewLine;
                sql += "where  1=1" + System.Environment.NewLine;

                if (this.txt이름.Text.Trim() != "")
                    sql += "and a.이름 like '%" + this.txt이름.Text.Trim() + "%'" + System.Environment.NewLine;

                if (this.dtp결제일자1.Text != "" && this.dtp결제일자2.Text != "")
                    sql += "and a.결제일자 between '" + this.dtp결제일자1.Text + "' and '" + this.dtp결제일자2.Text + "'" + System.Environment.NewLine;

                if (this.txt금액1.Text != "" && this.txt금액2.Text != "")
                    sql += "and a.금액>=" + this.txt금액1.Text + " and a.금액<=" + this.txt금액2.Text + "" + System.Environment.NewLine;

                if (this.cbo결제수단.SelectedIndex > 0)
                    sql += "and a.결제수단='" + this.cbo결제수단.SelectedItem + "'" + System.Environment.NewLine;

                if (this.cbo가입반.SelectedIndex > 0)
                    sql += "and e.가입반='" + this.cbo가입반.Text + "'" + System.Environment.NewLine;

                if (this.cbo가입경로.SelectedIndex > 0)
                    sql += "and a.가입경로=" + this.cbo가입경로.SelectedItem + "" + System.Environment.NewLine;

                if (this.cboPG사.SelectedIndex > 0)
                    sql += "and a.PG='" + this.cboPG사.Text + "'" + System.Environment.NewLine;

                if (this.cbo카드사.SelectedIndex > 0)
                    sql += "and a.카드사='" + this.cbo카드사.Text + "'" + System.Environment.NewLine;

                if (this.chk입금.Checked == true)
                    sql += "and a.결제구분='수입'" + System.Environment.NewLine;

                if (this.chk출금.Checked == true)
                    sql += "and a.결제구분='지출'" + System.Environment.NewLine;

                if (this.chk결변.Checked == true)
                    sql += "and a.결제구분='결변(결제변경)'" + System.Environment.NewLine;

                if (this.cbo현금영수증유무.SelectedIndex == 1)
                    sql += "and a.현금영수증발행=1" + System.Environment.NewLine;
                else if (this.cbo현금영수증유무.SelectedIndex == 2)
                    sql += "and a.현금영수증발행=2" + System.Environment.NewLine;
                if (this.txt전화번호.Text.Trim() != "")
                    sql += "and right(a.휴대폰,4)='" + this.txt전화번호.Text.Trim() + "'" + System.Environment.NewLine;

                if (this.cbo담당자.SelectedIndex > 0)
                    sql += "and a.담당자=" + this.cbo담당자.SelectedItem + "" + System.Environment.NewLine;
                else if (this._userInfo.자료검색 == 1 && getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "입출금리스트") == "1")
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

                    sql += "and a.담당자 in (";
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
                    sql += "and a.담당자 in (";
                    //소속팀담당자 전체삽입
                    for (int i = 0; i < dt2.Rows.Count; i++)
                    {
                        if (i != 0) sql += ",";
                        sql += dt2.Rows[i]["사용자정보ID"];
                    }
                    sql += ")" + System.Environment.NewLine;
                }
                else if (this._userInfo.자료검색 == 4 && getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "입출금리스트") == "1")
                    sql += "and a.담당자 in (" + this._userInfo.사용자정보ID + "," + this._userInfo.검색범위사용자정보ID + ")" + System.Environment.NewLine;
                else if (this._userInfo.자료검색 != 0 || getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "입출금리스트") != "1")
                    sql += "and a.담당자=" + this._userInfo.사용자정보ID + "" + System.Environment.NewLine;
                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                getConfig.searchDt.Load(sd);
                sd.Close();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
            }
        }

        private void frm매출자료검색_Load(object sender, EventArgs e)
        {
            this.dtp결제일자1.Value = DateTime.Now;
            this.dtp결제일자2.Value = DateTime.Now;

            this.cbo결제수단.Items.Add("전체");
            this.cbo결제수단.Items.Add("현금");
            this.cbo결제수단.Items.Add("신용카드");
            this.cbo결제수단.Items.Add("모바일");
            this.cbo결제수단.Items.Add("이체");
            this.cbo결제수단.Items.Add("기타");
            this.cbo결제수단.SelectedIndex = 0;

            this.settingComboData();
        }
        private void settingComboData()
        {
            DataTable dt = new DataTable();
            if (this._userInfo.자료검색 == 0 && getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "입출금리스트") == "1")
            {
                dt = getConfig.getData사용자정보(this._SQLServer);
            }
            else if (this._userInfo.자료검색 == 1 && getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "입출금리스트") == "1")
            {
                DataTable 소속팀정보 = new DataTable();
                DataTable 담당자정보 = new DataTable();
                int 본부설정ID = Convert.ToInt32(getConfig.getData사용자본부정보(this._SQLServer, _userInfo.소속팀정보ID).Rows[0][0]);
                소속팀정보 = getConfig.getData소속팀정보(this._SQLServer, 본부설정ID);

                for (int i = 0; i < 소속팀정보.Rows.Count; i++)
                {
                    담당자정보 = getConfig.getData소속사용자정보(this._SQLServer, Convert.ToInt32(소속팀정보.Rows[i]["소속팀정보ID"]));
                    dt.Merge(담당자정보);
                }
            }
            else if (this._userInfo.자료검색 == 2 && getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "입출금리스트") == "1")
            {
                dt = getConfig.getData소속사용자정보(this._SQLServer, _userInfo.소속팀정보ID);
            }
            else if (this._userInfo.자료검색 == 4 && getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "입출금리스트") == "1")
            {
                dt = getConfig.getData사용자정보(this._SQLServer);
                DataRow[] row담당자 = dt.Select("사용자정보ID in (" + _userInfo.사용자정보ID.ToString() + "," + _userInfo.검색범위사용자정보ID.ToString() + ")");
                dt = row담당자.CopyToDataTable();
            }
            else
            {
                dt = getConfig.getData사용자정보(this._SQLServer);
                DataRow[] row담당자 = dt.Select("사용자정보ID = " + _userInfo.사용자정보ID.ToString());
                dt = row담당자.CopyToDataTable();
            }
            this.cbo토스건담당자.ItemsDataSource = dt;
            this.cbo토스건담당자.ItemsDisplayMember = "이름";
            this.cbo토스건담당자.ItemsValueMember = "사용자정보ID";
            this.cbo토스건담당자.TranslateValue = true;
            DataRow row = dt.NewRow();
            row["사용자정보ID"] = 0;
            row["이름"] = "전체";
            dt.Rows.InsertAt(row, 0);
            this.cbo토스건담당자.SelectedIndex = 0;

            DataTable dt1 = new DataTable();
            if (this._userInfo.자료검색 == 0 && getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "입출금리스트") == "1")
            {
                dt1 = getConfig.getData사용자정보(this._SQLServer);
            }
            else if (this._userInfo.자료검색 == 1 && getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "입출금리스트") == "1")
            {
                DataTable 소속팀정보 = new DataTable();
                DataTable 담당자정보 = new DataTable();
                int 본부설정ID = Convert.ToInt32(getConfig.getData사용자본부정보(this._SQLServer, _userInfo.소속팀정보ID).Rows[0][0]);
                소속팀정보 = getConfig.getData소속팀정보(this._SQLServer, 본부설정ID);

                for (int i = 0; i < 소속팀정보.Rows.Count; i++)
                {
                    담당자정보 = getConfig.getData소속사용자정보(this._SQLServer, Convert.ToInt32(소속팀정보.Rows[i]["소속팀정보ID"]));
                    dt1.Merge(담당자정보);
                }
            }
            else if (this._userInfo.자료검색 == 2 && getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "입출금리스트") == "1")
            {
                dt1 = getConfig.getData소속사용자정보(this._SQLServer, _userInfo.소속팀정보ID);
            }
            else if (this._userInfo.자료검색 == 4 && getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "입출금리스트") == "1")
            {
                dt1 = getConfig.getData사용자정보(this._SQLServer);
                DataRow[] row담당자 = dt1.Select("사용자정보ID in (" + _userInfo.사용자정보ID.ToString() + "," + _userInfo.검색범위사용자정보ID.ToString() + ")");
                dt1 = row담당자.CopyToDataTable();
            }
            else
            {
                dt1 = getConfig.getData사용자정보(this._SQLServer);
                DataRow[] row담당자 = dt1.Select("사용자정보ID = " + _userInfo.사용자정보ID.ToString());
                dt1 = row담당자.CopyToDataTable();
            }
            this.cbo담당자.ItemsDataSource = dt1;
            this.cbo담당자.ItemsDisplayMember = "이름";
            this.cbo담당자.ItemsValueMember = "사용자정보ID";
            this.cbo담당자.TranslateValue = true;
            DataRow row1 = dt1.NewRow();
            row1["사용자정보ID"] = 0;
            row1["이름"] = "전체";
            dt1.Rows.InsertAt(row1, 0);
            this.cbo담당자.SelectedIndex = 0;

            DataTable dt2 = getConfig.getData가입반정보(this._SQLServer);
            this.cbo가입반.ItemsDataSource = dt2;
            this.cbo가입반.ItemsDisplayMember = "가입반";
            this.cbo가입반.ItemsValueMember = "가입반설정ID";
            this.cbo가입반.TranslateValue = true;
            DataRow row2 = dt2.NewRow();
            row2["가입반설정ID"] = 0;
            row2["가입반"] = "전체";
            dt2.Rows.InsertAt(row2, 0);
            this.cbo가입반.SelectedIndex = 0;

            DataTable dt3 = getConfig.getDt유입경로(this._SQLServer);
            this.cbo가입경로.ItemsDataSource = dt3;
            this.cbo가입경로.ItemsDisplayMember = "유입경로";
            this.cbo가입경로.ItemsValueMember = "유입경로설정ID";
            this.cbo가입경로.TranslateValue = true;
            DataRow row3 = dt3.NewRow();
            row3["유입경로설정ID"] = 0;
            row3["유입경로"] = "전체";
            dt3.Rows.InsertAt(row3, 0);
            this.cbo가입경로.SelectedIndex = 0;

            DataTable dt4 = getConfig.getDtPG사항목(this._SQLServer);
            this.cboPG사.ItemsDataSource = dt4;
            this.cboPG사.ItemsDisplayMember = "PG사항목";
            this.cboPG사.ItemsValueMember = "PG사항목설정ID";
            this.cboPG사.TranslateValue = true;
            DataRow row4 = dt4.NewRow();
            row4["PG사항목설정ID"] = 0;
            row4["PG사항목"] = "전체";
            dt4.Rows.InsertAt(row4, 0);
            this.cboPG사.SelectedIndex = 0;

            DataTable dt5 = getConfig.getDt카드사항목(this._SQLServer);
            this.cbo카드사.ItemsDataSource = dt5;
            this.cbo카드사.ItemsDisplayMember = "내용";
            this.cbo카드사.ItemsValueMember = "카드사항목설정ID";
            this.cbo카드사.TranslateValue = true;
            DataRow row5 = dt5.NewRow();
            row5["카드사항목설정ID"] = 0;
            row5["내용"] = "전체";
            dt5.Rows.InsertAt(row5, 0);
            this.cbo카드사.SelectedIndex = 0;

            this.cbo현금영수증유무.Items.Add("전체");
            this.cbo현금영수증유무.Items.Add("유");
            this.cbo현금영수증유무.Items.Add("무");
            this.cbo현금영수증유무.SelectedIndex = 0;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
