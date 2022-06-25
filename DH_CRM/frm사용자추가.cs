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
    public partial class frm사용자추가 : Form
    {
        private SQLServer _SQLServer;
        private userInfo _userInfo;

        private bool IsMouseMoveStart;
        private Point mousePoint;

        private int _int사용자정보ID;
        public frm사용자추가(int 사용자정보ID)
        {
            InitializeComponent();
            this._int사용자정보ID = 사용자정보ID;
            this._SQLServer = SQLServer.Instance();
            this._userInfo = userInfo.Instance();

            this.lblTopBar.Parent = this.picMain;
            this.lblClose.Parent = this.picMain;

            this.lbl저장.Parent = this.picMain;

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

        private void frm사용자추가_Load(object sender, EventArgs e)
        {
            this.setComboBoxData();

            if (this._int사용자정보ID > 0)
                this.viewData사용자정보();
        }
        private void setComboBoxData()
        {
            try
            {
                DataTable dt1 = getConfig.getData본부정보(this._SQLServer);
                this.cbo본부.ItemsDataSource = dt1;
                this.cbo본부.ItemsDisplayMember = "본부";
                this.cbo본부.ItemsValueMember = "본부설정ID";
                this.cbo본부.TranslateValue = true;
                this.cbo본부.SelectedIndex = 0;

                DataTable dt2 = getConfig.getData사용자정보(this._SQLServer);
                this.cbo자료검색범위.ItemsDataSource = dt2;
                this.cbo자료검색범위.ItemsDisplayMember = "이름";
                this.cbo자료검색범위.ItemsValueMember = "사용자정보ID";
                this.cbo자료검색범위.TranslateValue = true;
                this.cbo자료검색범위.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
            }
        }
        private void viewData사용자정보()
        {
            try
            {
                int int소속팀정보ID = 0;
                string str소속팀명 = "";
                string sql = "";
                sql += "select a.*, b.소속팀명 " + System.Environment.NewLine;
                sql += "from   tb_사용자정보 a left join tb_소속팀정보 b" + System.Environment.NewLine;
                sql += "on     a.소속팀정보ID=b.소속팀정보ID" + System.Environment.NewLine;
                sql += "where  사용자정보ID=" + this._int사용자정보ID + "" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this.txt사용자ID.Text = Convert.ToString(sd["사용자ID"]);
                    this.txt비밀번호.Text = Convert.ToString(sd["비밀번호"]);
                    this.chk관리자권한.Checked = Convert.ToInt32(sd["권한"] == DBNull.Value ? 0 : sd["권한"]) == 1 ? true : false;
                    this.chk엑셀업로드.Checked = Convert.ToInt32(sd["엑셀업로드"] == DBNull.Value ? 0 : sd["엑셀업로드"]) == 1 ? true : false;
                    this.chk엑셀다운로드.Checked = Convert.ToInt32(sd["엑셀다운로드"] == DBNull.Value ? 0 : sd["엑셀다운로드"]) == 1 ? true : false;
                    this.chk자료삭제.Checked = Convert.ToInt32(sd["자료삭제"] == DBNull.Value ? 0 : sd["자료삭제"]) == 1 ? true : false;
                    this.chk담당자변경.Checked = Convert.ToInt32(sd["담당자변경"] == DBNull.Value ? 0 : sd["담당자변경"]) == 1 ? true : false;
                    if (Convert.ToInt32(sd["자료검색"] == DBNull.Value ? 0 : sd["자료검색"]) == 0)
                        this.opt자료검색1.Checked = true;
                    else if (Convert.ToInt32(sd["자료검색"] == DBNull.Value ? 0 : sd["자료검색"]) == 1)
                        this.opt자료검색2.Checked = true;
                    else if (Convert.ToInt32(sd["자료검색"] == DBNull.Value ? 0 : sd["자료검색"]) == 2)
                        this.opt자료검색3.Checked = true;
                    else if (Convert.ToInt32(sd["자료검색"] == DBNull.Value ? 0 : sd["자료검색"]) == 3)
                        this.opt자료검색4.Checked = true;
                    else if (Convert.ToInt32(sd["자료검색"] == DBNull.Value ? 0 : sd["자료검색"]) == 4)
                        this.opt자료검색5.Checked = true;

                    this.cbo자료검색범위.SelectedItem = sd["검색범위사용자정보ID"];
                    this.txt이름.Text = Convert.ToString(sd["이름"]);
                    this.txt내선.Text = Convert.ToString(sd["내선"]);
                    this.txt전화번호.Text = Convert.ToString(sd["전화번호"]);
                    this.txt휴대전화.Text = Convert.ToString(sd["휴대폰"]);

                    int소속팀정보ID = Convert.ToInt32(sd["소속팀정보ID"]);
                    str소속팀명 = Convert.ToString(sd["소속팀명"]);
                }
                sd.Close();
                sql = "select 본부설정ID from tb_소속팀정보 where 소속팀정보ID=" + int소속팀정보ID + "" + System.Environment.NewLine;
                sd = this._SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                foreach (DataRow row in dt.Rows)
                {
                    this.cbo본부.SelectedItem = row["본부설정ID"];
                    this.cbo소속팀.SelectedItem = str소속팀명;
                }
                sd.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl저장_Click(object sender, EventArgs e)
        {
            this.saveData사용자정보();
            this.saveData사용자공유범위();

            getConfig.getData사용자환경설정(this._SQLServer, this._userInfo);
        }
        private void saveData사용자공유범위()
        {
            userInfo userinfo = userInfo.Instance();
            userinfo.사용자ID = this.txt사용자ID.Text.Trim();
            userinfo.사용자정보ID = this._int사용자정보ID;

            getConfig.saveData사용자공유범위(this._SQLServer, userinfo, "입출금리스트", this.chk입출금리스트.Checked == true ? "1" : "0");
            getConfig.saveData사용자공유범위(this._SQLServer, userinfo, "간편메모장관리", this.chk간편메모장관리.Checked == true ? "1" : "0");
            getConfig.saveData사용자공유범위(this._SQLServer, userinfo, "일정관리", this.chk일정관리.Checked == true ? "1" : "0");

            getConfig.saveData사용자공유범위(this._SQLServer, userinfo, "단체일정관리", this.chk단체일정관리.Checked == true ? "1" : "0");
            getConfig.saveData사용자공유범위(this._SQLServer, userinfo, "은행통장및카드관리", this.chk은행통장및카드관리.Checked == true ? "1" : "0");

            getConfig.saveData사용자공유범위(this._SQLServer, userinfo, "등록고객통계보기", this.chk등록고객통계보기.Checked == true ? "1" : "0");
            getConfig.saveData사용자공유범위(this._SQLServer, userinfo, "업무일지보기", this.chk업무일지보기.Checked == true ? "1" : "0");
            getConfig.saveData사용자공유범위(this._SQLServer, userinfo, "본인업무일지만보기", this.chk본인업무일지만보기.Checked == true ? "1" : "0");
        }
        private void saveData사용자정보()
        {
            try
            {
                if (this.txt사용자ID.Text.Trim() == "")
                {
                    MessageBox.Show("사용하실 ID를 입력하시기 바랍니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (this.txt비밀번호.Text.Trim() == "")
                {
                    MessageBox.Show("사용하실 비밀번호를 입력하시기 바랍니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (this.txt이름.Text.Trim() == "")
                {
                    MessageBox.Show("사용자의 이름을 입력하시기 바랍니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("저장하시겠습니까?", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;

                string sql = "";
                if (this._int사용자정보ID == 0)
                {
                    sql += "insert into tb_사용자정보(" + System.Environment.NewLine;
                    sql += "       [사용자ID], [이름], [비밀번호], [내선], [권한], " + System.Environment.NewLine;
                    sql += "       [소속팀정보ID], [전화번호], [휴대폰], [엑셀업로드], [엑셀다운로드], " + System.Environment.NewLine;
                    sql += "       [자료삭제], [담당자변경], [자료검색], [검색범위사용자정보ID])" + System.Environment.NewLine;
                    sql += "values (" + System.Environment.NewLine;
                    sql += "       @사용자ID, @이름, @비밀번호, @내선, @권한, " + System.Environment.NewLine;
                    sql += "       @소속팀정보ID, @전화번호, @휴대폰, @엑셀업로드, @엑셀다운로드, " + System.Environment.NewLine;
                    sql += "       @자료삭제, @담당자변경, @자료검색, @검색범위사용자정보ID)" + System.Environment.NewLine;
                    sql += "select convert(int,scope_identity())" + System.Environment.NewLine;
                }
                else
                {
                    sql += "update tb_사용자정보 set" + System.Environment.NewLine;
                    sql += "       [사용자ID]=@사용자ID, [이름]=@이름, [비밀번호]=@비밀번호, [내선]=@내선, [권한]=@권한, " + System.Environment.NewLine;
                    sql += "       [소속팀정보ID]=@소속팀정보ID, [전화번호]=@전화번호, [휴대폰]=@휴대폰, [엑셀업로드]=@엑셀업로드, [엑셀다운로드]=@엑셀다운로드, " + System.Environment.NewLine;
                    sql += "       [자료삭제]=@자료삭제, [담당자변경]=@담당자변경, [자료검색]=@자료검색, [검색범위사용자정보ID]=@검색범위사용자정보ID " + System.Environment.NewLine;
                    sql += "where  사용자정보ID=@사용자정보ID" + System.Environment.NewLine;
                }
                this._SQLServer.paraClear();
                this._SQLServer.addPara("사용자ID", this.txt사용자ID.Text.Trim(), SqlDbType.NVarChar);
                this._SQLServer.addPara("이름", this.txt이름.Text.Trim(), SqlDbType.NVarChar);
                this._SQLServer.addPara("비밀번호", this.txt비밀번호.Text.Trim(), SqlDbType.NVarChar);
                this._SQLServer.addPara("내선", this.txt내선.Text.Trim(), SqlDbType.NVarChar);
                this._SQLServer.addPara("권한", this.chk관리자권한.Checked == true ? 1 : 0, SqlDbType.TinyInt);

                int int소속팀정보ID = Convert.ToString(this.cbo소속팀.SelectedItem) == "" ? 0 : getData소속팀정보ID(Convert.ToInt32(this.cbo본부.SelectedItem), Convert.ToString(this.cbo소속팀.SelectedItem));
                this._SQLServer.addPara("소속팀정보ID", int소속팀정보ID, SqlDbType.Int);
                this._SQLServer.addPara("전화번호", this.txt전화번호.Text.Trim(), SqlDbType.NVarChar);
                this._SQLServer.addPara("휴대폰", this.txt휴대전화.Text.Trim(), SqlDbType.NVarChar);
                this._SQLServer.addPara("엑셀업로드", this.chk엑셀업로드.Checked == true ? 1 : 0, SqlDbType.TinyInt);
                this._SQLServer.addPara("엑셀다운로드", this.chk엑셀다운로드.Checked == true ? 1 : 0, SqlDbType.TinyInt);

                this._SQLServer.addPara("자료삭제", this.chk자료삭제.Checked == true ? 1 : 0, SqlDbType.TinyInt);
                this._SQLServer.addPara("담당자변경", this.chk담당자변경.Checked == true ? 1 : 0, SqlDbType.TinyInt);

                int int자료검색 = 0;
                if (this.opt자료검색2.Checked == true)
                    int자료검색 = 1;
                else if (this.opt자료검색3.Checked == true)
                    int자료검색 = 2;
                else if (this.opt자료검색4.Checked == true)
                    int자료검색 = 3;
                else if (this.opt자료검색5.Checked == true)
                    int자료검색 = 4;

                this._SQLServer.addPara("자료검색", int자료검색, SqlDbType.TinyInt);
                this._SQLServer.addPara("검색범위사용자정보ID", this.cbo자료검색범위.SelectedItem == null ? 0 : this.cbo자료검색범위.SelectedItem, SqlDbType.Int);

                this._int사용자정보ID = this._SQLServer.Command_SQL(sql, "사용자정보ID", this._int사용자정보ID);
                if (this._int사용자정보ID > 0)
                    this.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private int getData소속팀정보ID(int 본부정보ID, string 소속팀명)
        {
            try
            {
                int int소속팀정보ID = 0;
                string sql = "";
                sql += "select 소속팀정보ID" + System.Environment.NewLine;
                sql += "from   tb_소속팀정보" + System.Environment.NewLine;
                sql += "where  본부설정ID=" + 본부정보ID + "" + System.Environment.NewLine;
                sql += "and    소속팀명='" + 소속팀명 + "'" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    int소속팀정보ID = Convert.ToInt32(sd["소속팀정보ID"]);
                }
                sd.Close();
                return int소속팀정보ID;
            }
            catch (Exception ex)
            {
            }
            return 0;
        }
        private void txt비밀번호_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabMain.SelectedIndex == 0)
                this.viewData사용자정보();
            else if (this.tabMain.SelectedIndex == 1)
                this.settingData사용자공유범위();
        }
        private void settingData사용자공유범위()
        {
            string str입출금리스트 = getConfig.getData사용자공유범위(this._SQLServer, this._userInfo.사용자정보ID, "입출금리스트");
            string str간편메모장관리 = getConfig.getData사용자공유범위(this._SQLServer, this._userInfo.사용자정보ID, "간편메모장관리");
            string str일정관리 = getConfig.getData사용자공유범위(this._SQLServer, this._userInfo.사용자정보ID, "일정관리");

            string str단체일정관리 = getConfig.getData사용자공유범위(this._SQLServer, this._userInfo.사용자정보ID, "단체일정관리");
            string str은행통장및카드관리 = getConfig.getData사용자공유범위(this._SQLServer, this._userInfo.사용자정보ID, "은행통장및카드관리");

            string str등록고객통계보기 = getConfig.getData사용자공유범위(this._SQLServer, this._userInfo.사용자정보ID, "등록고객통계보기");
            string str업무일지보기 = getConfig.getData사용자공유범위(this._SQLServer, this._userInfo.사용자정보ID, "업무일지보기");
            string str본인업무일지만보기 = getConfig.getData사용자공유범위(this._SQLServer, this._userInfo.사용자정보ID, "본인업무일지만보기");

            this.chk입출금리스트.Checked = Convert.ToInt32(str입출금리스트 == "" ? "0" : str입출금리스트) == 1 ? true : false;
            this.chk간편메모장관리.Checked = Convert.ToInt32(str간편메모장관리 == "" ? "0" : str간편메모장관리) == 1 ? true : false;
            this.chk일정관리.Checked = Convert.ToInt32(str일정관리 == "" ? "0" : str일정관리) == 1 ? true : false;

            this.chk단체일정관리.Checked = Convert.ToInt32(str단체일정관리 == "" ? "0" : str단체일정관리) == 1 ? true : false;
            this.chk은행통장및카드관리.Checked = Convert.ToInt32(str은행통장및카드관리 == "" ? "0" : str은행통장및카드관리) == 1 ? true : false;

            this.chk등록고객통계보기.Checked = Convert.ToInt32(str등록고객통계보기 == "" ? "0" : str등록고객통계보기) == 1 ? true : false;
            this.chk업무일지보기.Checked = Convert.ToInt32(str업무일지보기 == "" ? "0" : str업무일지보기) == 1 ? true : false;
            this.chk본인업무일지만보기.Checked = Convert.ToInt32(str본인업무일지만보기 == "" ? "0" : str본인업무일지만보기) == 1 ? true : false;
        }

        private void lbl소속팀설정_Click(object sender, EventArgs e)
        {
            //if (this._userInfo.권한 == 0)
            //{
            //    MessageBox.Show("해당 기능은 권한이 없습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //frm소속팀설정 f소속팀설정 = new frm소속팀설정();
            //f소속팀설정.ShowDialog();
        }

        private void cbo본부_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                sql += "select 소속팀정보ID, 소속팀명" + System.Environment.NewLine;
                sql += "from   tb_소속팀정보" + System.Environment.NewLine;
                sql += "where  본부설정ID=" + this.cbo본부.SelectedItem + "" + System.Environment.NewLine;
                sql += "order by isnull(순서,0)" + System.Environment.NewLine;

                SqlDataReader sd = _SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                this.cbo소속팀.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    this.cbo소속팀.Items.Add(row["소속팀명"]);
                }
                if (this.cbo소속팀.Items.Count > 0)
                    this.cbo소속팀.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
            }
        }
    }
}
