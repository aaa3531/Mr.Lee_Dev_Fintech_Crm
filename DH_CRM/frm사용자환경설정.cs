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
using System.IO;
using C1.Win.C1FlexGrid;

namespace DH_CRM
{
    public partial class frm사용자환경설정 : Form
    {
        private SQLServer _SQLServer;
        private userInfo _userInfo;

        private bool IsMouseMoveStart;
        private Point mousePoint;

        private int _int대분류ID;
        private int _int소분류ID;

        private int _int가입반설정ID;
        private int _int카드사항목설정ID;
        private int _intPG사항목설정ID;
        private int _int유입경로설정ID;

        private string _str엑셀경로;
        public frm사용자환경설정()
        {
            InitializeComponent();
            this._SQLServer = SQLServer.Instance();
            this._userInfo = userInfo.Instance();

            this.lblTopBar.MouseDown += this.Form_MouseDown;
            this.lblTopBar.MouseMove += this.Form_MouseMove;
            this.lblTopBar.MouseUp += this.Form_MouseUp;

            this.lblTopBar.Parent = this.picMain;
            this.lblClose.Parent = this.picMain;

            //2021-01-27 임권호
            this.lbl추가.Parent = this.pictureBox3;
            this.lbl수정.Parent = this.pictureBox3;
            this.lbl삭제.Parent = this.pictureBox3;
            this.lbl추가1.Parent = this.pictureBox3;
            this.lbl수정1.Parent = this.pictureBox3;
            this.lbl삭제1.Parent = this.pictureBox3;
            this.lbl추가2.Parent = this.pictureBox3;
            this.lbl수정2.Parent = this.pictureBox3;
            this.lbl삭제2.Parent = this.pictureBox3;

            this.lbl추가3.Parent = this.pictureBox4;
            this.lbl수정3.Parent = this.pictureBox4;
            this.lbl삭제3.Parent = this.pictureBox4;
            this.lbl추가5.Parent = this.pictureBox4;
            this.lbl수정5.Parent = this.pictureBox4;
            this.lbl삭제5.Parent = this.pictureBox4;
            this.lbl추가6.Parent = this.pictureBox4;
            this.lbl수정6.Parent = this.pictureBox4;
            this.lbl삭제6.Parent = this.pictureBox4;

            this.lblExcel.Parent = this.pictureBox2;

            this.lblColor1.Click += this.lblColor_Click;
            this.lblColor2.Click += this.lblColor_Click;
            this.lblColor3.Click += this.lblColor_Click;
            this.lblColor4.Click += this.lblColor_Click;
            this.lblColor5.Click += this.lblColor_Click;
            this.lblColor6.Click += this.lblColor_Click;
            this.lblColor7.Click += this.lblColor_Click;
            this.lblColor8.Click += this.lblColor_Click;
            this.lblColor9.Click += this.lblColor_Click;
            this.lblColor10.Click += this.lblColor_Click;
        }
        private void lblColor_Click(object sender, EventArgs e)
        {
            Label lblControl = sender as Label;
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
                lblControl.BackColor = this.colorDialog1.Color;
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
        private void settingComboBoxData()
        {
            this.cbo고객리스트.Items.Add("전체");
            this.cbo고객리스트.Items.Add("50");
            this.cbo고객리스트.Items.Add("100");
            this.cbo고객리스트.Items.Add("200");
            this.cbo고객리스트.Items.Add("300");
            this.cbo고객리스트.Items.Add("400");
            this.cbo고객리스트.SelectedIndex = 0;

            for (int i = 8; i < 51; i++)
            {
                this.cbo크기.Items.Add(i);
            }
            this.cbo크기.SelectedIndex = 0;

            FontFamily[] fonts = FontFamily.Families;
            foreach (FontFamily font in fonts)
            {
                this.cbo폰트.Items.Add(font.Name);
            }
            this.cbo폰트.SelectedItem = "맑은 고딕";
        }
        private void frm사용자환경설정_Load(object sender, EventArgs e)
        {
            //2021-02-01 임권호
            this.settingComboBoxData();
            this.viewData사용자정보();
            this.settingData환경설정1();
            this.settingGrid사용자필드명();
        }
        private void settingGrid사용자필드명()
        {
            this.grdWork.Rows.Count = 1;
            this.grdWork.Cols.Count = 3;
            this.grdWork.Cols[0].Visible = false;
            this.grdWork[0, 1] = "내용";
            this.grdWork[0, 2] = "필드명";
            //this.grdWork.DataSource = null;
            this.settingData사용자필드명();
        }
        private void settingData사용자필드명()
        {
            try
            {
                string sql = "";
                sql += "select a.name, b.설정구분, b.환경설정  " + System.Environment.NewLine;
                sql += "from   syscolumns  a left join tb_환경설정 b" + System.Environment.NewLine;
                sql += "on a.name=b.설정구분" + System.Environment.NewLine;
                sql += "and b.사용자정보id=" + this._userInfo.사용자정보ID + "" + System.Environment.NewLine;
                sql += "where  id=object_id('TB_고객등록')" + System.Environment.NewLine;
                sql += "and b.사용자정보ID is not null" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    if (Convert.ToString(sd["name"]) != "고객등록ID")
                    {
                        this.grdWork.Rows.Count++;
                        int maxRows = this.grdWork.Rows.Count - 1;
                        this.grdWork[maxRows, 1] = sd["name"];
                        this.grdWork[maxRows, 2] = sd["환경설정"];
                    }
                }
                sd.Close();

            }
            catch (Exception ex)
            {
            }
        }

        private void viewData사용자정보()
        {
            try
            {
                string sql = "";
                sql += "select * " + System.Environment.NewLine;
                sql += "from   tb_사용자정보" + System.Environment.NewLine;
                sql += "where  사용자정보ID=" + this._userInfo.사용자정보ID + "" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this.txt사용자이름.Text = sd["이름"].ToString();
                    this.txt이메일.Text = sd["이메일"].ToString();
                    this.txt휴대폰.Text = sd["휴대폰"].ToString();
                    this.txt전화번호.Text = sd["전화번호"].ToString();
                    this.txt주소.Text = sd["주소"].ToString();
                    this._str엑셀경로 = sd["엑셀경로"].ToString();
                }
                sd.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void lbl저장1_Click(object sender, EventArgs e)
        {
            if (this.tabMain.SelectedIndex == 0)
                this.saveData환경설정1();
            else if (this.tabMain.SelectedIndex == 1)
                this.saveData환경설정2();
            else
            {
                this.saveData환경설정3();
                this.saveData환경설정4();
            }

            this.updateData사용자정보();
            this.updateData사용자비밀번호();

            MessageBox.Show("저장이 완료되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }     
        private void updateData사용자비밀번호()
        {
            try
            {
                if (this.txt비밀번호.Text.Trim() == "" || this.txt비밀번호확인.Text.Trim() == "")
                    return;
                if (this.txt비밀번호.Text.Trim() != this.txt비밀번호확인.Text.Trim())
                {
                    MessageBox.Show("변경하실 비밀번호를 확인하시기 바랍니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string sql = "";
                sql += "update tb_사용자정보 set" + System.Environment.NewLine;
                sql += "       비밀번호='" + this.txt비밀번호.Text.Trim() + "'" + System.Environment.NewLine;
                sql += "where  사용자정보ID=" + this._userInfo.사용자정보ID + "" + System.Environment.NewLine;

                int result = this._SQLServer.Command_SQL(sql);
            }
            catch (Exception ex)
            {
            }
        }
        private void updateData사용자정보()
        {
            try
            {
                string sql = "";
                sql += "update tb_사용자정보 set" + System.Environment.NewLine;
                sql += "       이름='" + this.txt사용자이름.Text.Trim() + "'," + System.Environment.NewLine;
                sql += "       휴대폰='" + this.txt휴대폰.Text.Trim() + "', " + System.Environment.NewLine;
                sql += "       이메일='" + this.txt이메일.Text.Trim() + "', " + System.Environment.NewLine;
                sql += "       전화번호='" + this.txt전화번호.Text.Trim() + "', " + System.Environment.NewLine;
                sql += "       주소='" + this.txt주소.Text.Trim() + "' " + System.Environment.NewLine;
                sql += "where  사용자정보ID=" + this._userInfo.사용자정보ID + "" + System.Environment.NewLine;

                int result = this._SQLServer.Command_SQL(sql);
            }
            catch (Exception ex)
            {
            }
        }
        private void saveData환경설정1()
        {
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "고객리스트", this.cbo고객리스트.SelectedItem.ToString());
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "프로그램시작시패스워드묻기", this.chk프로그램시작.Checked ? "1" : "0");
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "환경설정시패스워드묻기", this.chk환경설정.Checked ? "1" : "0");
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "프로그램자동실행", this.chk윈도우시작.Checked ? "1" : "0");
        }

        private void saveData환경설정2()
        {
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "폰트속성", this.cbo폰트.SelectedItem.ToString());
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "폰트크기", this.cbo크기.SelectedItem.ToString());
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "전화번호자리맞춤", this.chk전화번호.Checked ? "1" : "0");
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "폰트굵게", this.chk굵게.Checked ? "1" : "0");
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "신규등록현재위치에", this.opt신규등록위치1.Checked ? "1" : "0");
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "신규등록맨뒷부분에", this.opt신규등록위치2.Checked ? "1" : "0");
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "화면위치왼쪽상단", this.opt자료화면위치1.Checked ? "1" : "0");
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "화면위치오른쪽상단", this.opt자료화면위치2.Checked ? "1" : "0");
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "화면위치중앙", this.opt자료화면위치3.Checked ? "1" : "0");
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "정렬후등록순서유지", this.chk등록순서.Checked ? "1" : "0");

            Color color;
            string str = "";
            color = this.lblColor1.BackColor;
            str = color.R + "," + color.G + "," + color.B;
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "1문자색", str);

            color = this.lblColor2.BackColor;
            str = color.R + "," + color.G + "," + color.B;
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "1배경색", str);

            color = this.lblColor3.BackColor;
            str = color.R + "," + color.G + "," + color.B;
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "2문자색", str);

            color = this.lblColor4.BackColor;
            str = color.R + "," + color.G + "," + color.B;
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "2배경색", str);

            color = this.lblColor5.BackColor;
            str = color.R + "," + color.G + "," + color.B;
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "3문자색", str);

            color = this.lblColor6.BackColor;
            str = color.R + "," + color.G + "," + color.B;
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "3배경색", str);

            color = this.lblColor7.BackColor;
            str = color.R + "," + color.G + "," + color.B;
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "4문자색", str);

            color = this.lblColor8.BackColor;
            str = color.R + "," + color.G + "," + color.B;
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "4배경색", str);

            color = this.lblColor9.BackColor;
            str = color.R + "," + color.G + "," + color.B;
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "5문자색", str);

            color = this.lblColor10.BackColor;
            str = color.R + "," + color.G + "," + color.B;
            getConfig.saveData환경설정(this._SQLServer, this._userInfo, "5배경색", str);

            this.updateData엑셀경로();
        }
        private void updateData엑셀경로()
        {
            try
            {
                string sql = "";
                sql += "update tb_사용자정보 set 엑셀경로='" + this.txt엑셀경로.Text.Trim() + "'" + System.Environment.NewLine;
                sql += "where  사용자정보ID=" + this._userInfo.사용자정보ID + "" + System.Environment.NewLine;

                this._SQLServer.Command_SQL(sql);

                string folderPath = this.txt엑셀경로.Text.Trim();
                DirectoryInfo di = new DirectoryInfo(folderPath);
                if (!di.Exists)
                    di.Create();

                this._userInfo.엑셀경로 = this.txt엑셀경로.Text.Trim();
            }
            catch (Exception ex)
            {
            }
        }
        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabMain.SelectedIndex == 0)
                this.settingData환경설정1();
            else if (this.tabMain.SelectedIndex == 1)
                this.settingData환경설정2();
            else if (this.tabMain.SelectedIndex == 2)
                this.settingData환경설정3();
            else if (this.tabMain.SelectedIndex == 3)
                this.settingData환경설정4();
        }
        private void settingData환경설정1()
        {
            try
            {
                string str = "";
                str = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "고객리스트");
                if (str != "")
                    this.cbo고객리스트.SelectedItem = str;

                str = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "프로그램시작시패스워드묻기");
                if (str == "1")
                    this.chk프로그램시작.Checked = true;

                str = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "환경설정시패스워드묻기");
                if (str == "1")
                    this.chk환경설정.Checked = true;

            }
            catch (Exception ex)
            {
            }
        }
        private void settingData환경설정2()
        {
            string[] array;
            int intR = 0;
            int intG = 0;
            int intB = 0;
            string strTemp = "";
            Color color;

            strTemp = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "1문자색");
            if (strTemp == "")
            {
                color = Color.Black;
                this.lblColor1.BackColor = color;
            }
            else
            {
                array = strTemp.Split(',');
                intR = Convert.ToInt32(array[0]);
                intG = Convert.ToInt32(array[1]);
                intB = Convert.ToInt32(array[2]);

                this.lblColor1.BackColor = Color.FromArgb(intR, intG, intB);
            }

            strTemp = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "2문자색");
            if (strTemp == "")
            {
                color = Color.Black;
                this.lblColor3.BackColor = color;
            }
            else
            {
                array = strTemp.Split(',');
                intR = Convert.ToInt32(array[0]);
                intG = Convert.ToInt32(array[1]);
                intB = Convert.ToInt32(array[2]);

                this.lblColor3.BackColor = Color.FromArgb(intR, intG, intB);
            }

            strTemp = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "3문자색");
            if (strTemp == "")
            {
                color = Color.Black;
                this.lblColor5.BackColor = color;
            }
            else
            {
                array = strTemp.Split(',');
                intR = Convert.ToInt32(array[0]);
                intG = Convert.ToInt32(array[1]);
                intB = Convert.ToInt32(array[2]);

                this.lblColor5.BackColor = Color.FromArgb(intR, intG, intB);
            }

            strTemp = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "4문자색");
            if (strTemp == "")
            {
                color = Color.Black;
                this.lblColor7.BackColor = color;
            }
            else
            {
                array = strTemp.Split(',');
                intR = Convert.ToInt32(array[0]);
                intG = Convert.ToInt32(array[1]);
                intB = Convert.ToInt32(array[2]);

                this.lblColor7.BackColor = Color.FromArgb(intR, intG, intB);
            }

            strTemp = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "5문자색");
            if (strTemp == "")
            {
                color = Color.Black;
                this.lblColor9.BackColor = color;
            }
            else
            {
                array = strTemp.Split(',');
                intR = Convert.ToInt32(array[0]);
                intG = Convert.ToInt32(array[1]);
                intB = Convert.ToInt32(array[2]);

                this.lblColor9.BackColor = Color.FromArgb(intR, intG, intB);
            }

            strTemp = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "1배경색");
            if (strTemp == "")
            {
                color = Color.Black;
                this.lblColor2.BackColor = color;
            }
            else
            {
                array = strTemp.Split(',');
                intR = Convert.ToInt32(array[0]);
                intG = Convert.ToInt32(array[1]);
                intB = Convert.ToInt32(array[2]);

                this.lblColor2.BackColor = Color.FromArgb(intR, intG, intB);
            }

            strTemp = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "2배경색");
            if (strTemp == "")
            {
                color = Color.Black;
                this.lblColor4.BackColor = color;
            }
            else
            {
                array = strTemp.Split(',');
                intR = Convert.ToInt32(array[0]);
                intG = Convert.ToInt32(array[1]);
                intB = Convert.ToInt32(array[2]);

                this.lblColor4.BackColor = Color.FromArgb(intR, intG, intB);
            }

            strTemp = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "3배경색");
            if (strTemp == "")
            {
                color = Color.Black;
                this.lblColor6.BackColor = color;
            }
            else
            {
                array = strTemp.Split(',');
                intR = Convert.ToInt32(array[0]);
                intG = Convert.ToInt32(array[1]);
                intB = Convert.ToInt32(array[2]);

                this.lblColor6.BackColor = Color.FromArgb(intR, intG, intB);
            }

            strTemp = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "4배경색");
            if (strTemp == "")
            {
                color = Color.Black;
                this.lblColor8.BackColor = color;
            }
            else
            {
                array = strTemp.Split(',');
                intR = Convert.ToInt32(array[0]);
                intG = Convert.ToInt32(array[1]);
                intB = Convert.ToInt32(array[2]);

                this.lblColor8.BackColor = Color.FromArgb(intR, intG, intB);
            }

            strTemp = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "5배경색");
            if (strTemp == "")
            {
                color = Color.Black;
                this.lblColor10.BackColor = color;
            }
            else
            {
                array = strTemp.Split(',');
                intR = Convert.ToInt32(array[0]);
                intG = Convert.ToInt32(array[1]);
                intB = Convert.ToInt32(array[2]);

                this.lblColor10.BackColor = Color.FromArgb(intR, intG, intB);
            }
            //2021-02-01 임권호
            this.txt엑셀경로.Text = this._str엑셀경로;
            this.cbo폰트.SelectedItem = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "폰트속성");
            if (this.cbo폰트.SelectedItem == null)
                this.cbo폰트.SelectedItem = "맑은 고딕";
            this.cbo크기.SelectedItem = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "폰트크기");
            if (this.cbo크기.SelectedItem == null)
                this.cbo크기.SelectedItem = 10;

            string str신규등록위치1 = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "신규등록현재위치에");
            if (str신규등록위치1 == "1")
                this.opt신규등록위치1.Checked = true;
            string str신규등록위치2 = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "신규등록맨뒷부분에");
            if (str신규등록위치2 == "1")
                this.opt신규등록위치2.Checked = true;

            string str화면위치1 = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "화면위치왼쪽상단");
            string str화면위치2 = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "화면위치오른쪽상단");
            string str화면위치3 = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "화면위치중앙");

            if (str화면위치1 == "1")
                this.opt자료화면위치1.Checked = true;

            if (str화면위치2 == "1")
                this.opt자료화면위치2.Checked = true;

            if (str화면위치3 == "1")
                this.opt자료화면위치3.Checked = true;

            string str전화번호자리맞춤 = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "전화번호자리맞춤");
            if (str전화번호자리맞춤 == "1")
                this.chk전화번호.Checked = true;
        }
        private void settingData환경설정3()
        {
            this.settingGrid사용자필드명();
            this.settingData대분류정보();
            this.settingData소분류정보();
            this.settingData유입경로설정();
        }
        private void settingData환경설정4()
        {
            this.settingData가입반정보();
            this.settingData카드사항목설정();
            this.settingDataPG사항목설정();
        }
        private void settingData대분류정보()
        {
            try
            {
                this.grdList1.Rows.Count = 1;
                this.grdList1.Cols.Count = 4;
                this.grdList1[0, 2] = "대분류";
                this.grdList1.Cols[0].Visible = false;
                this.grdList1.Cols[1].Visible = false;
                this.grdList1.Cols[3].Visible = false;

                string sql = "";
                sql += "select 대분류ID, 대분류, 순서=isnull(순서,0) " + System.Environment.NewLine;
                sql += "from   tb_대분류" + System.Environment.NewLine;
                sql += "order by isnull(순서,0)" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this.grdList1.Rows.Count++;
                    int maxRows = this.grdList1.Rows.Count - 1;
                    this.grdList1[maxRows, 1] = sd["대분류ID"];
                    this.grdList1[maxRows, 2] = sd["대분류"];
                    this.grdList1[maxRows, 3] = sd["순서"];
                }
                sd.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private void settingData소분류정보()
        {
            try
            {
                //2021-02-19 임권호
                this.grdList2.Rows.Count = 1;
                this.grdList2.Cols.Count = 4;
                this.grdList2[0, 2] = "소분류";
                this.grdList2.Cols[0].Visible = false;
                this.grdList2.Cols[1].Visible = false;
                this.grdList2.Cols[3].Visible = false;

                string sql = "";
                sql += "select 소분류ID, 소분류, 순서=isnull(순서,0) " + System.Environment.NewLine;
                sql += "from   tb_소분류" + System.Environment.NewLine;
                sql += "order by isnull(순서,0)" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this.grdList2.Rows.Count++;
                    int maxRows = this.grdList2.Rows.Count - 1;
                    this.grdList2[maxRows, 1] = sd["소분류ID"];
                    this.grdList2[maxRows, 2] = sd["소분류"];
                    this.grdList2[maxRows, 3] = sd["순서"];
                }
                sd.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private void grdList1_DoubleClick(object sender, EventArgs e)
        {
            int row = this.grdList1.MouseRow;
            if (row < 1)
                return;
            this._int대분류ID = Convert.ToInt32(this.grdList1[row, 1]);
            this.txt대분류.Text = Convert.ToString(grdList1[row, 2]);
        }
        private void saveData환경설정3()
        {
            //2021-02-19 임권호
            if (this._userInfo.권한 == 0)
            {
                MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            for (int i = 1; i < this.grdWork.Rows.Count; i++)
            {
                string str설정구분 = Convert.ToString(this.grdWork[i, 1]);
                string str환경설정 = Convert.ToString(this.grdWork[i, 2]);

                getConfig.saveData환경설정(this._SQLServer, this._userInfo, str설정구분, str환경설정 == "" ? Convert.ToString(this.grdWork[i, 1]) : str환경설정);
            }
            for (int i = 1; i < this.grdList.Rows.Count; i++)
            {
                int int유입경로ID = Convert.ToInt32(this.grdList[i, 1]);
                string sql = "";
                sql += "update tb_유입경로설정 set 순서=" + i + "" + System.Environment.NewLine;
                sql += "where  유입경로설정ID=" + int유입경로ID + "" + System.Environment.NewLine;

                this._SQLServer.Command_SQL(sql);
            }
            for (int i = 1; i < this.grdList1.Rows.Count; i++)
            {
                int int대분류ID = Convert.ToInt32(this.grdList1[i, 1]);
                string sql = "";
                sql += "update tb_대분류 set 순서= " + i + "" + System.Environment.NewLine;
                sql += "where 대분류ID =" + int대분류ID + "" + System.Environment.NewLine;

                this._SQLServer.Command_SQL(sql);
            }
            for (int i = 1; i < this.grdList2.Rows.Count; i++)
            {
                int int소분류ID = Convert.ToInt32(this.grdList2[i, 1]);
                string sql = "";
                sql += "update tb_소분류 set 순서=" + i + "" + System.Environment.NewLine;
                sql += "where 소분류ID =" + int소분류ID + "" + System.Environment.NewLine;

                this._SQLServer.Command_SQL(sql);
            }
        }

        private void saveData환경설정4()
        {

            //2021-02-19 임권호
            if (this._userInfo.권한 == 0)
            {
                MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            for (int i = 1; i < this.grdList4.Rows.Count; i++)
            {
                int int가입반설정ID = Convert.ToInt32(this.grdList4[i, 1]);
                string sql = "";
                sql += "update tb_가입반설정 set 순서=" + i + "" + System.Environment.NewLine;
                sql += "where  가입반설정ID=" + int가입반설정ID + "" + System.Environment.NewLine;

                this._SQLServer.Command_SQL(sql);
            }
            for (int i = 1; i < this.grdList5.Rows.Count; i++)
            {
                int int카드사항목설정ID = Convert.ToInt32(this.grdList5[i, 1]);
                string sql = "";
                sql += "update tb_카드사항목설정 set 순서=" + i + "" + System.Environment.NewLine;
                sql += "where  카드사항목설정ID=" + int카드사항목설정ID + "" + System.Environment.NewLine;

                this._SQLServer.Command_SQL(sql);
            }
            for (int i = 1; i < this.grdList6.Rows.Count; i++)
            {
                int intPG사항목설정ID = Convert.ToInt32(this.grdList6[i, 1]);
                string sql = "";
                sql += "update tb_PG사항목설정 set 순서= " + i + "" + System.Environment.NewLine;
                sql += "where PG사항목설정ID=" + intPG사항목설정ID + "" + System.Environment.NewLine;

                this._SQLServer.Command_SQL(sql);
            }
        }

        private void lbl추가1_Click(object sender, EventArgs e)
        {
            this.save대분류Data();
        }
        private void save대분류Data()
        {
            try
            {
                if (this._userInfo.권한 == 0)
                {
                    MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show("추가하시겠습니까?", "유입경로 대분류 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;

                string sql = "";
                sql += "insert into tb_대분류 ( " + System.Environment.NewLine;
                sql += "     대분류) " + System.Environment.NewLine;
                sql += "values ( " + System.Environment.NewLine;
                sql += "     @대분류) " + System.Environment.NewLine;
                sql += "select convert(int,scope_identity())" + System.Environment.NewLine;

                this._SQLServer.paraClear();
                this._SQLServer.addPara("대분류", this.txt대분류.Text, SqlDbType.NVarChar);
                this._SQLServer.Command_SQL(sql);

                this.settingData대분류정보();
            }
            catch (Exception ex)
            {
            }
        }

        private void lbl수정1_Click(object sender, EventArgs e)
        {
            this.update대분류Data();
        }
        private void update대분류Data()
        {
            try
            {
                if (this._userInfo.권한 == 0)
                {
                    MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("변경하시겠습니까?", "유입경로 대분류 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                string str정보 = this.txt대분류.Text.Trim();
                string sql = "";
                sql += "update tb_대분류 set 대분류 = '" + str정보 + "' " + System.Environment.NewLine;
                sql += "where 대분류ID = '" + this._int대분류ID + "' " + System.Environment.NewLine;

                int result = this._SQLServer.Command_SQL(sql);
                if (result > 0)
                {
                    MessageBox.Show("변환이 완료 되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.txt대분류.Clear();
                this.settingData대분류정보();
            }
            catch (Exception ex)
            {
            }
        }
        private void update소분류Data()
        {
            try
            {
                if (this._userInfo.권한 == 0)
                {
                    MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("변경하시겠습니까?", "유입경로 소분류 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                string str정보 = this.txt소분류.Text.Trim();
                string sql = "";
                sql += "update tb_소분류 set 소분류 = '" + str정보 + "' " + System.Environment.NewLine;
                sql += "where 소분류ID = '" + this._int소분류ID + "' " + System.Environment.NewLine;

                int result = this._SQLServer.Command_SQL(sql);
                if (result > 0)
                {
                    MessageBox.Show("변환이 완료 되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.txt소분류.Clear();
                this.settingData소분류정보();
            }
            catch (Exception ex)
            {
            }
        }
        private void lbl삭제1_Click(object sender, EventArgs e)
        {
            this.Delete대분류Data();
        }

        private void Delete대분류Data()
        {
            if (this._userInfo.권한 == 0)
            {
                MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("삭제하시겠습니까?", "유입경로 대분류 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string sql = "delete from tb_대분류 where 대분류ID=" + this._int대분류ID + "";
                int result = this._SQLServer.Command_SQL(sql);

                if (result > 0)
                {
                    this.txt대분류.Clear();
                    this.settingData대분류정보();
                }
            }
        }
        private void Delete소분류Data()
        {
            if (this._userInfo.권한 == 0)
            {
                MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("삭제하시겠습니까?", "유입경로 소분류 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string sql = "delete from tb_소분류 where 소분류ID=" + this._int소분류ID + "";
                int result = this._SQLServer.Command_SQL(sql);

                if (result > 0)
                {
                    this.txt소분류.Clear();
                    this.settingData소분류정보();
                }
            }
        }
        private void lbl추가2_Click(object sender, EventArgs e)
        {
            this.save소분류Data();
        }

        private void save소분류Data()
        {
            try
            {
                if (this._userInfo.권한 == 0)
                {
                    MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("추가하시겠습니까?", "소분류 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;

                string sql = "";
                sql += "insert into tb_소분류 ( " + System.Environment.NewLine;
                sql += "     소분류) " + System.Environment.NewLine;
                sql += "values ( " + System.Environment.NewLine;
                sql += "     @소분류) " + System.Environment.NewLine;
                sql += "select convert(int,scope_identity())" + System.Environment.NewLine;

                this._SQLServer.paraClear();
                this._SQLServer.addPara("소분류", this.txt소분류.Text, SqlDbType.NVarChar);

                int result = this._SQLServer.Command_SQL(sql);
                if (result > 0)
                {
                    this.txt소분류.Clear();
                    this.settingData소분류정보();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void lbl추가3_Click(object sender, EventArgs e)
        {
            this.insertData가입반정보();
        }
        private void insertData가입반정보()
        {
            if (this._userInfo.권한 == 0)
            {
                MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("추가하시겠습니까?", "가입반 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            string sql = "";
            sql += "insert into tb_가입반설정(" + System.Environment.NewLine;
            sql += "       [가입반])" + System.Environment.NewLine;
            sql += "values (" + System.Environment.NewLine;
            sql += "       @가입반)" + System.Environment.NewLine;

            this._SQLServer.paraClear();
            this._SQLServer.addPara("가입반", this.txt가입반설정.Text.Trim(), SqlDbType.NVarChar);

            this._SQLServer.Command_SQL(sql);
            this.txt가입반설정.Clear();
            this.settingData가입반정보();
        }

        private void lbl수정3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._userInfo.권한 == 0)
                {
                    MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("변경하시겠습니까?", "가입반 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                string str정보 = this.txt가입반설정.Text.Trim();
                string sql = "";
                sql += "update tb_가입반설정 set 가입반 = '" + str정보 + "' " + System.Environment.NewLine;
                sql += "where 가입반설정ID = '" + this._int가입반설정ID + "' " + System.Environment.NewLine;

                int result = this._SQLServer.Command_SQL(sql);
                if (result > 0)
                {
                    MessageBox.Show("변환이 완료 되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.txt가입반설정.Clear();
                this.settingData가입반정보();
            }
            catch (Exception ex)
            {
            }
        }
        private void deleteData가입반정보()
        {
            try
            {
                if (this._userInfo.권한 == 0)
                {
                    MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("삭제하시겠습니까?", "가입반 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                string sql = "";
                sql += "delete from tb_가입반설정 where 가입반설정ID=" + this._int가입반설정ID + " " + System.Environment.NewLine;
                this._SQLServer.Command_SQL(sql);
                this.txt가입반설정.Clear();
                this._int가입반설정ID = 0;
                this.settingData가입반정보();
            }
            catch (Exception ex)
            {
            }
        }
        private void settingData가입반정보()
        {
            try
            {
                //2021-02-19 임권호
                this.grdList4.Rows.Count = 1;
                this.grdList4.Cols.Count = 4;
                this.grdList4[0, 2] = "가입반";
                this.grdList4.Cols[0].Visible = false;
                this.grdList4.Cols[1].Visible = false;
                this.grdList4.Cols[3].Visible = false;

                string sql = "";
                sql += "select 가입반설정ID, 가입반, 순서=isnull(순서,0) " + System.Environment.NewLine;
                sql += "from   tb_가입반설정" + System.Environment.NewLine;
                sql += "order by isnull(순서,0)" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this.grdList4.Rows.Count++;
                    int maxRows = this.grdList4.Rows.Count - 1;
                    this.grdList4[maxRows, 1] = sd["가입반설정ID"];
                    this.grdList4[maxRows, 2] = sd["가입반"];
                    this.grdList4[maxRows, 3] = sd["순서"];
                }
                sd.Close();
               
            }
            catch (Exception ex)
            {
            }
        }

        private void lbl삭제3_Click(object sender, EventArgs e)
        {
            this.deleteData가입반정보();
        }

        private void grdList2_DoubleClick(object sender, EventArgs e)
        {
            int row = this.grdList2.MouseRow;
            if (row < 1)
                return;
            this._int소분류ID = Convert.ToInt32(this.grdList2[row, 1]);
            this.txt소분류.Text = Convert.ToString(this.grdList2[row, 2]);
        }

        private void lbl수정2_Click(object sender, EventArgs e)
        {
            this.update소분류Data();
        }

        private void lbl삭제2_Click(object sender, EventArgs e)
        {
            this.Delete소분류Data();
        }

        private void lblExcel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.txt엑셀경로.Text = fbd.SelectedPath;
            }
        }

        private void grdList4_DoubleClick(object sender, EventArgs e)
        {
            int row = this.grdList4.MouseRow;
            if (row < 1)
                return;
            this._int가입반설정ID = Convert.ToInt32(this.grdList4[row, 1]);
            this.txt가입반설정.Text = Convert.ToString(this.grdList4[row, 2]);
        }

        private void settingData카드사항목설정()
        {
            //2021-02-19 임권호
            this.grdList5.Rows.Count = 1;
            this.grdList5.Cols.Count = 4;
            this.grdList5[0, 2] = "카드사";
            this.grdList5.Cols[0].Visible = false;
            this.grdList5.Cols[1].Visible = false;
            this.grdList5.Cols[3].Visible = false;

            string sql = "";
            sql += "select 카드사항목설정ID, 내용, 순서=isnull(순서,0) " + System.Environment.NewLine;
            sql += "from   tb_카드사항목설정" + System.Environment.NewLine;
            sql += "order by isnull(순서,0)" + System.Environment.NewLine;

            SqlDataReader sd = this._SQLServer.GetDataReader(sql);
            while (sd.Read())
            {
                this.grdList5.Rows.Count++;
                int maxRows = this.grdList5.Rows.Count - 1;
                this.grdList5[maxRows, 1] = sd["카드사항목설정ID"];
                this.grdList5[maxRows, 2] = sd["내용"];
                this.grdList5[maxRows, 3] = sd["순서"];
            }
            sd.Close();
        }

        private void lbl추가5_Click(object sender, EventArgs e)
        {
            this.insertData카드사항목();
        }

        private void insertData카드사항목()
        {
            if (this._userInfo.권한 == 0)
            {
                MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("추가하시겠습니까?", "카드사항목 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            string sql = "";
            sql += "insert into tb_카드사항목설정(" + System.Environment.NewLine;
            sql += "       [내용])" + System.Environment.NewLine;
            sql += "values (" + System.Environment.NewLine;
            sql += "       @내용)" + System.Environment.NewLine;

            this._SQLServer.paraClear();
            this._SQLServer.addPara("내용", this.txt카드사항목설정.Text.Trim(), SqlDbType.NVarChar);

            this._SQLServer.Command_SQL(sql);
            this.txt카드사항목설정.Clear();
            this.settingData카드사항목설정();
        }

        private void grdList5_DoubleClick(object sender, EventArgs e)
        {
            int row = this.grdList5.MouseRow;
            if (row < 1)
                return;
            this._int카드사항목설정ID = Convert.ToInt32(this.grdList5[row, 1]);
            this.txt카드사항목설정.Text = Convert.ToString(this.grdList5[row, 2]);
        }

        private void lbl수정5_Click(object sender, EventArgs e)
        {
            if (this._userInfo.권한 == 0)
            {
                MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("변경하시겠습니까?", "카드사항목 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            string str정보 = this.txt카드사항목설정.Text.Trim();
            string sql = "";
            sql += "update tb_카드사항목설정 set 내용 = '" + str정보 + "' " + System.Environment.NewLine;
            sql += "where 카드사항목설정ID = '" + this._int카드사항목설정ID + "' " + System.Environment.NewLine;

            int result = this._SQLServer.Command_SQL(sql);
            if (result > 0)
            {
                MessageBox.Show("변환이 완료 되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.txt카드사항목설정.Clear();
            this.settingData카드사항목설정();
        }

        private void lbl삭제5_Click(object sender, EventArgs e)
        {
            this.deleteData카드사항목();
        }
        private void deleteData카드사항목()
        {
            try
            {
                if (this._userInfo.권한 == 0)
                {
                    MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("삭제하시겠습니까?", "카드사항목 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                string sql = "";
                sql += "delete from tb_카드사항목설정 where 카드사항목설정ID=" + this._int카드사항목설정ID + " " + System.Environment.NewLine;
                this._SQLServer.Command_SQL(sql);
                this.txt카드사항목설정.Clear();
                this._int카드사항목설정ID = 0;
                this.settingData카드사항목설정();
            }
            catch (Exception ex)
            {
            }
        }

        private void settingDataPG사항목설정()
        {
            try
            {
                //2021-02-19 임권호
                this.grdList6.Rows.Count = 1;
                this.grdList6.Cols.Count = 4;
                this.grdList6[0, 2] = "PG사항목";
                this.grdList6.Cols[0].Visible = false;
                this.grdList6.Cols[1].Visible = false;
                this.grdList6.Cols[3].Visible = false;

                string sql = "";
                sql += "select PG사항목설정ID, PG사항목, 순서=isnull(순서,0) " + System.Environment.NewLine;
                sql += "from   tb_PG사항목설정" + System.Environment.NewLine;
                sql += "order by isnull(순서,0)" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this.grdList6.Rows.Count++;
                    int maxRows = this.grdList6.Rows.Count - 1;
                    this.grdList6[maxRows, 1] = sd["PG사항목설정ID"];
                    this.grdList6[maxRows, 2] = sd["PG사항목"];
                    this.grdList6[maxRows, 3] = sd["순서"];
                }
                sd.Close();
            }
            catch (Exception ex) 
            {
            }
        }

        private void lbl추가6_Click(object sender, EventArgs e)
        {
            this.insertDataPG사항목();
        }

        private void insertDataPG사항목()
        {
            try
            {
                if (this._userInfo.권한 == 0)
                {
                    MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("추가하시겠습니까?", "PG사항목 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;

                string sql = "";
                sql += "insert into tb_PG사항목설정(" + System.Environment.NewLine;
                sql += "       [PG사항목])" + System.Environment.NewLine;
                sql += "values (" + System.Environment.NewLine;
                sql += "       @PG사항목)" + System.Environment.NewLine;

                this._SQLServer.paraClear();
                this._SQLServer.addPara("PG사항목", this.txtPG사항목설정.Text.Trim(), SqlDbType.NVarChar);

                this._SQLServer.Command_SQL(sql);
                this.txtPG사항목설정.Clear();
                this.settingDataPG사항목설정();
            }
            catch (Exception ex) 
            {
            }
        }

        private void lbl수정6_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._userInfo.권한 == 0)
                {
                    MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("변경하시겠습니까?", "PG사항목 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                string str정보 = this.txtPG사항목설정.Text.Trim();
                string sql = "";
                sql += "update tb_PG사항목설정 set PG사항목 = '" + str정보 + "' " + System.Environment.NewLine;
                sql += "where PG사항목설정ID = '" + this._intPG사항목설정ID + "' " + System.Environment.NewLine;

                int result = this._SQLServer.Command_SQL(sql);
                if (result > 0)
                {
                    MessageBox.Show("변환이 완료 되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.txtPG사항목설정.Clear();
                this.settingDataPG사항목설정();
            }
            catch (Exception ex)
            {
            }
        }

        

        private void lbl삭제6_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._userInfo.권한 == 0)
                {
                    MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("삭제하시겠습니까?", "PG사항목 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                string sql = "";
                sql += "delete from tb_PG사항목설정 where PG사항목설정ID=" + this._intPG사항목설정ID + " " + System.Environment.NewLine;
                this._SQLServer.Command_SQL(sql);
                this.txtPG사항목설정.Clear();
                this._intPG사항목설정ID = 0;
                this.settingDataPG사항목설정();
            }
            catch (Exception ex) 
            {
            }
        }

        private void settingData유입경로설정()
        {
            try
            {
                //2021-02-19 임권호
                this.grdList.Rows.Count = 1;
                this.grdList.Cols.Count = 4;
                this.grdList[0, 2] = "유입경로";
                this.grdList.Cols[0].Visible = false;
                this.grdList.Cols[1].Visible = false;
                this.grdList.Cols[3].Visible = false;

                string sql = "";
                sql += "select 유입경로설정ID, 유입경로, 순서=isnull(순서,0) " + System.Environment.NewLine;
                sql += "from   tb_유입경로설정" + System.Environment.NewLine;
                sql += "order by isnull(순서,0)" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this.grdList.Rows.Count++;
                    int maxRows = this.grdList.Rows.Count - 1;
                    this.grdList[maxRows, 1] = sd["유입경로설정ID"];
                    this.grdList[maxRows, 2] = sd["유입경로"];
                    this.grdList[maxRows, 3] = sd["순서"];
                }
                sd.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void lbl추가_Click(object sender, EventArgs e)
        {
            this.insertData유입경로();
        }

        private void insertData유입경로()
        {
            try
            {
                if (this._userInfo.권한 == 0)
                {
                    MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("추가하시겠습니까?", "유입경로 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;

                string sql = "";
                sql += "insert into tb_유입경로설정(" + System.Environment.NewLine;
                sql += "       [유입경로])" + System.Environment.NewLine;
                sql += "values (" + System.Environment.NewLine;
                sql += "       @유입경로)" + System.Environment.NewLine;

                this._SQLServer.paraClear();
                this._SQLServer.addPara("유입경로", this.txt유입경로.Text.Trim(), SqlDbType.NVarChar);

                this._SQLServer.Command_SQL(sql);
                this.txt유입경로.Clear();
                this.settingData유입경로설정();
            }
            catch (Exception ex)
            {
            }
        }

        private void grdList_DoubleClick(object sender, EventArgs e)
        {
            int row = this.grdList.MouseRow;
            if (row < 1)
                return;
            this._int유입경로설정ID = Convert.ToInt32(this.grdList[row, 1]);
            this.txt유입경로.Text = Convert.ToString(this.grdList[row, 2]);
        }

        private void lbl수정_Click(object sender, EventArgs e)
        {
            if (this._userInfo.권한 == 0)
            {
                MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("변경하시겠습니까?", "유입경로 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            string str정보 = this.txt유입경로.Text.Trim();
            string sql = "";
            sql += "update tb_유입경로설정 set 유입경로 = '" + str정보 + "' " + System.Environment.NewLine;
            sql += "where 유입경로설정ID = '" + this._int유입경로설정ID + "' " + System.Environment.NewLine;

            int result = this._SQLServer.Command_SQL(sql);
            if (result > 0)
            {
                MessageBox.Show("변환이 완료 되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.txt유입경로.Clear();
            this.settingData유입경로설정();
        }

        private void lbl삭제_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._userInfo.권한 == 0)
                {
                    MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("삭제하시겠습니까?", "유입경로 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                string sql = "";
                sql += "delete from tb_유입경로설정 where 유입경로설정ID=" + this._int유입경로설정ID + " " + System.Environment.NewLine;
                this._SQLServer.Command_SQL(sql);
                this.txt유입경로.Clear();
                this._int유입경로설정ID = 0;
                this.settingData유입경로설정();
            }
            catch (Exception ex)
            {
            }
        }
        private void grdList6_DoubleClick(object sender, EventArgs e)
        {
            int row = this.grdList6.MouseRow;
            if (row < 1)
                return;
            this._intPG사항목설정ID = Convert.ToInt32(this.grdList6[row, 1]);
            this.txtPG사항목설정.Text = Convert.ToString(this.grdList6[row, 2]);
        }
        //C1FlexGrid _src = null;
        private void grdList_BeforeMouseDown(object sender, BeforeMouseDownEventArgs e)
        {
            HitTestInfo hti = this.grdList.HitTest(e.X, e.Y);
            if (hti.Type == HitTestTypeEnum.Cell)
            {
                //select the row 
                int index = hti.Row;
                this.grdList.Select(index, 0, index, this.grdList.Cols.Count - 1, false);

                //save info for target
                //_src = this.grdList;

                //do drag drop
                DragDropEffects dd = this.grdList.DoDragDrop(this.grdList.Clip, DragDropEffects.Move);

                //if it worked, delete row from source (it's a move) 
                if (dd == DragDropEffects.Move)
                {
                    this.grdList.Rows.Remove(index);
                }

                //done, reset info
                //_src = null;

                this._int유입경로설정ID = Convert.ToInt32(this.grdList[hti.Row, 1]);
                this.txt유입경로.Text = Convert.ToString(this.grdList[hti.Row, 2]);
            }
        }

        private void grdList_DragDrop(object sender, DragEventArgs e)
        {
            C1FlexGrid flex = (C1FlexGrid)sender;
            Point pt = flex.PointToClient(new Point(e.X, e.Y));
            HitTestInfo hti = flex.HitTest(pt.X, pt.Y);

            //newindex - the index where the row is to be moved to
            //oldindex - the index from where the row was moved from
            int newindex = hti.Row;
            int oldindex = flex.RowSel;

            if (newindex < 0)
                newindex = flex.Rows.Count;

            if (newindex < 1)
                newindex = 1;

            C1.Win.C1FlexGrid.Row row = default(C1.Win.C1FlexGrid.Row);

            //going upwards
            if (oldindex > 1 & newindex < oldindex)
            {
                row = flex.Rows[oldindex];
            }

            //coming downwards
            if (newindex > oldindex & (oldindex + 1) < flex.Rows.Count)
            {
                row = flex.Rows[oldindex + 1];
            }

            // remove the row from the earlier position
            flex.Rows.Remove(oldindex);

            // if the row to be added is the last row
            if (newindex > flex.Rows.Count)
            {
                //insert a new row at the drop position
                flex.Rows.Insert(newindex - 1);

                //copy data from source row
                flex.Select(newindex - 1, 0, newindex - 1, flex.Cols.Count - 1, false);
                flex.Clip = Convert.ToString(e.Data.GetData(typeof(string)));
            }
            else
            {
                //insert a new row at the drop position
                flex.Rows.Insert(newindex);

                //copy data from source row
                flex.Select(newindex, 0, newindex, flex.Cols.Count - 1, false);
                flex.Clip = Convert.ToString(e.Data.GetData(typeof(string)));

            }

            flex.Rows.Insert(oldindex);
        }

        private void grdList_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void grdList1_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void grdList2_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void grdList1_DragDrop(object sender, DragEventArgs e)
        {
            C1FlexGrid flex = (C1FlexGrid)sender;
            Point pt = flex.PointToClient(new Point(e.X, e.Y));
            HitTestInfo hti = flex.HitTest(pt.X, pt.Y);

            //newindex - the index where the row is to be moved to
            //oldindex - the index from where the row was moved from
            int newindex = hti.Row;
            int oldindex = flex.RowSel;

            if (newindex < 0)
                newindex = flex.Rows.Count;

            if (newindex < 1)
                newindex = 1;

            C1.Win.C1FlexGrid.Row row = default(C1.Win.C1FlexGrid.Row);

            //going upwards
            if (oldindex > 1 & newindex < oldindex)
            {
                row = flex.Rows[oldindex];
            }

            //coming downwards
            if (newindex > oldindex & (oldindex + 1) < flex.Rows.Count)
            {
                row = flex.Rows[oldindex + 1];
            }

            // remove the row from the earlier position
            flex.Rows.Remove(oldindex);

            // if the row to be added is the last row
            if (newindex > flex.Rows.Count)
            {
                //insert a new row at the drop position
                flex.Rows.Insert(newindex - 1);

                //copy data from source row
                flex.Select(newindex - 1, 0, newindex - 1, flex.Cols.Count - 1, false);
                flex.Clip = Convert.ToString(e.Data.GetData(typeof(string)));
            }
            else
            {
                //insert a new row at the drop position
                flex.Rows.Insert(newindex);

                //copy data from source row
                flex.Select(newindex, 0, newindex, flex.Cols.Count - 1, false);
                flex.Clip = Convert.ToString(e.Data.GetData(typeof(string)));

            }

            flex.Rows.Insert(oldindex);
        }

        private void grdList2_DragDrop(object sender, DragEventArgs e)
        {
            C1FlexGrid flex = (C1FlexGrid)sender;
            Point pt = flex.PointToClient(new Point(e.X, e.Y));
            HitTestInfo hti = flex.HitTest(pt.X, pt.Y);

            //newindex - the index where the row is to be moved to
            //oldindex - the index from where the row was moved from
            int newindex = hti.Row;
            int oldindex = flex.RowSel;

            if (newindex < 0)
                newindex = flex.Rows.Count;

            if (newindex < 1)
                newindex = 1;

            C1.Win.C1FlexGrid.Row row = default(C1.Win.C1FlexGrid.Row);

            //going upwards
            if (oldindex > 1 & newindex < oldindex)
            {
                row = flex.Rows[oldindex];
            }

            //coming downwards
            if (newindex > oldindex & (oldindex + 1) < flex.Rows.Count)
            {
                row = flex.Rows[oldindex + 1];
            }

            // remove the row from the earlier position
            flex.Rows.Remove(oldindex);

            // if the row to be added is the last row
            if (newindex > flex.Rows.Count)
            {
                //insert a new row at the drop position
                flex.Rows.Insert(newindex - 1);

                //copy data from source row
                flex.Select(newindex - 1, 0, newindex - 1, flex.Cols.Count - 1, false);
                flex.Clip = Convert.ToString(e.Data.GetData(typeof(string)));
            }
            else
            {
                //insert a new row at the drop position
                flex.Rows.Insert(newindex);

                //copy data from source row
                flex.Select(newindex, 0, newindex, flex.Cols.Count - 1, false);
                flex.Clip = Convert.ToString(e.Data.GetData(typeof(string)));

            }

            flex.Rows.Insert(oldindex);
        }

        private void grdList1_BeforeMouseDown(object sender, BeforeMouseDownEventArgs e)
        {
            HitTestInfo hti = this.grdList1.HitTest(e.X, e.Y);
            if (hti.Type == HitTestTypeEnum.Cell)
            {
                //select the row 
                int index = hti.Row;
                this.grdList1.Select(index, 0, index, this.grdList1.Cols.Count - 1, false);

                //save info for target
                //_src = this.grdList1;

                //do drag drop
                DragDropEffects dd = this.grdList1.DoDragDrop(this.grdList1.Clip, DragDropEffects.Move);

                //if it worked, delete row from source (it's a move) 
                if (dd == DragDropEffects.Move)
                {
                    this.grdList1.Rows.Remove(index);
                }

                //done, reset info
                //_src = null;
                this._int대분류ID = Convert.ToInt32(this.grdList1[index, 1]);
                this.txt대분류.Text = Convert.ToString(grdList1[index, 2]);
            }
        }

        private void grdList2_BeforeMouseDown(object sender, BeforeMouseDownEventArgs e)
        {
            HitTestInfo hti = this.grdList2.HitTest(e.X, e.Y);
            if (hti.Type == HitTestTypeEnum.Cell)
            {
                //select the row 
                int index = hti.Row;
                this.grdList2.Select(index, 0, index, this.grdList2.Cols.Count - 1, false);

                //save info for target
                //_src = this.grdList2;

                //do drag drop
                DragDropEffects dd = this.grdList2.DoDragDrop(this.grdList2.Clip, DragDropEffects.Move);

                //if it worked, delete row from source (it's a move) 
                if (dd == DragDropEffects.Move)
                {
                    this.grdList2.Rows.Remove(index);
                }

                //done, reset info
                //_src = null;
                this._int소분류ID = Convert.ToInt32(this.grdList2[index, 1]);
                this.txt소분류.Text = Convert.ToString(this.grdList2[index, 2]);
            }
        }

        private void grdList4_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void grdList5_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void grdList6_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void grdList4_DragDrop(object sender, DragEventArgs e)
        {
            C1FlexGrid flex = (C1FlexGrid)sender;
            Point pt = flex.PointToClient(new Point(e.X, e.Y));
            HitTestInfo hti = flex.HitTest(pt.X, pt.Y);

            //newindex - the index where the row is to be moved to
            //oldindex - the index from where the row was moved from
            int newindex = hti.Row;
            int oldindex = flex.RowSel;

            if (newindex < 0)
                newindex = flex.Rows.Count;

            if (newindex < 1)
                newindex = 1;

            C1.Win.C1FlexGrid.Row row = default(C1.Win.C1FlexGrid.Row);

            //going upwards
            if (oldindex > 1 & newindex < oldindex)
            {
                row = flex.Rows[oldindex];
            }

            //coming downwards
            if (newindex > oldindex & (oldindex + 1) < flex.Rows.Count)
            {
                row = flex.Rows[oldindex + 1];
            }

            // remove the row from the earlier position
            flex.Rows.Remove(oldindex);

            // if the row to be added is the last row
            if (newindex > flex.Rows.Count)
            {
                //insert a new row at the drop position
                flex.Rows.Insert(newindex - 1);

                //copy data from source row
                flex.Select(newindex - 1, 0, newindex - 1, flex.Cols.Count - 1, false);
                flex.Clip = Convert.ToString(e.Data.GetData(typeof(string)));
            }
            else
            {
                //insert a new row at the drop position
                flex.Rows.Insert(newindex);

                //copy data from source row
                flex.Select(newindex, 0, newindex, flex.Cols.Count - 1, false);
                flex.Clip = Convert.ToString(e.Data.GetData(typeof(string)));

            }

            flex.Rows.Insert(oldindex);
        }

        private void grdList5_DragDrop(object sender, DragEventArgs e)
        {
            C1FlexGrid flex = (C1FlexGrid)sender;
            Point pt = flex.PointToClient(new Point(e.X, e.Y));
            HitTestInfo hti = flex.HitTest(pt.X, pt.Y);

            //newindex - the index where the row is to be moved to
            //oldindex - the index from where the row was moved from
            int newindex = hti.Row;
            int oldindex = flex.RowSel;

            if (newindex < 0)
                newindex = flex.Rows.Count;

            if (newindex < 1)
                newindex = 1;

            C1.Win.C1FlexGrid.Row row = default(C1.Win.C1FlexGrid.Row);

            //going upwards
            if (oldindex > 1 & newindex < oldindex)
            {
                row = flex.Rows[oldindex];
            }

            //coming downwards
            if (newindex > oldindex & (oldindex + 1) < flex.Rows.Count)
            {
                row = flex.Rows[oldindex + 1];
            }

            // remove the row from the earlier position
            flex.Rows.Remove(oldindex);

            // if the row to be added is the last row
            if (newindex > flex.Rows.Count)
            {
                //insert a new row at the drop position
                flex.Rows.Insert(newindex - 1);

                //copy data from source row
                flex.Select(newindex - 1, 0, newindex - 1, flex.Cols.Count - 1, false);
                flex.Clip = Convert.ToString(e.Data.GetData(typeof(string)));
            }
            else
            {
                //insert a new row at the drop position
                flex.Rows.Insert(newindex);

                //copy data from source row
                flex.Select(newindex, 0, newindex, flex.Cols.Count - 1, false);
                flex.Clip = Convert.ToString(e.Data.GetData(typeof(string)));

            }

            flex.Rows.Insert(oldindex);
        }

        private void grdList6_DragDrop(object sender, DragEventArgs e)
        {
            C1FlexGrid flex = (C1FlexGrid)sender;
            Point pt = flex.PointToClient(new Point(e.X, e.Y));
            HitTestInfo hti = flex.HitTest(pt.X, pt.Y);

            //newindex - the index where the row is to be moved to
            //oldindex - the index from where the row was moved from
            int newindex = hti.Row;
            int oldindex = flex.RowSel;

            if (newindex < 0)
                newindex = flex.Rows.Count;

            if (newindex < 1)
                newindex = 1;

            C1.Win.C1FlexGrid.Row row = default(C1.Win.C1FlexGrid.Row);

            //going upwards
            if (oldindex > 1 & newindex < oldindex)
            {
                row = flex.Rows[oldindex];
            }

            //coming downwards
            if (newindex > oldindex & (oldindex + 1) < flex.Rows.Count)
            {
                row = flex.Rows[oldindex + 1];
            }

            // remove the row from the earlier position
            flex.Rows.Remove(oldindex);

            // if the row to be added is the last row
            if (newindex > flex.Rows.Count)
            {
                //insert a new row at the drop position
                flex.Rows.Insert(newindex - 1);

                //copy data from source row
                flex.Select(newindex - 1, 0, newindex - 1, flex.Cols.Count - 1, false);
                flex.Clip = Convert.ToString(e.Data.GetData(typeof(string)));
            }
            else
            {
                //insert a new row at the drop position
                flex.Rows.Insert(newindex);

                //copy data from source row
                flex.Select(newindex, 0, newindex, flex.Cols.Count - 1, false);
                flex.Clip = Convert.ToString(e.Data.GetData(typeof(string)));

            }

            flex.Rows.Insert(oldindex);
        }

        private void grdList4_BeforeMouseDown(object sender, BeforeMouseDownEventArgs e)
        {
            HitTestInfo hti = this.grdList4.HitTest(e.X, e.Y);
            if (hti.Type == HitTestTypeEnum.Cell)
            {
                //select the row 
                int index = hti.Row;
                this.grdList4.Select(index, 0, index, this.grdList4.Cols.Count - 1, false);

                //save info for target
                //_src = this.grdList4;

                //do drag drop
                DragDropEffects dd = this.grdList4.DoDragDrop(this.grdList4.Clip, DragDropEffects.Move);

                //if it worked, delete row from source (it's a move) 
                if (dd == DragDropEffects.Move)
                {
                    this.grdList4.Rows.Remove(index);
                }

                //done, reset info
                //_src = null;
                this._int가입반설정ID = Convert.ToInt32(this.grdList4[index, 1]);
                this.txt가입반설정.Text = Convert.ToString(this.grdList4[index, 2]);
            }
        }

        private void grdList5_BeforeMouseDown(object sender, BeforeMouseDownEventArgs e)
        {
            HitTestInfo hti = this.grdList5.HitTest(e.X, e.Y);
            if (hti.Type == HitTestTypeEnum.Cell)
            {
                //select the row 
                int index = hti.Row;
                this.grdList5.Select(index, 0, index, this.grdList5.Cols.Count - 1, false);

                //save info for target
               // _src = this.grdList5;

                //do drag drop
                DragDropEffects dd = this.grdList5.DoDragDrop(this.grdList5.Clip, DragDropEffects.Move);

                //if it worked, delete row from source (it's a move) 
                if (dd == DragDropEffects.Move)
                {
                    this.grdList5.Rows.Remove(index);
                }

                //done, reset info
                //_src = null;
                this._int카드사항목설정ID = Convert.ToInt32(this.grdList5[index, 1]);
                this.txt카드사항목설정.Text = Convert.ToString(this.grdList5[index, 2]);
            }
        }

        private void grdList6_BeforeMouseDown(object sender, BeforeMouseDownEventArgs e)
        {
            HitTestInfo hti = this.grdList6.HitTest(e.X, e.Y);
            if (hti.Type == HitTestTypeEnum.Cell)
            {
                //select the row 
                int index = hti.Row;
                this.grdList6.Select(index, 0, index, this.grdList6.Cols.Count - 1, false);

                //save info for target
                //_src = this.grdList6;

                //do drag drop
                DragDropEffects dd = this.grdList6.DoDragDrop(this.grdList6.Clip, DragDropEffects.Move);

                //if it worked, delete row from source (it's a move) 
                if (dd == DragDropEffects.Move)
                {
                    this.grdList6.Rows.Remove(index);
                }

                //done, reset info
                //_src = null;
                this._intPG사항목설정ID = Convert.ToInt32(this.grdList6[index, 1]);
                this.txtPG사항목설정.Text = Convert.ToString(this.grdList6[index, 2]);
            }
        }

        private void grdList_Click(object sender, EventArgs e)
        {

        }
    }
}
