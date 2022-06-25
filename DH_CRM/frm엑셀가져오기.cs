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
using OfficeOpenXml;
using System.IO;

namespace DH_CRM
{
    public partial class frm엑셀가져오기 : Form
    {
        private SQLServer _SQLServer;
        private userInfo _userInfo;

        private bool IsMouseMoveStart;
        private Point mousePoint;

        private bool _isSave;
        public frm엑셀가져오기()
        {
            InitializeComponent();

            this._SQLServer = SQLServer.Instance();
            this._userInfo = userInfo.Instance();

            this.lblTopBar.Parent = this.picMain;
            this.lblClose.Parent = this.picMain;

            this.lbl엑셀읽기.Parent = this.picMain;
            this.lbl자료변환.Parent = this.picMain;
            this.lbl닫기.Parent = this.picMain;
            this.lbl업로드취소.Parent = this.picMain;

            this.lblTopBar.MouseDown += this.Form_MouseDown;
            this.lblTopBar.MouseMove += this.Form_MouseMove;
            this.lblTopBar.MouseUp += this.Form_MouseUp;

            this.grdWork.Rows.Count = 1;
            this.grdWork.Cols.Count = 1;
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

        private void lbl닫기_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl엑셀읽기_Click(object sender, EventArgs e)
        {
            this.ExcelUploadData();
        }
        private void ExcelUploadData()
        {
            try
            {
                OpenFileDialog ofg = new OpenFileDialog();
                ofg.Filter = "엑셀파일 (*.xls;*.xlsx)|*.xls;*xlsx";
                string filePath = "";
                if (ofg.ShowDialog() == DialogResult.OK)
                    filePath = ofg.FileName;
                this.lblFile.Text = filePath;
                if (!string.IsNullOrEmpty(filePath))
                    this.readDataExcel();
            }
            catch (Exception ex)
            {
            }
        }
        private void readDataExcel()
        {
            this.grdWork.Rows.Count = 1;
            this.grdWork.Cols.Count = 1;

            ExcelPackage excelPackage = new ExcelPackage(new FileInfo(this.lblFile.Text));
            ExcelWorksheet worksheet1 = excelPackage.Workbook.Worksheets[1];
            Data_Processing dataProcessing = new Data_Processing();
            List<Data_Member> member = dataProcessing.get_Member_List(worksheet1);
            int rowsCount = Convert.ToInt32(worksheet1.Dimension.End.Row) - 1;
            this.progressBar1.Visible = true;
            this.progressBar1.Value = 0;
            this.progressBar1.Maximum = rowsCount;

            for (int i = 1; i <= worksheet1.Dimension.End.Column; i++)
            {
                this.grdWork.Cols.Count++;
                int maxCols = this.grdWork.Cols.Count - 1;
                this.grdWork[0, maxCols] = worksheet1.Cells[1, i].Text;
            }
            using (List<Data_Member>.Enumerator enumerator = member.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Data_Member current = enumerator.Current;
                    if (current.이름.Trim() == "")
                        break;

                    this.grdWork.Rows.Count++;
                    int maxRows = this.grdWork.Rows.Count - 1;

                    this.grdWork[maxRows, 1] = current.이름;
                    this.grdWork[maxRows, 2] = current.카톡아이디;
                    this.grdWork[maxRows, 3] = current.네이버아이디;
                    this.grdWork[maxRows, 4] = current.핸드폰번호;
                    this.grdWork[maxRows, 5] = current.유입경로;

                    this.grdWork[maxRows, 6] = current.대분류;
                    this.grdWork[maxRows, 7] = current.소분류;
                    this.grdWork[maxRows, 8] = current.수정일자;
                    this.grdWork[maxRows, 9] = current.최초분배일;
                    this.grdWork[maxRows, 10] = current.체험기수;

                    this.grdWork[maxRows, 11] = current.검색어;
                    this.grdWork[maxRows, 12] = current.회원메모;
                    this.grdWork[maxRows, 13] = current.무료리딩시작;
                    this.grdWork[maxRows, 14] = current.무료리딩종료;
                    this.grdWork[maxRows, 15] = current.예약일;

                    this.grdWork[maxRows, 16] = current.담당자;
                    this.grdWork[maxRows, 17] = current.예수금;
                    this.grdWork[maxRows, 18] = current.소속팀;
                    this.grdWork[maxRows, 19] = current.증권사;
                    this.grdWork[maxRows, 20] = current.날짜;

                    this.grdWork[maxRows, 21] = current.금액;
                    this.grdWork[maxRows, 22] = current.가입반;
                    this.grdWork[maxRows, 23] = current.카드사;
                    this.grdWork[maxRows, 24] = current.결제방식;
                    this.grdWork[maxRows, 25] = current.PG;

                    this.grdWork[maxRows, 26] = current.할부;
                    this.grdWork[maxRows, 27] = current.현금영수증발행유무;
                    this.grdWork[maxRows, 28] = current.현금영수증번호;
                    this.grdWork[maxRows, 29] = current.VIP회원메모;

                    this.progressBar1.Value++;
                    Application.DoEvents();
                }
            }
        }
        private bool checkData고객정보(string 이름, string 휴대전화)
        {
            try
            {
                bool isData = false;
                string sql = "";
                sql += "select 고객등록ID" + System.Environment.NewLine;
                sql += "from   tb_고객등록" + System.Environment.NewLine;
                sql += "where  1=1" + System.Environment.NewLine;
                if (this._userInfo.중복체크기준 == 0)
                    sql += "and  이름='" + 이름 + "'" + System.Environment.NewLine;
                else
                    sql += "and  휴대전화='" + 휴대전화 + "'" + System.Environment.NewLine;

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
        private int checkData고객정보ID(string 이름, string 휴대전화)
        {
            try
            {
                int int고객등록ID = 0;
                string sql = "";
                sql += "select 고객등록ID" + System.Environment.NewLine;
                sql += "from   tb_고객등록" + System.Environment.NewLine;
                sql += "where  1=1" + System.Environment.NewLine;
                if (this._userInfo.중복체크기준 == 0)
                    sql += "and 이름='" + 이름 + "'" + System.Environment.NewLine;
                else
                    sql += "and 휴대전화='" + 휴대전화 + "'" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    int고객등록ID = Convert.ToInt32(sd["고객등록ID"]);
                }
                sd.Close();
                return int고객등록ID;
            }
            catch (Exception ex)
            {
            }
            return 0;
        }
        private void update고객등록Data(int 고객등록ID, Data_Member current)
        {
            try
            {
                string sd고객메모 = "";
                string sql = "";
                sql += "select 이름, 카톡아이디, 네이버아이디, 휴대전화, 유입경로," + System.Environment.NewLine;
                sql += "       유입경로대분류, 유입경로소분류, 최초분배일, 기수, 검색어, " + System.Environment.NewLine;
                sql += "       무료리딩시작일, 무료리딩종료일, 예약일설정 " + System.Environment.NewLine;
                sql += "from   tb_고객등록" + System.Environment.NewLine;
                sql += "where  고객등록ID=" + 고객등록ID + "" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();

                sql = "select 내용 from tb_고객메모 where 고객등록ID=" + 고객등록ID + "" + System.Environment.NewLine;
                sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    sd고객메모 = Convert.ToString(sd["내용"]);
                }
                sd.Close();

                foreach (DataRow row in dt.Rows)
                {
                    string str이름 = Convert.ToString(row["이름"]);
                    string str카톡아이디 = Convert.ToString(row["카톡아이디"]);
                    string str네이버아이디 = Convert.ToString(row["네이버아이디"]);
                    string str휴대전화 = Convert.ToString(row["휴대전화"]);
                    string str유입경로 = Convert.ToString(row["유입경로"]);
                    int int유입경로대분류 = Convert.ToInt32(row["유입경로대분류"]);
                    int int유입경로소분류 = Convert.ToInt32(row["유입경로소분류"]);

                    string str최초분배일 = Convert.ToString(row["최초분배일"]);
                    string str기수 = Convert.ToString(row["기수"]);
                    string str검색어 = Convert.ToString(row["검색어"]);
                    string str무료리딩시작일 = Convert.ToString(row["무료리딩시작일"]);
                    string str무료리딩종료일 = Convert.ToString(row["무료리딩종료일"]);
                    string str예약일설정 = Convert.ToString(row["예약일설정"]);
                    string str고객메모 = sd고객메모;

                    if (str이름 == "" && current.이름 != "")
                    {
                        sql = "update tb_고객등록 set 이름='" + current.이름 + "'" + System.Environment.NewLine;
                        sql += "where 고객등록ID=" + 고객등록ID + "" + System.Environment.NewLine;
                        this._SQLServer.Command_SQL(sql);
                    }

                    if (str카톡아이디 == "" && current.카톡아이디 != "")
                    {
                        sql = "update tb_고객등록 set 카톡아이디='" + current.카톡아이디 + "'" + System.Environment.NewLine;
                        sql += "where 고객등록ID=" + 고객등록ID + "" + System.Environment.NewLine;
                        this._SQLServer.Command_SQL(sql);
                    }

                    if (str네이버아이디 == "" && current.네이버아이디 != "")
                    {
                        sql = "update tb_고객등록 set 네이버아이디='" + current.네이버아이디 + "'" + System.Environment.NewLine;
                        sql += "where 고객등록ID=" + 고객등록ID + "" + System.Environment.NewLine;
                        this._SQLServer.Command_SQL(sql);
                    }

                    if (str휴대전화 == "" && current.핸드폰번호 != "")
                    {
                        sql = "update tb_고객등록 set 휴대전화='" + current.핸드폰번호 + "'" + System.Environment.NewLine;
                        sql += "where 고객등록ID=" + 고객등록ID + "" + System.Environment.NewLine;
                        this._SQLServer.Command_SQL(sql);
                    }

                    if (str유입경로 == "" && current.유입경로 != "")
                    {
                        sql = "update tb_고객등록 set 유입경로='" + current.유입경로 + "'" + System.Environment.NewLine;
                        sql += "where 고객등록ID=" + 고객등록ID + "" + System.Environment.NewLine;
                        this._SQLServer.Command_SQL(sql);
                    }

                    if (str최초분배일 == "" && current.최초분배일 != "")
                    {
                        sql = "update tb_고객등록 set 최초분배일='" + current.최초분배일 + "'" + System.Environment.NewLine;
                        sql += "where 고객등록ID=" + 고객등록ID + "" + System.Environment.NewLine;
                        this._SQLServer.Command_SQL(sql);
                    }

                    if (str기수 == "" && current.체험기수 != "")
                    {
                        sql = "update tb_고객등록 set 기수='" + current.체험기수 + "'" + System.Environment.NewLine;
                        sql += "where 고객등록ID=" + 고객등록ID + "" + System.Environment.NewLine;
                        this._SQLServer.Command_SQL(sql);
                    }

                    if (str검색어 == "" && current.검색어 != "")
                    {
                        sql = "update tb_고객등록 set 검색어='" + current.검색어 + "'" + System.Environment.NewLine;
                        sql += "where 고객등록ID=" + 고객등록ID + "" + System.Environment.NewLine;
                        this._SQLServer.Command_SQL(sql);
                    }

                    if (str무료리딩시작일 == "" && current.무료리딩시작 != "")
                    {
                        sql = "update tb_고객등록 set 무료리딩시작일='" + current.무료리딩시작 + "'" + System.Environment.NewLine;
                        sql += "where 고객등록ID=" + 고객등록ID + "" + System.Environment.NewLine;
                        this._SQLServer.Command_SQL(sql);
                    }

                    if (str무료리딩종료일 == "" && current.무료리딩종료 != "")
                    {
                        sql = "update tb_고객등록 set 무료리딩종료일='" + current.무료리딩종료 + "'" + System.Environment.NewLine;
                        sql += "where 고객등록ID=" + 고객등록ID + "" + System.Environment.NewLine;
                        this._SQLServer.Command_SQL(sql);
                    }

                    if (str예약일설정 == "" && current.예약일 != "")
                    {
                        sql = "update tb_고객등록 set 예약일설정='" + current.예약일 + "'" + System.Environment.NewLine;
                        sql += "where 고객등록ID=" + 고객등록ID + "" + System.Environment.NewLine;
                        this._SQLServer.Command_SQL(sql);
                    }

                    if (str고객메모 == "" && current.회원메모 != "")
                    {
                        this.insertData회원메모(고객등록ID, current.회원메모);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void readExcel(string isFilePath)
        {
            try
            {
                //2021-02-09 임권호 (최초분배일 datetime)
                ExcelPackage excelPackage = new ExcelPackage(new FileInfo(isFilePath));
                ExcelWorksheet worksheet1 = excelPackage.Workbook.Worksheets[1];
                Data_Processing dataProcessing = new Data_Processing();
                List<Data_Member> member = dataProcessing.get_Member_List(worksheet1);
                int rowsCount = Convert.ToInt32(worksheet1.Dimension.End.Row) - 1;
                this.progressBar1.Visible = true;
                this.progressBar1.Value = 0;
                this.progressBar1.Maximum = rowsCount;
                int result = 0;
                using (List<Data_Member>.Enumerator enumerator = member.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        if (this._isSave)
                        {
                            MessageBox.Show("업로드가 취소되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        Data_Member current = enumerator.Current;

                        if (current.이름.Trim() == "")
                            break;

                        int int고객등록ID = 0;
                        if (this._userInfo.중복체크 == 1)
                        {
                            int고객등록ID = checkData고객정보ID(current.이름, current.핸드폰번호);
                            if (this._userInfo.중복체크1 == 0)
                            {
                                if (checkData고객정보(current.이름, current.핸드폰번호))
                                {
                                    this.progressBar1.Value++;
                                    Application.DoEvents();
                                    continue;
                                }
                            }
                            else if (this._userInfo.중복체크1 == 1)
                            {
                                this.update고객등록Data(int고객등록ID, current);
                                this.progressBar1.Value++;
                                Application.DoEvents();
                                continue;
                            }
                            else if (this._userInfo.중복체크1 == 2)
                            {

                            }
                        }
                        int int대분류ID = 0;
                        if (this._userInfo.대분류ID > 0)
                        {
                            int대분류ID = this._userInfo.대분류ID;
                        }
                        bool isData = false;
                        string sql = "";
                        if (this._userInfo.중복체크 == 1 && (this._userInfo.중복체크1 == 1 || this._userInfo.중복체크1 == 2) && int고객등록ID > 0)
                        {
                            sql += "update tb_고객등록 set" + System.Environment.NewLine;
                            sql += "        [이름]=@이름, [성별]=@성별, [생년월일]=@생년월일, [휴대전화]=@휴대전화, [집전화]=@집전화, " + System.Environment.NewLine;
                            sql += "        [최초분배일]=@최초분배일, [카톡아이디]=@카톡아이디, [예약일설정]=@예약일설정, [유입경로대분류]=@유입경로대분류, [유입경로소분류]=@유입경로소분류, " + System.Environment.NewLine;
                            sql += "        [담당자]=@담당자, [무료리딩시작일]=@무료리딩시작일, [무료리딩종료일]=@무료리딩종료일, [기수]=@기수, " + System.Environment.NewLine;
                            sql += "        [수정자]=@수정자, [수정일자]=@수정일자, [네이버아이디]=@네이버아이디, [유입경로]=@유입경로," + System.Environment.NewLine;
                            sql += "        [검색어]=@검색어" + System.Environment.NewLine;
                            sql += "where   고객등록ID=@고객등록ID" + System.Environment.NewLine;
                        }
                        else
                        {
                            isData = true;
                            sql += "insert into tb_고객등록(" + System.Environment.NewLine;
                            sql += "        [이름], [성별], [생년월일], [휴대전화], [집전화], " + System.Environment.NewLine;
                            sql += "        [최초분배일], [카톡아이디], [예약일설정], [유입경로대분류], [유입경로소분류], " + System.Environment.NewLine;
                            sql += "        [담당자], [무료리딩시작일], [무료리딩종료일], [기수], [등록자], " + System.Environment.NewLine;
                            sql += "        [등록일자], [수정자], [수정일자], [네이버아이디], [유입경로]," + System.Environment.NewLine;
                            sql += "        [검색어])" + System.Environment.NewLine;
                            sql += "values  (" + System.Environment.NewLine;
                            sql += "        @이름, @성별, @생년월일, @휴대전화, @집전화, " + System.Environment.NewLine;
                            sql += "        @최초분배일, @카톡아이디, @예약일설정, @유입경로대분류, @유입경로소분류, " + System.Environment.NewLine;
                            sql += "        @담당자, @무료리딩시작일, @무료리딩종료일, @기수, @등록자, " + System.Environment.NewLine;
                            sql += "        @등록일자, @수정자, @수정일자, @네이버아이디, @유입경로," + System.Environment.NewLine;
                            sql += "        @검색어)" + System.Environment.NewLine;
                            sql += "select convert(int,scope_identity())" + System.Environment.NewLine;
                        }

                        this._SQLServer.paraClear();
                        this._SQLServer.addPara("이름", current.이름, SqlDbType.NVarChar);
                        this._SQLServer.addPara("성별", "", SqlDbType.NVarChar);
                        this._SQLServer.addPara("생년월일", "", SqlDbType.NVarChar);
                        this._SQLServer.addPara("휴대전화", current.핸드폰번호, SqlDbType.NVarChar);
                        this._SQLServer.addPara("집전화", "", SqlDbType.NVarChar);

                        this._SQLServer.addPara("최초분배일", current.최초분배일, SqlDbType.NVarChar);
                        this._SQLServer.addPara("카톡아이디", current.카톡아이디, SqlDbType.NVarChar);
                        this._SQLServer.addPara("예약일설정", current.예약일, SqlDbType.NVarChar);

                        int int대분류정보ID = this.getData대분류정보ID(current.대분류);
                        int int소분류정보ID = this.getData소분류정보ID(current.소분류);

                        if (this._userInfo.대분류ID > 0)
                            this._SQLServer.addPara("유입경로대분류", this._userInfo.대분류ID, SqlDbType.Int);
                        else
                            this._SQLServer.addPara("유입경로대분류", int대분류정보ID, SqlDbType.Int);

                        this._SQLServer.addPara("유입경로소분류", int소분류정보ID, SqlDbType.Int);

                        int int담당자정보ID = this.getData사용자정보ID(current.담당자);

                        if (this._userInfo.담당자ID > 0 && current.담당자.Trim() == "")
                            this._SQLServer.addPara("담당자", this._userInfo.담당자ID, SqlDbType.Int);
                        else
                            this._SQLServer.addPara("담당자", int담당자정보ID, SqlDbType.Int);

                        this._SQLServer.addPara("무료리딩시작일", current.무료리딩시작, SqlDbType.NVarChar);
                        this._SQLServer.addPara("무료리딩종료일", current.무료리딩종료, SqlDbType.NVarChar);
                        this._SQLServer.addPara("기수", current.체험기수, SqlDbType.NVarChar);

                        DateTime dt수정일자 = current.수정일자 == "" ? DateTime.Now : Convert.ToDateTime(current.수정일자);

                        if (int고객등록ID == 0)
                        {
                            this._SQLServer.addPara("등록자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                            this._SQLServer.addPara("등록일자", DateTime.Now, SqlDbType.DateTime);
                        }

                        this._SQLServer.addPara("수정자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                        this._SQLServer.addPara("수정일자", dt수정일자, SqlDbType.DateTime);
                        this._SQLServer.addPara("네이버아이디", current.네이버아이디, SqlDbType.NVarChar);

                        this._SQLServer.addPara("유입경로", current.유입경로, SqlDbType.NVarChar);
                        this._SQLServer.addPara("검색어", current.검색어, SqlDbType.NVarChar);

                        int고객등록ID = this._SQLServer.Command_SQL(sql, "고객등록ID", int고객등록ID);

                        if(isData) this.insertData회원메모(int고객등록ID, current.회원메모);

                        this.progressBar1.Value++;
                        Application.DoEvents();
                    }
                }
                MessageBox.Show("업로드가 완료되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("업로드가 실패했습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void insertData회원메모(int 고객등록ID, string 회원메모)
        {
            string sql = "";
            try
            {
                sql += "insert  into tb_고객메모(" + System.Environment.NewLine;
                sql += "       고객등록ID, 내용, 작성자, 작성일자, 수정자, " + System.Environment.NewLine;
                sql += "       수정일자)" + System.Environment.NewLine;
                sql += "values (" + System.Environment.NewLine;
                sql += "       @고객등록ID, @내용, @작성자, @작성일자, @수정자, " + System.Environment.NewLine;
                sql += "       @수정일자)" + System.Environment.NewLine;
                sql += "select convert(int,scope_identity())" + System.Environment.NewLine;

                this._SQLServer.paraClear();
                this._SQLServer.addPara("고객등록ID", 고객등록ID, SqlDbType.Int);
                this._SQLServer.addPara("내용", 회원메모, SqlDbType.NVarChar);
                this._SQLServer.addPara("작성자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                this._SQLServer.addPara("작성일자", DateTime.Now, SqlDbType.DateTime);
                this._SQLServer.addPara("수정자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                this._SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);
                this._SQLServer.Command_SQL(sql, "고객메모ID", 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(sql.ToString() + "\r\n" + "\r\n" + 고객등록ID);
                return;
            }
        }
        private int getData사용자정보ID(string 담당자명)
        {
            try
            {
                int int사용자정보ID = 0;
                string sql = "";
                sql += "select 사용자정보ID" + System.Environment.NewLine;
                sql += "from   tb_사용자정보" + System.Environment.NewLine;
                sql += "where  이름='" + 담당자명 + "'" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    int사용자정보ID = Convert.ToInt32(sd["사용자정보ID"]);
                }
                sd.Close();
                return int사용자정보ID;
            }
            catch (Exception ex)
            {
            }
            return 0;
        }
        private int getData소분류정보ID(string 소분류)
        {
            try
            {
                int int분류정보ID = 0;
                string sql = "";
                sql += "select 소분류ID" + System.Environment.NewLine;
                sql += "from   TB_소분류" + System.Environment.NewLine;
                sql += "where  소분류='" + 소분류 + "'" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    int분류정보ID = Convert.ToInt32(sd["소분류ID"]);
                }
                sd.Close();
                return int분류정보ID;
            }
            catch (Exception ex)
            {
            }
            return 0;
        }
        private int getData대분류정보ID(string 대분류)
        {
            try
            {
                int int분류정보ID = 0;
                string sql = "";
                sql += "select 대분류ID" + System.Environment.NewLine;
                sql += "from   TB_대분류" + System.Environment.NewLine;
                sql += "where  대분류='" + 대분류 + "'" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    int분류정보ID = Convert.ToInt32(sd["대분류ID"]);
                }
                sd.Close();
                return int분류정보ID;
            }
            catch (Exception ex)
            {
            }
            return 0;
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl자료변환_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.lblFile.Text))
            {
                this._isSave = false;
                frm엑셀자료변환옵션 f엑셀자료변환옵션 = new frm엑셀자료변환옵션();
                if (f엑셀자료변환옵션.ShowDialog() == DialogResult.OK)
                {
                    readExcel(this.lblFile.Text);
                }           
            }
        }

        private void lbl업로드취소_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("현재 진행중인 업로드를 취소하시겠습니까?", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            else
                this._isSave = true;
        }
    }
}
