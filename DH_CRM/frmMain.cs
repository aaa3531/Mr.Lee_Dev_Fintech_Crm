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
using C1.Win.Ribbon;

namespace DH_CRM
{
    public partial class frmMain : C1RibbonForm
    {
        private userInfo _userInfo;

        private bool IsMouseMoveStart;
        private Point mousePoint;

        private int _selectIndex;

        private frm고객정보 f고객정보;
        private frm문자내역 f문자내역;
        private frm업무일지 f업무일지;
        private frm매출관리 f매출관리;
        private frm일정관리 f일정관리;
        private frm통계 f통계;

        const int WM_NCHITTEST = 0x0084;
        const int HTCLIENT = 1;
        const int HTCAPTION = 2;

        //protected override void WndProc(ref Message m)

        //{

        //    base.WndProc(ref m);

        //    switch (m.Msg)

        //    {

        //        case WM_NCHITTEST:

        //            if (m.Result == (IntPtr)HTCLIENT)

        //            {

        //                m.Result = (IntPtr)HTCAPTION;

        //            }

        //            break;

        //    }

        //}

        //protected override CreateParams CreateParams

        //{

        //    get

        //    {

        //        CreateParams cp = base.CreateParams;

        //        cp.Style |= 0x40000;

        //        return cp;

        //    }

        //}


        frmLoading loadingForm = new frmLoading();
        BackgroundWorker worker = new BackgroundWorker();

        private SQLServer _SQLServer;
        public frmMain()
        {
            InitializeComponent();

            this._SQLServer = SQLServer.Instance();
            this._userInfo = userInfo.Instance();

            this.Load += this.fMain_Load;

            this.lbl고객등록.Click += this.lbl고객등록_Click;
            this.lblDelete.Click += this.lblDelete_Click;
            this.lblExcelDownload.Click += this.lblExcelDownload_Click;

            this.picMain.MouseDown += this.picMain_MouseDown;
            this.picMain.MouseMove += this.picMain_MouseMove;
            this.picMain.MouseUp += this.picMain_MouseUp;

            this.lblMenu고객관리.Click += this.lblMenu고객관리_Click;
            this.lblMenu업무관리.Click += this.lblMenu업무관리_Click;
            this.lblMenu환경설정.Click += this.lblMenu환경설정_Click;
            this.lblMenu기타.Click += this.lblMenu기타_Click;

            f고객정보 = new frm고객정보();
            f문자내역 = new frm문자내역();
            f업무일지 = new frm업무일지();
            f매출관리 = new frm매출관리();
            f일정관리 = new frm일정관리();
            f통계 = new frm통계();

            AddForms2Panel(f고객정보);
            AddForms2Panel(f문자내역);
            AddForms2Panel(f업무일지);
            AddForms2Panel(f매출관리);
            AddForms2Panel(f일정관리);
            AddForms2Panel(f통계);

            DisplayPage(nameof(frm고객정보));

            worker.DoWork += (sender, args) => LoadData고객정보();
            worker.RunWorkerCompleted += (sender, args) => ReadingCompleted();
        }
        private void ReadingCompleted()
        {
            this.loadingForm.Close();
        }
        private void AddForms2Panel(Form form)
        {
            form.TopLevel = false;
            mainPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        private void DisplayPage(string formName)
        {
            if (this.mainPanel.Controls.ContainsKey(formName))
            {
                this.mainPanel.Controls[formName].BringToFront();
            }
        }
        private void lblMenu고객관리_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip1.Show(this.lblMenu고객관리, 0, this.lblMenu고객관리.Height);
        }
        private void lblMenu업무관리_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip2.Show(this.lblMenu업무관리, 0, this.lblMenu업무관리.Height);
        }
        private void lblMenu환경설정_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip3.Show(this.lblMenu환경설정, 0, this.lblMenu환경설정.Height);
        }
        private void lblMenu기타_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip4.Show(this.lblMenu기타, 0, this.lblMenu기타.Height);
        }

        private void lblTopBar_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void fMain_Load(object senedr, EventArgs e)
        {
            this.lbl고객등록.Parent = this.picMain;
            this.lblMenu고객관리.Parent = this.picMain;
            this.lblMenu업무관리.Parent = this.picMain;
            this.lblMenu환경설정.Parent = this.picMain;
            this.lblMenu기타.Parent = this.picMain;
            this.lbl자료검색.Parent = this.picMain;
            this.lbl고객관리.Parent = this.picMain;
            this.lbl문자내역.Parent = this.picMain;
            this.lblDelete.Parent = this.picMain;
            this.lblExcelDownload.Parent = this.picMain;
            this.lblPrint.Parent = this.picMain;
            this.lbl매출관리.Parent = this.picMain;
            this.lbl업무관리.Parent = this.picMain;
            this.lbl일정관리.Parent = this.picMain;

            this.viewTrayIcon();
        }
        private void viewTrayIcon()
        {
            try
            {
                bool isData = false;
                string sql = "";
                sql += "select 무료리딩종료일, 남은일수=DATEDIFF(dd, getdate(), 무료리딩종료일)" + System.Environment.NewLine;
                sql += "from tb_고객등록" + System.Environment.NewLine;
                sql += "where 무료리딩종료일<>''" + System.Environment.NewLine;
                sql += "and DATEDIFF(dd, getdate(), 무료리딩종료일)>0" + System.Environment.NewLine;
                sql += "and (DATEDIFF(dd, getdate(), 무료리딩종료일)=0 or DATEDIFF(dd, getdate(), 무료리딩종료일)<=3)" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    isData = true;
                }
                sd.Close();

                if (isData)
                {
                    MainForm mForm = new MainForm(f고객정보);
                    mForm.Show();
                }
            }
            catch (Exception ex)
            {
                //throw;
                MessageBox.Show(ex.ToString());
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
        private void lbl최소화_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lbl고객등록_Click(object sender, EventArgs e)
        {
            if (this._userInfo.권한 == 0)
            {
                MessageBox.Show("고객등록은 관리자만 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frm고객등록 f고객등록 = new frm고객등록(this.f고객정보, 0);
            f고객등록.Show();
        }
        private void lbl자료검색_Click(object sender, EventArgs e)
        {
            frm자료검색 f자료검색 = new frm자료검색();
            if (f자료검색.ShowDialog() == DialogResult.OK)
            {
                DisplayPage(nameof(frm고객정보));
                this.f고객정보.searchData자료검색();
            }
        }

        private void lbl문자내역_Click(object sender, EventArgs e)
        {
            DisplayPage(nameof(frm문자내역));
            this._selectIndex = 2;
            this.f문자내역.searchSMSData();
        }

        private void lbl고객관리_Click(object sender, EventArgs e)
        {
            DisplayPage(nameof(frm고객정보));
            this._selectIndex = 0;

            worker.RunWorkerAsync(); // 백그라운드로 비동기 실행
                                     //Show progress form in a main thread
            loadingForm.ShowDialog(); // 로딩폼 나타내기
        }
        private void LoadData고객정보()
        {
            try
            {
                this.f고객정보.searchCustomerData(true);
            }
            catch (Exception ex)
            {
            }
        }
        private void 업무일지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "업무일지보기") != "1")
            {
                MessageBox.Show("해당 메뉴는 접근 권한이 필요합니다.");
                return;
            }
            DisplayPage(nameof(frm업무일지));
        }

        private void 소속팀설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._userInfo.권한 == 0)
            {
                MessageBox.Show("관리자만 수정 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //2021-01-26 임권호
            frm소속팀설정 f소속팀설정 = new frm소속팀설정();
            f소속팀설정.Show();
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._userInfo.권한 == 0)
            {
                MessageBox.Show("해당 기능은 관리자만 이용 가능합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //2021-01-26 임권호
            frm사용자관리 f사용자관리 = new frm사용자관리();
            f사용자관리.Show();
        }

        private void 사용자환경설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = getConfig.getData환경설정(this._SQLServer, this._userInfo.사용자정보ID, "환경설정시패스워드묻기");
            if (str == "1")
            {
                frm환경설정비밀번호 f환경설정비밀번호 = new frm환경설정비밀번호();
                if (f환경설정비밀번호.ShowDialog() == DialogResult.OK)
                {
                    frm사용자환경설정 f사용자환경설정 = new frm사용자환경설정();
                    f사용자환경설정.Show();
                }
            }
            else
            {
                //2021-01-26 임권호
                frm사용자환경설정 f사용자환경설정 = new frm사용자환경설정();
                f사용자환경설정.Show();
            }
        }

        private void 문자설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //2021-02-01 임권호
            if (this._userInfo.권한 == 0)
            {
                MessageBox.Show("해당 기능은 관리자만 이용 가능합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frm문자설정 f문자설정 = new frm문자설정();
            f문자설정.Show();
        }

        private void 국경일기념일정의ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //2021-01-26 임권호
            if (this._userInfo.권한 == 0)
            {
                MessageBox.Show("해당 기능은 관리자만 이용 가능합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frm공휴일정보 f공휴일정보 = new frm공휴일정보();
            f공휴일정보.Show();
        }

        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm프로그램정보 f프로그램정보 = new frm프로그램정보();
            f프로그램정보.ShowDialog();
        }

        private void 공지사항웹연결ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("준비중입니다.");
        }

        private void 매출관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayPage(nameof(frm매출관리));
            this._selectIndex = 1;
            this.f매출관리.viewData매출정보();
        }

        private void 일정관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "일정관리") != "1")
            {
                MessageBox.Show("해당 메뉴는 접근 권한이 필요합니다.");
                return;
            }
            DisplayPage(nameof(frm일정관리));
        }

        private void 고객등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._userInfo.권한 == 0)
            {
                MessageBox.Show("고객등록은 관리자만 가능 합니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frm고객등록 f고객등록 = new frm고객등록(this.f고객정보, 0);
            f고객등록.Show();
        }

        private void 자료검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm자료검색 f자료검색 = new frm자료검색();
            if (f자료검색.ShowDialog() == DialogResult.OK)
            {
                DisplayPage(nameof(frm고객정보));
                this.f고객정보.searchData자료검색();
            }
        }

        private void 문자발송내역ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayPage(nameof(frm문자내역));
        }

        private void 엑셀자료가져오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._userInfo.엑셀업로드 == 0 && this._userInfo.권한 == 0)
            {
                MessageBox.Show("해당 기능은 권한이 없습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frm엑셀가져오기 f엑셀자료가져오기 = new frm엑셀가져오기();
            f엑셀자료가져오기.ShowDialog();
        }
        private void lblDelete_Click(object sender, EventArgs e)
        {
            if (this._userInfo.자료삭제 == 0 && this._userInfo.권한 == 0)
            {
                MessageBox.Show("해당 기능은 권한이 없습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.Delete고객정보();
        }

        private void Delete고객정보()
        {
            this.f고객정보.deleteData고객정보();
        }

        private void Delete매출관리()
        {
            this.f매출관리.deleteData매출관리();
        }

        private void ExcelDownload고객정보()
        {
            //2021-02-23 임권호
            if (this._userInfo.엑셀다운로드 == 0 && this._userInfo.권한 == 0)
            {
                //MessageBox.Show("해당 기능은 권한이 없습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.f고객정보.고객정보ExcelDownload();
        }

        private void ExcelDownload매출정보()
        {
            //2021-02-23 임권호
            if (this._userInfo.엑셀다운로드 == 0 && this._userInfo.권한 == 0)
            {
                //MessageBox.Show("해당 기능은 권한이 없습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.f매출관리.매출관리ExcelDownload();
        }

        private void ExcelDownload문자내역()
        {
            this.f문자내역.문자내역ExcelDownload();
        }
        private void lblExcelDownload_Click(object sender, EventArgs e)
        {
            if (this._selectIndex == 0)
                this.ExcelDownload고객정보();
            else if (this._selectIndex == 1)
                this.ExcelDownload매출정보();
            else if (this._selectIndex == 2)
                this.ExcelDownload문자내역();
        }

        private void 통계ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "등록고객통계보기") != "1")
            {
                MessageBox.Show("해당 메뉴는 접근 권한이 필요합니다.");
                return;
            }
            DisplayPage(nameof(frm통계));
        }

        private void 담당관리자일괄변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._userInfo.담당자변경 == 0 && this._userInfo.권한 == 0)
            {
                MessageBox.Show("해당 기능은 권한이 없습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //2021-01-26 임권호
            frm담당자변경 f담당자변경 = new frm담당자변경(this.f고객정보);
            f담당자변경.Show();
        }

        private void 특정항목일괄변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //2021-02-01 임권호
            if (this._userInfo.권한 == 0)
            {
                MessageBox.Show("해당 기능은 권한이 없습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frm특정항목변경 f특정항목변경 = new frm특정항목변경();
            f특정항목변경.Show();
        }

        private void 엑셀로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._userInfo.엑셀다운로드 == 0 && this._userInfo.권한 == 0)
            {
                //MessageBox.Show("해당 기능은 권한이 없습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.ExcelDownload고객정보1();
        }
        private void ExcelDownload고객정보1()
        {
            //2021-01-21 임권호
            this.f고객정보.고객정보ExcelDownload1();
        }

        private void lblPrint_Click(object sender, EventArgs e)
        {
            this.printData고객정보();
        }
        private void printData고객정보()
        {
            this.f고객정보.printData고객정보();
        }

        private void lbl매출관리_Click(object sender, EventArgs e)
        {
            DisplayPage(nameof(frm매출관리));
            this._selectIndex = 1;
            this.f매출관리.viewData매출정보();
        }

        private void lbl업무관리_Click(object sender, EventArgs e)
        {
            if (getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "업무일지보기") != "1")
            {
                MessageBox.Show("해당 메뉴는 접근 권한이 필요합니다.");
                return;
            }
            DisplayPage(nameof(frm업무일지));
        }

        private void lbl일정관리_Click(object sender, EventArgs e)
        {
            if (getConfig.getData사용자공유범위(_SQLServer, _userInfo.사용자정보ID, "일정관리") != "1")
            {
                MessageBox.Show("해당 메뉴는 접근 권한이 필요합니다.");
                return;
            }
            DisplayPage(nameof(frm일정관리));
        }

        private void 엑셀자료변환옵션ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm엑셀자료변환옵션 f엑셀자료변환옵션 = new frm엑셀자료변환옵션();
            f엑셀자료변환옵션.Show();
        }
    }
}
