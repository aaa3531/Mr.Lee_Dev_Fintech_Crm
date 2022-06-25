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
    public partial class frm자료검색 : Form
    {
        private bool IsMouseMoveStart;
        private Point mousePoint;

        private SQLServer _SQLServer;
        private userInfo _userInfo;
        public frm자료검색()
        {
            InitializeComponent();

            this._SQLServer = SQLServer.Instance();
            this._userInfo = userInfo.Instance();

            this.lblTopBar.Parent = this.picMain;
            this.lblClose.Parent = this.picMain;
            this.lblSearch.Parent = this.picMain;

            this.picMain.MouseDown += this.picMain_MouseDown;
            this.picMain.MouseMove += this.picMain_MouseMove;
            this.picMain.MouseUp += this.picMain_MouseUp;

            this.lblTopBar.MouseDown += this.picMain_MouseDown;
            this.lblTopBar.MouseMove += this.picMain_MouseMove;
            this.lblTopBar.MouseUp += this.picMain_MouseUp;

            this.cbo검색제한.Items.Add("");
            this.cbo검색제한.Items.Add("10");
            for (int i = 50; i < 10000; i+=50)
            {
                this.cbo검색제한.Items.Add(i);
            }
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

        private void frm자료검색_Load(object sender, EventArgs e)
        {
            this.settingComboData();

            this.cbo인바운드.Items.Add("유");
            this.cbo인바운드.Items.Add("무");

            //this.dtp등록시작일자.Value = DateTime.Now;
            //this.dtp등록마감일자.Value = DateTime.Now;
            //this.dtp수정시작일자.Value = DateTime.Now;
            //this.dtp수정마감일자.Value = DateTime.Now;
        }
        private void settingComboData()
        {
            //2021-10-20 이찬명
            DataTable dt = new DataTable();
            if (this._userInfo.자료검색 == 0)
            {
                dt = getConfig.getData사용자정보(this._SQLServer);
            }
            else if (this._userInfo.자료검색 == 1)
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
            else if (this._userInfo.자료검색 == 2)
            {
                dt = getConfig.getData소속사용자정보(this._SQLServer, _userInfo.소속팀정보ID);
            }
            else if (this._userInfo.자료검색 == 3)
            {
                dt = getConfig.getData사용자정보(this._SQLServer);
                DataRow[] row담당자 = dt.Select("사용자정보ID = " + _userInfo.사용자정보ID.ToString());
                dt = row담당자.CopyToDataTable();
            }
            else
            {
                dt = getConfig.getData사용자정보(this._SQLServer);
                DataRow[] row담당자 = dt.Select("사용자정보ID in (" + _userInfo.사용자정보ID.ToString() + "," + _userInfo.검색범위사용자정보ID.ToString() + ")");
                dt = row담당자.CopyToDataTable();
            }
            DataRow row = dt.NewRow();
            row["사용자정보ID"] = 0;
            row["이름"] = "전체";
            dt.Rows.InsertAt(row, 0);
            this.cbo담당자.ItemsDataSource = dt;
            this.cbo담당자.ItemsDisplayMember = "이름";
            this.cbo담당자.ItemsValueMember = "사용자정보ID";
            this.cbo담당자.TranslateValue = true;
            if (this.cbo담당자.Items.Count > 0)
                this.cbo담당자.SelectedIndex = 0;

            DataTable dt1 = getConfig.getDt유입경로대분류(this._SQLServer);
            this.cbo유입경로대분류.ItemsDataSource = dt1;
            this.cbo유입경로대분류.ItemsDisplayMember = "대분류";
            this.cbo유입경로대분류.ItemsValueMember = "대분류ID";
            this.cbo유입경로대분류.TranslateValue = true;
            DataRow row1 = dt1.NewRow();
            row1["대분류ID"] = 0;
            row1["대분류"] = "전체";
            dt1.Rows.InsertAt(row1, 0);
            if (this.cbo유입경로대분류.Items.Count > 0)
                this.cbo유입경로대분류.SelectedIndex = 0;

            DataTable dt3 = getConfig.getDt유입경로소분류(this._SQLServer);
            this.cbo유입경로소분류.ItemsDataSource = dt3;
            this.cbo유입경로소분류.ItemsDisplayMember = "소분류";
            this.cbo유입경로소분류.ItemsValueMember = "소분류ID";
            this.cbo유입경로소분류.TranslateValue = true;

            DataRow row2 = dt3.NewRow();
            row2["소분류ID"] = 0;
            row2["소분류"] = "전체";
            dt3.Rows.InsertAt(row2, 0);

            if (this.cbo유입경로소분류.Items.Count > 0)
                this.cbo유입경로소분류.SelectedIndex = 0;

            DataTable dt2 = getConfig.getDt소속팀정보(this._SQLServer, 0);
            this.cbo소속팀정보.ItemsDataSource = dt2;
            this.cbo소속팀정보.ItemsDisplayMember = "소속팀명";
            this.cbo소속팀정보.ItemsValueMember = "소속팀정보ID";
            this.cbo소속팀정보.TranslateValue = true;
            DataRow row3 = dt2.NewRow();
            row3["소속팀정보ID"] = 0;
            row3["소속팀명"] = "전체";
            dt2.Rows.InsertAt(row3, 0);
            this.cbo소속팀정보.SelectedIndex = 0;

            this.cbo유입경로.Items.Add("전체");
            string sql = "";
            sql = "";
            sql += "select * from tb_유입경로설정 order by isnull(순서,0)";
            SqlDataReader sd = this._SQLServer.GetDataReader(sql);
            while (sd.Read())
            {
                this.cbo유입경로.Items.Add(Convert.ToString(sd["유입경로"]));
            }
            sd.Close();
            this.cbo유입경로.SelectedIndex = 0;

            this.cbo가입반.Items.Add("전체");
            sql = "";
            sql += "select * from tb_가입반설정 order by isnull(순서,0)";
            sd = this._SQLServer.GetDataReader(sql);
            while (sd.Read())
            {
                this.cbo가입반.Items.Add(Convert.ToString(sd["가입반"]));
            }
            sd.Close();
            this.cbo가입반.SelectedIndex = 0;
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
            this.searchData회원정보();
        }
        private void searchData회원정보()
        {
            try
            {
                string str전화번호자리맞춤 = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "전화번호자리맞춤");
                //2021-02-05 임권호
                getConfig.searchDt.Clear();

                string str검색제한 = Convert.ToString(this.cbo검색제한.Text);
                if (str검색제한 != "")
                    str검색제한 = "top " + str검색제한;
                string sql = "";
                sql += "select " + str검색제한 + "a.고객등록ID, a.이름, a.카톡아이디, a.네이버아이디, " + System.Environment.NewLine;

                if (str전화번호자리맞춤 == "1")
                {
                    sql += "휴대전화=case CHARINDEX('-', a.휴대전화) " + System.Environment.NewLine;
                    sql += "when 4 then SUBSTRING(a.휴대전화, 1, 3)+')'+SUBSTRING(a.휴대전화, 5,10) " + System.Environment.NewLine;
                    sql += "when 0 then SUBSTRING(a.휴대전화, 1, 3)+')'+SUBSTRING(a.휴대전화, 4,4)+'-'+SUBSTRING(a.휴대전화,8,4) " + System.Environment.NewLine;
                    sql += "else a.휴대전화 end," + System.Environment.NewLine;
                }
                else
                    sql += "a.휴대전화, " + System.Environment.NewLine;

                sql += "       a.유입경로, 대분류=(select top 1 대분류 from tb_대분류 where 대분류ID=a.유입경로대분류), 소분류= (select top 1 소분류 from tb_소분류 where 소분류ID=a.유입경로소분류), " + System.Environment.NewLine;
                sql += "       수정일=convert(nvarchar,a.수정일자,23), a.최초분배일, a.기수, a.검색어, 기타메모=(select top 1 내용 from tb_고객메모 where 고객등록ID=a.고객등록id order by 작성일자 desc), " + System.Environment.NewLine;
                sql += "       무료리딩시작일=case when a.VIP고객여부=0 then a.무료리딩시작일 else b.리딩기간1 end, 무료리딩종료일=case when a.VIP고객여부=0 then a.무료리딩종료일 else b.리딩기간2 end, a.예약일설정, 담당자=(select top 1 이름 from tb_사용자정보 where 사용자정보ID=a.담당자), b.예수금, " + System.Environment.NewLine;
                sql += "       소속팀=(select top 1 소속팀명 from tb_소속팀정보 where 소속팀정보ID=c.소속팀정보ID), b.증권사, d.매출일자, d.금액, b.가입반,  " + System.Environment.NewLine;
                sql += "       d.카드사, d.결제수단, d.PG, d.할부개월, 현금영수증=(case when d.현금영수증발행=1 then '유' else '무' end), " + System.Environment.NewLine;
                sql += "       d.현금영수증번호, VIP회원메모이력=(select top 1 내용 from tb_VIP고객메모 where VIP고객등록ID=b.VIP고객등록id order by 작성일자 desc) " + System.Environment.NewLine;
                sql += "from   tb_고객등록 a left  join tb_VIP고객등록 b" + System.Environment.NewLine;
                sql += "on     a.고객등록ID=b.고객등록ID" + System.Environment.NewLine;
                sql += "left join tb_사용자정보 c " + System.Environment.NewLine;
                sql += "on     a.고객등록ID=c.소속팀정보ID" + System.Environment.NewLine;
                sql += "left join tb_매출정보 d" + System.Environment.NewLine;
                sql += "on     a.고객등록ID=d.고객등록ID" + System.Environment.NewLine;
                sql += "and    d.매출정보ID=(select top 1 매출정보id from tb_매출정보 where 고객등록id=a.고객등록ID order by 매출일자 desc)" + System.Environment.NewLine;
                sql += "where  1=1" + System.Environment.NewLine;

                if (this.cbo유입경로.SelectedIndex > 0)
                {
                    sql += "and a.유입경로='" + this.cbo유입경로.Text + "'" + System.Environment.NewLine;
                }

                if (this.txt기수검색.Text.Trim() != "")
                {
                    sql += "and a.생년월일='" + this.txt기수검색.Text.Trim() + "'" + System.Environment.NewLine;
                }

                if (this.cbo소속팀정보.SelectedIndex > 0)
                    sql += "and    c.소속팀정보ID=" + this.cbo소속팀정보.SelectedItem + "" + System.Environment.NewLine;

                if (this.cbo유입경로대분류.SelectedIndex > 0)
                    sql += "and    a.유입경로대분류=" + this.cbo유입경로대분류.SelectedItem + "" + System.Environment.NewLine;

                if (this.cbo유입경로소분류.SelectedIndex > 0)
                    sql += "and    a.유입경로소분류=" + this.cbo유입경로소분류.SelectedItem + "" + System.Environment.NewLine;

                if (this.cbo가입반.SelectedIndex > 0)
                    sql += "and    b.가입반='" + this.cbo가입반.Text + "'" + System.Environment.NewLine;

                if (this.cbo인바운드.SelectedIndex > 0)
                    sql += "and    b.인바운드=" + this.cbo인바운드.Text + "' " + System.Environment.NewLine;

                if (this.txt이름.Text.Trim() != "")
                    sql += "and a.이름 like '%" + this.txt이름.Text.Trim() + "%'" + System.Environment.NewLine;
                if (this.txt휴대폰.Text.Trim() != "")
                    sql += "and a.휴대전화 like '%" + this.txt휴대폰.Text.Trim() + "%'" + System.Environment.NewLine;
                //2021-10-20 이찬명
                if (this.cbo담당자.SelectedIndex > 0)
                    sql += "and a.담당자=" + this.cbo담당자.SelectedItem + "" + System.Environment.NewLine;
                else if (this._userInfo.자료검색 == 1)
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
                else if (this._userInfo.자료검색 == 2)
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
                else if (this._userInfo.자료검색 == 3)
                    sql += "and a.담당자=" + this._userInfo.사용자정보ID + "" + System.Environment.NewLine;
                else if (this._userInfo.자료검색 == 4)
                    sql += "and a.담당자 in (" + this._userInfo.사용자정보ID + "," + this._userInfo.검색범위사용자정보ID + ")" + System.Environment.NewLine;
                //2021-10-20 이찬명
                if (this.txt메모란.Text.Trim() != "")
                    sql += "and e.내용 like '%" + this.txt메모란.Text.Trim() + "%'" + System.Environment.NewLine;
                if (this.txt증권사.Text.Trim() != "")
                    sql += "and b.증권사 like '%" + this.txt증권사.Text.Trim() + "%'" + System.Environment.NewLine;
                if (this.txt검색어.Text.Trim() != "")
                    sql += "and a.검색어 like '%" + this.txt검색어.Text.Trim() + "%'" + System.Environment.NewLine;
                if (this.txt카톡아이디.Text.Trim() != "")
                    sql += "and a.카톡아이디  like '%" + this.txt카톡아이디.Text.Trim() + "%'" + System.Environment.NewLine;
                if (this.txt카톡아이디.Text.Trim() != "")
                    sql += "or b.카톡아이디  like '%" + this.txt카톡아이디.Text.Trim() + "%'" + System.Environment.NewLine;
                if (this.txt네이버아이디.Text.Trim() != "")
                    sql += "and a.네이버아이디 like '%" + this.txt네이버아이디.Text.Trim() + "%'" + System.Environment.NewLine;
                if (this.txt네이버아이디.Text.Trim() != "")
                    sql += "or b.VIP네이버아이디 like '%" + this.txt네이버아이디.Text.Trim() + "%'" + System.Environment.NewLine;
                if (this.txt메모란.Text.Trim() != "")
                    sql += "and e.내용 like '%" + this.txt메모란.Text.Trim() + "%'" + System.Environment.NewLine;
                if (this.txt기수검색.Text.Trim() != "")
                    sql += "and a.생년월일 like '%" + this.txt기수검색.Text.Trim() + "%'" + System.Environment.NewLine;

                if (this.dtp최초분배일.Text.Trim() != "")
                    sql += "and a.최초분배일 like '%" + this.dtp최초분배일.Text.Trim() + "%'" + System.Environment.NewLine;

                if (this.dtp등록시작일자.Text != "" && this.dtp등록마감일자.Text != "")
                    sql += "and convert(nvarchar,a.등록일자,23) between '" + this.dtp등록시작일자.Text + "' and '" + this.dtp등록마감일자.Text + "'" + System.Environment.NewLine;

                if (this.dtp수정시작일자.Text != "" && this.dtp수정마감일자.Text != "")
                    sql += "and convert(nvarchar,a.수정일자,23) between '" + this.dtp수정시작일자.Text + "' and '" + this.dtp수정마감일자.Text + "'" + System.Environment.NewLine;

                if (this.dtp리딩기간1.Text != "" && this.dtp리딩기간2.Text != "")
                    sql += "and convert(nvarchar,a.무료리딩시작일,23) between '" + this.dtp리딩기간1.Text + "' and '" + this.dtp리딩기간1.Text + "'" + System.Environment.NewLine;

                sql += "order by a.이름" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                getConfig.searchDt.Load(sd);
                sd.Close();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
            }
        }

        private void cbo유입경로대분류_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.settingData소분류(Convert.ToInt32(this.cbo유입경로대분류.SelectedItem));
        }
        private void settingData소분류(int 분류정보ID)
        {
            //DataTable dt = getConfig.getDt유입경로소분류(this._SQLServer, 분류정보ID);
            //this.cbo유입경로소분류.ItemsDataSource = dt;
            //this.cbo유입경로소분류.ItemsDisplayMember = "소분류";
            //this.cbo유입경로소분류.ItemsValueMember = "분류정보ID";
            //this.cbo유입경로소분류.TranslateValue = true;
            //if (this.cbo유입경로소분류.Items.Count > 0)
            //    this.cbo유입경로소분류.SelectedIndex = 0;
            //else
            //    this.cbo유입경로소분류.Clear();
        }

        private void cbo유입경로소분류_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void cbo유입경로대분류_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
