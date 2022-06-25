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
using C1.Win.C1FlexGrid;

namespace DH_CRM
{
    public partial class frm업무일지 : Form
    {
        private SQLServer _SQLServer;
        private userInfo _userInfo;

        private string _searchDate;
        private int _int업무일지ID;

        private DateTime _dateMonth = DateTime.Now;

        private int _intRow;
        private int _intCol;
        public frm업무일지()
        {
            InitializeComponent();
            this._searchDate = DateTime.Now.ToShortDateString();
        }

        private void frm업무일지_Load(object sender, EventArgs e)
        {
            this._SQLServer = SQLServer.Instance();
            this._userInfo = userInfo.Instance();
            this.dtp작성일자.Value = DateTime.Now;

            this.lblUser.Text = this._userInfo.이름;
            //this.lblUser.Parent = this.picMain;
            
            this.viewCalender(0);
            this.searchData();
            //2021-02-23 임권호
            this.settingComboData();
        }

        private void settingComboData()
        {
            try
            {
                //2021-02-23 임권호
                DataTable dt1 = getConfig.getData상태설정(this._SQLServer);
                this.cbo상태.ItemsDataSource = dt1;
                this.cbo상태.ItemsDisplayMember = "내용";
                this.cbo상태.ItemsValueMember = "상태설정ID";
                this.cbo상태.TranslateValue = true;
                this.cbo상태.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
            }
        }
        private void viewCalender(int isNext)
        {
            try
            {
                this.grdCalender.Redraw = false;
                this.grdCalender.Rows.Count = 0;
                this.grdCalender.Cols.Count = 0;
                this.grdCalender.Rows.Count = 7;
                this.grdCalender.Cols.Count = 8;
                this.grdCalender.Cols[0].Visible = false;
                this.grdCalender.Cols[1].Width = 92;
                this.grdCalender.Cols[2].Width = 92;
                this.grdCalender.Cols[3].Width = 92;
                this.grdCalender.Cols[4].Width = 92;
                this.grdCalender.Cols[5].Width = 92;
                this.grdCalender.Cols[6].Width = 92;
                this.grdCalender.Cols[7].Width = 92;
                this.grdCalender.Cols[1].TextAlignFixed = TextAlignEnum.CenterCenter;
                this.grdCalender.Cols[1].TextAlign = TextAlignEnum.CenterCenter;
                this.grdCalender.Cols[2].TextAlignFixed = TextAlignEnum.CenterCenter;
                this.grdCalender.Cols[2].TextAlign = TextAlignEnum.CenterCenter;
                this.grdCalender.Cols[3].TextAlignFixed = TextAlignEnum.CenterCenter;
                this.grdCalender.Cols[3].TextAlign = TextAlignEnum.CenterCenter;
                this.grdCalender.Cols[4].TextAlignFixed = TextAlignEnum.CenterCenter;
                this.grdCalender.Cols[4].TextAlign = TextAlignEnum.CenterCenter;
                this.grdCalender.Cols[5].TextAlignFixed = TextAlignEnum.CenterCenter;
                this.grdCalender.Cols[5].TextAlign = TextAlignEnum.CenterCenter;
                this.grdCalender.Cols[6].TextAlignFixed = TextAlignEnum.CenterCenter;
                this.grdCalender.Cols[6].TextAlign = TextAlignEnum.CenterCenter;
                this.grdCalender.Cols[7].TextAlignFixed = TextAlignEnum.CenterCenter;
                this.grdCalender.Cols[7].TextAlign = TextAlignEnum.CenterCenter;

                this.grdCalender.Rows[0].Height = 50;
                this.grdCalender.Rows[1].Height = 50;
                this.grdCalender.Rows[2].Height = 50;
                this.grdCalender.Rows[3].Height = 50;
                this.grdCalender.Rows[4].Height = 50;
                this.grdCalender.Rows[5].Height = 50;
                this.grdCalender.Rows[6].Height = 50;

                this.grdCalender[0, 1] = "일";
                this.grdCalender[0, 2] = "월";
                this.grdCalender[0, 3] = "화";
                this.grdCalender[0, 4] = "수";
                this.grdCalender[0, 5] = "목";
                this.grdCalender[0, 6] = "금";
                this.grdCalender[0, 7] = "토";

                if (isNext == 1)
                    this._dateMonth = this._dateMonth.AddYears(-1);
                else if (isNext == 2)
                    this._dateMonth = this._dateMonth.AddYears(1);
                else if (isNext == 4)
                    this._dateMonth = this._dateMonth.AddMonths(1);
                else if (isNext == 3)
                    this._dateMonth = this._dateMonth.AddMonths(-1);

                this.lblYearMonth.Text = this._dateMonth.Year + "." + this._dateMonth.Month;
                DateTime beforeDate = Convert.ToDateTime(this._dateMonth.ToShortDateString().Substring(0, 8) + "01");
                DateTime daysDate = beforeDate.AddMonths(1);
                daysDate = daysDate.AddDays(-1);

                int startindex;
                if (beforeDate.DayOfWeek == DayOfWeek.Sunday)
                    startindex = 1;
                else if (beforeDate.DayOfWeek == DayOfWeek.Monday)
                    startindex = 2;
                else if (beforeDate.DayOfWeek == DayOfWeek.Tuesday)
                    startindex = 3;
                else if (beforeDate.DayOfWeek == DayOfWeek.Wednesday)
                    startindex = 4;
                else if (beforeDate.DayOfWeek == DayOfWeek.Thursday)
                    startindex = 5;
                else if (beforeDate.DayOfWeek == DayOfWeek.Friday)
                    startindex = 6;
                else if (beforeDate.DayOfWeek == DayOfWeek.Saturday)
                    startindex = 7;
                else
                    startindex = 0;

                int row = 1;
                CellStyle cs = this.grdCalender.Styles.Add("CellStyle");
                cs.BackColor = Color.LightBlue;
                cs.Font = new Font(Font, FontStyle.Bold);
                CellStyle cs1 = this.grdCalender.Styles.Add("CellStyle1");
                cs1.ForeColor = Color.Blue;
                CellStyle cs2 = this.grdCalender.Styles.Add("CellStyle2");
                cs2.ForeColor = Color.Red;
                CellStyle cs3 = this.grdCalender.Styles.Add("CellStyle3");
                cs3.BackColor = Color.LightBlue;
                cs3.ForeColor = Color.Red;

                int intDay = this._dateMonth.Day;

                for (int i = 1; i <= daysDate.Day; i++)
                {
                    if (startindex % 8 == 0)
                    {
                        row++;
                        startindex = 1;
                    }
                    this.grdCalender[row, startindex] = i.ToString();
                    if (i == intDay)
                    {
                        this.grdCalender.SetCellStyle(row, startindex, cs);
                        this._intRow = row;
                        this._intCol = startindex;
                    }
                        
                    DateTime dt = Convert.ToDateTime(this._dateMonth.Year.ToString() + "-" + this._dateMonth.Month.ToString("D2") + "-" + i.ToString("D2"));
                    var days = dt.DayOfWeek;
                    if (days == DayOfWeek.Saturday)
                        this.grdCalender.SetCellStyle(row, startindex, cs1);
                    if (days == DayOfWeek.Sunday)
                        this.grdCalender.SetCellStyle(row, startindex, cs2);

                    string sql = "";
                    sql += "select 공휴일정보ID" + System.Environment.NewLine;
                    sql += "from   tb_공휴일정보" + System.Environment.NewLine;
                    sql += "where  일자='" + this._dateMonth.Month.ToString("D2") + "-" + i.ToString("D2") + "'" + System.Environment.NewLine;

                    SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                    while (sd.Read())
                    {
                        if (DateTime.Now.ToShortDateString().Substring(5) == this._dateMonth.Month.ToString("D2") + "-" + i.ToString("D2"))
                            this.grdCalender.SetCellStyle(row, startindex, cs3);
                        else
                            this.grdCalender.SetCellStyle(row, startindex, cs2);
                    }
                    sd.Close();

                    startindex++;
                }
                this.grdCalender.Redraw = true;
            }
            catch (Exception ex)
            {
            }
        }
        private void searchData()
        {
            try
            {
                string sql = "";
                sql += "select 업무일지ID, 작성자, 금일업무, 상태, 예정업무," + System.Environment.NewLine;
                sql += "       작성일자" + System.Environment.NewLine;
                sql += "from   tb_업무일지" + System.Environment.NewLine;
                sql += "where  1=1" + System.Environment.NewLine;
                if(getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "본인업무일지만보기") == "1") sql += "and    작성자='" + this._userInfo.사용자ID + "'" + System.Environment.NewLine;
                sql += "and    작성일자='" + this._searchDate + "'" + System.Environment.NewLine;
                sql += "order by 작성일자 desc" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                this.grdWork.DataSource = dt;
                this.grdWork.Cols[0].Visible = false;
                this.grdWork.Cols[1].Visible = false;
                this.grdWork.Cols[5].Visible = false;
                this.grdWork.Cols[6].Visible = false;
                this.grdWork.Cols[2].Width = 60;
                this.grdWork.Cols[3].Width = 200;
            }
            catch (Exception ex)
            {
            }
        }

        private void lblNew_Click(object sender, EventArgs e)
        {
            this.controlClear();   
        }
        private void controlClear()
        {
            //2021-01-19 임권호
            this._int업무일지ID = 0;
            this.dtp작성일자.Value = DateTime.Now;
            this.cbo상태.SelectedIndex = 0;
            this.txt금일업무.Clear();
            this.txt예정업무.Clear();
            this.txt댓글.Clear();
            this.searchData();
        }
        private void lblSave_Click(object sender, EventArgs e)
        {
            this.saveData();
        }
        private void deleteData()
        {
            try
            {
                if (this._int업무일지ID == 0)
                    return;
                if (MessageBox.Show("업무일지를 삭제하시겠습니까?", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                string sql = "";
                sql += "delete from tb_업무일지 where 업무일지id=" + this._int업무일지ID + "" + System.Environment.NewLine;
                if (this._SQLServer.Command_SQL(sql) > 0)
                {
                    this.controlClear();
                    this.searchData();
                    MessageBox.Show("삭제가 완료되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void saveData()
        {
            try
            {
                if (MessageBox.Show("업무일지를 저장하시겠습니까?", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                if (this.txt금일업무.Text.Trim() == "")
                    return;
                string sql = "";
                if (this._int업무일지ID == 0)
                {
                    sql += "insert into tb_업무일지(" + System.Environment.NewLine;
                    sql += "       [작성자], [금일업무], [예정업무], [상태], [작성일자], " + System.Environment.NewLine;
                    sql += "       [등록자], [등록일자], [수정자], [수정일자])" + System.Environment.NewLine;
                    sql += "values (" + System.Environment.NewLine;
                    sql += "       @작성자, @금일업무, @예정업무, @상태, @작성일자, " + System.Environment.NewLine;
                    sql += "       @등록자, @등록일자, @수정자, @수정일자)" + System.Environment.NewLine;
                    sql += "select convert(int,scope_identity())" + System.Environment.NewLine;
                }
                else
                {
                    sql += "update tb_업무일지 set" + System.Environment.NewLine;
                    sql += "       [작성자]=@작성자, [금일업무]=@금일업무, [예정업무]=@예정업무, [상태]=@상태, [작성일자]=@작성일자, " + System.Environment.NewLine;
                    sql += "       [수정자]=@수정자, [수정일자]=@수정일자" + System.Environment.NewLine;
                    sql += "where  업무일지ID=@업무일지ID" + System.Environment.NewLine;
                }
                this._SQLServer.paraClear();
                this._SQLServer.addPara("작성자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                this._SQLServer.addPara("금일업무", this.txt금일업무.Text.Trim(), SqlDbType.NVarChar);
                this._SQLServer.addPara("예정업무", this.txt예정업무.Text.Trim(), SqlDbType.NVarChar);
                this._SQLServer.addPara("상태", this.cbo상태.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("작성일자", this.dtp작성일자.Text, SqlDbType.NVarChar);

                if (this._int업무일지ID == 0)
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
                this._int업무일지ID = this._SQLServer.Command_SQL(sql, "업무일지ID", this._int업무일지ID);
                if (this._int업무일지ID > 0)
                {
                    this.controlClear();
                    this.searchData();
                    MessageBox.Show("저장이 완료되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {
            this.deleteData();
        }

        private void lblPrevMonth_Click(object sender, EventArgs e)
        {
            this.viewCalender(1);
        }

        private void lblNextMonth_Click(object sender, EventArgs e)
        {
            this.viewCalender(2);
        }

        private void lblNextDay_Click(object sender, EventArgs e)
        {
            this.viewCalender(4);
        }

        private void grdWork_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int row = this.grdWork.MouseRow;
                if (row < 1)
                    return;
                this._int업무일지ID = Convert.ToInt32(this.grdWork[row, 1]);
                this.txt금일업무.Text = Convert.ToString(this.grdWork[row, 3]);
                this.cbo상태.Text = Convert.ToString(this.grdWork[row, 4]);
                this.txt예정업무.Text = Convert.ToString(this.grdWork[row, 5]);
                this.dtp작성일자.Text = Convert.ToString(this.grdWork[row, 6]);
            }
            catch (Exception ex)
            {
            }
        }

        private void lblPrevDay_Click(object sender, EventArgs e)
        {
            this.viewCalender(3);
        }

        private void lblPrint_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int ySize = 50;
            Graphics g = e.Graphics;
            using (Font font = new Font("굴림", 10))
            using (Font fontTItle = new Font("굴림", 20))

            using (SolidBrush drawBrush = new SolidBrush(Color.Black))
            {
                g.DrawString("금일업무", fontTItle, drawBrush, 340, ySize);
                ySize += 100;
                g.DrawString(this.txt금일업무.Text.Trim(), font, drawBrush, 20, ySize);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //2021-02-23 임권호
            if (this._userInfo.권한 == 0)
            {
                MessageBox.Show("관리자만 등록 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            상태설정 f상태설정 = new 상태설정();
            if (f상태설정.ShowDialog() == DialogResult.OK)
            {
                this.settingComboData();
            }
        }

        private void grdCalender_Click(object sender, EventArgs e)
        {
            CellStyle cs = this.grdCalender.Styles.Add("CellStyle98");
            cs.BackColor = Color.White;
            CellStyle cs1 = this.grdCalender.Styles.Add("CellStyle99");
            cs1.BackColor = Color.DeepSkyBlue;

            CellRange csR = this.grdCalender.GetCellRange(0, 0, this.grdCalender.Rows.Count - 1, this.grdCalender.Cols.Count - 1);
            csR.Style = this.grdCalender.Styles["CellStyle98"];

            this.grdCalender.SetCellStyle(this.grdCalender.MouseRow, this.grdCalender.MouseCol, cs1);

            this.grdCalender.SetCellStyle(this._intRow, this._intCol, this.grdCalender.Styles["CellStyle3"]);

            string day = Convert.ToString(this.grdCalender[this.grdCalender.MouseRow, this.grdCalender.MouseCol]);
            if (day == "")
                return;
            this._searchDate = this.lblYearMonth.Text.Substring(0, 4) + "-" + Convert.ToInt32(this.lblYearMonth.Text.Substring(5)).ToString("D2") + "-" + day;

            this.searchData();
        }
    }
}
