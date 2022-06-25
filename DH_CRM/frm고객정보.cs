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
    public partial class frm고객정보 : Form
    {
        private SQLServer _SQLServer = null;
        private userInfo _userInfo;
        private iniFile _iniFile;
        //2021-01-28 임권호
        private const int _con고객등록ID = 1;
        private const int _con이름= 2;
        private const int _con카카오아이디 = 3;
        private const int _con네이버아이디 = 4;//41?
        private const int _con휴대전화 = 5;

        private const int _con유입경로 = 6;
        private const int _con유입경로대분류 = 7;
        private const int _con유입경로소분류 = 8;
        private const int _con수정일 = 9;
        private const int _con최초분배일 = 10;

        private const int _con체험기수 = 11;
        private const int _con검색어 = 12;
        private const int _con기타메모 = 13;
        private const int _con무료리딩시작일 = 14;
        private const int _con무료리딩종료일 = 15;

        private const int _con예약일 = 16;
        private const int _con담당자 = 17;
        private const int _con예수금 = 18;
        private const int _con소속팀 = 19;
        private const int _con증권사 = 20;

        private const int _con날짜 = 21;
        private const int _con금액 = 22;
        private const int _con가입반 = 23;
        private const int _con카드사 = 24;
        private const int _con결제방식 = 25;

        private const int _conPG = 26;
        private const int _con할부 = 27;
        private const int _con현금영수증발행유무 = 28;
        private const int _con현금영수증번호 = 29;
        private const int _conVIP회원메모이력 = 30;

        private int _int고객등록ID;
        private int _intVIP고객등록ID;

        private string _str신규등록위치1;
        private string _str신규등록위치2;
        private string _str전화번호자리맞춤;

        frmLoading loadingForm = new frmLoading();
        BackgroundWorker worker = new BackgroundWorker();

        private frm고객등록 f고객등록;

        private Dictionary<string, string> _dicColumnName = new Dictionary<string, string>();
        private string _filePath = Application.StartupPath + @"\settingCol.ini";

        public bool _is자료검색;
        public frm고객정보()
        {
            InitializeComponent();
            this._is자료검색 = false;
            this._userInfo = userInfo.Instance();
            this._iniFile = new iniFile();
            this.settingComboData();

            worker.DoWork += (sender, args) => searchCustomerData();
            worker.RunWorkerCompleted += (sender, args) => ReadingCompleted();
        }
        private void ReadingCompleted()
        {
            this.loadingForm.Close();
        }
        private void settingComboData()
        {
            try
            {
                //DataTable dt = getConfig.getData사용자정보(this._SQLServer);
                //this.cbo담당자.ItemsDataSource = dt;
                //this.cbo담당자.ItemsDisplayMember = "이름";
                //this.cbo담당자.ItemsValueMember = "사용자정보ID";
                //this.cbo담당자.TranslateValue = true;
                //DataRow row = dt.NewRow();
                //row["사용자정보ID"] = 0;
                //row["이름"] = "전체";
                //dt.Rows.InsertAt(row, 0);
                //this.cbo담당자.SelectedIndex = 0;
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

                DataTable dt3 = getConfig.getDt유입경로(this._SQLServer);
                this.cbo유입경로.ItemsDataSource = dt3;
                this.cbo유입경로.ItemsDisplayMember = "유입경로";
                this.cbo유입경로.ItemsValueMember = "유입경로설정ID";
                this.cbo유입경로.TranslateValue = true;
                DataRow row3 = dt3.NewRow();
                row3["유입경로설정ID"] = 0;
                row3["유입경로"] = "유입경로";
                dt3.Rows.InsertAt(row3, 0);
                this.cbo유입경로.SelectedIndex = 0;

                this.txt검색어.Text = "";
                this.txt이름.Text = "";
                this.txt휴대폰.Text = "";
            }
            catch (Exception ex)
            {
            }
        }
        public void searchData자료검색()
        {
            try
            {
                this._is자료검색 = true;
                this.grdWork.Redraw = false;
                this.grdWork.DataSource = getConfig.searchDt;
                this.grdWork.Cols[0].DataType = typeof(bool);
                this.grdWork.SetCellCheck(0, 0, C1.Win.C1FlexGrid.CheckEnum.Unchecked);
                this.grdWork.Cols[0].ImageAlignFixed = C1.Win.C1FlexGrid.ImageAlignEnum.CenterCenter;
                this.grdWork.Cols[_con고객등록ID].Visible = false;
                //2021-02-19 임권호 (21)
                this.grdWork[0, _con유입경로대분류] = "대분류";
                this.grdWork[0, _con유입경로소분류] = "소분류";

                for (int i = 1; i < this.grdWork.Cols.Count; i++)
                {
                    //this.grdWork.AutoSizeCol(i);
                    this.grdWork.Cols[i].AllowEditing = false;
                    if (this._dicColumnName.ContainsKey(Convert.ToString(this.grdWork[0, i])))
                    {
                        string strTitle = this._dicColumnName[Convert.ToString(this.grdWork[0, i])];
                        this.grdWork[0, i] = strTitle == "" ? Convert.ToString(this.grdWork[0, i]) : strTitle;
                        string strWidth = this._iniFile.Reader("고객정보", strTitle, this._filePath);
                        if (strWidth == "")
                            this.grdWork.Cols[i].Width = 150;
                        else
                            this.grdWork.Cols[i].Width = Convert.ToInt32(strWidth);
                    }
                }

                this.settingListColor이름();
                this.settingListColor증권사();
                this.settingListColor예수금();
                this.settingListColor휴대폰();

                this.grdWork.Redraw = true;
            }
            catch (Exception ex)
            {
            }
        }
        public void searchCustomerData(bool isAll = false, bool 무료리딩종료 = false)
        {
            try
            {
                this._is자료검색 = false;
                //2021-02-09 임권호
                string sql = "";
                sql += "select a.고객등록ID, a.이름, a.카톡아이디, a.네이버아이디, " + System.Environment.NewLine;

                if (this._str전화번호자리맞춤 == "1")
                {
                    sql += "휴대전화=case CHARINDEX('-', a.휴대전화) " + System.Environment.NewLine;
                    sql += "when 4 then SUBSTRING(a.휴대전화, 1, 3)+')'+SUBSTRING(a.휴대전화, 5,10) " + System.Environment.NewLine;
                    sql += "when 0 then SUBSTRING(a.휴대전화, 1, 3)+')'+SUBSTRING(a.휴대전화, 4,4)+'-'+SUBSTRING(a.휴대전화,8,4) " + System.Environment.NewLine;
                    sql += "else a.휴대전화 end," + System.Environment.NewLine;
                }
                else
                    sql += "a.휴대전화, " + System.Environment.NewLine;

                sql += "       a.유입경로, 유입경로대분류=(select top 1 대분류 from tb_대분류 where 대분류ID=a.유입경로대분류), 유입경로소분류= (select top 1 소분류 from tb_소분류 where 소분류ID=a.유입경로소분류), " + System.Environment.NewLine;
                sql += "       수정일=convert(nvarchar,a.수정일자,23), a.최초분배일, a.기수, a.검색어, 기타메모=(select top 1 내용 from tb_고객메모 where 고객등록ID=a.고객등록id order by 작성일자 desc), " + System.Environment.NewLine;
                //sql += "       무료리딩시작일=case when a.VIP고객여부=0 then a.무료리딩시작일 else b.리딩기간1 end, 무료리딩종료일=case when a.VIP고객여부=0 then a.무료리딩종료일 else b.리딩기간2 end, a.예약일설정, 담당자=(select top 1 이름 from tb_사용자정보 where 사용자정보ID=a.담당자), b.예수금, " + System.Environment.NewLine;
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

                if (!isAll)
                {
                    if (this.txt휴대폰.Text.Trim() != "")
                        sql += "and a.휴대전화 like '%" + this.txt휴대폰.Text.Trim() + "%'" + System.Environment.NewLine;
                    //sql += "and replace(replace(a.휴대전화,')',''),'-','') like '%" + this.txt휴대폰.Text.Trim().Replace(")", "").Replace("-", "") + "%'" + System.Environment.NewLine;

                    if (this.cbo유입경로대분류.SelectedIndex > 0)
                        sql += "and    a.유입경로대분류=" + this.cbo유입경로대분류.SelectedItem + "" + System.Environment.NewLine;

                    if (this.cbo유입경로소분류.SelectedIndex > 0)
                        sql += "and    a.유입경로소분류=" + this.cbo유입경로소분류.SelectedItem + "" + System.Environment.NewLine;

                    if (this.cbo유입경로.SelectedIndex > 0)
                        sql += "and    a.유입경로='" + this.cbo유입경로.Text + "'" + System.Environment.NewLine;

                    if (this.txt이름.Text.Trim() != "")
                        sql += "and a.이름 like '%" + this.txt이름.Text.Trim() + "%'" + System.Environment.NewLine;

                    if (this._userInfo.자료검색 == 3)
                        sql += "and a.담당자=" + this._userInfo.사용자정보ID + "" + System.Environment.NewLine;
                    else //2021-10-20 이찬명
                    {
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
                        else if (this._userInfo.자료검색 == 4) //해당부분 전체 및 담당자 선택기능 생성 및 개편
                            sql += "and a.담당자 in (" + this._userInfo.사용자정보ID + "," + this._userInfo.검색범위사용자정보ID + ")" + System.Environment.NewLine;
                    }

                    if (this.txt검색어.Text.Trim() != "")
                        sql += "and a.검색어 like '%" + this.txt검색어.Text.Trim() + "%'" + System.Environment.NewLine;
                }
                else //2021-10-20 이찬명
                {
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
                }
                //txt검색어.Text = "";
                //txt이름.Text = "";
                //txt휴대폰.Text = "";
                if (무료리딩종료)
                {
                    sql += "and a.무료리딩종료일<>''" + System.Environment.NewLine;
                    sql += "and DATEDIFF(dd, getdate(), a.무료리딩종료일)>0" + System.Environment.NewLine;
                    sql += "and (DATEDIFF(dd, getdate(), a.무료리딩종료일)=0 or DATEDIFF(dd, getdate(), a.무료리딩종료일)<=3)" + System.Environment.NewLine;
                }
                if (this._str신규등록위치2 == "1")
                    sql += "order by a.고객등록ID" + System.Environment.NewLine;
                else if (this._str신규등록위치1 == "1")
                    sql += "order by a.이름" + System.Environment.NewLine;
                else
                    sql += "order by a.이름" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();

                this.Invoke(new Action(() =>
                {
                    this.grdWork.Redraw = false;
                    this.grdWork.DataSource = dt;
                    this.grdWork.Cols[0].DataType = typeof(bool);
                    this.grdWork.SetCellCheck(0, 0, C1.Win.C1FlexGrid.CheckEnum.Unchecked);
                    this.grdWork.Cols[0].ImageAlignFixed = C1.Win.C1FlexGrid.ImageAlignEnum.CenterCenter;
                    this.grdWork.Cols[_con고객등록ID].Visible = false;
                    //2021-02-19 임권호 (21)
                    this.grdWork[0, _con유입경로대분류] = "대분류";
                    this.grdWork[0, _con유입경로소분류] = "소분류";
                    //2021-11-26 이찬명
                    this.grdWork[0, _con무료리딩시작일] = "무료시작";
                    this.grdWork[0, _con무료리딩종료일] = "무료종료";

                    for (int i = 1; i < this.grdWork.Cols.Count; i++)
                    {
                        //this.grdWork.AutoSizeCol(i);
                        this.grdWork.Cols[i].AllowEditing = false;
                        if (this._dicColumnName.ContainsKey(Convert.ToString(this.grdWork[0, i])))
                        {
                            string strTitle = this._dicColumnName[Convert.ToString(this.grdWork[0, i])];
                            this.grdWork[0, i] = strTitle == "" ? Convert.ToString(this.grdWork[0, i]) : strTitle;
                            string strWidth = this._iniFile.Reader("고객정보", strTitle, this._filePath);
                            if (strWidth == "")
                                this.grdWork.Cols[i].Width = 150;
                            else
                                this.grdWork.Cols[i].Width = Convert.ToInt32(strWidth);
                        }
                    }
                    //2021-11-26 이찬명
                    this.grdWork.Cols[_con카카오아이디].Width = 70;
                    this.grdWork.Cols[_con네이버아이디].Width = 80;
                    this.grdWork.Cols[_con유입경로소분류].Width = 130;
                    this.grdWork.Cols[_con수정일].Width = 75;
                    this.grdWork.Cols[_con최초분배일].Width = 75;
                    this.grdWork.Cols[_con체험기수].Width = 33;

                    this.settingListColor이름();
                    this.settingListColor증권사();
                    this.settingListColor예수금();
                    this.settingListColor휴대폰();

                    this.grdWork.Redraw = true;
                }));
            }
            catch (Exception ex)
            {
            }
        }
        public void printData고객정보()
        {
            try
            {
                System.Drawing.Printing.PrintDocument pd = this.grdWork.PrintParameters.PrintDocument;
                pd.DefaultPageSettings.Landscape = true;

                this.grdWork.Cols[0].Visible = false;
                this.grdWork.PrintGrid("고객리스트", PrintGridFlags.FitToPage | PrintGridFlags.ShowPreviewDialog, "고객리스트", DateTime.Now.ToString());
                this.grdWork.Cols[0].Visible = true;
            }
            catch (Exception ex)
            {
            }
        }
        private void settingListColor집전화()
        {
            try
            {
                //2021-01-28 임권호
                //string[] array;
                //int intR = 0;
                //int intG = 0;
                //int intB = 0;
                //string strTemp = "";
                //Color color문자색;
                //Color color배경색;

                //strTemp = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "5문자색");
                //if (strTemp == "")
                //    color문자색 = Color.Black;
                //else
                //{
                //    array = strTemp.Split(',');
                //    intR = Convert.ToInt32(array[0]);
                //    intG = Convert.ToInt32(array[1]);
                //    intB = Convert.ToInt32(array[2]);
                //    color문자색 = Color.FromArgb(intR, intG, intB);
                //}
                //strTemp = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "5배경색");
                //if (strTemp == "")
                //    color배경색 = Color.White;
                //else
                //{
                //    array = strTemp.Split(',');
                //    intR = Convert.ToInt32(array[0]);
                //    intG = Convert.ToInt32(array[1]);
                //    intB = Convert.ToInt32(array[2]);
                //    color배경색 = Color.FromArgb(intR, intG, intB);
                //}
                //CellStyle cs5 = this.grdWork.Styles.Add("CellStyle5");
                //cs5.BackColor = color배경색;
                //cs5.ForeColor = color문자색;

                //CellRange cr = this.grdWork.GetCellRange(1, _con집전화, this.grdWork.Rows.Count - 1, _con집전화);
                //cr.Style = this.grdWork.Styles["CellStyle5"];
            }
            catch (Exception ex)
            {
            }
        }
        private void settingListColor휴대폰()
        {
            try
            {
                string[] array;
                int intR = 0;
                int intG = 0;
                int intB = 0;
                string strTemp = "";
                Color color문자색;
                Color color배경색;

                strTemp = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "4문자색");
                if (strTemp == "")
                    color문자색 = Color.Black;
                else
                {
                    array = strTemp.Split(',');
                    intR = Convert.ToInt32(array[0]);
                    intG = Convert.ToInt32(array[1]);
                    intB = Convert.ToInt32(array[2]);
                    color문자색 = Color.FromArgb(intR, intG, intB);
                }
                strTemp = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "4배경색");
                if (strTemp == "")
                    color배경색 = Color.White;
                else
                {
                    array = strTemp.Split(',');
                    intR = Convert.ToInt32(array[0]);
                    intG = Convert.ToInt32(array[1]);
                    intB = Convert.ToInt32(array[2]);
                    color배경색 = Color.FromArgb(intR, intG, intB);
                }
                CellStyle cs4 = this.grdWork.Styles.Add("CellStyle4");
                cs4.BackColor = color배경색;
                cs4.ForeColor = color문자색;

                CellRange cr = this.grdWork.GetCellRange(1, _con휴대전화, this.grdWork.Rows.Count - 1, _con휴대전화);
                cr.Style = this.grdWork.Styles["CellStyle4"];
            }
            catch (Exception ex)
            {
            }
        }
        private void settingListColor예수금()
        {
            try
            {
                string[] array;
                int intR = 0;
                int intG = 0;
                int intB = 0;
                string strTemp = "";
                Color color문자색;
                Color color배경색;

                strTemp = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "3문자색");
                if (strTemp == "")
                    color문자색 = Color.Black;
                else
                {
                    array = strTemp.Split(',');
                    intR = Convert.ToInt32(array[0]);
                    intG = Convert.ToInt32(array[1]);
                    intB = Convert.ToInt32(array[2]);
                    color문자색 = Color.FromArgb(intR, intG, intB);
                }
                strTemp = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "3배경색");
                if (strTemp == "")
                    color배경색 = Color.White;
                else
                {
                    array = strTemp.Split(',');
                    intR = Convert.ToInt32(array[0]);
                    intG = Convert.ToInt32(array[1]);
                    intB = Convert.ToInt32(array[2]);
                    color배경색 = Color.FromArgb(intR, intG, intB);
                }
                CellStyle cs3 = this.grdWork.Styles.Add("CellStyle3");
                cs3.BackColor = color배경색;
                cs3.ForeColor = color문자색;

                CellRange cr = this.grdWork.GetCellRange(1, _con예수금, this.grdWork.Rows.Count - 1, _con예수금);
                cr.Style = this.grdWork.Styles["CellStyle3"];
            }
            catch (Exception ex)
            {
            }
        }
        private void settingListColor증권사()
        {
            try
            {
                string[] array;
                int intR = 0;
                int intG = 0;
                int intB = 0;
                string strTemp = "";
                Color color문자색;
                Color color배경색;

                strTemp = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "2문자색");
                if (strTemp == "")
                    color문자색 = Color.Black;
                else
                {
                    array = strTemp.Split(',');
                    intR = Convert.ToInt32(array[0]);
                    intG = Convert.ToInt32(array[1]);
                    intB = Convert.ToInt32(array[2]);
                    color문자색 = Color.FromArgb(intR, intG, intB);
                }
                strTemp = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "2배경색");
                if (strTemp == "")
                    color배경색 = Color.White;
                else
                {
                    array = strTemp.Split(',');
                    intR = Convert.ToInt32(array[0]);
                    intG = Convert.ToInt32(array[1]);
                    intB = Convert.ToInt32(array[2]);
                    color배경색 = Color.FromArgb(intR, intG, intB);
                }
                CellStyle cs2 = this.grdWork.Styles.Add("CellStyle2");
                cs2.BackColor = color배경색;
                cs2.ForeColor = color문자색;

                CellRange cr = this.grdWork.GetCellRange(1, _con증권사, this.grdWork.Rows.Count - 1, _con증권사);
                cr.Style = this.grdWork.Styles["CellStyle2"];
            }
            catch (Exception ex)
            {
            }
        }
        private void settingListColor이름()
        {
            try
            {
                string[] array;
                int intR = 0;
                int intG = 0;
                int intB = 0;
                string strTemp = "";
                Color color문자색;
                Color color배경색;

                strTemp = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "1문자색");
                if (strTemp == "")
                    color문자색 = Color.Black;
                else
                {
                    array = strTemp.Split(',');
                    intR = Convert.ToInt32(array[0]);
                    intG = Convert.ToInt32(array[1]);
                    intB = Convert.ToInt32(array[2]);
                    color문자색 = Color.FromArgb(intR, intG, intB);
                }
                strTemp = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "1배경색");
                if (strTemp == "")
                    color배경색 = Color.White;
                else
                {
                    array = strTemp.Split(',');
                    intR = Convert.ToInt32(array[0]);
                    intG = Convert.ToInt32(array[1]);
                    intB = Convert.ToInt32(array[2]);
                    color배경색 = Color.FromArgb(intR, intG, intB);
                }
                CellStyle cs1 = this.grdWork.Styles.Add("CellStyle1");
                cs1.BackColor = color배경색;
                cs1.ForeColor = color문자색;

                CellRange cr = this.grdWork.GetCellRange(1, _con이름, this.grdWork.Rows.Count - 1, _con이름);
                cr.Style = this.grdWork.Styles["CellStyle1"];
            }
            catch (Exception ex)
            {
            }
        }

        private void grdWork_DoubleClick(object sender, EventArgs e)
        {
            //2021-10-21 이찬명
            try
            {
                int row = this.grdWork.MouseRow;
                if (row < 1)
                    return;
                int int고객등록ID = Convert.ToInt32(this.grdWork[row, _con고객등록ID]);

                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "frm고객등록")
                    {
                        frm.Close();
                        break;
                    }
                }
                f고객등록 = new frm고객등록(this, int고객등록ID);
                f고객등록.Show();
            }
            catch (Exception ex)
            {
            }
        }

        private void frm고객정보_Load(object sender, EventArgs e)
        {
            this._SQLServer = SQLServer.Instance();
            this.grdList1.Rows.Count = 1;
            this.grdList1.Cols.Count = 1;
            this.grdList1.Cols[0].Width = 10;
            this.grdList2.Cols[0].Width = 10;

            this.settingComboData();
            this.settingGridUI();
            this.searchCustomerData();

        }
        private void settingGridUI()
        {
            try
            {
                this._str신규등록위치1 = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "신규등록현재위치에");
                this._str신규등록위치2 = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "신규등록맨뒷부분에");
                this._str전화번호자리맞춤 = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "전화번호자리맞춤");

                string strFont = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "폰트속성");
                string strFontSize = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "폰트크기");
                int intFontSize = 0;

                if (strFontSize == "")
                    intFontSize = 9;
                else
                    intFontSize = Convert.ToInt32(strFontSize);

                this.grdWork.Font = new Font(strFont, intFontSize);
                this.settingGridColumnName();
            }
            catch (Exception ex)
            {
            }
        }
        private void settingGridColumnName()
        {
            try
            {
                this._dicColumnName.Clear();

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
                        this._dicColumnName.Add(Convert.ToString(sd["name"]), Convert.ToString(sd["환경설정"]));
                    }
                }
                sd.Close();
            }
            catch (Exception ex)
            {
            }
        }
        private void lbl검색_Click(object sender, EventArgs e)
        {
            this.searchCustomerData();
        }
        private void cbo유입경로대분류_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.settingData소분류(Convert.ToInt32(this.cbo유입경로대분류.SelectedItem));
        }

        public void 고객정보ExcelDownload()
        {
            try
            {
                //2021-01-28 임권호
                if (MessageBox.Show("조회된 자료를 다운로드 합니다.", "고객정보", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                SaveFileDialog sfg = new SaveFileDialog();
                sfg.Filter = "Excel 통합문서|*.xlsx";
                sfg.FileName = "고객정보.xlsx";
                if (sfg.ShowDialog() == DialogResult.OK)
                {


                    ExcelPackage excel = new ExcelPackage();

                    // name of the sheet 
                    var workSheet = excel.Workbook.Worksheets.Add("Sheet1");

                    // Header of the Excel sheet 
                    workSheet.Cells[1, 1].Value = "이름";
                    workSheet.Cells[1, 2].Value = "카카오아이디";
                    workSheet.Cells[1, 3].Value = "네이버아이디";
                    workSheet.Cells[1, 4].Value = "휴대전화";
                    workSheet.Cells[1, 5].Value = "유입경로";

                    //2021-03-04 임권호
                    workSheet.Cells[1, 6].Value = "대분류";
                    workSheet.Cells[1, 7].Value = "소분류";
                    workSheet.Cells[1, 8].Value = "수정일";
                    workSheet.Cells[1, 9].Value = "최초분배일";
                    workSheet.Cells[1, 10].Value = "체험기수";

                    workSheet.Cells[1, 11].Value = "검색어";
                    workSheet.Cells[1, 12].Value = "기타메모";
                    workSheet.Cells[1, 13].Value = "무료리딩시작일";
                    workSheet.Cells[1, 14].Value = "무료리딩종료일";
                    workSheet.Cells[1, 15].Value = "예약일";

                    workSheet.Cells[1, 16].Value = "담당자";
                    workSheet.Cells[1, 17].Value = "예수금";
                    workSheet.Cells[1, 18].Value = "소속팀";
                    workSheet.Cells[1, 19].Value = "증권사";
                    workSheet.Cells[1, 20].Value = "날짜";

                    workSheet.Cells[1, 21].Value = "금액";
                    workSheet.Cells[1, 22].Value = "가입반";
                    workSheet.Cells[1, 23].Value = "카드사";
                    workSheet.Cells[1, 24].Value = "결제방식";
                    workSheet.Cells[1, 25].Value = "PG";

                    workSheet.Cells[1, 26].Value = "할부";
                    workSheet.Cells[1, 27].Value = "현금영수증발행유무";
                    workSheet.Cells[1, 28].Value = "현금영수증번호";
                    workSheet.Cells[1, 29].Value = "VIP호원메모이력";

                    for (int i = 1; i < 30; i++)
                    {
                        workSheet.Column(i).Style.Font.Size = 10;
                    }
                    workSheet.Column(1).Width = 15;
                    workSheet.Column(2).Width = 15;
                    workSheet.Column(3).Width = 23;
                    workSheet.Column(4).Width = 15;
                    workSheet.Column(5).Width = 15;

                    workSheet.Column(6).Width = 15;
                    workSheet.Column(7).Width = 15;
                    workSheet.Column(8).Width = 15;
                    workSheet.Column(9).Width = 15;
                    workSheet.Column(10).Width = 15;

                    workSheet.Column(11).Width = 15;
                    workSheet.Column(12).Width = 15;
                    workSheet.Column(13).Width = 15;
                    workSheet.Column(14).Width = 15;
                    workSheet.Column(15).Width = 15;

                    workSheet.Column(16).Width = 25;
                    workSheet.Column(17).Width = 25;
                    workSheet.Column(18).Width = 15;
                    workSheet.Column(19).Width = 15;
                    workSheet.Column(20).Width = 15;

                    workSheet.Column(21).Width = 15;
                    workSheet.Column(22).Width = 15;
                    workSheet.Column(23).Width = 15;
                    workSheet.Column(24).Width = 15;
                    workSheet.Column(25).Width = 15;

                    workSheet.Column(26).Width = 15;
                    workSheet.Column(27).Width = 15;
                    workSheet.Column(28).Width = 15;
                    workSheet.Column(29).Width = 15;

                    for (int i = 1; i < this.grdWork.Rows.Count; i++)
                    {
                        workSheet.Cells[i + 1, 1].Value = this.grdWork[i, _con이름];
                        workSheet.Cells[i + 1, 2].Value = this.grdWork[i, _con카카오아이디];
                        workSheet.Cells[i + 1, 3].Value = this.grdWork[i, _con네이버아이디];
                        workSheet.Cells[i + 1, 4].Value = this.grdWork[i, _con휴대전화];
                        workSheet.Cells[i + 1, 5].Value = this.grdWork[i, _con유입경로];

                        workSheet.Cells[i + 1, 6].Value = this.grdWork[i, _con유입경로대분류];
                        workSheet.Cells[i + 1, 7].Value = this.grdWork[i, _con유입경로소분류];
                        workSheet.Cells[i + 1, 8].Value = this.grdWork[i, _con수정일];
                        workSheet.Cells[i + 1, 9].Value = this.grdWork[i, _con최초분배일];
                        workSheet.Cells[i + 1, 10].Value = this.grdWork[i, _con체험기수];

                        workSheet.Cells[i + 1, 11].Value = this.grdWork[i, _con검색어];
                        workSheet.Cells[i + 1, 12].Value = this.grdWork[i, _con기타메모];
                        workSheet.Cells[i + 1, 13].Value = this.grdWork[i, _con무료리딩시작일];
                        workSheet.Cells[i + 1, 14].Value = this.grdWork[i, _con무료리딩종료일];
                        workSheet.Cells[i + 1, 15].Value = this.grdWork[i, _con예약일];

                        workSheet.Cells[i + 1, 16].Value = this.grdWork[i, _con담당자];
                        workSheet.Cells[i + 1, 17].Value = this.grdWork[i, _con예수금];
                        workSheet.Cells[i + 1, 18].Value = this.grdWork[i, _con소속팀];
                        workSheet.Cells[i + 1, 19].Value = this.grdWork[i, _con증권사];
                        workSheet.Cells[i + 1, 20].Value = this.grdWork[i, _con날짜];

                        workSheet.Cells[i + 1, 21].Value = this.grdWork[i, _con금액];
                        workSheet.Cells[i + 1, 22].Value = this.grdWork[i, _con가입반];
                        workSheet.Cells[i + 1, 23].Value = this.grdWork[i, _con카드사];
                        workSheet.Cells[i + 1, 24].Value = this.grdWork[i, _con결제방식];
                        workSheet.Cells[i + 1, 25].Value = this.grdWork[i, _conPG];

                        workSheet.Cells[i + 1, 26].Value = this.grdWork[i, _con할부];
                        workSheet.Cells[i + 1, 27].Value = this.grdWork[i, _con현금영수증발행유무];
                        workSheet.Cells[i + 1, 28].Value = this.grdWork[i, _con현금영수증번호];
                        workSheet.Cells[i + 1, 29].Value = this.grdWork[i, _conVIP회원메모이력];

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
        public void deleteData고객정보()
        {
            try
            {
                bool isDelete = false;

                if (MessageBox.Show("삭제하시겠습니까?", "고객정보", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = 1; i < this.grdWork.Rows.Count; i++)
                    {
                        if (Convert.ToBoolean(this.grdWork[i, 0]) == true)
                        {
                            isDelete = true;
                            int int고객등록ID = 0;
                            int고객등록ID = Convert.ToInt32(this.grdWork[i, 1]);
                            string sql = "delete from tb_고객등록 where 고객등록ID = " + int고객등록ID + "";
                            this._SQLServer.Command_SQL(sql);
                        }
                    }
                    if (isDelete)
                    {
                        MessageBox.Show("삭제되었습니다.");
                        this.searchCustomerData();
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        public void update담당자(int 새담당자)
        {
            try
            {
                int int고객등록ID = 0;
                if (MessageBox.Show("담당자를 변경하시겠습니까?", "담당자변경", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    for (int i = 1; i < this.grdWork.Rows.Count; i++)
                    {
                        int고객등록ID = Convert.ToInt32(this.grdWork[i, _con고객등록ID]);

                        string sql = "update tb_고객등록 set 담당자=@담당자1 where 고객등록ID=@고객등록ID" + System.Environment.NewLine;

                        this._SQLServer.paraClear();
                        this._SQLServer.addPara("담당자1", 새담당자, SqlDbType.Int);

                        int고객등록ID = this._SQLServer.Command_SQL(sql, "고객등록ID", int고객등록ID);
                    }
                }
                if (int고객등록ID > 0)
                {
                    this.searchCustomerData();
                    MessageBox.Show("담당자가 변경 되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
            }
        }
        public void 고객정보ExcelDownload1()
        {
            try
            {
                //2021-01-28 임권호
                if (MessageBox.Show("조회된 자료를 다운로드 합니다.", "고객정보", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                SaveFileDialog sfg = new SaveFileDialog();
                sfg.Filter = "Excel 통합문서|*.xlsx";
                sfg.InitialDirectory = this._userInfo.엑셀경로;
                sfg.FileName = "고객정보.xlsx";
                if (sfg.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage excel = new ExcelPackage();

                    // name of the sheet 
                    var workSheet = excel.Workbook.Worksheets.Add("Sheet1");

                    // Header of the Excel sheet 
                    workSheet.Cells[1, 1].Value = "이름";
                    workSheet.Cells[1, 2].Value = "카카오아이디";
                    workSheet.Cells[1, 3].Value = "네이버아이디";
                    workSheet.Cells[1, 4].Value = "휴대전화";
                    workSheet.Cells[1, 5].Value = "유입경로";

                    workSheet.Cells[1, 6].Value = "대분류";
                    workSheet.Cells[1, 7].Value = "소분류";
                    workSheet.Cells[1, 8].Value = "수정일";
                    workSheet.Cells[1, 9].Value = "최초분배일";
                    workSheet.Cells[1, 10].Value = "체험기수";

                    workSheet.Cells[1, 11].Value = "검색어";
                    workSheet.Cells[1, 12].Value = "기타메모";
                    workSheet.Cells[1, 13].Value = "무료리딩시작일";
                    workSheet.Cells[1, 14].Value = "무료리딩종료일";
                    workSheet.Cells[1, 15].Value = "예약일";

                    workSheet.Cells[1, 16].Value = "담당자";
                    workSheet.Cells[1, 17].Value = "예수금";
                    workSheet.Cells[1, 18].Value = "소속팀";
                    workSheet.Cells[1, 19].Value = "증권사";
                    workSheet.Cells[1, 20].Value = "날짜";

                    workSheet.Cells[1, 21].Value = "금액";
                    workSheet.Cells[1, 22].Value = "가입반";
                    workSheet.Cells[1, 23].Value = "카드사";
                    workSheet.Cells[1, 24].Value = "결제방식";
                    workSheet.Cells[1, 25].Value = "PG";

                    workSheet.Cells[1, 26].Value = "할부";
                    workSheet.Cells[1, 27].Value = "현금영수증발행유무";
                    workSheet.Cells[1, 28].Value = "현금영수증번호";
                    workSheet.Cells[1, 29].Value = "VIP호원메모이력";

                    for (int i = 1; i < 30; i++)
                    {
                        workSheet.Column(i).Style.Font.Size = 10;
                    }
                    workSheet.Column(1).Width = 15;
                    workSheet.Column(2).Width = 15;
                    workSheet.Column(3).Width = 23;
                    workSheet.Column(4).Width = 15;
                    workSheet.Column(5).Width = 15;

                    workSheet.Column(6).Width = 15;
                    workSheet.Column(7).Width = 15;
                    workSheet.Column(8).Width = 15;
                    workSheet.Column(9).Width = 15;
                    workSheet.Column(10).Width = 15;

                    workSheet.Column(11).Width = 15;
                    workSheet.Column(12).Width = 15;
                    workSheet.Column(13).Width = 15;
                    workSheet.Column(14).Width = 15;
                    workSheet.Column(15).Width = 15;

                    workSheet.Column(16).Width = 25;
                    workSheet.Column(17).Width = 25;
                    workSheet.Column(18).Width = 15;
                    workSheet.Column(19).Width = 15;
                    workSheet.Column(20).Width = 15;

                    workSheet.Column(21).Width = 15;
                    workSheet.Column(22).Width = 15;
                    workSheet.Column(23).Width = 15;
                    workSheet.Column(24).Width = 15;
                    workSheet.Column(25).Width = 15;

                    workSheet.Column(26).Width = 15;
                    workSheet.Column(27).Width = 15;
                    workSheet.Column(28).Width = 15;
                    workSheet.Column(29).Width = 15;

                    for (int i = 1; i < this.grdWork.Rows.Count; i++)
                    {
                        workSheet.Cells[i + 1, 1].Value = this.grdWork[i, _con이름];
                        workSheet.Cells[i + 1, 2].Value = this.grdWork[i, _con카카오아이디];
                        workSheet.Cells[i + 1, 3].Value = this.grdWork[i, _con네이버아이디];
                        workSheet.Cells[i + 1, 4].Value = this.grdWork[i, _con휴대전화];
                        workSheet.Cells[i + 1, 5].Value = this.grdWork[i, _con유입경로];

                        workSheet.Cells[i + 1, 6].Value = this.grdWork[i, _con유입경로대분류];
                        workSheet.Cells[i + 1, 7].Value = this.grdWork[i, _con유입경로소분류];
                        workSheet.Cells[i + 1, 8].Value = this.grdWork[i, _con수정일];
                        workSheet.Cells[i + 1, 9].Value = this.grdWork[i, _con최초분배일];
                        workSheet.Cells[i + 1, 10].Value = this.grdWork[i, _con체험기수];

                        workSheet.Cells[i + 1, 11].Value = this.grdWork[i, _con검색어];
                        workSheet.Cells[i + 1, 12].Value = this.grdWork[i, _con기타메모];
                        workSheet.Cells[i + 1, 13].Value = this.grdWork[i, _con무료리딩시작일];
                        workSheet.Cells[i + 1, 14].Value = this.grdWork[i, _con무료리딩종료일];
                        workSheet.Cells[i + 1, 15].Value = this.grdWork[i, _con예약일];

                        workSheet.Cells[i + 1, 16].Value = this.grdWork[i, _con담당자];
                        workSheet.Cells[i + 1, 17].Value = this.grdWork[i, _con예수금];
                        workSheet.Cells[i + 1, 18].Value = this.grdWork[i, _con소속팀];
                        workSheet.Cells[i + 1, 19].Value = this.grdWork[i, _con증권사];
                        workSheet.Cells[i + 1, 20].Value = this.grdWork[i, _con날짜];

                        workSheet.Cells[i + 1, 21].Value = this.grdWork[i, _con금액];
                        workSheet.Cells[i + 1, 22].Value = this.grdWork[i, _con가입반];
                        workSheet.Cells[i + 1, 23].Value = this.grdWork[i, _con카드사];
                        workSheet.Cells[i + 1, 24].Value = this.grdWork[i, _con결제방식];
                        workSheet.Cells[i + 1, 25].Value = this.grdWork[i, _conPG];

                        workSheet.Cells[i + 1, 26].Value = this.grdWork[i, _con할부];
                        workSheet.Cells[i + 1, 27].Value = this.grdWork[i, _con현금영수증발행유무];
                        workSheet.Cells[i + 1, 28].Value = this.grdWork[i, _con현금영수증번호];
                        workSheet.Cells[i + 1, 29].Value = this.grdWork[i, _conVIP회원메모이력];
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

        private void lbl전체보기_Click(object sender, EventArgs e)
        {
            //2021-10-21 이찬명
            worker.RunWorkerAsync(); // 백그라운드로 비동기 실행
                                     //Show progress form in a main thread
            loadingForm.ShowDialog(); // 로딩폼 나타내기

            this.settingComboData();
            this.searchCustomerData();
        }

        private void grdWork_AfterEdit(object sender, RowColEventArgs e)
        {
            //2021-01-26 임권호
            if (e.Col == 0 && e.Row == 0)
            {
                int check = Convert.ToInt32(this.grdWork.GetCellCheck(0, 0));
                for (int i = 1; i < this.grdWork.Rows.Count; i++)
                {
                    if (check == 1)
                        this.grdWork.SetCellCheck(i, 0, CheckEnum.Checked);
                    else
                        this.grdWork.SetCellCheck(i, 0, CheckEnum.Unchecked);
                }
            }
        }

        private void grdWork_Click(object sender, EventArgs e)
        {
            int row = this.grdWork.MouseRow;
            if (row < 1)
                return;
            this._int고객등록ID = Convert.ToInt32(this.grdWork[row, _con고객등록ID]);
            if (this.tabList.SelectedIndex == 0)
                this.searchData회원메모();
            else
                this.searchData매출정보();
        }
        private void searchData회원메모()
        {
            try
            {
                bool isVip = false;
                string sql = "";
                sql += "select VIP고객여부=isnull(VIP고객여부,0) " + System.Environment.NewLine;
                sql += "from   tb_고객등록" + System.Environment.NewLine;
                sql += "where  고객등록ID=" + this._int고객등록ID + "" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    if (Convert.ToInt32(sd["VIP고객여부"]) == 1)
                        isVip = true;
                }
                sd.Close();
                if (isVip)
                {
                    sql = "";
                    sql += "select VIP고객등록ID " + System.Environment.NewLine;
                    sql += "from   tb_VIP고객등록" + System.Environment.NewLine;
                    sql += "where  고객등록ID=" + this._int고객등록ID + "" + System.Environment.NewLine;

                    sd = this._SQLServer.GetDataReader(sql);
                    while (sd.Read())
                    {
                        this._intVIP고객등록ID = Convert.ToInt32(sd["VIP고객등록ID"]);
                    }
                    sd.Close();
                    sql = "";
                    sql += "select * " + System.Environment.NewLine;
                    sql += "from   tb_VIP고객메모" + System.Environment.NewLine;
                    sql += "where  VIP고객등록ID=" + this._intVIP고객등록ID + "" + System.Environment.NewLine;
                    sql += "order by 작성일자 desc" + System.Environment.NewLine;

                    sd = this._SQLServer.GetDataReader(sql);
                    DataTable dt = new DataTable();
                    dt.Load(sd);
                    sd.Close();
                    this.grdList1.DataSource = dt;
                }
                else
                {
                    sql = "";
                    sql += "select * " + System.Environment.NewLine;
                    sql += "from   tb_고객메모" + System.Environment.NewLine;
                    sql += "where  고객등록ID=" + this._int고객등록ID + "" + System.Environment.NewLine;

                    sd = this._SQLServer.GetDataReader(sql);
                    DataTable dt = new DataTable();
                    dt.Load(sd);
                    sd.Close();
                    this.grdList1.DataSource = dt;
                }
                this.grdList1.Redraw = false;
                this.grdList1.Cols[1].Visible = false;
                this.grdList1.Cols[2].Visible = false;
                this.grdList1.Cols[5].Format = "yyyy-MM-dd HH:mm:ss";
                this.grdList1.Cols[7].Format = "yyyy-MM-dd HH:mm:ss";
                this.grdList1.Cols[5].Width = 150;
                this.grdList1.Cols[3].Width = 500;

                for (int i = 1; i < this.grdList1.Rows.Count; i++)
                {
                    this.grdList1.AutoSizeRow(i);
                }
                this.grdList1.Redraw = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void tabList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabList.SelectedIndex == 0)
                this.searchData회원메모();
            else
                this.searchData매출정보();
        }
        private void searchData매출정보()
        {
            try
            {
                string sql = "";
                sql += "select a.매출정보ID, 결제구분=isnull(a.결제구분,''), d.성별, a.이름, a.휴대폰, a.결제일자, a.금액, " + System.Environment.NewLine;
                sql += "       a.결제수단, a.할부개월, e.인바운드, 유입경로대분류=(select top 1 대분류 from tb_대분류 where 대분류ID=d.유입경로대분류), " + System.Environment.NewLine;
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
                sql += "and  a.고객등록ID=" + this._int고객등록ID + "" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                this.grdList2.Redraw = false;
                this.grdList2.DataSource = dt;
                this.grdList2.Cols[1].Visible = false;
                this.grdList2.Cols[25].Visible = false;
                this.grdList2[0, 11] = "대분류";
                for (int i = 1; i < this.grdList2.Cols.Count; i++)
                {
                    this.grdList2.AutoSizeCol(i);
                }
                this.grdList2.Redraw = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void grdWork_AfterResizeColumn(object sender, RowColEventArgs e)
        {
            string strColName = Convert.ToString(this.grdWork[0, e.Col]);
            this._iniFile.Write("고객정보", strColName, Convert.ToString(this.grdWork.Cols[e.Col].Width), this._filePath);
        }
    }
}
