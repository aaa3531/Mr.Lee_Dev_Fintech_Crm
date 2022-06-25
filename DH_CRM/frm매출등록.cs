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
    public partial class frm매출등록 : Form
    {
        private SQLServer _SQLServer;
        private userInfo _userInfo;

        private bool IsMouseMoveStart;
        private Point mousePoint;

        private int _int매출정보ID;
        private int _int고객등록ID;
        private int _intBefore고객등록ID;

        private int _intVIP고객등록ID;
        public frm매출등록(int 매출정보ID)
        {
            InitializeComponent();
            this._int매출정보ID = 매출정보ID;
            this._SQLServer = SQLServer.Instance();
            this._userInfo = userInfo.Instance();

            this.viewForm();

            this.lblTopBar.Parent = this.picMain;
            this.lblClose.Parent = this.picMain;
            this.lbl고객정보.Parent = this.picMain;

            this.lbl등록.Parent = this.picMain;
            this.lbl결제수단변경.Parent = this.picMain;
            this.lbl환불처리.Parent = this.picMain;

            this.lblTopBar.MouseDown += this.Form_MouseDown;
            this.lblTopBar.MouseMove += this.Form_MouseMove;
            this.lblTopBar.MouseUp += this.Form_MouseUp;
            this.panel1.Parent = this.picMain;
            this.panel2.Parent = this.picMain;
            this.panel3.Parent = this.picMain;
            this.panel4.Parent = this.picMain;
        }
        private void viewForm()
        {
            try
            {
                string str1 = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "화면위치왼쪽상단");
                if (str1 == "1")
                {
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = new Point(0, 0);
                }
                string str2 = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "화면위치오른쪽상단");
                if (str2 == "1")
                {
                    int x = Screen.PrimaryScreen.Bounds.Right - this.Width;
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = new Point(x, 0);
                }
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

        private void frm매출등록_Load(object sender, EventArgs e)
        {
            this.cbo결제수단.Items.Add("신용카드");
            this.cbo결제수단.Items.Add("현금");
            this.cbo결제수단.Items.Add("이체");
            this.cbo결제수단.Items.Add("모바일");
            this.cbo결제수단.Items.Add("기타");
            this.cbo결제수단.SelectedIndex = 0;

            //2021-02-15 임권호
            this.cbo결제구분.Items.Add("수입");
            this.cbo결제구분.Items.Add("지출");
            this.cbo결제구분.Items.Add("결변(결제변경)");
            this.cbo결제구분.SelectedIndex = 0;

            this.dtp매출일자.Value = DateTime.Now;
            this.dtp결제일자.Value = DateTime.Now;

            this.settingComboData();
            //2021-03-25 임권호
            this.txt현금영수증번호.Enabled = false;

            if (this._int매출정보ID > 0)
                this.viewData매출정보();
        }
        private void settingComboData()
        {
            try
            {
                DataTable dt = new DataTable();
                if ((this._userInfo.자료검색 == 0 && getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "입출금리스트") == "1")||this._userInfo.권한 == 1)
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
                this.cbo담당자.ItemsDataSource = dt;
                this.cbo담당자.ItemsDisplayMember = "이름";
                this.cbo담당자.ItemsValueMember = "사용자정보ID";
                this.cbo담당자.TranslateValue = true;
                this.cbo담당자.SelectedIndex = 0;

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
                this.cbo토스담당자.ItemsDataSource = dt1;
                this.cbo토스담당자.ItemsDisplayMember = "이름";
                this.cbo토스담당자.ItemsValueMember = "사용자정보ID";
                this.cbo토스담당자.TranslateValue = true;
                DataRow row = dt1.NewRow();
                row["사용자정보ID"] = 0;
                row["이름"] = "담당자 선택";
                dt1.Rows.InsertAt(row, 0);
                this.cbo토스담당자.SelectedIndex = 0;

                //2021-02-19 임권호 (13)
                DataTable dt3 = getConfig.getDt유입경로(this._SQLServer);
                this.cbo가입경로.ItemsDataSource = dt3;
                this.cbo가입경로.ItemsDisplayMember = "유입경로";
                this.cbo가입경로.ItemsValueMember = "유입경로설정ID";
                this.cbo가입경로.TranslateValue = true;
                if (this.cbo가입경로.Items.Count > 0)
                    this.cbo가입경로.SelectedIndex = 0;

                //DataTable dt4 = getConfig.getData가입반정보(this._SQLServer);
                //this.cbo가입반.ItemsDataSource = dt4;
                //this.cbo가입반.ItemsDisplayMember = "가입반";
                //this.cbo가입반.ItemsValueMember = "가입반설정ID";
                //this.cbo가입반.TranslateValue = true;
                //if (this.cbo가입반.Items.Count > 0)
                //    this.cbo가입반.SelectedIndex = 0;

                //DataTable dt5 = getConfig. getDtPG사항목(this._SQLServer);
                //this.cboPG사.ItemsDataSource = dt5;
                //this.cboPG사.ItemsDisplayMember = "PG사항목";
                //this.cboPG사.ItemsValueMember = "PG사항목설정ID";
                //this.cboPG사.TranslateValue = true;
                //if (this.cboPG사.Items.Count > 0)
                //    this.cboPG사.SelectedIndex = 0;

                //DataTable dt6 = getConfig.getDt카드사항목(this._SQLServer);
                //this.cbo카드사.ItemsDataSource = dt6;
                //this.cbo카드사.ItemsDisplayMember = "내용";
                //this.cbo카드사.ItemsValueMember = "카드사항목설정ID";
                //this.cbo카드사.TranslateValue = true;
                //if (this.cbo카드사.Items.Count > 0)
                //    this.cbo카드사.SelectedIndex = 0;

                //2021-02-15 임권호
                string sql = "";
                sql += "select * from tb_가입반설정 order by 가입반";
                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this.cbo가입반.Items.Add(Convert.ToString(sd["가입반"]));
                }
                sd.Close();
                this.cbo가입반.SelectedIndex = 0;

                sql = "";
                sql += "select * from tb_PG사항목설정 order by PG사항목";
                sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this.cboPG사.Items.Add(Convert.ToString(sd["PG사항목"]));
                }
                sd.Close();
                this.cboPG사.SelectedIndex = 0;

                sql = "";
                sql += "select * from tb_카드사항목설정 order by 내용";
                sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this.cbo카드사.Items.Add(Convert.ToString(sd["내용"]));
                }
                sd.Close();
                this.cbo카드사.SelectedIndex = 0;

                for (int i = 0; i < 37; i++)
                {
                    this.cbo할부변경.Items.Add(i.ToString());
                }
                this.cbo할부변경.SelectedIndex = 1;


            }
            catch (Exception ex)
            {
            }
        }
        private void viewData매출정보()
        {
            try
            {
               //2021-02-19 임권호
                string sql = "";
                sql += "select a.이름, a.휴대폰, a.매출일자, a.가입경로, a.담당자, " + System.Environment.NewLine;
                sql += "       a.금액, a.결제일자, a.결제수단, a.할부개월, a.토스건담당자, " + System.Environment.NewLine;
                sql += "       a.카드사별적용내역, a.영업자별매출, a.현금영수증발행, a.토스건결제유무, a.인바운드유무, " + System.Environment.NewLine;
                sql += "       a.PG, a.카드사, a.할부개월, a.결제구분, c.VIP고객등록ID, " + System.Environment.NewLine;
                sql += "       b.고객등록ID" + System.Environment.NewLine;
                sql += "from tb_매출정보 a left join tb_고객등록 b " + System.Environment.NewLine;
                sql += "on a.고객등록ID = b.고객등록ID " + System.Environment.NewLine;
                sql += "left join tb_VIP고객등록 c" + System.Environment.NewLine;
                sql += "on a.고객등록ID=c.고객등록ID" + System.Environment.NewLine;
                sql += "where  a.매출정보ID=" + this._int매출정보ID + "" + System.Environment.NewLine;
                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this.txt이름.Text = Convert.ToString(sd["이름"]);
                    this.txt휴대폰.Text = Convert.ToString(sd["휴대폰"]);
                    this.dtp매출일자.Text = Convert.ToString(sd["매출일자"]);
                    this.cbo가입경로.SelectedItem = Convert.ToString(sd["가입경로"]);
                    this.cbo담당자.SelectedItem = Convert.ToInt32(sd["담당자"]);
                    this.txt금액.Text = Convert.ToString(sd["금액"]);
                    this.dtp결제일자.Text = Convert.ToString(sd["결제일자"]);
                    this.cbo결제수단.SelectedItem = sd["결제수단"];
                    this.cbo토스담당자.SelectedItem = Convert.ToInt32(sd["토스건담당자"]);
                    this.txt카드사별적용내역.Text = Convert.ToString(sd["카드사별적용내역"]);
                    if (Convert.ToInt32(sd["영업자별매출"]) == 1)
                        this.opt영업자별매출2.Checked = true;
                    if (Convert.ToInt32(sd["현금영수증발행"]) == 1)
                        this.opt현금영수증발행2.Checked = true;
                    if (Convert.ToInt32(sd["토스건결제유무"]) == 1)
                        this.opt토스건결제유무2.Checked = true;
                    if (Convert.ToInt32(sd["인바운드유무"]) == 1)
                        this.opt인바운드유무2.Checked = true;
                    this.cboPG사.SelectedItem = Convert.ToString(sd["PG"]);
                    this.cbo카드사.SelectedItem = Convert.ToString(sd["카드사"]);
                    this.cbo할부변경.SelectedIndex = Convert.ToInt32(sd["할부개월"]);
                    //this.cbo결제구분.Text = Convert.ToString(sd["결제구분"]);
                    if (Convert.ToString(sd["결제구분"]) == "수입")
                        this.cbo결제구분.SelectedIndex = 0;
                    else if (Convert.ToString(sd["결제구분"]) == "지출")
                        this.cbo결제구분.SelectedIndex = 1;
                    else
                        this.cbo결제구분.SelectedIndex = 2;
                    this._intVIP고객등록ID = sd["VIP고객등록ID"] == DBNull.Value ? 0 : Convert.ToInt32(sd["VIP고객등록ID"]);
                    this._int고객등록ID = sd["고객등록ID"] == DBNull.Value ? 0 : Convert.ToInt32(sd["고객등록ID"]);
                    this._intBefore고객등록ID = this._int고객등록ID;
                }
                sd.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void lbl등록_Click(object sender, EventArgs e)
        {
            this.saveData매출정보();
        }
        private void checkData고객정보()
        {
            try
            {
                string sql = "";
                sql += "update tb_고객등록 set VIP고객여부=0" + System.Environment.NewLine;
                sql += "where  고객등록ID=" + this._intBefore고객등록ID + "" + System.Environment.NewLine;

                this._SQLServer.Command_SQL(sql);

                sql = "";
                sql += "update tb_고객등록 set VIP고객여부=1" + System.Environment.NewLine;
                sql += "where  고객등록ID=" + this._int고객등록ID + "" + System.Environment.NewLine;

                this._SQLServer.Command_SQL(sql);
            }
            catch (Exception ex)
            {
            }
        }
        private void changeVIP고객여부()
        {
            try
            {
                string sql = "";
                sql += "update tb_고객등록 set VIP고객여부=1" + System.Environment.NewLine;
                sql += "where  고객등록ID=" + this._int고객등록ID + "" + System.Environment.NewLine;

                this._SQLServer.Command_SQL(sql);
            }
            catch (Exception ex)
            {
            }
        }
        private void saveDataVIP고객등록()
        {
            try
            {
                string str체험기수 = "";
                string str카톡아이디 = "";
                string str리딩기간1 = "";
                string str리딩기간2 = "";
                string str검색어 = "";
                string str네이버아이디 = "";

                string sql = "";
                sql += "select 생년월일, 카톡아이디, 무료리딩시작일, 무료리딩종료일, 검색어, " + System.Environment.NewLine;
                sql += "       네이버아이디" + System.Environment.NewLine;
                sql += "from   tb_고객등록" + System.Environment.NewLine;
                sql += "where  고객등록ID=" + this._int고객등록ID + "" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    str체험기수 = Convert.ToString(sd["생년월일"]);
                    str카톡아이디 = Convert.ToString(sd["카톡아이디"]);
                    str리딩기간1 = Convert.ToString(sd["무료리딩시작일"]);
                    str리딩기간2 = Convert.ToString(sd["무료리딩종료일"]);
                    str검색어 = Convert.ToString(sd["검색어"]);
                    str네이버아이디 = Convert.ToString(sd["네이버아이디"]);
                }
                sd.Close();

                sql = "insert into tb_VIP고객등록 ( " + System.Environment.NewLine;
                sql += "     고객등록ID, 이름, 생년월일, 휴대전화, " + System.Environment.NewLine;
                sql += "     집전화, 가입일자, 카톡아이디, 담당자, " + System.Environment.NewLine;
                sql += "     리딩기간1, 리딩기간2, 가입반, 인바운드, 증권사, " + System.Environment.NewLine;
                sql += "     예수금, 등록자, 등록일자, 수정자, 수정일자, " + System.Environment.NewLine;
                sql += "     검색어, VIP네이버아이디, 가입경로 ) " + System.Environment.NewLine;
                sql += "values ( " + System.Environment.NewLine;
                sql += "     @고객등록ID, @이름, @생년월일, @휴대전화, " + System.Environment.NewLine;
                sql += "     @집전화, @가입일자, @카톡아이디, @담당자, " + System.Environment.NewLine;
                sql += "     @리딩기간1, @리딩기간2, @가입반, @인바운드, @증권사, " + System.Environment.NewLine;
                sql += "     @예수금, @등록자, @등록일자, @수정자, @수정일자, " + System.Environment.NewLine;
                sql += "     @검색어, @VIP네이버아이디, @가입경로 ) " + System.Environment.NewLine;
                sql += "select convert(int,scope_identity())" + System.Environment.NewLine;

                this._SQLServer.paraClear();
                this._SQLServer.addPara("고객등록ID", this._int고객등록ID, SqlDbType.Int);
                this._SQLServer.addPara("이름", this.txt이름.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("생년월일", str체험기수, SqlDbType.NVarChar);
                this._SQLServer.addPara("휴대전화", this.txt휴대폰.Text, SqlDbType.NVarChar);

                this._SQLServer.addPara("집전화", "", SqlDbType.NVarChar);
                this._SQLServer.addPara("가입일자", DateTime.Now.ToShortDateString(), SqlDbType.NVarChar);
                this._SQLServer.addPara("카톡아이디", str카톡아이디, SqlDbType.NVarChar);
                this._SQLServer.addPara("담당자", this.cbo담당자.SelectedItem, SqlDbType.Int);

                this._SQLServer.addPara("리딩기간1", str리딩기간1, SqlDbType.NVarChar);
                this._SQLServer.addPara("리딩기간2", str리딩기간2, SqlDbType.NVarChar);
                this._SQLServer.addPara("가입반", this.cbo가입반.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("인바운드", this.opt인바운드유무1.Checked == true ? "유" : "무", SqlDbType.NVarChar);
                this._SQLServer.addPara("증권사", "", SqlDbType.NVarChar);

                this._SQLServer.addPara("예수금", this.txt금액.Text, SqlDbType.NVarChar);


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

                this._SQLServer.addPara("검색어", str검색어, SqlDbType.NVarChar);
                this._SQLServer.addPara("VIP네이버아이디", str네이버아이디, SqlDbType.NVarChar);
                this._SQLServer.addPara("가입경로", this.cbo가입경로.SelectedItem, SqlDbType.Int);

                this._intVIP고객등록ID = this._SQLServer.Command_SQL(sql, "VIP고객등록ID", this._intVIP고객등록ID);
            }
            catch (Exception ex)
            {
            }
        }
        private void saveData매출정보(bool isMessage = true, string 결제구분 = "")
        {
            try
            {
                if (this._int고객등록ID == 0)
                {
                    MessageBox.Show("고객정보를 불러와 주시기 바랍니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (isMessage)
                {
                    //2021-02-15 임권호
                    if (MessageBox.Show("매출정보를 저장하시겠습니까?", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                        return;
                }
                if (this._intBefore고객등록ID != this._int고객등록ID)
                    this.checkData고객정보();
                else
                {
                    this.changeVIP고객여부();
                }

                if (this._intVIP고객등록ID == 0)
                    this.saveDataVIP고객등록();

                string sql = "";
                if (this._int매출정보ID == 0)
                {
                    sql += "insert into tb_매출정보(" + System.Environment.NewLine;
                    sql += "       [고객등록ID], [매출일자], [가입경로], [담당자], " + System.Environment.NewLine;
                    sql += "       [금액], [결제일자], [결제수단], [할부개월], [카드사별적용내역], " + System.Environment.NewLine;
                    sql += "       [영업자별매출], [현금영수증발행], [현금영수증번호], [토스건결제유무], [인바운드유무], " + System.Environment.NewLine;
                    sql += "       [등록자], [등록일자], [수정자], [수정일자], [토스건담당자], " + System.Environment.NewLine;
                    sql += "       [이름], [휴대폰], [결제구분], [PG], [카드사]) " + System.Environment.NewLine;
                    sql += "values (" + System.Environment.NewLine;
                    sql += "       @고객등록ID, @매출일자, @가입경로, @담당자, " + System.Environment.NewLine;
                    sql += "       @금액, @결제일자, @결제수단, @할부개월, @카드사별적용내역, " + System.Environment.NewLine;
                    sql += "       @영업자별매출, @현금영수증발행, @현금영수증번호, @토스건결제유무, @인바운드유무, " + System.Environment.NewLine;
                    sql += "       @등록자, @등록일자, @수정자, @수정일자, @토스건담당자, " + System.Environment.NewLine;
                    sql += "       @이름, @휴대폰, @결제구분, @PG, @카드사)  " + System.Environment.NewLine;
                    sql += "select convert(int,scope_identity())" + System.Environment.NewLine;
                }
                else
                {
                    sql += "update tb_매출정보 set" + System.Environment.NewLine;
                    sql += "       [고객등록ID]=@고객등록ID, [매출일자]=@매출일자, [가입경로]=@가입경로, [담당자]=@담당자, " + System.Environment.NewLine;
                    sql += "       [금액]=@금액, [결제일자]=@결제일자, [결제수단]=@결제수단, [할부개월]=@할부개월, [카드사별적용내역]=@카드사별적용내역, " + System.Environment.NewLine;
                    sql += "       [영업자별매출]=@영업자별매출, [현금영수증발행]=@현금영수증발행, [현금영수증번호]=@현금영수증번호, [토스건결제유무]=@토스건결제유무, [인바운드유무]=@인바운드유무, " + System.Environment.NewLine;
                    sql += "       [수정자]=@수정자, [수정일자]=@수정일자, [토스건담당자]=@토스건담당자, [이름]=@이름, [휴대폰]=@휴대폰, " + System.Environment.NewLine;
                    sql += "       [결제구분]=@결제구분, [PG]=@PG, [카드사]=@카드사" + System.Environment.NewLine;
                    sql += "where  매출정보ID=@매출정보ID" + System.Environment.NewLine;
                }
                this._SQLServer.paraClear();
                this._SQLServer.addPara("고객등록ID", this._int고객등록ID, SqlDbType.Int);
                this._SQLServer.addPara("매출일자", this.dtp매출일자.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("가입경로", this.cbo가입경로.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("담당자", this.cbo담당자.SelectedItem, SqlDbType.Int);

                this._SQLServer.addPara("금액", this.txt금액.Text == "" ? "0" : this.txt금액.Text, SqlDbType.Int);
                this._SQLServer.addPara("결제일자", this.dtp결제일자.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("결제수단", this.cbo결제수단.SelectedItem, SqlDbType.NVarChar);
                this._SQLServer.addPara("할부개월", this.cbo할부변경.SelectedItem, SqlDbType.Int);
                this._SQLServer.addPara("카드사별적용내역", this.txt카드사별적용내역.Text.Trim(), SqlDbType.NVarChar);

                int int영업자별매출 = 0;
                if (Convert.ToString(this.cbo결제수단.SelectedItem) == "신용카드")
                    int영업자별매출 = 1;

                this._SQLServer.addPara("영업자별매출", int영업자별매출, SqlDbType.TinyInt);
                this._SQLServer.addPara("현금영수증발행", this.opt현금영수증발행1.Checked == true ? 0 : 1, SqlDbType.TinyInt);
                this._SQLServer.addPara("현금영수증번호", this.txt현금영수증번호.Text.Trim(), SqlDbType.NVarChar);
                this._SQLServer.addPara("토스건결제유무", this.opt토스건결제유무1.Checked == true ? 0 : 1, SqlDbType.TinyInt);
                this._SQLServer.addPara("인바운드유무", this.opt인바운드유무1.Checked == true ? 0 : 1, SqlDbType.TinyInt);

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
                this._SQLServer.addPara("토스건담당자", this.cbo토스담당자.SelectedItem, SqlDbType.Int);
                this._SQLServer.addPara("이름", this.txt이름.Text.Trim(), SqlDbType.NVarChar);
                this._SQLServer.addPara("휴대폰", this.txt휴대폰.Text.Trim(), SqlDbType.NVarChar);
                this._SQLServer.addPara("결제구분", this.cbo결제구분.SelectedItem, SqlDbType.NVarChar);
                this._SQLServer.addPara("PG", this.cboPG사.SelectedItem, SqlDbType.NVarChar);
                this._SQLServer.addPara("카드사", this.cbo카드사.SelectedItem, SqlDbType.NVarChar);

                this._int매출정보ID = this._SQLServer.Command_SQL(sql, "매출정보ID", _int매출정보ID);
                if (this._int매출정보ID > 0)
                {
                    MessageBox.Show("저장이 완료되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                this.saveData결제변경메모();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lbl고객정보_Click(object sender, EventArgs e)
        {
            //2021-01-23 임권호

            frm고객등록정보 f고객등록정보 = new frm고객등록정보();
            if (f고객등록정보.ShowDialog() == DialogResult.OK)
            {
                this.viewData고객정보(getConfig.고객등록ID);
            }
        }
        private void viewData고객정보(int 고객등록ID)
        {
            try
            {
                //2021-01-23 임권호
                string sql = "";
                sql += "select a.고객등록ID, a.이름, a.휴대전화, a.담당자, b.VIP고객등록ID " + System.Environment.NewLine;
                sql += "from   tb_고객등록 a left join tb_VIP고객등록 b" + System.Environment.NewLine;
                sql += "on     a.고객등록ID=b.고객등록ID" + System.Environment.NewLine;
                sql += "where  1=1" + System.Environment.NewLine;
                sql += "and    a.고객등록ID=" + 고객등록ID + "" + System.Environment.NewLine;
                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this.txt이름.Text = Convert.ToString(sd["이름"]);
                    this.txt휴대폰.Text = Convert.ToString(sd["휴대전화"]);
                    this.cbo담당자.SelectedItem = sd["담당자"];
                    this._intVIP고객등록ID = sd["VIP고객등록ID"] == DBNull.Value ? 0 : Convert.ToInt32(sd["VIP고객등록ID"]);
                    this._int고객등록ID = sd["고객등록ID"] == DBNull.Value ? 0 : Convert.ToInt32(sd["고객등록ID"]);
                }
                sd.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void lbl결제수단변경_Click(object sender, EventArgs e)
        {
            if (this._userInfo.권한 == 0)
            {
                //MessageBox.Show("해당 기능은 권한이 없습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.change결제수단();
        }
        private void change결제수단()
        {
            try
            {
                if (this._int매출정보ID == 0)
                {
                    MessageBox.Show("결제수단을 변경하시려는 결제정보를 불러와 주시기 바랍니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //2021-02-16 임권호
                if (MessageBox.Show("결제수단을 변경하시겠습니까?", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.No)
                    return;

                string str결제변경 = "(금액:" + this.txt금액.Text + " / 결제방식 : " + this.cbo결제수단.SelectedItem + " / PG : " + this.cboPG사.SelectedItem + " / 카드사 : " + this.cbo카드사.SelectedItem + " / 할부 : " + this.cbo할부변경.SelectedItem + ")";

                string sql = "";
                sql += "update tb_매출정보 set 결제변경='" + str결제변경 + "', 결제구분='결변(결제변경)' " + System.Environment.NewLine;
                sql += "where  매출정보ID=" + this._int매출정보ID + "" + System.Environment.NewLine;

                this._SQLServer.Command_SQL(sql);
                this._int매출정보ID = 0;
                this.saveData매출정보(false);
                this.saveData결제변경메모();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void saveData결제변경메모()
        {
            try
            {
                //2021-02-19 임권호 (9)
                //string str메모 = "(일자: " + this.dtp결제일자.Text + " / 금액 : " + this.txt금액.Text + " / 결제수단 : " + this.cbo결제수단.SelectedItem + " / 카드사 : " + this.cbo카드사.SelectedItem + " / PG : " + this.cboPG사.SelectedItem + " / 할부 : " + this.cbo할부변경.SelectedItem + " )";
                string str메모 = "(" + this.txt이름.Text + " / " + this.cbo결제구분.SelectedItem + " / 가입반 : " + this.cbo가입반.SelectedItem + " / PG : " + this.cboPG사.SelectedItem + " / " + this.cbo카드사.SelectedItem + " " + this.txt금액.Text + " (" + this.cbo할부변경.SelectedItem + ") / " + this.cbo가입경로.Text + " / " + this.cbo담당자.Text + ")";
                
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

        private void lbl환불처리_Click(object sender, EventArgs e)
        {
            if (this._userInfo.권한 == 0)
            {
                MessageBox.Show("해당 기능은 권한이 없습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.change환불처리();
        }
        private void change환불처리()
        {
            try
            {
                if (this._int매출정보ID == 0)
                {
                    MessageBox.Show("환불 처리 하시려는 결제정보를 불러와 주시기 바랍니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("환불처리를 하시겠습니까?", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.No)
                    return;

                string sql = "";
                sql += "update tb_매출정보 set 결제구분='환불' " + System.Environment.NewLine;
                sql += "where  매출정보ID=" + this._int매출정보ID + "" + System.Environment.NewLine;
                this._SQLServer.Command_SQL(sql);

                sql = "update tb_고객등록 set VIP고객여부=0 where 고객등록ID=" + this._int고객등록ID + "" + System.Environment.NewLine;
                int result = this._SQLServer.Command_SQL(sql);
                if (result > 0)
                    MessageBox.Show("환불처리 되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
            }
        }

        private void cbo결제수단_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str결제수단 = Convert.ToString(this.cbo결제수단.SelectedItem);
            if (str결제수단 == "신용카드")
                this.opt영업자별매출2.Checked = true;
        }

        private void opt현금영수증발행2_CheckedChanged(object sender, EventArgs e)
        {
            //2021-03-25 임권호
            this.txt현금영수증번호.Enabled = true;
        }

        private void opt현금영수증발행1_CheckedChanged(object sender, EventArgs e)
        {
            //2021-03-25 임권호
            this.txt현금영수증번호.Enabled = false;
        }
    }
}
