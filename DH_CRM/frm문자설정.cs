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
    public partial class frm문자설정 : Form
    {
        private SQLServer _SQLServer;
        private userInfo _userInfo;

        private bool IsMouseMoveStart;
        private Point mousePoint;
        private int _int문자저장ID;

        private Label[] label;
        public frm문자설정()
        {
            InitializeComponent();
            this.label = new Label[64]
            {
                this.label1,
                this.label2,
                this.label3,
                this.label4,
                this.label5,
                this.label6,
                this.label7,
                this.label8,
                this.label9,
                this.label10,
                this.label11,
                this.label12,
                this.label13,
                this.label14,
                this.label15,
                this.label16,
                this.label17,
                this.label18,
                this.label19,
                this.label20,
                this.label21,
                this.label22,
                this.label23,
                this.label24,
                this.label25,
                this.label26,
                this.label27,
                this.label28,
                this.label29,
                this.label30,
                this.label31,
                this.label32,
                this.label33,
                this.label34,
                this.label35,
                this.label36,
                this.label37,
                this.label38,
                this.label39,
                this.label40,
                this.label41,
                this.label42,
                this.label43,
                this.label44,
                this.label45,
                this.label46,
                this.label47,
                this.label48,
                this.label49,
                this.label50,
                this.label51,
                this.label52,
                this.label53,
                this.label54,
                this.label55,
                this.label56,
                this.label57,
                this.label58,
                this.label59,
                this.label60,
                this.label61,
                this.label62,
                this.label63,
                this.label64,
            };
            this.label1.Click += this.label_Click;
            this.label2.Click += this.label_Click;
            this.label3.Click += this.label_Click;
            this.label4.Click += this.label_Click;
            this.label5.Click += this.label_Click;
            this.label6.Click += this.label_Click;
            this.label7.Click += this.label_Click;
            this.label8.Click += this.label_Click;
            this.label9.Click += this.label_Click;
            this.label10.Click += this.label_Click;
            this.label11.Click += this.label_Click;
            this.label12.Click += this.label_Click;
            this.label13.Click += this.label_Click;
            this.label14.Click += this.label_Click;
            this.label15.Click += this.label_Click;
            this.label16.Click += this.label_Click;
            this.label17.Click += this.label_Click;
            this.label18.Click += this.label_Click;
            this.label19.Click += this.label_Click;
            this.label20.Click += this.label_Click;
            this.label21.Click += this.label_Click;
            this.label22.Click += this.label_Click;
            this.label23.Click += this.label_Click;
            this.label24.Click += this.label_Click;
            this.label25.Click += this.label_Click;
            this.label26.Click += this.label_Click;
            this.label27.Click += this.label_Click;
            this.label28.Click += this.label_Click;
            this.label29.Click += this.label_Click;
            this.label30.Click += this.label_Click;
            this.label31.Click += this.label_Click;
            this.label32.Click += this.label_Click;
            this.label33.Click += this.label_Click;
            this.label34.Click += this.label_Click;
            this.label35.Click += this.label_Click;
            this.label36.Click += this.label_Click;
            this.label37.Click += this.label_Click;
            this.label38.Click += this.label_Click;
            this.label39.Click += this.label_Click;
            this.label40.Click += this.label_Click;
            this.label41.Click += this.label_Click;
            this.label42.Click += this.label_Click;
            this.label43.Click += this.label_Click;
            this.label44.Click += this.label_Click;
            this.label45.Click += this.label_Click;
            this.label46.Click += this.label_Click;
            this.label47.Click += this.label_Click;
            this.label48.Click += this.label_Click;
            this.label49.Click += this.label_Click;
            this.label50.Click += this.label_Click;
            this.label51.Click += this.label_Click;
            this.label52.Click += this.label_Click;
            this.label53.Click += this.label_Click;
            this.label54.Click += this.label_Click;
            this.label55.Click += this.label_Click;
            this.label56.Click += this.label_Click;
            this.label57.Click += this.label_Click;
            this.label58.Click += this.label_Click;
            this.label59.Click += this.label_Click;
            this.label60.Click += this.label_Click;
            this.label61.Click += this.label_Click;
            this.label62.Click += this.label_Click;
            this.label63.Click += this.label_Click;
            this.label64.Click += this.label_Click;

            this._SQLServer = SQLServer.Instance();
            this._userInfo = userInfo.Instance();

            this.lblTopBar.MouseDown += this.Form_MouseDown;
            this.lblTopBar.MouseMove += this.Form_MouseMove;
            this.lblTopBar.MouseUp += this.Form_MouseUp;

            this.lbl슈어엠회원가입.Parent = this.pictureBox2;
            this.lbl크로샷회원가입.Parent = this.pictureBox2;

            this.lblTopBar.Parent = this.picMain;
            this.lblClose.Parent = this.picMain;
            this.lblAdd.Parent = this.pictureBox1;
            this.lblDelete.Parent = this.pictureBox1;
            this.lbl문자발송.Parent = this.pictureBox1;
            this.lbl문자저장.Parent = this.pictureBox1;
            this.lbl사진발송.Parent = this.pictureBox1;
            this.lbl사진선택.Parent = this.pictureBox1;
            this.lbl삭제.Parent = this.pictureBox1;
            this.lbl추가.Parent = this.pictureBox1;
            this.lbl잔액조회.Parent = this.pictureBox1;
            this.lbl충전하기.Parent = this.pictureBox1;

            Label lblText;
            for (int i = 0; i < 64; i++)
            {
                lblText = this.label.ElementAt<Label>(i);
                lblText.Parent = this.pictureBox1;
            }
        }
        public ICollection<Label> LableText
        {
            get
            {
                return (ICollection<Label>)this.label;
            }
        }
        private void label_Click(object sender, EventArgs e)
        {
            Label lblControl = sender as Label;
            string text = lblControl.Tag.ToString();
            this.txt문자내용.Text += text;
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

        private void frm문자설정_Load(object sender, EventArgs e)
        {
            this.dtpDate.Value = DateTime.Now;

            this.grdwork.Rows.Count = 1;
            this.grdwork.Cols.Count = 4;
            this.grdwork[0, 1] = "고객등록ID";
            this.grdwork[0, 2] = "이름";
            this.grdwork[0, 3] = "연락처";
            this.grdwork.Cols[0].Visible = false;
            this.grdwork.Cols[1].Visible = false;
            this.grdwork.Cols[1].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter;
            this.grdwork.Cols[2].TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftCenter;

            this.settingComboData();
            this.settingUserControl();
        }
        private void settingComboData()
        {
            for (int i = 0; i < 24; i++)
            {
                this.cboHour.Items.Add(i);
            }
            this.cboHour.SelectedIndex = 0;
            for (int i = 0; i < 60; i++)
            {
                this.cbominute.Items.Add(i);
            }
            this.cbominute.SelectedIndex = 0;
        }
        private void initControl()
        {
            try
            {
                if (this.tabPage1.Controls.Count > 0)
                    this.tabPage1.Controls.Clear();
            }
            catch (Exception ex)
            {
            }
        }
        public void settingUserControl()
        {
            try
            {
                this.initControl();

                uc저장된문자[] 저장된문자 = null;
                string sql = "";
                sql += "select * " + System.Environment.NewLine;
                sql += "from   tb_문자저장" + System.Environment.NewLine;
                sql += "where  문자구분='사랑'" + System.Environment.NewLine;
                sql += "order by 문자저장ID desc" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                int y = 20;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == 0)
                        저장된문자 = new uc저장된문자[dt.Rows.Count];
                    저장된문자[i] = new uc저장된문자(this, dt.Rows[i]["문자저장ID"].ToString(), dt.Rows[i]["문자제목"].ToString(), dt.Rows[i]["문자내용"].ToString());
                    int x = 11;
                    if (i % 2 != 0)
                        x = 315;
                    저장된문자[i].Location = new Point(x, y);
                    저장된문자[i].Name = "uc저장된문자" + i.ToString();
                    this.tabPage1.Controls.Add(저장된문자[i]);

                    if ((i > 0 && (i % 2 != 0)))
                        y += 215;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            frm연락처추가 f연락처추가 = new frm연락처추가();
            if (f연락처추가.ShowDialog() == DialogResult.OK)
            {
                this.settingData연락처정보();
            }
        }
        private void settingData연락처정보()
        {
            foreach (KeyValuePair<int, string> items in getConfig.dic연락처정보)
            {
                this.grdwork.Rows.Count++;
                int maxRows = this.grdwork.Rows.Count - 1;
                this.grdwork[maxRows, 1] = items.Key;
                string[] array = items.Value.Split('|');
                this.grdwork[maxRows, 2] = array[0];
                this.grdwork[maxRows, 3] = array[1];
            }
            this.lblCount.Text = "총 " + Convert.ToString(this.grdwork.Rows.Count - 1) + "명";
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {
            this.deleteList연락처정보();
        }
        private void deleteList연락처정보()
        {
            this.grdwork.Rows.Count = 1;
            this.lblCount.Text = "총 0명";
        }

        private void lbl문자저장_Click(object sender, EventArgs e)
        {
            this.saveData문자정보();
        }
        private void saveData문자정보()
        {
            try
            {
                if (this.txt문자내용.Text.Trim() == "")
                    return;

                if (MessageBox.Show("문자내용을 저장하시겠습니까?", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;

                string sql = "";
                if (this._int문자저장ID == 0)
                {
                    sql += "insert into tb_문자저장(" + System.Environment.NewLine;
                    sql += "       [문자구분], [문자제목], [문자내용], [등록자], [등록일자], " + System.Environment.NewLine;
                    sql += "       [수정자], [수정일자])" + System.Environment.NewLine;
                    sql += "values (" + System.Environment.NewLine;
                    sql += "       @문자구분, @문자제목, @문자내용, @등록자, @등록일자, " + System.Environment.NewLine;
                    sql += "       @수정자, @수정일자)" + System.Environment.NewLine;
                    sql += "select convert(int,scope_identity())" + System.Environment.NewLine;
                }
                else
                {
                    sql += "update tb_문자저장 set" + System.Environment.NewLine;
                    sql += "       [문자구분]=@문자구분, [문자제목]=@문자제목, [문자내용]=@문자내용, [수정자]=@수정자, [수정일자]=@수정일자" + System.Environment.NewLine;
                    sql += "where  문자저장ID=@문자저장ID" + System.Environment.NewLine;
                }
                this._SQLServer.paraClear();
                this._SQLServer.addPara("문자구분", "사랑", SqlDbType.NVarChar);
                this._SQLServer.addPara("문자제목", this.txt문자제목.Text.Trim(), SqlDbType.NVarChar);
                this._SQLServer.addPara("문자내용", this.txt문자내용.Text.Trim(), SqlDbType.NVarChar);
                if (this._int문자저장ID == 0)
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
                this._int문자저장ID = this._SQLServer.Command_SQL(sql, "문자저장ID", this._int문자저장ID);
                if (this._int문자저장ID > 0)
                {
                    this.settingUserControl();
                    this.controlClear();
                    MessageBox.Show("저장이 완료되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void controlClear()
        {
            this.txt문자내용.Clear();
            this.txt문자제목.Clear();
            this._int문자저장ID = 0;
        }

        private void lbl잔액조회_Click(object sender, EventArgs e)
        {
            MessageBox.Show("잔액조회 준비중입니다.");
        }

        private void lbl충전하기_Click(object sender, EventArgs e)
        {
            MessageBox.Show("충전하기 준비중입니다.");
        }

        private void lbl문자발송_Click(object sender, EventArgs e)
        {
            this.sendDataSMS();
        }
        private void sendDataSMS()
        {
            try
            {
                if (this.txt문자내용.Text.Trim() == "")
                    return;
                int int문자발송ID = 0;
                for (int i = 1; i < this.grdwork.Rows.Count; i++)
                {
                    string sql = "";
                    sql += "insert into tb_문자발송(" + System.Environment.NewLine;
                    sql += "       고객등록ID, 문자내용, 전송결과, 전송일자, 등록자, " + System.Environment.NewLine;
                    sql += "       등록일자, 수정자, 수정일자)" + System.Environment.NewLine;
                    sql += "values (" + System.Environment.NewLine;
                    sql += "       @고객등록ID, @문자내용, @전송결과, @전송일자, @등록자, " + System.Environment.NewLine;
                    sql += "       @등록일자, @수정자, @수정일자)" + System.Environment.NewLine;
                    sql += "select convert(int,scope_identity())" + System.Environment.NewLine;

                    this._SQLServer.paraClear();
                    this._SQLServer.addPara("고객등록ID", Convert.ToInt32(this.grdwork[i, 1]), SqlDbType.Int);
                    this._SQLServer.addPara("문자내용", this.txt문자내용.Text.Trim(), SqlDbType.NVarChar);
                    this._SQLServer.addPara("전송결과", "완료", SqlDbType.NVarChar);
                    this._SQLServer.addPara("전송일자", DateTime.Now, SqlDbType.DateTime);
                    this._SQLServer.addPara("등록자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                    this._SQLServer.addPara("등록일자", DateTime.Now, SqlDbType.DateTime);
                    this._SQLServer.addPara("수정자", this._userInfo.사용자ID, SqlDbType.NVarChar);
                    this._SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);
                    int문자발송ID += this._SQLServer.Command_SQL(sql);
                }
                if (int문자발송ID > 0)
                {
                    MessageBox.Show("문자발송이 완료되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void lbl슈어엠회원가입_Click(object sender, EventArgs e)
        {
            MessageBox.Show("준비중입니다.");
        }

        private void lbl크로샷회원가입_Click(object sender, EventArgs e)
        {
            MessageBox.Show("준비중입니다.");
        }

        private void picMain_Click(object sender, EventArgs e)
        {

        }
    }
}
