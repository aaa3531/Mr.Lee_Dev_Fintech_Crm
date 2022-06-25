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
using OfficeOpenXml;
using System.IO;

namespace DH_CRM
{
    public partial class frm매출관리 : Form
    {
        private SQLServer _SQLServer;
        private userInfo _userInfo;

        private const int _con매출정보ID = 1;
        private const int _con수입지출 = 2;
        private const int _con성별 = 3;
        private const int _con이름 = 4;
        private const int _con결제일자 = 5;
        //private const int _con생년월일 = 5;
        private const int _con휴대폰 = 6;
        private const int _con금액 = 7;
        private const int _con결제수단 = 8;
        private const int _con할부개월 = 9;
        private const int _con인바운드 = 10;
        private const int _con가입경로 = 11;
        private const int _con결제수단변경 = 12;
        private const int _con현금영수증 = 13;
        private const int _con토스결제유무 = 14;
        private const int _con토스건담당자 = 15;
        private const int _con담당자 = 16;
        public frm매출관리()
        {
            InitializeComponent();

            this._SQLServer = SQLServer.Instance();
            this._userInfo = userInfo.Instance();
        }

        private void frm매출관리_Load(object sender, EventArgs e)
        {
            this.dtp조회기간1.Value = DateTime.Now;
            this.dtp조회기간2.Value = DateTime.Now;

            this.settingComboData();
            this.viewData매출정보();
        }
        private void settingComboData()
        {
            try
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
                DataRow row = dt.NewRow();
                row["사용자정보ID"] = 0;
                row["이름"] = "전체";
                dt.Rows.InsertAt(row, 0);
                this.cbo담당자.ItemsDataSource = dt;
                this.cbo담당자.ItemsDisplayMember = "이름";
                this.cbo담당자.ItemsValueMember = "사용자정보ID";
                this.cbo담당자.TranslateValue = true;
                this.cbo담당자.SelectedIndex = 0;

                //2021-02-19 임권호 (5)
                this.cbo결제방법.Items.Add("전체");
                this.cbo결제방법.Items.Add("신용카드");
                this.cbo결제방법.Items.Add("현금");
                this.cbo결제방법.Items.Add("이체");
                this.cbo결제방법.Items.Add("모바일");
                this.cbo결제방법.Items.Add("기타");
                this.cbo결제방법.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
            }
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
        public void viewData매출정보(bool isAll = false)
        {
            try
            {
               //2021-02-23 임권호
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
                sql += "on   d.고객등록ID=e.고객등록ID" + System.Environment.NewLine;
                sql += "where  1=1" + System.Environment.NewLine;
                
                if (!isAll)
                {
                    sql += "and    a.결제일자 between '" + this.dtp조회기간1.Text + "' and '" + this.dtp조회기간2.Text + "'" + System.Environment.NewLine;

                    if (this.txt금액1.Text.Trim() != "" && this.txt금액2.Text.Trim() != "")
                        sql += "and (a.금액 >= " + this.txt금액1.Text + " and a.금액<= " + this.txt금액2.Text + ")" + System.Environment.NewLine;
                    else if (this.txt금액1.Text.Trim() != "")
                        sql += "and a.금액 >= " + this.txt금액1.Text + "" + System.Environment.NewLine;
                    else if (this.txt금액2.Text.Trim() != "")
                        sql += "and a.금액<=" + this.txt금액2.Text + "" + System.Environment.NewLine;

                    if (this.cbo결제방법.SelectedIndex > 0)
                        sql += "and a.결제수단='" + this.cbo결제방법.SelectedItem + "'" + System.Environment.NewLine;

                    if (this.txt이름.Text.Trim() != "")
                        sql += "and a.이름 like '%" + this.txt이름.Text.Trim() + "%'" + System.Environment.NewLine;

                    if (this.chk입금.Checked == true)
                        sql += "and a.결제구분='수입'" + System.Environment.NewLine;

                    if (this.chk출금.Checked == true)
                        sql += "and (a.결제구분='지출' or a.결제구분='환불')" + System.Environment.NewLine;

                    if (this.chk결변.Checked == true)
                        sql += "and a.결제구분='결변(결제변경)'" + System.Environment.NewLine;

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
                }
               
                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                this.grdWork.Redraw = false;
                this.grdWork.DataSource = dt;
                this.grdWork.Cols[0].DataType = typeof(bool);
                this.grdWork.SetCellCheck(0, 0, C1.Win.C1FlexGrid.CheckEnum.Unchecked);
                this.grdWork.Cols[0].ImageAlignFixed = C1.Win.C1FlexGrid.ImageAlignEnum.CenterCenter;
                this.grdWork.Cols[_con매출정보ID].Visible = false;
                this.grdWork.Cols[26].Visible = false;
                this.grdWork.Cols[_con성별].Visible = false;
                this.grdWork.Cols[_con금액].Format = "#,###";
                this.grdWork.Cols[_con결제수단변경].Format = "#,###";
                this.grdWork[0, _con가입경로] = "대분류";
                for (int i = 1; i < this.grdWork.Cols.Count; i++)
                {
                    //this.grdWork.AutoSizeCol(i);
                    this.grdWork.Cols[i].AllowEditing = false;
                }
                int int수입 = 0;
                int int지출 = 0;

                CellStyle cs = this.grdWork.Styles.Add("CellStyle");
                cs.ForeColor = Color.Red;

                for (int i = 1; i < this.grdWork.Rows.Count; i++)
                {
                    if (Convert.ToString(this.grdWork[i, _con수입지출]) == "수입")
                        int수입 += Convert.ToInt32(this.grdWork[i, _con금액]);
                    else if (Convert.ToString(this.grdWork[i, _con수입지출]) == "지출")
                    {
                        int지출 += Convert.ToInt32(this.grdWork[i, _con금액]);
                        CellRange cr = this.grdWork.GetCellRange(i, 1, i, this.grdWork.Cols.Count - 1);
                        cr.Style = this.grdWork.Styles["CellStyle"];
                    }
                        
                }
                this.txt수입합계.Text = string.Format("{0:#,##0}", int수입);
                this.txt지출합계.Text = string.Format("{0:#,##0}", int지출);
                this.txt수입지출.Text = string.Format("{0:#,##0}", int수입 - int지출);
                this.grdWork.Redraw = true;
            }
            catch (Exception ex)
            {
            }
        }
        private void searchData매출정보()
        {
            try
            {
                this.grdWork.Redraw = false;
                this.grdWork.DataSource = getConfig.searchDt;
                this.grdWork.Cols[0].DataType = typeof(bool);
                this.grdWork.SetCellCheck(0, 0, C1.Win.C1FlexGrid.CheckEnum.Unchecked);
                this.grdWork.Cols[0].ImageAlignFixed = C1.Win.C1FlexGrid.ImageAlignEnum.CenterCenter;
                this.grdWork.Cols[_con매출정보ID].Visible = false;
                this.grdWork.Cols[26].Visible = false;
                this.grdWork.Cols[_con성별].Visible = false;
                this.grdWork.Cols[_con금액].Format = "#,###";
                this.grdWork.Cols[_con결제수단변경].Format = "#,###";
                this.grdWork[0, _con가입경로] = "대분류";
                for (int i = 1; i < this.grdWork.Cols.Count; i++)
                {
                    this.grdWork.AutoSizeCol(i);
                    this.grdWork.Cols[i].AllowEditing = false;
                }
                int int수입 = 0;
                int int지출 = 0;

                CellStyle cs = this.grdWork.Styles.Add("CellStyle");
                cs.ForeColor = Color.Red;

                for (int i = 1; i < this.grdWork.Rows.Count; i++)
                {
                    if (Convert.ToString(this.grdWork[i, _con수입지출]) == "수입")
                        int수입 += Convert.ToInt32(this.grdWork[i, _con금액]);
                    else if (Convert.ToString(this.grdWork[i, _con수입지출]) == "지출")
                    {
                        int지출 += Convert.ToInt32(this.grdWork[i, _con금액]);
                        CellRange cr = this.grdWork.GetCellRange(i, 1, i, this.grdWork.Cols.Count - 1);
                        cr.Style = this.grdWork.Styles["CellStyle"];
                    }

                }
                this.txt수입합계.Text = string.Format("{0:#,##0}", int수입);
                this.txt지출합계.Text = string.Format("{0:#,##0}", int지출);
                this.txt수입지출.Text = string.Format("{0:#,##0}", int수입 - int지출);
                this.grdWork.Redraw = true;
            }
            catch (Exception ex)
            {
            }
        }
        private void lbl매출등록_Click(object sender, EventArgs e)
        {
            frm매출등록 f매출등록 = new frm매출등록(0);
            if (f매출등록.ShowDialog() == DialogResult.OK)
            {
                this.viewData매출정보();
            }
        }

        private void grdWork_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
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

        private void lbl자료검색_Click(object sender, EventArgs e)
        {            
            frm매출자료검색 f매출자료검색 = new frm매출자료검색();
            if (f매출자료검색.ShowDialog() == DialogResult.OK)
                this.searchData매출정보();
        }

        private void lbl검색_Click(object sender, EventArgs e)
        {
            this.viewData매출정보();
        }

        private void cbo유입경로대분류_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.settingData소분류(Convert.ToInt32(this.cbo유입경로대분류.SelectedItem));
        }
        public void deleteData매출관리()
        {
            try
            {
                bool isDelete = false;

                if (MessageBox.Show("삭제하시겠습니까?", "매출관리", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = 1; i < this.grdWork.Rows.Count; i++)
                    {
                        if (Convert.ToBoolean(this.grdWork[i, 0]) == true)
                        {
                            isDelete = true;
                            int int매출정보ID = 0;
                            int매출정보ID = Convert.ToInt32(this.grdWork[i, 1]);
                            string sql = "delete from tb_매출정보 where 매출정보ID = " + int매출정보ID + "";
                            this._SQLServer.Command_SQL(sql);
                        }
                    }
                    if (isDelete)
                    {
                        MessageBox.Show("삭제되었습니다.");
                        this.viewData매출정보();

                    }
                }

            }
            catch (Exception ex)
            {
            }
        }
        public void 매출관리ExcelDownload()
        {
            try
            {
                if (MessageBox.Show("조회된 자료를 다운로드 합니다.", "매출관리", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                SaveFileDialog sfg = new SaveFileDialog();
                sfg.Filter = "Excel 통합문서|*.xlsx";
                sfg.FileName = "매출관리.xlsx";
                if (sfg.ShowDialog() == DialogResult.OK)
                {


                    ExcelPackage excel = new ExcelPackage();

                    // name of the sheet 
                    var workSheet = excel.Workbook.Worksheets.Add("Sheet1");

                    // Header of the Excel sheet 
                    workSheet.Cells[1, 1].Value = "이름";
                    workSheet.Cells[1, 2].Value = "결제일자";
                    workSheet.Cells[1, 3].Value = "휴대폰";
                    workSheet.Cells[1, 4].Value = "금액";
                    workSheet.Cells[1, 5].Value = "결제수단";

                    workSheet.Cells[1, 6].Value = "할부개월";
                    workSheet.Cells[1, 7].Value = "인바운드";
                    workSheet.Cells[1, 8].Value = "가입경로";
                    workSheet.Cells[1, 9].Value = "현금영수증";
                    workSheet.Cells[1, 10].Value = "토스결제유무";

                    workSheet.Cells[1, 11].Value = "토스건담당자";
                    workSheet.Cells[1, 12].Value = "담당자";

                    for (int i = 1; i < 13; i++)
                    {
                        workSheet.Column(i).Style.Font.Size = 10;
                    }
                    workSheet.Column(1).Width = 15;
                    workSheet.Column(2).Width = 13;
                    workSheet.Column(3).Width = 15;
                    workSheet.Column(4).Width = 15;
                    workSheet.Column(5).Width = 15;

                    workSheet.Column(6).Width = 15;
                    workSheet.Column(7).Width = 15;
                    workSheet.Column(8).Width = 15;
                    workSheet.Column(9).Width = 15;
                    workSheet.Column(10).Width = 15;

                    workSheet.Column(11).Width = 15;
                    workSheet.Column(12).Width = 15;


                    for (int i = 1; i < this.grdWork.Rows.Count; i++)
                    {
                        workSheet.Cells[i + 1, 1].Value = this.grdWork[i, _con이름];
                        workSheet.Cells[i + 1, 2].Value = this.grdWork[i, _con결제일자];
                        workSheet.Cells[i + 1, 3].Value = this.grdWork[i, _con휴대폰];
                        workSheet.Cells[i + 1, 4].Value = string.Format("{0:#,##0}", Convert.ToInt32(this.grdWork[i, _con금액]));
                        workSheet.Cells[i + 1, 5].Value = this.grdWork[i, _con결제수단];
                        workSheet.Cells[i + 1, 6].Value = this.grdWork[i, _con할부개월];
                        workSheet.Cells[i + 1, 7].Value = this.grdWork[i, _con인바운드];
                        workSheet.Cells[i + 1, 8].Value = this.grdWork[i, _con가입경로];
                        workSheet.Cells[i + 1, 9].Value = this.grdWork[i, _con현금영수증];
                        workSheet.Cells[i + 1, 10].Value = this.grdWork[i, _con토스결제유무];
                        workSheet.Cells[i + 1, 11].Value = this.grdWork[i, _con토스건담당자];
                        workSheet.Cells[i + 1, 12].Value = this.grdWork[i, _con담당자];

                    }

                    string p_strPath = sfg.FileName;

                    if (File.Exists(p_strPath))
                        File.Delete(p_strPath);

                    // Create excel file on physical disk  
                    FileStream objFileStrm = File.Create(p_strPath);
                    objFileStrm.Close();

                    // Write content to excel file  
                    File.WriteAllBytes(p_strPath, excel.GetAsByteArray());
                    //Close Excel package 
                    excel.Dispose();

                    MessageBox.Show("Excel 변환이 완료되었습니다.", "Excel다운로드", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
            }
        }

        private void lbl수정_Click(object sender, EventArgs e)
        {
            this.UpdateData();
        }
        private void UpdateData()
        {
            try
            {
                int row = this.grdWork.RowSel;
                if (row < 1)
                    return;
                int int매출정보ID = Convert.ToInt32(this.grdWork[row, _con매출정보ID]);
                frm매출등록 f매출등록 = new frm매출등록(int매출정보ID);
                f매출등록.Show();
            }
            catch (Exception ex)
            {
            }
        }

        private void lbl삭제_Click(object sender, EventArgs e)
        {
            if (this._userInfo.권한 == 0)
            {
                //MessageBox.Show("해당 기능은 권한이 없습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.DeleteKindData();
        }
        private void DeleteKindData()
        {
            try
            {
                //2021-01-21 임권호
                bool isDelete = false;

                if (MessageBox.Show("삭제하시겠습니까?", "매출관리", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = 1; i < this.grdWork.Rows.Count; i++)
                    {
                        if (Convert.ToBoolean(this.grdWork[i, 0]) == true)
                        {
                            isDelete = true;
                            int int매출정보ID = 0;
                            int매출정보ID = Convert.ToInt32(this.grdWork[i, 1]);
                            string sql = "delete from tb_매출정보 where 매출정보ID = " + int매출정보ID + "";
                            this._SQLServer.Command_SQL(sql);
                        }
                    }
                    if (isDelete)
                    {
                        MessageBox.Show("삭제되었습니다.");
                        this.viewData매출정보();
                    }
                }
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

            int col = this.grdWork.MouseCol;
            if (col != _con이름)
                return;

            if (this.grdWork[row, 25] == DBNull.Value)
            {
                MessageBox.Show("고객등록이 저장되지 않은 고객입니다. 확인하시기 바랍니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int int고객등록ID = Convert.ToInt32(this.grdWork[row, 26]);
            frm고객등록 f고객등록 = new frm고객등록(null, int고객등록ID);
            f고객등록.Show();
        }

        private void lbl검색_Click_1(object sender, EventArgs e)
        {
            this.viewData매출정보();
        }
    }
}
