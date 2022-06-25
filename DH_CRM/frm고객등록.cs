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
using C1.Win.C1FlexGrid;

namespace DH_CRM
{
    public partial class frm고객등록 : Form
    {
        private SQLServer _SQLServer;
        private userInfo _userInfo;

        private int _int고객등록ID;
        private int _int고객메모ID;

        //2021-01-23 임권호
        private int _intVIP고객등록ID;
        private int _intVIP고객메모ID;
        private int _int매출정보ID;
        private int _int문자발송ID;
        private int _intVIP고객여부;

        private string _str환불;
        private string _str결제변경;

        private bool IsMouseMoveStart;
        private Point mousePoint;

        private const int _con고객등록ID = 1;
        private const int _con이름 = 2;
        private const int _con성별 = 3;
        private const int _con생년월일 = 4;
        private const int _con휴대전화 = 5;
        private const int _con집전화 = 6;
        private const int _con최초분배일 = 7;
        private const int _con카톡아이디 = 8;
        private const int _con예약일설정 = 9;
        private const int _con유입경로대분류 = 10;
        private const int _con유입경로소분류 = 11;
        private const int _con담당자 = 12;
        private const int _con무료리딩시작일 = 13;
        private const int _con무료리딩종료일 = 14;
        private const int _con기수 = 15;

        private const int _con고객메모ID = 1;
        private const int _con작성일자 = 2;
        private const int _con작성자 = 3;
        private const int _con내용 = 4;

        //2021-01-23 임권호
        private const int _conVIP고객메모ID = 1;
        private const int _conVIP메모작성일자 = 2;
        private const int _conVIP메모작성자 = 3;
        private const int _conVIP메모내용 = 4;

        private const int _con매출정보ID = 1;
        private const int _con날짜 = 2;
        private const int _con금액 = 3;
        private const int _con결제방식 = 4;
        private const int _conPG = 5;
        private const int _con카드사 = 6;
        private const int _con할부 = 7;
        private const int _con현금영수증 = 8;
        private const int _con환불 = 9;
        private const int _con결제변경 = 10;

        private frm고객정보 _f고객정보;
        public frm고객등록(frm고객정보 f고객정보, int 고객등록ID)
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            this._SQLServer = SQLServer.Instance();
            this._userInfo = userInfo.Instance();

            this._f고객정보 = f고객정보;

            this.viewForm();

            this._int고객등록ID = 고객등록ID;
            this.Load += this.frm고객등록_Load;
            this.lblAdd.Click += this.button_Click;
            this.lblClose.Click += this.lblClose_Click;

            this.picMain.MouseDown += this.picMain_MouseDown;
            this.picMain.MouseMove += this.picMain_MouseMove;
            this.picMain.MouseUp += this.picMain_MouseUp;

            this.lblTopBar.MouseDown += this.picMain_MouseDown;
            this.lblTopBar.MouseMove += this.picMain_MouseMove;
            this.lblTopBar.MouseUp += this.picMain_MouseUp;
        }
        private void viewForm()
        {
            try
            {
                Screen[] screens = Screen.AllScreens;
                if (screens.Length > 1)
                {
                    Screen scrn;
                    scrn = screens[1];
                    int x = scrn.Bounds.Right - this.Width;
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = new Point(x, 0);
                }
                else
                {
                    int x = Screen.PrimaryScreen.Bounds.Right - this.Width;
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = new Point(x, 0);
                }
                string str1 = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "화면위치왼쪽상단");
                if (str1 == "1")
                {
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = new Point(0, 0);
                }
                //string str2 = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "화면위치오른쪽상단");
                //if (str2 == "1")
                //{
                //    int x = Screen.PrimaryScreen.Bounds.Right - this.Width;
                //    this.StartPosition = FormStartPosition.Manual;
                //    this.Location = new Point(x, 0);
                //}
                string str3 = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "화면위치중앙");
                if (str3 == "1")
                {
                    this.StartPosition = FormStartPosition.CenterScreen;
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (sender.Equals(this.lblAdd))
            {
                this.save고객등록Data();
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
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
            if (this._f고객정보 != null)
            {
                if (!this._f고객정보._is자료검색)
                    this._f고객정보.searchCustomerData();
                else
                    this._f고객정보.searchData자료검색();
            }
        }
        private void frm고객등록_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();

            //2021-02-09 임권호 (결제확인없앰)
            this.lblTopBar.Parent = this.picMain;
            this.lblClose.Parent = this.picMain;

            this.lblVIP.Parent = this.pictureBox1;
            this.lblAdd.Parent = this.pictureBox1;
            this.lblCancel.Parent = this.pictureBox1;

            this.lbl결제확인.Parent = this.pictureBox2;
            this.lblVIP확인.Parent = this.pictureBox2;
            this.lblVIP취소.Parent = this.pictureBox2;

            this.cbo결제방식.Items.Add("");
            this.cbo결제방식.Items.Add("현금");
            this.cbo결제방식.Items.Add("신용카드");
            this.cbo결제방식.Items.Add("모바일");
            this.cbo결제방식.Items.Add("이체");
            this.cbo결제방식.Items.Add("기타");
            this.cbo결제방식.SelectedIndex = 0;

            this.cbo할부.Items.Add("");

            //2021-03-25 임권호
            this.dtp무료리딩시작일.Value = DateTime.Now;
            this.dtp무료리딩종료일.Value = DateTime.Now.AddDays(+7);
            this.dtp예약일설정.Value = DateTime.Now.AddDays(+7);

            this.grd결제정보.Cols.Count = 1;
            this.grd결제정보.Rows.Count = 1;

            this.grdVIP회원메모.Cols.Count = 1;
            this.grdVIP회원메모.Rows.Count = 1;

            this.dtp최초분배일.Value = DateTime.Now;

            this.settingComboData();

            this.dtp결제일자.Value = DateTime.Now;

            this.setGridMemoUI();
            //this.setGridSMSUI();
            this.setGridVIPMemoUI();
            this.setGrid결제정보UI();

            if (this._int고객등록ID > 0)
            {
                this.viewCustomerData();
                this.searchDataSMS();
                this.settingVIP고객여부();
            }

            if (getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "전화번호자리맞춤") == "1")
            {
                this.txt휴대전화.EditMask = "###)####-####";
                this.txtVIP휴대전화.EditMask = "###)####-####";
            }

            this.settingControl();

        }
        private void settingVIP고객여부()
        {
            try
            {
                string sql = "";
                sql += "select VIP고객여부=isnull(VIP고객여부,0) from tb_고객등록 where 고객등록ID=" + this._int고객등록ID + "" + System.Environment.NewLine;
                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this._intVIP고객여부 = Convert.ToInt32(sd["VIP고객여부"]);
                }
                sd.Close();
                if (this._intVIP고객여부 == 1)
                {
                    this.tabMain.SelectedIndex = 1;
                    this.controlEnabledVIP(true);
                    this.settingVIPData();
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void settingVIPData()
        {
            try
            {
                string sql = "";
                sql += "select * " + System.Environment.NewLine;
                sql += "from   tb_VIP고객등록" + System.Environment.NewLine;
                sql += "where  고객등록ID=" + this._int고객등록ID + "" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this._intVIP고객등록ID = Convert.ToInt32(sd["VIP고객등록ID"]);
                    this.txtVIP이름.Text = Convert.ToString(sd["이름"]);
                    this.txtVIP체험기수.Text = Convert.ToString(sd["기수"]);
                    this.txtVIP휴대전화.Text = Convert.ToString(sd["휴대전화"]);

                    this.dtp가입날짜.Text = Convert.ToString(sd["가입일자"]);
                    this.txtVIP카톡아이디.Text = Convert.ToString(sd["카톡아이디"]);
                    this.txtVIP네이버아이디.Text = Convert.ToString(sd["VIP네이버아이디"]);
                    this.txtVIP검색어.Text = Convert.ToString(sd["검색어"]);

                    this.cbo가입경로.SelectedItem = sd["가입경로"];
                    this.cboVIP담당자.SelectedItem = sd["담당자"];
                    this.dtp리딩기간1.Text = Convert.ToString(sd["리딩기간1"]);
                    this.dtp리딩기간2.Text = Convert.ToString(sd["리딩기간2"]);
                    this.cbo가입반.SelectedItem = sd["가입반"];

                    this.cbo인바운드.SelectedItem = sd["인바운드"];
                    this.txt증권사.Text = Convert.ToString(sd["증권사"]);
                    this.txt예수금.Text = Convert.ToString(sd["예수금"]);
                }
                sd.Close();
                if (this._intVIP고객등록ID > 0)
                {
                    this.viewData매출정보();
                    this.viewVIPCustomerMemoData();
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void settingComboData()
        {
            //2021-10-22 이찬명
            try
            {
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
                this.cbo담당자.ItemsDataSource = dt;
                this.cbo담당자.ItemsDisplayMember = "이름";
                this.cbo담당자.ItemsValueMember = "사용자정보ID";
                this.cbo담당자.TranslateValue = true;
                this.cbo담당자.SelectedIndex = 0;

                DataTable dt1 = getConfig.getData사용자정보(this._SQLServer);
                this.cboVIP담당자.ItemsDataSource = dt1;
                this.cboVIP담당자.ItemsDisplayMember = "이름";
                this.cboVIP담당자.ItemsValueMember = "사용자정보ID";
                this.cboVIP담당자.TranslateValue = true;
                DataRow row = dt1.NewRow();
                this.cboVIP담당자.SelectedIndex = 0;

                DataTable dt2 = getConfig.getDt유입경로대분류(this._SQLServer);
                this.cbo유입경로대분류.ItemsDataSource = dt2;
                this.cbo유입경로대분류.ItemsDisplayMember = "대분류";
                this.cbo유입경로대분류.ItemsValueMember = "대분류ID";
                this.cbo유입경로대분류.TranslateValue = true;
                if (this.cbo유입경로대분류.Items.Count > 0)
                    this.cbo유입경로대분류.SelectedIndex = 0;

                DataTable dt3 = getConfig.getDt유입경로(this._SQLServer);
                this.cbo가입경로.ItemsDataSource = dt3;
                this.cbo가입경로.ItemsDisplayMember = "유입경로";
                this.cbo가입경로.ItemsValueMember = "유입경로설정ID";
                this.cbo가입경로.TranslateValue = true;
                if (this.cbo가입경로.Items.Count > 0)
                    this.cbo가입경로.SelectedIndex = 0;
                this.cbo유입경로.ItemsDataSource = dt3;
                this.cbo유입경로.ItemsDisplayMember = "유입경로";
                this.cbo유입경로.ItemsValueMember = "유입경로";
                this.cbo유입경로.TranslateValue = true;
                if (this.cbo유입경로.Items.Count > 0)
                    this.cbo유입경로.SelectedIndex = 0;

                DataTable dt4 = getConfig.getDt유입경로소분류(this._SQLServer);
                this.cbo유입경로소분류.ItemsDataSource = dt4;
                this.cbo유입경로소분류.ItemsDisplayMember = "소분류";
                this.cbo유입경로소분류.ItemsValueMember = "소분류ID";
                this.cbo유입경로소분류.TranslateValue = true;
                if (this.cbo유입경로소분류.Items.Count > 0)
                    this.cbo유입경로소분류.SelectedIndex = 0;

                string sql = "";
                sql += "select * from tb_가입반설정 order by isnull(순서,0)";
                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this.cbo가입반.Items.Add(Convert.ToString(sd["가입반"]));
                }
                sd.Close();
                this.cbo가입반.SelectedIndex = 0;

                //sql = "";
                //sql += "select * from tb_유입경로설정 order by isnull(순서,0)";
                //sd = this._SQLServer.GetDataReader(sql);
                //while (sd.Read())
                //{
                //    this.cbo유입경로.Items.Add(Convert.ToString(sd["유입경로"]));
                //}
                //sd.Close();
                //this.cbo유입경로.SelectedIndex = 0;

                this.cbo인바운드.Items.Add("유");
                this.cbo인바운드.Items.Add("무");
                this.cbo인바운드.SelectedIndex = 0;

                this.settingComboBox();

                for (int i = 0; i < 37; i++)
                {
                    this.cbo할부.Items.Add(i.ToString());
                }
                this.cbo할부.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
            }
        }
        private void setGridSMSUI()
        {
            try
            {
                //this.grd문자발송.Cols.Count = 5;
                //this.grd문자발송.Rows.Count = 1;
                //this.grd문자발송.Cols[0].Visible = false;
                //this.grd문자발송.Cols[1].Visible = false;
                //this.grd문자발송[0, 1] = "문자발송ID";
                //this.grd문자발송[0, 2] = "전송일자";
                //this.grd문자발송[0, 3] = "내용";
                //this.grd문자발송[0, 4] = "전송결과";
            }
            catch (Exception ex)
            {
            }
        }
        private void setGridMemoUI()
        {
            try
            {
                this.grdWork.Cols.Count = 1;
                this.grdWork.Rows.Count = 1;
            }
            catch (Exception ex)
            {
            }
        }
        private void viewCustomerData()
        {
            try
            {
                //2021-02-09 임권호 (txt기수 삭제)
                string sql = "";
                sql += "select * " + System.Environment.NewLine;
                sql += "from   tb_고객등록" + System.Environment.NewLine;
                sql += "where  1=1" + System.Environment.NewLine;
                sql += "and    고객등록ID=" + this._int고객등록ID + "" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this.txt이름.Text = Convert.ToString(sd["이름"]);
                    this.txt체험기수.Text = Convert.ToString(sd["기수"]);
                    this.txt휴대전화.Text = Convert.ToString(sd["휴대전화"]);
                    this.dtp최초분배일.Text = Convert.ToString(sd["최초분배일"]);
                    this.txt카톡아이디.Text = Convert.ToString(sd["카톡아이디"]);
                    this.txt네이버아이디.Text = Convert.ToString(sd["네이버아이디"]);
                    this.txt검색어.Text = Convert.ToString(sd["검색어"]);
                    this.dtp예약일설정.Text = Convert.ToString(sd["예약일설정"]);
                    this.cbo유입경로대분류.SelectedItem = sd["유입경로대분류"];
                    this.cbo유입경로소분류.SelectedItem = sd["유입경로소분류"];
                    this.cbo담당자.SelectedItem = sd["담당자"];
                    this.dtp무료리딩시작일.Text = Convert.ToString(sd["무료리딩시작일"]);
                    this.dtp무료리딩종료일.Text = Convert.ToString(sd["무료리딩종료일"]);
                    this.cbo유입경로.SelectedItem = sd["유입경로"];
                }
                sd.Close();
                this.viewCustomerMemoData();
            }
            catch (Exception ex)
            {
            }
        }

        private void view메모data()
        {

            string sql = "";
            sql += "Select VIP고객메모ID, 작성일자, 작성자, 내용 " + System.Environment.NewLine;
            sql += "from    tb_VIP고객메모" + System.Environment.NewLine;
            sql += "where 1=1 " + System.Environment.NewLine;
            sql += "and   VIP고객등록ID=" + this._intVIP고객등록ID + "" + System.Environment.NewLine;
            sql += "order by 작성일자 desc" + System.Environment.NewLine;

            SqlDataReader sd = this._SQLServer.GetDataReader(sql);
            DataTable dt = new DataTable();
            dt.Load(sd);
            sd.Close();
            this.grdVIP회원메모.Redraw = false;
            this.grdVIP회원메모.DataSource = dt;
            this.grdVIP회원메모.Cols[0].Visible = false;
            this.grdVIP회원메모.Cols[_conVIP고객메모ID].Visible = false;
            this.grdVIP회원메모.Cols[_conVIP메모작성일자].Width = 180;
            this.grdVIP회원메모.Cols[_conVIP메모작성일자].Format = "yyyy-MM-dd HH:mm:ss";
            for (int i = 1; i < this.grdVIP회원메모.Rows.Count; i++)
            {
                this.grdVIP회원메모.AutoSizeRow(i);
            }
            this.grdVIP회원메모.Redraw = true;
        }
        private void viewCustomerMemoData()
        {

            string sql = "";
            sql += "Select 고객메모ID, 작성일자, 작성자, 내용 " + System.Environment.NewLine;
            sql += "from    tb_고객메모" + System.Environment.NewLine;
            sql += "where 1=1 " + System.Environment.NewLine;
            sql += "and   고객등록ID=" + this._int고객등록ID + "" + System.Environment.NewLine;
            sql += "order by 작성일자 desc" + System.Environment.NewLine;

            SqlDataReader sd = this._SQLServer.GetDataReader(sql);
            DataTable dt = new DataTable();
            dt.Load(sd);
            sd.Close();
            this.grdWork.Redraw = false;
            this.grdWork.DataSource = dt;
            this.grdWork.Cols[0].DataType = typeof(bool);
            this.grdWork.SetCellCheck(0, 0, CheckEnum.Unchecked);
            this.grdWork.Cols[0].ImageAlignFixed = ImageAlignEnum.CenterCenter;
            this.grdWork.Cols[_con고객메모ID].Visible = false;
            this.grdWork.Cols[_con작성일자].Format = "yyyy-MM-dd HH:mm:ss";
            this.grdWork.Cols[_con작성일자].Width = 130;
            this.grdWork.Cols[_con내용].Width = 240;
            for (int i = 1; i < this.grdWork.Rows.Count; i++)
            {
                this.grdWork.AutoSizeRow(i);
            }
            for (int i = 1; i < this.grdWork.Cols.Count; i++)
            {
                //this.grdWork.AutoSizeCol(i);
                this.grdWork.Cols[i].AllowEditing = false;
            }
            this.grdWork.Redraw = true;
        }
        private bool checkDataPhone()
        {
            try
            {
                bool isData = false;
                string str휴대전화 = this.txt휴대전화.Text.Trim().Replace("-", "").Replace(")", "");
                string sql = "";
                sql += "select 휴대전화" + System.Environment.NewLine;
                sql += "from   tb_고객등록" + System.Environment.NewLine;
                sql += "where  1=1" + System.Environment.NewLine;
                sql += "and    replace(replace(휴대전화,')',''),'-','')='" + str휴대전화 + "'" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    isData = true;
                }
                sd.Close();
                return isData;
            }
            catch (Exception ex)
            {
            }
            return false;
        }
        private void save고객등록Data()
        {
            try
            {
                if (this.txt이름.Text.Trim() == "" || this.txt휴대전화.Text.Trim() == "")
                {
                    MessageBox.Show("고객이름과 휴대전화를 입력해 주시기 바랍니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //2021-02-09 임권호 (기수삭제)
                string sql = "";
                if (this._int고객등록ID == 0)
                {
                    if (checkDataPhone())
                    {
                        MessageBox.Show("이미 등록된 휴대전화번호가 있는 고객정보가 존재합니다." + System.Environment.NewLine + System.Environment.NewLine + "확인하시기 바랍니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    sql += "insert into tb_고객등록 ( " + System.Environment.NewLine;
                    sql += "    이름, 기수, 휴대전화, 집전화, " + System.Environment.NewLine;
                    sql += "    최초분배일, 카톡아이디, 예약일설정, 유입경로대분류, 유입경로소분류, " + System.Environment.NewLine;
                    sql += "    담당자, 무료리딩시작일, 무료리딩종료일, 등록자, " + System.Environment.NewLine;
                    sql += "    등록일자, 수정자, 수정일자, 검색어, 네이버아이디, " + System.Environment.NewLine;
                    sql += "    유입경로 ) " + System.Environment.NewLine;
                    sql += "values ( " + System.Environment.NewLine;
                    sql += "    @이름, @기수, @휴대전화, @집전화, " + System.Environment.NewLine;
                    sql += "    @최초분배일, @카톡아이디, @예약일설정, @유입경로대분류, @유입경로소분류, " + System.Environment.NewLine;
                    sql += "    @담당자, @무료리딩시작일, @무료리딩종료일, @등록자," + System.Environment.NewLine;
                    sql += "    @등록일자, @수정자, @수정일자, @검색어, @네이버아이디, " + System.Environment.NewLine;
                    sql += "    @유입경로 ) " + System.Environment.NewLine;
                    sql += "select convert(int,scope_identity())" + System.Environment.NewLine;
                }
                else
                {
                    sql += "update tb_고객등록 set " + System.Environment.NewLine;
                    sql += "    이름=@이름, 기수=@기수, 휴대전화=@휴대전화, 집전화=@집전화, " + System.Environment.NewLine;
                    sql += "    최초분배일=@최초분배일, 카톡아이디=@카톡아이디, 예약일설정=@예약일설정, 유입경로대분류=@유입경로대분류, 유입경로소분류=@유입경로소분류, " + System.Environment.NewLine;
                    sql += "    담당자=@담당자, 무료리딩시작일=@무료리딩시작일, 무료리딩종료일=@무료리딩종료일, 수정자=@수정자," + System.Environment.NewLine;
                    sql += "    수정일자=@수정일자, 검색어=@검색어, 네이버아이디=@네이버아이디, 유입경로=@유입경로 " + System.Environment.NewLine;
                    sql += "where 고객등록ID=@고객등록ID " + System.Environment.NewLine;
                }
                this._SQLServer.paraClear();
                this._SQLServer.addPara("이름", this.txt이름.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("기수", this.txt체험기수.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("휴대전화", this.txt휴대전화.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("집전화", "", SqlDbType.NVarChar);

                this._SQLServer.addPara("최초분배일", this.dtp최초분배일.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("카톡아이디", this.txt카톡아이디.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("예약일설정", this.dtp예약일설정.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("유입경로대분류", this.cbo유입경로대분류.SelectedItem == null ? 0 : this.cbo유입경로대분류.SelectedItem, SqlDbType.Int);
                this._SQLServer.addPara("유입경로소분류", this.cbo유입경로소분류.SelectedItem == null ? 0 : this.cbo유입경로소분류.SelectedItem, SqlDbType.Int);

                this._SQLServer.addPara("담당자", this.cbo담당자.SelectedItem == null ? 0 : this.cbo담당자.SelectedItem, SqlDbType.Int);
                this._SQLServer.addPara("무료리딩시작일", this.dtp무료리딩시작일.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("무료리딩종료일", this.dtp무료리딩종료일.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("검색어", this.txt검색어.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("네이버아이디", this.txt네이버아이디.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("유입경로", this.cbo유입경로.Text, SqlDbType.NVarChar);

                if (this._int고객등록ID == 0)
                {
                    this._SQLServer.addPara("등록자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                    this._SQLServer.addPara("등록일자", DateTime.Now, SqlDbType.DateTime);
                    this._SQLServer.addPara("수정자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                    this._SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);
                }
                else
                {
                    this._SQLServer.addPara("수정자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                    this._SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);
                }

                this._int고객등록ID = this._SQLServer.Command_SQL(sql, "고객등록ID", this._int고객등록ID);
                if (this._int고객등록ID > 0)
                {
                    this.saveMemoData();
                    this.viewCustomerMemoData();
                    MessageBox.Show("등록이 완료되었습니다.", "완료");
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void saveMemoData()
        {
            try
            {
                //2021-02-24 임권호
                if (this.txt메모.Text.Trim() == "")
                    return;
                if (this._int고객등록ID == 0)
                    return;
                string sql = "";
                if (this._int고객메모ID == 0)
                {
                    sql += "insert  into tb_고객메모(" + System.Environment.NewLine;
                    sql += "       고객등록ID, 내용, 작성자, 작성일자, 수정자, " + System.Environment.NewLine;
                    sql += "       수정일자)" + System.Environment.NewLine;
                    sql += "values (" + System.Environment.NewLine;
                    sql += "       @고객등록ID, @내용, @작성자, @작성일자, @수정자, " + System.Environment.NewLine;
                    sql += "       @수정일자)" + System.Environment.NewLine;
                    sql += "select convert(int,scope_identity())" + System.Environment.NewLine;
                }
                else
                {
                    //2021-03-04 임권호
                    //if (this._userInfo.권한 == 0)
                    //{
                        //MessageBox.Show("해당 기능은 권한이 없습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //return;
                    //}
                    sql += "update tb_고객메모 set" + System.Environment.NewLine;
                    sql += "       고객등록ID=@고객등록ID, 내용=@내용, 수정자=@수정자, 수정일자=@수정일자" + System.Environment.NewLine;
                    sql += "where  고객메모ID=@고객메모ID" + System.Environment.NewLine;
                }
                this._SQLServer.paraClear();
                this._SQLServer.addPara("고객등록ID", this._int고객등록ID, SqlDbType.Int);
                this._SQLServer.addPara("내용", this.txt메모.Text.Trim(), SqlDbType.NVarChar);
                if (this._int고객메모ID == 0)
                {
                    this._SQLServer.addPara("작성자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                    this._SQLServer.addPara("작성일자", DateTime.Now, SqlDbType.DateTime);
                    this._SQLServer.addPara("수정자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                    this._SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);
                }
                else
                {
                    this._SQLServer.addPara("수정자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                    this._SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);
                }
                this._int고객메모ID = this._SQLServer.Command_SQL(sql, "고객메모ID", this._int고객메모ID);
                if (this._int고객메모ID > 0)
                {
                    this.txt메모.Clear();
                    this._int고객메모ID = 0;
                }

            }
            catch (Exception ex)
            {
            }
        }
        private void updateVIPData(int VIP고객여부)
        {
            try
            {
                string sql = "";
                sql += "update tb_고객등록 set VIP고객여부=" + VIP고객여부 + ", 유입경로대분류=4 where 고객등록ID=" + this._int고객등록ID + "" + System.Environment.NewLine;

                this._SQLServer.Command_SQL(sql);
            }
            catch (Exception ex)
            {
            }
        }
        private void checkBeforeVIPID()
        {
            try
            {
                string sql = "";
                sql += "select VIP고객등록ID" + System.Environment.NewLine;
                sql += "from   tb_VIP고객등록" + System.Environment.NewLine;
                sql += "where  고객등록ID=" + this._int고객등록ID + "" + System.Environment.NewLine;
                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this._intVIP고객등록ID = Convert.ToInt32(sd["VIP고객등록ID"]);
                }
                sd.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private void lblVIP_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._userInfo.권한 == 0)
                {
                    //MessageBox.Show("해당 기능은 권한이 없습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                this.tabMain.SelectedIndex = 1;
                this.controlEnabledVIP(true);

                //2021-01-27 임권호
                if (this._intVIP고객등록ID != 0 && this._intVIP고객여부 == 1)
                    return;

                this.updateVIPData(1);
                this._intVIP고객여부 = 1;
                this.checkBeforeVIPID();

                this.txtVIP이름.Text = this.txt이름.Text;
                this.txtVIP체험기수.Text = this.txt체험기수.Text;
                this.txtVIP휴대전화.Text = this.txt휴대전화.Text;
                this.dtp가입날짜.Value = DateTime.Now;
                this.txtVIP카톡아이디.Text = this.txt카톡아이디.Text;
                this.txtVIP검색어.Text = this.txt검색어.Text;
                this.cboVIP담당자.SelectedItem = this.cbo담당자.SelectedItem;
                //this.cbo가입경로.SelectedItem = this.cbo유입경로대분류.SelectedItem;
                this.cbo가입경로.SelectedIndex = this.cbo유입경로.SelectedIndex;
                this.txtVIP네이버아이디.Text = this.txt네이버아이디.Text;
                this.txtVIP검색어.Text = this.txt검색어.Text;
                //this.cbo가입경로.SelectedIndex = 0;
                //this.cbo유입경로대분류.SelectedIndex = 5;
                this.cbo유입경로대분류.SelectedIndex = 2;
                save고객등록Data();

                this.settingComboBox();
            }
            catch (Exception ex)
            {
            }
        }

        private void settingComboBox()
        {
            try
            {
                DataTable dt = getConfig.getDtPG사항목(this._SQLServer);
                this.cboPG.ItemsDataSource = dt;
                this.cboPG.ItemsDisplayMember = "PG사항목";
                this.cboPG.ItemsValueMember = "PG사항목설정ID";
                this.cboPG.TranslateValue = true;
                DataRow row = dt.NewRow();
                row["PG사항목설정ID"] = 0;
                row["PG사항목"] = "";
                dt.Rows.InsertAt(row, 0);
                this.cboPG.SelectedIndex = 0;

                DataTable dt2 = getConfig.getDt카드사항목(this._SQLServer);
                this.cbo카드사.ItemsDataSource = dt2;
                this.cbo카드사.ItemsDisplayMember = "내용";
                this.cbo카드사.ItemsValueMember = "카드사항목설정ID";
                this.cbo카드사.TranslateValue = true;
                DataRow row1 = dt2.NewRow();
                row1["카드사항목설정ID"] = 0;
                row1["내용"] = "";
                dt2.Rows.InsertAt(row1, 0);
                this.cbo카드사.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
            }
        }

        private void lbl문자발송_Click(object sender, EventArgs e)
        {
            this.sendDataSMS();
        }
        private void sendDataSMS()
        {
            try
            {
                ////2021-02-19 임권호 (17)
                //if (this._userInfo.권한 == 0)
                //{
                //    MessageBox.Show("해당 기능은 권한이 없습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}
                //if (this._int고객등록ID == 0)
                //{
                //    MessageBox.Show("고객등록후 이용해주시기 바랍니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}

                //if (this.txt문자내용.Text.Trim() == "")
                //    return;
                //this._int문자발송ID = 0;
                //string sql = "";
                //if (this._int문자발송ID == 0)
                //{
                //    sql += "insert into tb_문자발송(" + System.Environment.NewLine;
                //    sql += "       고객등록ID, 문자내용, 전송결과, 전송일자, 등록자, " + System.Environment.NewLine;
                //    sql += "       등록일자, 수정자, 수정일자)" + System.Environment.NewLine;
                //    sql += "values (" + System.Environment.NewLine;
                //    sql += "       @고객등록ID, @문자내용, @전송결과, @전송일자, @등록자, " + System.Environment.NewLine;
                //    sql += "       @등록일자, @수정자, @수정일자)" + System.Environment.NewLine;
                //    sql += "select convert(int,scope_identity())" + System.Environment.NewLine;
                //}
                //else
                //{
                //    //sql += "update tb_문자발송 set" + System.Environment.NewLine;
                //    //sql += "       고객등록ID=@고객등록ID, 문자내용=@문자내용, 전송결과=@전송결과, 전송일자=@전송일자, 수정자=@수정자, " + System.Environment.NewLine;
                //    //sql += "       수정일자=@수정일자" + System.Environment.NewLine;
                //    //sql += "where  문자발송ID=@문자발송ID" + System.Environment.NewLine;
                //}
                //this._SQLServer.paraClear();
                //this._SQLServer.addPara("고객등록ID", this._int고객등록ID, SqlDbType.Int); 
                //this._SQLServer.addPara("문자내용", this.txt문자내용.Text.Trim(), SqlDbType.NVarChar);
                //this._SQLServer.addPara("전송결과", "완료", SqlDbType.NVarChar);
                //this._SQLServer.addPara("전송일자", DateTime.Now, SqlDbType.DateTime);

                //if (this._int문자발송ID == 0)
                //{
                //    this._SQLServer.addPara("등록자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                //    this._SQLServer.addPara("등록일자", DateTime.Now, SqlDbType.DateTime);
                //    this._SQLServer.addPara("수정자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                //    this._SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);
                //}
                //else
                //{
                //    this._SQLServer.addPara("수정자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                //    this._SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);
                //}
                //this._int문자발송ID = this._SQLServer.Command_SQL(sql, "문자발송ID", this._int문자발송ID);
                //if (this._int문자발송ID > 0)
                //{
                //    this.searchDataSMS();
                //    MessageBox.Show("문자발송이 완료되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            catch (Exception ex)
            {
            }
        }
        private void searchDataSMS()
        {
            try
            {
                //string sql = "";
                //sql += "select 문자발송ID, 전송일자, 문자내용, 전송결과" + System.Environment.NewLine;
                //sql += "from   tb_문자발송" + System.Environment.NewLine;
                //sql += "where  고객등록ID=" + this._int고객등록ID + "" + System.Environment.NewLine;
                //sql += "order by 전송일자 desc" + System.Environment.NewLine;

                //SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                //DataTable dt = new DataTable();
                //dt.Load(sd);
                //sd.Close();
                //this.grd문자발송.DataSource = dt;
                //this.grd문자발송.Cols[0].Visible = false;
                //this.grd문자발송.Cols[1].Visible = false;
                //this.grd문자발송[0, 1] = "문자발송ID";
                //this.grd문자발송[0, 2] = "전송일자";
                //this.grd문자발송.Cols[2].Format = "yyyy-MM-dd HH:mm:ss";
                //this.grd문자발송[0, 3] = "내용";
                //this.grd문자발송[0, 4] = "전송결과";

                //this.grd문자발송.Cols[2].Width = 130;
                //this.grd문자발송.Cols[3].Width = 120;
            }
            catch (Exception ex)
            {
            }
        }

        private void cbo유입경로대분류_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.settingData소분류(Convert.ToInt32(this.cbo유입경로대분류.SelectedItem));
        }

        private void lblVIP확인_Click(object sender, EventArgs e)
        {
            if (this._userInfo.권한 == 0)
            {
                //MessageBox.Show("해당 기능은 권한이 없습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //2021-01-23 임권호
            this.SaveVIP고객등록Data();
        }

        private void SaveVIP고객등록Data(bool isMessage = true)
        {
            //2021-01-27 임권호
            try
            {
                if (this.txt이름.Text.Trim() == "" || this.txt휴대전화.Text.Trim() == "")
                {
                    MessageBox.Show("고객이름과 휴대전화를 입력해 주시기 바랍니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string sql = "";
                if (this._intVIP고객등록ID == 0)
                {
                    sql += "insert into tb_VIP고객등록 ( " + System.Environment.NewLine;
                    sql += "     고객등록ID, 이름, 기수, 휴대전화, " + System.Environment.NewLine;
                    sql += "     집전화, 가입일자, 카톡아이디, 담당자, " + System.Environment.NewLine;
                    sql += "     리딩기간1, 리딩기간2, 가입반, 인바운드, 증권사, " + System.Environment.NewLine;
                    sql += "     예수금, 등록자, 등록일자, 수정자, 수정일자, " + System.Environment.NewLine;
                    sql += "     검색어, VIP네이버아이디, 가입경로 ) " + System.Environment.NewLine;
                    sql += "values ( " + System.Environment.NewLine;
                    sql += "     @고객등록ID, @이름, @기수, @휴대전화, " + System.Environment.NewLine;
                    sql += "     @집전화, @가입일자, @카톡아이디, @담당자, " + System.Environment.NewLine;
                    sql += "     @리딩기간1, @리딩기간2, @가입반, @인바운드, @증권사, " + System.Environment.NewLine;
                    sql += "     @예수금, @등록자, @등록일자, @수정자, @수정일자, " + System.Environment.NewLine;
                    sql += "     @검색어, @VIP네이버아이디, @가입경로 ) " + System.Environment.NewLine;
                    sql += "select convert(int,scope_identity())" + System.Environment.NewLine;
                }
                else
                {
                    sql += "update tb_VIP고객등록 set " + System.Environment.NewLine;
                    sql += "     고객등록ID=@고객등록ID, 이름=@이름, 기수=@기수, 휴대전화=@휴대전화, " + System.Environment.NewLine;
                    sql += "     집전화=@집전화, 가입일자=@가입일자, 카톡아이디=@카톡아이디, 담당자=@담당자, " + System.Environment.NewLine;
                    sql += "     리딩기간1=@리딩기간1, 리딩기간2=@리딩기간2, 가입반=@가입반, 인바운드=@인바운드, 증권사=@증권사, " + System.Environment.NewLine;
                    sql += "     예수금=@예수금, 수정자=@수정자, 수정일자=@수정일자, 검색어=@검색어, VIP네이버아이디=@VIP네이버아이디, 가입경로=@가입경로 " + System.Environment.NewLine;
                    sql += "where VIP고객등록ID=@VIP고객등록ID " + System.Environment.NewLine;
                }
                this._SQLServer.paraClear();
                this._SQLServer.addPara("고객등록ID", this._int고객등록ID, SqlDbType.Int);
                this._SQLServer.addPara("이름", this.txtVIP이름.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("기수", this.txtVIP체험기수.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("휴대전화", this.txtVIP휴대전화.Text, SqlDbType.NVarChar);

                this._SQLServer.addPara("집전화", "", SqlDbType.NVarChar);
                this._SQLServer.addPara("가입일자", this.dtp가입날짜.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("카톡아이디", this.txtVIP카톡아이디.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("담당자", this.cboVIP담당자.SelectedItem, SqlDbType.Int);

                this._SQLServer.addPara("리딩기간1", this.dtp리딩기간1.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("리딩기간2", this.dtp리딩기간2.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("가입반", this.cbo가입반.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("인바운드", this.cbo인바운드.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("증권사", this.txt증권사.Text, SqlDbType.NVarChar);

                this._SQLServer.addPara("예수금", this.txt예수금.Text, SqlDbType.NVarChar);


                if (this._intVIP고객등록ID == 0)
                {
                    this._SQLServer.addPara("등록자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                    this._SQLServer.addPara("등록일자", DateTime.Now, SqlDbType.DateTime);
                    this._SQLServer.addPara("수정자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                    this._SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);
                }
                else
                {
                    this._SQLServer.addPara("수정자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                    this._SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);
                }

                this._SQLServer.addPara("검색어", this.txt검색어.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("VIP네이버아이디", this.txtVIP네이버아이디.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("가입경로", this.cbo가입경로.SelectedItem, SqlDbType.Int);

                this._intVIP고객등록ID = this._SQLServer.Command_SQL(sql, "VIP고객등록ID", this._intVIP고객등록ID);
                if (this._intVIP고객등록ID > 0)
                {
                    this.saveVIPMemoData();
                    if (isMessage)
                        MessageBox.Show("등록이 완료되었습니다.", "완료");
                    this.viewVIPCustomerMemoData();
                    //this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void saveVIPMemoData()
        {
            //2021-01-23 임권호
            if (this.txtVIP고객메모.Text.Trim() == "")
                return;
            if (this._intVIP고객등록ID == 0)
                return;
            string sql = "";
            if (this._intVIP고객메모ID == 0)
            {
                sql += "insert  into tb_VIP고객메모(" + System.Environment.NewLine;
                sql += "       VIP고객등록ID, 내용, 작성자, 작성일자, 수정자, " + System.Environment.NewLine;
                sql += "       수정일자)" + System.Environment.NewLine;
                sql += "values (" + System.Environment.NewLine;
                sql += "       @VIP고객등록ID, @내용, @작성자, @작성일자, @수정자, " + System.Environment.NewLine;
                sql += "       @수정일자)" + System.Environment.NewLine;
                sql += "select convert(int,scope_identity())" + System.Environment.NewLine;
            }
            else
            {
                sql += "update tb_VIP고객메모 set" + System.Environment.NewLine;
                sql += "       VIP고객등록ID=@VIP고객등록ID, 내용=@내용, 수정자=@수정자, 수정일자=@수정일자" + System.Environment.NewLine;
                sql += "where  VIP고객메모ID=@VIP고객메모ID" + System.Environment.NewLine;
            }
            this._SQLServer.paraClear();
            this._SQLServer.addPara("VIP고객등록ID", this._intVIP고객등록ID, SqlDbType.Int);
            this._SQLServer.addPara("내용", this.txtVIP고객메모.Text.Trim(), SqlDbType.NVarChar);
            if (this._int고객메모ID == 0)
            {
                this._SQLServer.addPara("작성자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                this._SQLServer.addPara("작성일자", DateTime.Now, SqlDbType.DateTime);
                this._SQLServer.addPara("수정자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                this._SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);
            }
            else
            {
                this._SQLServer.addPara("수정자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                this._SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);
            }
            this._intVIP고객메모ID = this._SQLServer.Command_SQL(sql, "VIP고객메모ID", this._intVIP고객메모ID);
            if (this._intVIP고객메모ID > 0)
            {
                this.txtVIP고객메모.Clear();
                this._intVIP고객메모ID = 0;
            }
        }



        private void saveData매출등록(bool isMessage = true)
        {
            try
            {
                bool isSave = false;
                //2021-02-23 임권호
                if (this._intVIP고객여부 == 0)
                {
                    MessageBox.Show("VIP고객등록후 이용해주시기 바랍니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (isMessage)
                {
                    if (MessageBox.Show("매출정보를 저장하시겠습니까?", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                        return;
                }
                string sql = "";
                if (this._int매출정보ID == 0)
                {
                    isSave = true;
                    sql += "insert into tb_매출정보(" + System.Environment.NewLine;
                    sql += "       [고객등록ID], [매출일자], [가입경로], [담당자], " + System.Environment.NewLine;
                    sql += "       [금액], [결제일자], [결제수단], [할부개월], [카드사별적용내역], " + System.Environment.NewLine;
                    sql += "       [영업자별매출], [현금영수증발행], [현금영수증번호], [토스건결제유무], [인바운드유무], " + System.Environment.NewLine;
                    sql += "       [등록자], [등록일자], [수정자], [수정일자], [토스건담당자], [PG], " + System.Environment.NewLine;
                    sql += "       [카드사], [이름], [휴대폰], [환불], [결제변경], " + System.Environment.NewLine;
                    sql += "       [결제구분] ) " + System.Environment.NewLine;
                    sql += "values (" + System.Environment.NewLine;
                    sql += "       @고객등록ID, @매출일자, @가입경로, @담당자, " + System.Environment.NewLine;
                    sql += "       @금액, @결제일자, @결제수단, @할부개월, @카드사별적용내역, " + System.Environment.NewLine;
                    sql += "       @영업자별매출, @현금영수증발행, @현금영수증번호, @토스건결제유무, @인바운드유무, " + System.Environment.NewLine;
                    sql += "       @등록자, @등록일자, @수정자, @수정일자, @토스건담당자, @PG, " + System.Environment.NewLine;
                    sql += "       @카드사, @이름, @휴대폰, @환불, @결제변경, " + System.Environment.NewLine;
                    sql += "       @결제구분 ) " + System.Environment.NewLine;
                    sql += "select convert(int,scope_identity())" + System.Environment.NewLine;
                }
                else
                {
                    sql += "update tb_매출정보 set" + System.Environment.NewLine;
                    sql += "       [고객등록ID]=@고객등록ID, [매출일자]=@매출일자, [가입경로]=@가입경로, [담당자]=@담당자, " + System.Environment.NewLine;
                    sql += "       [금액]=@금액, [결제일자]=@결제일자, [결제수단]=@결제수단, [할부개월]=@할부개월, [카드사별적용내역]=@카드사별적용내역, " + System.Environment.NewLine;
                    sql += "       [영업자별매출]=@영업자별매출, [현금영수증발행]=@현금영수증발행, [현금영수증번호]=@현금영수증번호, [토스건결제유무]=@토스건결제유무, [인바운드유무]=@인바운드유무, " + System.Environment.NewLine;
                    sql += "       [수정자]=@수정자, [수정일자]=@수정일자, [토스건담당자]=@토스건담당자, [PG]=@PG, [카드사]=@카드사, " + System.Environment.NewLine;
                    sql += "       [이름]=@이름, [휴대폰]=@휴대폰, [환불]=@환불, [결제변경]=@결제변경" + System.Environment.NewLine;
                    sql += "where  매출정보ID=@매출정보ID" + System.Environment.NewLine;
                }
                this._SQLServer.paraClear();
                this._SQLServer.addPara("고객등록ID", this._int고객등록ID, SqlDbType.Int);
                this._SQLServer.addPara("매출일자", this.dtp결제일자.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("가입경로", this.cbo가입경로.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("담당자", this.cboVIP담당자.SelectedItem, SqlDbType.Int);

                this._SQLServer.addPara("금액", this.txt결제금액.Text == "" ? "0" : this.txt결제금액.Text, SqlDbType.Int);
                this._SQLServer.addPara("결제일자", this.dtp결제일자.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("결제수단", this.cbo결제방식.SelectedItem, SqlDbType.NVarChar);
                this._SQLServer.addPara("할부개월", this.cbo할부.SelectedIndex == 0 ? "0" : this.cbo할부.SelectedItem, SqlDbType.Int);
                this._SQLServer.addPara("카드사별적용내역", "", SqlDbType.NVarChar);

                int int영업자별매출 = 0;
                if (this.cbo결제방식.SelectedItem == "신용카드")
                {
                    int영업자별매출 = 1;
                }
                this._SQLServer.addPara("영업자별매출", int영업자별매출, SqlDbType.TinyInt);
                this._SQLServer.addPara("현금영수증발행", this.opt현금영수증1.Checked == true ? 0 : 1, SqlDbType.NVarChar);
                this._SQLServer.addPara("현금영수증번호", this.txt현금영수증.Text.Trim(), SqlDbType.NVarChar);
                this._SQLServer.addPara("토스건결제유무", 0, SqlDbType.TinyInt);
                this._SQLServer.addPara("인바운드유무", this.cbo인바운드.SelectedIndex == 0 ? 1 : 0, SqlDbType.TinyInt);

                if (this._int매출정보ID == 0)
                {
                    this._SQLServer.addPara("등록자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                    this._SQLServer.addPara("등록일자", DateTime.Now, SqlDbType.DateTime);
                    this._SQLServer.addPara("수정자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                    this._SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);
                }
                else
                {
                    this._SQLServer.addPara("수정자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                    this._SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);
                }
                this._SQLServer.addPara("토스건담당자", 0, SqlDbType.Int);
                this._SQLServer.addPara("PG", this.cboPG.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("카드사", this.cbo결제방식.SelectedIndex == 2 ? this.cbo카드사.Text : "", SqlDbType.NVarChar);
                this._SQLServer.addPara("이름", this.txtVIP이름.Text.Trim(), SqlDbType.NVarChar);
                this._SQLServer.addPara("휴대폰", this.txtVIP휴대전화.Text.Trim(), SqlDbType.NVarChar);

                this._SQLServer.addPara("환불", "", SqlDbType.NVarChar);
                this._SQLServer.addPara("결제변경", "", SqlDbType.NVarChar);
                this._SQLServer.addPara("결제구분", "수입", SqlDbType.NVarChar);

                this._int매출정보ID = this._SQLServer.Command_SQL(sql, "매출정보ID", this._int매출정보ID);
                if (this._int매출정보ID > 0)
                {
                    if (isSave)
                    {
                        this.saveData결제변경메모1();
                        this.viewVIPCustomerMemoData();
                    }
                    this.viewData매출정보();
                    MessageBox.Show("저장이 완료되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void viewData매출정보()
        {
            try
            {
                CellStyle cs = this.grd결제정보.Styles.Add("CellStyle");
                cs.ForeColor = System.Drawing.Color.Red;

                this.grd결제정보.Rows.Count = 1;
                string sql = "";
                sql += "select * " + System.Environment.NewLine;
                sql += "from   tb_매출정보" + System.Environment.NewLine;
                sql += "where  고객등록ID=" + this._int고객등록ID + "" + System.Environment.NewLine;
                sql += "order by 매출일자 desc" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this.grd결제정보.Rows.Count++;
                    int maxRows = this.grd결제정보.Rows.Count - 1;
                    this.grd결제정보[maxRows, _con매출정보ID] = sd["매출정보ID"];
                    this.grd결제정보[maxRows, _con날짜] = sd["매출일자"];
                    this.grd결제정보[maxRows, _con금액] = sd["금액"];
                    this.grd결제정보[maxRows, _con결제방식] = sd["결제수단"];
                    this.grd결제정보[maxRows, _conPG] = sd["PG"];
                    this.grd결제정보[maxRows, _con카드사] = sd["카드사"];
                    this.grd결제정보[maxRows, _con할부] = sd["할부개월"];
                    this.grd결제정보[maxRows, _con현금영수증] = sd["현금영수증번호"];
                    this.grd결제정보[maxRows, _con환불] = sd["환불"];
                    this.grd결제정보[maxRows, _con결제변경] = sd["결제변경"];

                    if (Convert.ToString(this.grd결제정보[maxRows, _con환불]) != "" || Convert.ToString(this.grd결제정보[maxRows, _con결제변경]) != "")
                    {
                        CellRange cr = this.grd결제정보.GetCellRange(maxRows, 1, maxRows, this.grd결제정보.Cols.Count - 1);
                        cr.Style = this.grd결제정보.Styles["CellStyle"];
                    }
                }
                sd.Close();
                for (int i = 1; i < this.grd결제정보.Cols.Count; i++)
                {
                    this.grd결제정보.AutoSizeCol(i);
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void setGridVIPMemoUI()
        {
            try
            {
                //2021-01-23 임권호
                this.grdVIP회원메모.Cols.Count = _con내용 + 1;
                this.grdVIP회원메모.Rows.Count = 1;
                //this.grdVIP회원메모.Cols[0].Visible = false;
                this.grdVIP회원메모[0, _conVIP고객메모ID] = "고객메모ID";
                this.grdVIP회원메모.Cols[_conVIP고객메모ID].Visible = false;
                this.grdVIP회원메모[0, _conVIP메모작성일자] = "작성일자";
                this.grdVIP회원메모[0, _conVIP메모작성자] = "작성자";
                this.grdVIP회원메모[0, _conVIP메모내용] = "내용";
            }
            catch (Exception ex)
            {
            }
        }

        private void setGrid결제정보UI()
        {
            try
            {
                //2021-01-23 임권호
                this.grd결제정보.Rows.Count = 1;
                this.grd결제정보.Cols.Count = _con결제변경 + 1;
                this.grd결제정보.Cols[0].Visible = false;
                this.grd결제정보.Cols[_con매출정보ID].Visible = false;
                this.grd결제정보[0, _con날짜] = "날짜";
                this.grd결제정보[0, _con금액] = "금액";
                this.grd결제정보[0, _con결제방식] = "결제방식";
                this.grd결제정보[0, _conPG] = "PG";
                this.grd결제정보[0, _con카드사] = "카드사";
                this.grd결제정보[0, _con할부] = "할부";
                this.grd결제정보[0, _con현금영수증] = "현금영수증";
                this.grd결제정보[0, _con환불] = "환불";
                this.grd결제정보[0, _con결제변경] = "결제변경";
            }
            catch (Exception ex)
            {
            }
        }

        private void viewVIPCustomerMemoData(int VIP고객등록ID = 0)
        {
            //2021-01-24 임권호
            string sql = "";
            sql += "Select VIP고객메모ID, 작성일자, 작성자, 내용 " + System.Environment.NewLine;
            sql += "from    tb_VIP고객메모" + System.Environment.NewLine;
            sql += "where 1=1 " + System.Environment.NewLine;
            if (VIP고객등록ID > 0)
                sql += "and   VIP고객등록ID=" + VIP고객등록ID + "" + System.Environment.NewLine;
            else
                sql += "and   VIP고객등록ID=" + this._intVIP고객등록ID + "" + System.Environment.NewLine;
            sql += "order by 작성일자 desc" + System.Environment.NewLine;

            SqlDataReader sd = this._SQLServer.GetDataReader(sql);
            DataTable dt = new DataTable();
            dt.Load(sd);
            sd.Close();
            this.grdVIP회원메모.Redraw = false;
            this.grdVIP회원메모.DataSource = dt;
            //this.grdVIP회원메모.Cols[0].Visible = false;
            this.grdVIP회원메모.Cols[0].DataType = typeof(bool);
            this.grdVIP회원메모.SetCellCheck(0, 0, CheckEnum.Unchecked);
            this.grdVIP회원메모.Cols[0].ImageAlignFixed = ImageAlignEnum.CenterCenter;
            this.grdVIP회원메모.Cols[_conVIP고객메모ID].Visible = false;
            this.grdVIP회원메모.Cols[_conVIP메모작성일자].Width = 130;
            this.grdVIP회원메모.Cols[_conVIP메모작성일자].Format = "yyyy-MM-dd HH:mm:ss";
            this.grdVIP회원메모.Cols[_conVIP메모내용].Width = 240;
            for (int i = 1; i < this.grdVIP회원메모.Rows.Count; i++)
            {
                this.grdVIP회원메모.AutoSizeRow(i);

            }
            for (int i = 1; i < this.grdWork.Cols.Count; i++)
            {
                //this.grdVIP회원메모.AutoSizeCol(i);
                this.grdVIP회원메모.Cols[i].AllowEditing = false;
            }
            this.grdVIP회원메모.Redraw = true;
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            //2021-01-23임권호
            this.Close();
        }

        private void lblVIP취소_Click(object sender, EventArgs e)
        {
            //2021-01-23임권호
            this.Close();
        }

        private void txt메모_KeyDown(object sender, KeyEventArgs e)
        {
            if (this._intVIP고객여부 == 1)
                return;
            if (!e.Shift)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    this.saveMemoData();
                    this.viewCustomerMemoData();
                }
            }
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            //2021-01-27 임권호
            //해당부분도 수정
            //2021-10-22 이찬명
            if (this.tabMain.SelectedIndex == 0)
            {
                settingControl();
            }
            else if (this.tabMain.SelectedIndex == 1)
            {
                if (this._intVIP고객등록ID != 0)
                    this.controlEnabledVIP(true);
                else
                {
                    this.controlEnabledVIP(false);
                    this.viewDataNormalData();
                }
            }
        }

        private void settingControl()
        {
            if (this._intVIP고객등록ID != 0)
            {
                this.controlEnabled(false);
                this.controlEnabled담당자(false);
                return;
            }

            if (this._userInfo.사용자정보ID == getConfig.getData고객담당자(this._SQLServer, this._int고객등록ID) || this._userInfo.권한 == 1)
                this.controlEnabled(true);
            else
                this.controlEnabled(false);

            if (this._userInfo.담당자변경 == 1 || this._userInfo.권한 == 1)
                this.controlEnabled담당자(true);
            else
                this.controlEnabled담당자(false);

            if (getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "간편메모장관리") == "1" || this._userInfo.권한 == 1)
                this.controlEnabled메모(true);
            else
                this.controlEnabled메모(false);
        }

        private void viewDataNormalData()
        {
            try
            {
                int intVIP고객등록ID = 0;
                string sql = "";
                sql += "select VIP고객등록ID" + System.Environment.NewLine;
                sql += "from   tb_VIP고객등록" + System.Environment.NewLine;
                sql += "where  고객등록ID=" + this._int고객등록ID + "" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    intVIP고객등록ID = Convert.ToInt32(sd["VIP고객등록ID"]);
                }
                sd.Close();
                this.viewData매출정보();
                this.viewVIPCustomerMemoData(intVIP고객등록ID);
            }
            catch (Exception ex)
            {
            }
        }
        private void controlEnabled(bool isEnabled)
        {
            //2021-02-09 임권호 (기수삭제)
            this.txt이름.Enabled = isEnabled;
            this.txt체험기수.Enabled = isEnabled;
            this.txt휴대전화.Enabled = isEnabled;

            this.dtp최초분배일.Enabled = isEnabled;
            this.txt카톡아이디.Enabled = isEnabled;
            this.dtp예약일설정.Enabled = isEnabled;
            this.txt네이버아이디.Enabled = isEnabled;
            this.cbo유입경로대분류.Enabled = isEnabled;

            this.cbo유입경로소분류.Enabled = isEnabled;
            //this.cbo담당자.Enabled = isEnabled;
            this.dtp무료리딩시작일.Enabled = isEnabled;
            this.dtp무료리딩종료일.Enabled = isEnabled;
            this.cbo유입경로.Enabled = isEnabled;

            this.txt검색어.Enabled = isEnabled;
            //this.txt메모.Enabled = isEnabled;
            this.lblAdd.Enabled = isEnabled;
        }
        private void controlEnabled담당자(bool isEnabled)
        {
            this.cbo담당자.Enabled = isEnabled;
            this.lblAdd.Enabled = isEnabled;
        }
        private void controlEnabled메모(bool isEnabled)
        {
            if (this._userInfo.사용자정보ID == getConfig.getData고객담당자(this._SQLServer, this._int고객등록ID))
            {
                this.txt메모.Enabled = true;
                this.lblAdd.Enabled = true;
                return;
            }
            this.txt메모.Enabled = isEnabled;
            this.lblAdd.Enabled = isEnabled;
        }
        private void controlEnabledVIP(bool isEnabled)
        {
            //2021-02-09 임권호 (결제확인)
            this.txtVIP이름.Enabled = isEnabled;
            this.txtVIP체험기수.Enabled = isEnabled;
            this.txtVIP휴대전화.Enabled = isEnabled;

            this.dtp가입날짜.Enabled = isEnabled;
            this.txtVIP카톡아이디.Enabled = isEnabled;
            this.cbo가입경로.Enabled = isEnabled;
            this.cboVIP담당자.Enabled = isEnabled;
            this.txtVIP네이버아이디.Enabled = isEnabled;

            this.dtp리딩기간1.Enabled = isEnabled;
            this.dtp리딩기간2.Enabled = isEnabled;
            this.cbo가입반.Enabled = isEnabled;
            this.cbo인바운드.Enabled = isEnabled;
            this.txt증권사.Enabled = isEnabled;

            this.txt예수금.Enabled = isEnabled;
            this.txtVIP검색어.Enabled = isEnabled;
            this.dtp결제일자.Enabled = isEnabled;
            this.txt결제금액.Enabled = isEnabled;
            this.cbo결제방식.Enabled = isEnabled;

            this.cboPG.Enabled = isEnabled;
            this.cbo카드사.Enabled = isEnabled;
            this.cbo할부.Enabled = isEnabled;
            //2021-03-25 임권호
            this.txt현금영수증.Enabled = false;

            this.lblVIP확인.Enabled = isEnabled;
        }

        private void txtVIP고객메모_KeyDown(object sender, KeyEventArgs e)
        {
            if (this._intVIP고객여부 == 0)
                return;
            if (!e.Shift)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    this.saveVIPMemoData();
                    this.viewVIPCustomerMemoData();
                }
            }
        }

        private void grd결제정보_DoubleClick(object sender, EventArgs e)
        {
            int row = this.grd결제정보.MouseRow;
            if (row < 1)
                return;

            if (Convert.ToString(this.grd결제정보[row, _con환불]) != "" || Convert.ToString(this.grd결제정보[row, _con결제변경]) != "")
            {
                MessageBox.Show("환불처리나 결제변경된 내역은 수정하실수 없습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this._int매출정보ID = Convert.ToInt32(this.grd결제정보[row, _con매출정보ID]);
            this._str환불 = Convert.ToString(this.grd결제정보[row, _con환불]);
            this._str결제변경 = Convert.ToString(this.grd결제정보[row, _con결제변경]);

            this.dtp결제일자.Text = Convert.ToString(this.grd결제정보[row, _con날짜]);
            this.txt결제금액.Text = Convert.ToString(this.grd결제정보[row, _con금액]);
            this.cbo결제방식.SelectedItem = this.grd결제정보[row, _con결제방식];

            this.cboPG.SelectedItem = Convert.ToString(this.grd결제정보[row, _conPG]);
            this.cbo카드사.SelectedItem = Convert.ToString(this.grd결제정보[row, _con카드사]);
            this.cbo할부.SelectedItem = Convert.ToString(this.grd결제정보[row, _con할부]);
            this.txt현금영수증.Text = Convert.ToString(this.grd결제정보[row, _con현금영수증]);

            frm매출등록 f매출등록 = new frm매출등록(this._int매출정보ID);
            f매출등록.ShowDialog();
            this.viewVIPCustomerMemoData();
            this.viewData매출정보();
        }

        private void grd문자발송_DoubleClick(object sender, EventArgs e)
        {
            //int row = this.grd문자발송.MouseRow;
            //if (row < 1)
            //    return;
            //this.txt문자내용.Text = Convert.ToString(this.grd문자발송[row, 3]);
        }
        private void change결제수단()
        {
            try
            {
                //2021-02-16 임권호
                if (MessageBox.Show("결제수단을 변경하시겠습니까?", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.No)
                    return;

                string str결제변경 = "(금액:" + this.txt결제금액.Text + " / 결제방식 : " + this.cbo결제방식.SelectedItem + " / PG : " + this.cboPG.SelectedItem + " / 카드사 : " + this.cbo카드사.SelectedItem + " / 할부 : " + this.cbo할부.SelectedItem + ")";

                string sql = "";
                sql += "update tb_매출정보 set 결제변경='" + str결제변경 + "' " + System.Environment.NewLine;
                sql += "where  매출정보ID=" + this._int매출정보ID + "" + System.Environment.NewLine;

                this._SQLServer.Command_SQL(sql);
                this._int매출정보ID = 0;
                this.saveData매출등록(false);

                this.saveVIPMemoData();
                this.viewVIPCustomerMemoData();

                this.saveData결제변경메모();
            }
            catch (Exception ex)
            {
            }
        }

        private void saveData결제변경메모1()
        {
            try
            {
                //2021-02-16 임권호
                string str메모 = "(일자: " + this.dtp결제일자.Text + " / 금액 : " + this.txt결제금액.Text + " / 결제수단 : " + this.cbo결제방식.SelectedItem + " / 카드사 : " + this.cbo카드사.SelectedItem + " / PG : " + this.cboPG.Text + " )";

                string sql = "";
                sql += "insert  into tb_VIP고객메모(" + System.Environment.NewLine;
                sql += "       VIP고객등록ID, 내용, 작성자, 작성일자, 수정자, " + System.Environment.NewLine;
                sql += "       수정일자)" + System.Environment.NewLine;
                sql += "values (" + System.Environment.NewLine;
                sql += "       @VIP고객등록ID, @내용, @작성자, @작성일자, @수정자, " + System.Environment.NewLine;
                sql += "       @수정일자)" + System.Environment.NewLine;
                sql += "select convert(int,scope_identity())" + System.Environment.NewLine;

                this._SQLServer.paraClear();
                this._SQLServer.addPara("VIP고객등록ID", this._intVIP고객등록ID, SqlDbType.Int);
                this._SQLServer.addPara("내용", str메모, SqlDbType.NVarChar);
                this._SQLServer.addPara("작성자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                this._SQLServer.addPara("작성일자", DateTime.Now, SqlDbType.DateTime);
                this._SQLServer.addPara("수정자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                this._SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);

                this._SQLServer.Command_SQL(sql, "VIP고객메모ID", this._intVIP고객메모ID);

                this.viewVIPCustomerMemoData();
            }
            catch (Exception ex)
            {
            }
        }
        private void change환불처리()
        {
            try
            {
                if (MessageBox.Show("환불처리를 하시겠습니까?", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.No)
                    return;

                string sql = "";
                sql += "update tb_매출정보 set 환불='환불' " + System.Environment.NewLine;
                sql += "where  매출정보ID=" + this._int매출정보ID + "" + System.Environment.NewLine;

                this._SQLServer.Command_SQL(sql);
                this._int매출정보ID = 0;
            }
            catch (Exception ex)
            {
            }
        }
        private void lbl결제확인_Click(object sender, EventArgs e)
        {
            //2021-02-23 임권호
            if (this._userInfo.권한 == 0)
            {
                //MessageBox.Show("해당 기능은 권한이 없습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this._intVIP고객등록ID == 0)
                this.SaveVIP고객등록Data();

            this.saveData매출등록();
        }
        private void saveData결제변경메모()
        {
            try
            {
                //2021-02-19 임권호 (9)
                //string str메모 = "(일자: " + this.dtp결제일자.Text + " / 금액 : " + this.txt금액.Text + " / 결제수단 : " + this.cbo결제수단.SelectedItem + " / 카드사 : " + this.cbo카드사.SelectedItem + " / PG : " + this.cboPG사.SelectedItem + " / 할부 : " + this.cbo할부변경.SelectedItem + " )";
                string str메모 = "(" + this.txt이름.Text + " / " + this.cbo결제방식.SelectedItem + " / 가입반 : " + this.cbo가입반.SelectedItem + " / PG : " + this.cboPG.SelectedItem + " / " + this.cbo카드사.SelectedItem + " " + this.txt결제금액.Text + " (" + this.cbo할부.SelectedItem + ") / " + this.cbo가입경로.Text + " / " + this.cbo담당자.Text + ")";

                string sql = "";
                sql += "insert  into tb_VIP고객메모(" + System.Environment.NewLine;
                sql += "       VIP고객등록ID, 내용, 작성자, 작성일자, 수정자, " + System.Environment.NewLine;
                sql += "       수정일자)" + System.Environment.NewLine;
                sql += "values (" + System.Environment.NewLine;
                sql += "       @VIP고객등록ID, @내용, @작성자, @작성일자, @수정자, " + System.Environment.NewLine;
                sql += "       @수정일자)" + System.Environment.NewLine;
                sql += "select convert(int,scope_identity())" + System.Environment.NewLine;

                this._SQLServer.paraClear();
                this._SQLServer.addPara("VIP고객등록ID", this._intVIP고객등록ID, SqlDbType.Int);
                this._SQLServer.addPara("내용", str메모, SqlDbType.NVarChar);
                this._SQLServer.addPara("작성자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                this._SQLServer.addPara("작성일자", DateTime.Now, SqlDbType.DateTime);
                this._SQLServer.addPara("수정자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                this._SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);

                this._SQLServer.Command_SQL(sql, "VIP고객메모ID", 0);
            }
            catch (Exception ex)
            {
            }
        }
        private void lblAdd_Click(object sender, EventArgs e)
        {

        }

        private void grdWork_DoubleClick(object sender, EventArgs e)
        {
            //2021-03-04 임권호
            int row = this.grdWork.MouseRow;
            if (row < 1)
                return;
            this._int고객메모ID = Convert.ToInt32(this.grdWork[row, _con고객메모ID]);
            this.txt메모.Text = Convert.ToString(this.grdWork[row, _con내용]);
        }

        private void lbl메모삭제_Click(object sender, EventArgs e)
        {
            this.deleteMemoData();
        }
        private void deleteMemoData()
        {
            try
            {
                if (this._userInfo.권한 == 0)
                {
                    //MessageBox.Show("해당 기능은 권한이 없습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (this.grdWork.Rows.Count - 1 == 0)
                    return;
                if (MessageBox.Show("선택하신 메모를 삭제하시겠습니까?", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                int result = 0;
                for (int i = 1; i < this.grdWork.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(this.grdWork[i, 0]) == false)
                        continue;
                    int int고객메모ID = Convert.ToInt32(this.grdWork[i, 1]);
                    string sql = "";
                    sql += "delete from tb_고객메모 where 고객메모ID=" + int고객메모ID + "" + System.Environment.NewLine;

                    result += this._SQLServer.Command_SQL(sql);
                }
                if (result > 0)
                {
                    this._int고객메모ID = 0;
                    MessageBox.Show("삭제가 완료되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.viewCustomerMemoData();
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void deleteVIPMemoData()
        {
            try
            {
                if (this._userInfo.권한 == 0)
                {
                    //MessageBox.Show("해당 기능은 권한이 없습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (this.grdVIP회원메모.Rows.Count - 1 == 0)
                    return;
                if (MessageBox.Show("선택하신 메모를 삭제하시겠습니까?", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                int result = 0;
                for (int i = 1; i < this.grdVIP회원메모.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(this.grdVIP회원메모[i, 0]) == false)
                        continue;
                    int int고객메모ID = Convert.ToInt32(this.grdVIP회원메모[i, 1]);
                    string sql = "";
                    sql += "delete from tb_VIP고객메모 where VIP고객메모ID=" + int고객메모ID + "" + System.Environment.NewLine;

                    result += this._SQLServer.Command_SQL(sql);
                }
                if (result > 0)
                {
                    this._intVIP고객메모ID = 0;
                    MessageBox.Show("삭제가 완료되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.viewVIPCustomerMemoData();
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void grdWork_AfterEdit(object sender, RowColEventArgs e)
        {
            if (e.Col == 0 && e.Row == 0)
            {
                int check = Convert.ToInt32(this.grdWork.GetCellCheck(0, 0));
                for (int i = 1; i < this.grdWork.Rows.Count; i++)
                {
                    //this.grdWork.Refresh();
                    if (check == 1)
                        this.grdWork.SetCellCheck(i, 0, CheckEnum.Checked);
                    else
                        this.grdWork.SetCellCheck(i, 0, CheckEnum.Unchecked);
                }
            }
        }

        private void lblVIP메모삭제_Click(object sender, EventArgs e)
        {
            this.deleteVIPMemoData();
        }

        private void grdVIP회원메모_AfterEdit(object sender, RowColEventArgs e)
        {
            if (e.Col == 0 && e.Row == 0)
            {
                int check = Convert.ToInt32(this.grdVIP회원메모.GetCellCheck(0, 0));
                for (int i = 1; i < this.grdVIP회원메모.Rows.Count; i++)
                {
                    //this.grdWork.Refresh();
                    if (check == 1)
                        this.grdVIP회원메모.SetCellCheck(i, 0, CheckEnum.Checked);
                    else
                        this.grdVIP회원메모.SetCellCheck(i, 0, CheckEnum.Unchecked);
                }
            }
        }

        private void grdVIP회원메모_DoubleClick(object sender, EventArgs e)
        {
            int row = this.grdVIP회원메모.MouseRow;
            if (row < 1)
                return;
            this._intVIP고객메모ID = Convert.ToInt32(this.grdVIP회원메모[row, _conVIP고객메모ID]);
            this.txtVIP고객메모.Text = Convert.ToString(this.grdVIP회원메모[row, _conVIP메모내용]);
        }

        private void grdWork_AfterResizeColumn(object sender, RowColEventArgs e)
        {
            //this.grdWork.AutoSizeRows(1, 4, this.grdWork.Rows.Count - 1, 4, 0, AutoSizeFlags.None);
        }

        private void opt현금영수증2_CheckedChanged(object sender, EventArgs e)
        {
            //2021-03-25 임권호
            this.txt현금영수증.Enabled = true;
        }

        private void opt현금영수증1_CheckedChanged(object sender, EventArgs e)
        {
            //2021-03-25 임권호
            this.txt현금영수증.Enabled = false;
        }

        private void frm고객등록_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            else if (e.Control && e.KeyCode == Keys.S)
            {
                if (this.tabMain.SelectedIndex == 0)
                {
                    if (this._userInfo.권한 == 0 && this._int고객등록ID == 0)
                    {
                        return;
                    }
                    this.save고객등록Data();
                }
                else
                {
                    if (this._userInfo.권한 == 0 && this._intVIP고객등록ID == 0)
                    {
                        return;
                    }
                    this.SaveVIP고객등록Data();
                }
            }
        }

        private void dtp무료리딩시작일_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = Convert.ToDateTime(this.dtp무료리딩시작일.Value);
                this.dtp무료리딩종료일.Value = startDate.AddDays(7);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
