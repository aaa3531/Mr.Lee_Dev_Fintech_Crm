using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

using DH_CRM.Properties;

namespace DH_CRM
{
    /// <summary>
    /// 메인 폼
    /// </summary>
    public partial class MainForm : Form
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////// Delegate
        ////////////////////////////////////////////////////////////////////////////////////////// Private

        #region 높이/위쪽 위치 설정하기 대리자 - SetHeightTopDelegate(flag)

        /// <summary>
        /// 높이/위쪽 위치 설정하기 대리자
        /// </summary>
        /// <param name="flag">플래그</param>
        private delegate void SetHeightTopDelegate(int flag);

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Field
        ////////////////////////////////////////////////////////////////////////////////////////// Private

        #region Field

        /// <summary>
        /// 높이/위쪽 위치 설정하기 대리자
        /// </summary>
        private SetHeightTopDelegate setHeightTopDelegate = null;

        /// <summary>
        /// 타이머
        /// </summary>
        private System.Timers.Timer timer;

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Constructor
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 생성자 - NoticeForm()

        /// <summary>
        /// 생성자
        /// </summary>
        /// 
        private frm고객정보 f고객정보;
        public MainForm(frm고객정보 f고객정보)
        {
            InitializeComponent();
            this.f고객정보 = f고객정보;

            this.closePictureBox.Image = Resources.close_normal;

            this.closePictureBox.Click      += closePictureBox_Click;
            this.closePictureBox.MouseDown  += closePictureBox_MouseDown;
            this.closePictureBox.MouseMove  += closePictureBox_MouseMove;
            this.closePictureBox.MouseLeave += closePictureBox_MouseLeave;
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Method
        ////////////////////////////////////////////////////////////////////////////////////////// Private
        //////////////////////////////////////////////////////////////////////////////// Event

        #region 폼 로드시 처리하기 - Form_Load(sender, e)

        /// <summary>
        /// 폼 로드시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void Form_Load(object sender, EventArgs e)
        {
            setHeightTopDelegate = new SetHeightTopDelegate(SetHeightTop);

            Size     = new Size(220, 0);
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width - 20, Screen.PrimaryScreen.WorkingArea.Height - Height);

            this.timer = new System.Timers.Timer(2);

            this.timer.Elapsed += timer_Elapsed_PopUp;

            this.timer.Start();
        }

        #endregion
        #region 닫기 픽쳐 박스 클릭시 처리하기 - closePictureBox_Click(sender, e)

        /// <summary>
        /// 닫기 픽처 박스 클릭시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void closePictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
        #region 닫기 픽쳐 박스 마우스 DOWN 처리하기 - closePictureBox_MouseDown(sender, e)

        /// <summary>
        /// 닫기 픽쳐 박스 마우스 DOWN 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void closePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.closePictureBox.Image = Resources.close_down;
        }

        #endregion
        #region 닫기 픽쳐 박스 마우스 이동시 처리하기 - closePictureBox_MouseMove(sender, e)

        /// <summary>
        /// 닫기 픽쳐 박스 마우스 이동시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void closePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            this.closePictureBox.Image = Resources.close_over;
        }

        #endregion
        #region 닫기 픽쳐 박스 마우스 이탈시 처리하기 - closePictureBox_MouseLeave(sender, e)

        /// <summary>
        /// 닫기 픽쳐 박스 마우스 이탈시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void closePictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.closePictureBox.Image = Resources.close_normal;
        }

        #endregion

        #region 타이머 경과시 처리하기 (팝업용) - timer_Elapsed_PopUp(sender, e)

        /// <summary>
        /// 타이머 경과시 처리하기 (팝업용)
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void timer_Elapsed_PopUp(object sender, ElapsedEventArgs e)
        {
            if(Height < 120)
            {
                Invoke(setHeightTopDelegate, 0);
            }
            else
            {
                this.timer.Stop();

                this.timer.Elapsed -= timer_Elapsed_PopUp;
                this.timer.Elapsed += timer_Elapsed_PopOut;

                this.timer.Interval = 3000;

                this.timer.Start();
            }

            Application.DoEvents();
        }

        #endregion
        #region 타이머 경과시 처리하기 (팝아웃용) - timer_Elapsed_PopOut(sender, e)

        /// <summary>
        /// 타이머 경과시 처리하기 (팝아웃용)
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void timer_Elapsed_PopOut(object sender, ElapsedEventArgs e)
        {
            while(Height > 2)
            {
                Invoke(setHeightTopDelegate, 1);
            }

            this.timer.Stop();

            Application.DoEvents();

            Invoke(setHeightTopDelegate, 2);
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////// Function

        #region 높이/위쪽 위치 설정하기 - SetHeightTop(flag)

        /// <summary>
        /// 높이/위쪽 위치 설정하기
        /// </summary>
        /// <param name="flag">플래그</param>
        private void SetHeightTop(int flag)
        {
            if(flag == 0)
            {
                Height++;

                Top--;
            }
            else if(flag == 1)
            {
                Height--;

                Top++;
            }
            else if(flag == 2)
            {
                Close();
            }
        }

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {
            this.f고객정보.searchCustomerData(false, true);
        }
    }
}