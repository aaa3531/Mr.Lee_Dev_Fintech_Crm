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
    public partial class frm문자내역 : Form
    {
        private SQLServer _SQLServer = null;

        private const int _con문자발송ID = 1;
        private const int _con전송일자 = 2;
        private const int _con이름 = 3;
        private const int _con휴대전화 = 4;
        private const int _con담당자 = 5;
        private const int _con문자내용 = 6;
        private const int _con전송결과 = 7;
        public frm문자내역()
        {
            InitializeComponent();
        }

        private void frm문자내역_Load(object sender, EventArgs e)
        {
            this._SQLServer = SQLServer.Instance();

            this.settingComboData();
            this.searchSMSData();
        }

        private void settingComboData()
        {
            try
            {
                //2021-02-19 임권호
                DataTable dt = getConfig.getData사용자정보(this._SQLServer);
                this.cbo담당자.ItemsDataSource = dt;
                this.cbo담당자.ItemsDisplayMember = "이름";
                this.cbo담당자.ItemsValueMember = "사용자정보ID";
                this.cbo담당자.TranslateValue = true;
                DataRow row = dt.NewRow();
                row["사용자정보ID"] = 0;
                row["이름"] = "전체";
                dt.Rows.InsertAt(row, 0);
                this.cbo담당자.SelectedIndex = 0;

                DataTable dt1 = getConfig.getDt유입경로대분류(this._SQLServer);
                this.cbo유입경로대분류.ItemsDataSource = dt1;
                this.cbo유입경로대분류.ItemsDisplayMember = "대분류";
                this.cbo유입경로대분류.ItemsValueMember = "대분류ID";
                this.cbo유입경로대분류.TranslateValue = true;
                DataRow row1 = dt1.NewRow();
                row1["대분류ID"] = 0;
                row1["대분류"] = "대분류";
                dt1.Rows.InsertAt(row1, 0);
                this.cbo유입경로대분류.SelectedIndex = 0;

                DataTable dt2 = getConfig.getDt유입경로소분류(this._SQLServer);
                this.cbo유입경로소분류.ItemsDataSource = dt2;
                this.cbo유입경로소분류.ItemsDisplayMember = "소분류";
                this.cbo유입경로소분류.ItemsValueMember = "소분류ID";
                this.cbo유입경로소분류.TranslateValue = true;
                DataRow row2 = dt2.NewRow();
                row2["소분류ID"] = 0;
                row2["소분류"] = "소분류";
                dt2.Rows.InsertAt(row2, 0);
                this.cbo유입경로소분류.SelectedIndex = 0;
            } 
            catch (Exception ex)
            {
            }
        }
        public void searchSMSData()
        {
            try
            {
                //2021-02-19 임권호
                string sql = "";
                sql += "select a.문자발송id, a.전송일자, b.이름, b.휴대전화, 담당자=(select top 1 이름 from tb_사용자정보 where 사용자정보ID=b.담당자)," + System.Environment.NewLine;
                sql += "       a.문자내용, a.전송결과, b.유입경로대분류, b.유입경로소분류" + System.Environment.NewLine;
                sql += "from TB_문자발송 a left join tb_고객등록 b" + System.Environment.NewLine;
                sql += "on a.고객등록id=b.고객등록id" + System.Environment.NewLine;
                sql += "where  1=1" + System.Environment.NewLine;
                //sql += "and    b.유입경로대분류=" + this.cbo유입경로대분류.SelectedItem + "" + System.Environment.NewLine;
                //sql += "and    b.유입경로소분류=" + this.cbo유입경로소분류.SelectedItem + "" + System.Environment.NewLine;

                if (this.txt이름.Text.Trim() != "")
                    sql += "and b.이름 like '%" + this.txt이름.Text.Trim() + "%'" + System.Environment.NewLine;
                if (this.txt휴대폰.Text.Trim() != "")
                    sql += "and b.휴대전화 like '%" + this.txt휴대폰.Text.Trim() + "%'" + System.Environment.NewLine;

                if (this.cbo유입경로대분류.SelectedIndex > 0)
                    sql += "and    b.유입경로대분류=" + this.cbo유입경로대분류.SelectedItem + "" + System.Environment.NewLine;

                if (this.cbo유입경로소분류.SelectedIndex > 0)
                    sql += "and    b.유입경로소분류=" + this.cbo유입경로소분류.SelectedItem + "" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                this.grdWork.Redraw = false;
                this.grdWork.DataSource = dt;
                this.grdWork.Cols[1].Visible = false;
                this.grdWork.Cols[8].Visible = false;
                this.grdWork.Cols[9].Visible = false;
                this.grdWork.Cols[2].Width = 130;
                this.grdWork.Cols[3].Width = 110;
                this.grdWork.Cols[4].Width = 130;
                this.grdWork.Cols[5].Width = 110;
                this.grdWork.Cols[6].Width = 1300;
                this.grdWork.Redraw = true;
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
            int int문자발송ID = Convert.ToInt32(this.grdWork[row, 1]);
            frm문자정보 f문자정보 = new frm문자정보(int문자발송ID);
            f문자정보.ShowDialog();
        }

        private void grdWork_OwnerDrawCell(object sender, C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
        {
            if ((e.Row >= this.grdWork.Rows.Fixed) && (e.Col == (this.grdWork.Cols.Fixed - 1)))
                e.Text = ((e.Row - this.grdWork.Rows.Fixed) + 1).ToString();
        }

        private void lbl검색_Click(object sender, EventArgs e)
        {
            this.searchSMSData();
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
        private void cbo유입경로대분류_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.settingData소분류(Convert.ToInt32(this.cbo유입경로대분류.SelectedItem));
        }
        public void 문자내역ExcelDownload()
        {
            try
            {
                if (MessageBox.Show("조회된 자료를 다운로드 합니다.", "문자내역", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                SaveFileDialog sfg = new SaveFileDialog();
                sfg.Filter = "Excel 통합문서|*.xlsx";
                sfg.FileName = "문자내역.xlsx";
                if (sfg.ShowDialog() == DialogResult.OK)
                {


                    ExcelPackage excel = new ExcelPackage();

                    // name of the sheet 
                    var workSheet = excel.Workbook.Worksheets.Add("Sheet1");

                    // Header of the Excel sheet 
                    workSheet.Cells[1, 1].Value = "No.";
                    workSheet.Cells[1, 2].Value = "전송일자";
                    workSheet.Cells[1, 3].Value = "이름";
                    workSheet.Cells[1, 4].Value = "휴대전화";
                    workSheet.Cells[1, 5].Value = "담당자";
                    workSheet.Cells[1, 6].Value = "문자내용";
                    workSheet.Cells[1, 7].Value = "전송결과";

                    for (int i = 1; i < 8; i++)
                    {
                        workSheet.Column(i).Style.Font.Size = 10;
                    }
                    workSheet.Column(1).Width = 8;
                    workSheet.Column(2).Width = 15;
                    workSheet.Column(3).Width = 13;
                    workSheet.Column(4).Width = 15;
                    workSheet.Column(5).Width = 15;
                    workSheet.Column(6).Width = 100;
                    workSheet.Column(7).Width = 15;


                    for (int i = 1; i < this.grdWork.Rows.Count; i++)
                    {
                        workSheet.Cells[i + 1, 1].Value = i;
                        workSheet.Cells[i + 1, 2].Value = this.grdWork[i, _con전송일자];
                        workSheet.Cells[i + 1, 3].Value = this.grdWork[i, _con이름];
                        workSheet.Cells[i + 1, 4].Value = this.grdWork[i, _con휴대전화];
                        workSheet.Cells[i + 1, 5].Value = this.grdWork[i, _con담당자];
                        workSheet.Cells[i + 1, 6].Value = this.grdWork[i, _con문자내용];
                        workSheet.Cells[i + 1, 7].Value = this.grdWork[i, _con전송결과];
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
    }
}
