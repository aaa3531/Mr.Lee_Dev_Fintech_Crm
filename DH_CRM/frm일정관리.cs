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
    public partial class frm일정관리 : Form
    {
        private SQLServer _SQLServer;
        private userInfo _userInfo;

        private string _searchDate;
        private int _int일정관리ID;

        private DateTime _dateMonth = DateTime.Now;
        private int _intRow;
        private int _intCol;
        public frm일정관리()
        {
            InitializeComponent();

            this._searchDate = DateTime.Now.ToShortDateString();

            this._SQLServer = SQLServer.Instance();
            this._userInfo = userInfo.Instance();

        }

        private void frm일정관리_Load(object sender, EventArgs e)
        {
            for (int i = 8; i <= 50; i++)
            {
                this.cboFontSize.Items.Add(i);
            }
            this.cboFontSize.SelectedIndex = 22;

            this.txt일정내용.Font = new Font("맑은 고딕", 30);
            this.dtp작성일자.Value = DateTime.Now;

            this.viewCalender(0);
            this.searchData();
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

                this.grdCalender.Rows[0].Height = 46;
                this.grdCalender.Rows[1].Height = 46;
                this.grdCalender.Rows[2].Height = 46;
                this.grdCalender.Rows[3].Height = 46;
                this.grdCalender.Rows[4].Height = 46;
                this.grdCalender.Rows[5].Height = 46;
                this.grdCalender.Rows[6].Height = 46;

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
                int row = 1;
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
                    string strDay = i.ToString("D2");
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
                sql += "select 일정관리ID, 작성일자, 등록자, 일정내용=(case when b.일자 is null then a.일정내용 else '('+b.일자+')'+a.일정내용 end), 일정내용RTF" + System.Environment.NewLine;
                sql += "from   tb_일정관리 a left join tb_공휴일정보 b" + System.Environment.NewLine;
                sql += "on     substring(a.작성일자,6,5)=b.일자" + System.Environment.NewLine;
                sql += "where  1=1" + System.Environment.NewLine;
                if (getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "단체일정관리") != "1" && _userInfo.권한 == 0) sql += "and    등록자='" + this._userInfo.사용자ID + "'" + System.Environment.NewLine;
                sql += "and    작성일자='" + this._searchDate + "'" + System.Environment.NewLine;
                //sql += "and    convert(nvarchar,등록일자,23)='" + this._searchDate + "'" + System.Environment.NewLine;
                sql += "order by 작성일자 desc, 일정관리ID desc" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                this.grdWork.DataSource = dt;
                this.grdWork.Cols[0].Visible = false;
                this.grdWork.Cols[1].Visible = false;
                this.grdWork.Cols[5].Visible = false;
                this.grdWork.Cols[2].Width = 90;
                if (getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "단체일정관리") == "1" || _userInfo.권한 == 1) this.grdWork.Cols[3].Width = 90;
                else grdWork.Cols[3].Visible = false;
                this.grdWork.Cols[4].Width = 200;
            }
            catch (Exception ex)
            {
            }
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            this.saveData();
        }
        private void saveData()
        {
            try
            {
                if (MessageBox.Show("일정을 저장하시겠습니까?", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                if (this.txt일정내용.Text.Trim() == "")
                    return;
                string sql = "";
                if (this._int일정관리ID == 0)
                {
                    sql += "insert into tb_일정관리(" + System.Environment.NewLine;
                    sql += "       [작성일자], [일정내용], [등록자], [등록일자], [수정자], " + System.Environment.NewLine;
                    sql += "       [수정일자], [일정내용RTF])" + System.Environment.NewLine;
                    sql += "values (" + System.Environment.NewLine;
                    sql += "       @작성일자, @일정내용, @등록자, @등록일자, @수정자, " + System.Environment.NewLine;
                    sql += "       @수정일자, @일정내용RTF)" + System.Environment.NewLine;
                    sql += "select convert(int,scope_identity())" + System.Environment.NewLine;
                }
                else
                {
                    sql += "update tb_일정관리 set" + System.Environment.NewLine;
                    sql += "       [작성일자]=@작성일자, [일정내용]=@일정내용, [수정자]=@수정자, [수정일자]=@수정일자, [일정내용RTF]=@일정내용RTF" + System.Environment.NewLine;
                    sql += "where  일정관리ID=@일정관리ID" + System.Environment.NewLine;
                }
                this._SQLServer.paraClear();
                if (this._int일정관리ID == 0)
                {
                    this._SQLServer.addPara("작성일자", this.dtp작성일자.Text, SqlDbType.NVarChar);
                    this._SQLServer.addPara("일정내용", this.txt일정내용.Text.Trim(), SqlDbType.NVarChar);
                    this._SQLServer.addPara("등록자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                    this._SQLServer.addPara("등록일자", DateTime.Now, SqlDbType.DateTime);
                    this._SQLServer.addPara("수정자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                    this._SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);
                    this._SQLServer.addPara("일정내용RTF", this.txt일정내용.Rtf, SqlDbType.NVarChar);
                }
                else
                {
                    this._SQLServer.addPara("작성일자", this.dtp작성일자.Text, SqlDbType.NVarChar);
                    this._SQLServer.addPara("일정내용", this.txt일정내용.Text.Trim(), SqlDbType.NVarChar);
                    this._SQLServer.addPara("일정내용RTF", this.txt일정내용.Rtf, SqlDbType.NVarChar);
                    this._SQLServer.addPara("수정자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                    this._SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);
                }
                this._int일정관리ID = this._SQLServer.Command_SQL(sql, "일정관리ID", this._int일정관리ID);
                if (this._int일정관리ID > 0)
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
        private void controlClear()
        {
            this._int일정관리ID = 0;
            this.searchData();
        }

        private void lblPrevMonth_Click(object sender, EventArgs e)
        {
            this.viewCalender(1);
        }

        private void lblPrevDay_Click(object sender, EventArgs e)
        {
            this.viewCalender(3);
        }

        private void lblNextDay_Click(object sender, EventArgs e)
        {
            this.viewCalender(4);
        }

        private void lblNextMonth_Click(object sender, EventArgs e)
        {
            this.viewCalender(2);
        }

        private void grdWork_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int row = this.grdWork.MouseRow;
                if (row < 1)
                    return;
                this._int일정관리ID = Convert.ToInt32(this.grdWork[row, 1]);
                this.txt일정내용.Rtf = Convert.ToString(this.grdWork[row, 4]);
                this.dtp작성일자.Text = Convert.ToString(this.grdWork[row, 2]);
            }
            catch (Exception ex)
            {
            }
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            //2021-02-19 임권호
            if (this._int일정관리ID == 0)
            {
                MessageBox.Show("작성된 일정내용을 선택해 주시기 바랍니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.saveData();
            int row = this.grdWork.RowSel;
            this._int일정관리ID = Convert.ToInt32(this.grdWork[row, 1]);
            this.txt일정내용.Rtf = Convert.ToString(this.grdWork[row, 4]);
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {
            this.deleteData();
        }
        private void deleteData()
        {
            try
            {
                if (this._int일정관리ID == 0)
                    return;
                if (MessageBox.Show("일정내용을 삭제하시겠습니까?", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                string sql = "";
                sql += "delete from tb_일정관리 where 일정관리id=" + this._int일정관리ID + "" + System.Environment.NewLine;
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

        private void btn굵기_Click(object sender, EventArgs e)
        {
            fnSetFontBold();
        }

        private void btn밑줄_Click(object sender, EventArgs e)
        {
            fnSetFontUnderLine();
        }

        private void btn기울기_Click(object sender, EventArgs e)
        {
            fnSetFontItalic();
        }
        private void SetFontSize()
        {
            try
            {
                RichTextBox txtRichTextBox = this.txt일정내용;
                if (!(txtRichTextBox.SelectionFont == null))
                {
                    Font currentFont = txtRichTextBox.SelectionFont;
                    FontStyle newFontStyle = txtRichTextBox.SelectionFont.Style;
                    newFontStyle = txtRichTextBox.SelectionFont.Style ^ FontStyle.Italic;
                    float floSize;
                    float.TryParse(this.cboFontSize.SelectedItem.ToString(), out floSize);
                    txtRichTextBox.SelectionFont = new Font(currentFont.FontFamily, floSize, newFontStyle);
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void btn색상_Click(object sender, EventArgs e)
        {
            fnSetFontColor();
        }
        private void fnSetFontItalic()
        {
            try
            {
                RichTextBox txtRichTextBox = this.txt일정내용;
                if (!(txtRichTextBox.SelectionFont == null))
                {
                    Font currentFont = txtRichTextBox.SelectionFont;
                    FontStyle newFontStyle = txtRichTextBox.SelectionFont.Style;
                    newFontStyle = txtRichTextBox.SelectionFont.Style ^ FontStyle.Italic;
                    txtRichTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
        private void fnSetFontBold()
        {
            try
            {
                RichTextBox txtRichTextBox = this.txt일정내용;
                if (!(txtRichTextBox.SelectionFont == null))
                {
                    Font currentFont = txtRichTextBox.SelectionFont;
                    FontStyle newFontStyle = txtRichTextBox.SelectionFont.Style;
                    newFontStyle = txtRichTextBox.SelectionFont.Style ^ FontStyle.Bold;
                    txtRichTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
        private void fnSetFontUnderLine()
        {
            try
            {
                RichTextBox txtRichTextBox = this.txt일정내용;
                if (!(txtRichTextBox.SelectionFont == null))
                {
                    Font currentFont = txtRichTextBox.SelectionFont;
                    FontStyle newFontStyle = txtRichTextBox.SelectionFont.Style;
                    newFontStyle = txtRichTextBox.SelectionFont.Style ^ FontStyle.Underline;
                    txtRichTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
        private void fnSetFontColor()
        {
            try
            {
                RichTextBox txtRichTextBox = this.txt일정내용;
                using (ColorDialog dlg = new ColorDialog())
                {
                    dlg.Color = txtRichTextBox.SelectionColor;
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        txtRichTextBox.SelectionColor = dlg.Color;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void cboFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetFontSize();
        }

        private void lbl항목등록_Click(object sender, EventArgs e)
        {
            this.txt일정내용.Clear();
            this._int일정관리ID = 0;
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
                g.DrawString("일정메모", fontTItle, drawBrush, 340, ySize);
                ySize += 100;
                g.DrawString(this.txt일정내용.Text.Trim(), font, drawBrush, 20, ySize);
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
