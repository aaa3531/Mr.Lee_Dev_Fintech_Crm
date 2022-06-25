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
using C1.Win.C1FlexGrid;

namespace DH_CRM
{
    public partial class frm특정항목변경 : Form
    {
        private SQLServer _SQLServer;

        private bool IsMouseMoveStart;
        private Point mousePoint;
        public frm특정항목변경()
        {
            InitializeComponent();

            this._SQLServer = SQLServer.Instance();

            this.lblTopBar.Parent = this.picMain;
            this.lblClose.Parent = this.picMain;

            this.lbl변환.Parent = this.picMain;
            this.lbl취소.Parent = this.picMain;

            this.lblTopBar.MouseDown += this.Form_MouseDown;
            this.lblTopBar.MouseMove += this.Form_MouseMove;
            this.lblTopBar.MouseUp += this.Form_MouseUp;
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

        private void frm특정항목변경_Load(object sender, EventArgs e)
        {
            this.settingComboData();
        }
        private void settingComboData()
        {
            this.cbo변환항목.Items.Add("이름");
            this.cbo변환항목.Items.Add("카톡아이디");
            this.cbo변환항목.Items.Add("네이버아이디");
            this.cbo변환항목.Items.Add("휴대전화");
            this.cbo변환항목.Items.Add("유입경로");
            this.cbo변환항목.Items.Add("대분류");
            this.cbo변환항목.Items.Add("소분류");
            this.cbo변환항목.Items.Add("수정일자");
            this.cbo변환항목.Items.Add("최초분배일");
            this.cbo변환항목.Items.Add("기수");
            this.cbo변환항목.Items.Add("검색어");
            this.cbo변환항목.Items.Add("무료리딩시작일");
            this.cbo변환항목.Items.Add("무료리딩종료일");
            this.cbo변환항목.Items.Add("예약일");
            this.cbo변환항목.SelectedIndex = 0;
        }

        private void lbl취소_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbl변환_Click(object sender, EventArgs e)
        {
            this.Dataupdate();
        }
        private int getData대분류정보ID(string 대분류명)
        {
            try
            {
                int int대분류정보ID = 0;
                string sql = "";
                sql += "select 대분류ID" + System.Environment.NewLine;
                sql += "from   tb_대분류 " + System.Environment.NewLine;
                sql += "where  대분류='" + 대분류명 + "'" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    int대분류정보ID = Convert.ToInt32(sd["대분류ID"]);
                }
                sd.Close();
                return int대분류정보ID;
            }
            catch (Exception ex)
            {
            }
            return 0;
        }
        private int getData소분류정보ID(string 소분류명)
        {
            try
            {
                int int소분류정보ID = 0;
                string sql = "";
                sql += "select 소분류ID" + System.Environment.NewLine;
                sql += "from   tb_소분류 " + System.Environment.NewLine;
                sql += "where  소분류='" + 소분류명 + "'" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    int소분류정보ID = Convert.ToInt32(sd["소분류ID"]);
                }
                sd.Close();
                return int소분류정보ID;
            }
            catch (Exception ex)
            {
            }
            return 0;
        }
        private void Dataupdate()
        {
            try
            {
                if (MessageBox.Show("변경하시겠습니까?", "항목변경", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;

                string sql = "";
                string str항목 = cbo변환항목.SelectedItem.ToString();
                string str변환이필요한값 = this.txt변환이필요한값.Text.Trim();
                string str변화된값 = this.txt변환된값.Text.Trim();

                if (str항목 == "대분류")
                {
                    int int대분류ID = 0;
                    int int변환대분류ID = 0;
                    int대분류ID = this.getData대분류정보ID(str변환이필요한값);
                    int변환대분류ID = this.getData대분류정보ID(str변화된값);
                    if (int대분류ID == 0 || int변환대분류ID == 0)
                    {
                        MessageBox.Show("입력하신 대분류의 정보가 존재하지 않습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    sql += "update tb_고객등록 set 유입경로대분류=" + int변환대분류ID + " " + System.Environment.NewLine;
                    sql += " where 유입경로대분류=" + int대분류ID + " " + System.Environment.NewLine;
                }
                else if (str항목 == "소분류")
                {
                    int int소분류ID = 0;
                    int int변환소분류ID = 0;
                    int소분류ID = this.getData소분류정보ID(str변환이필요한값);
                    int변환소분류ID = this.getData소분류정보ID(str변화된값);

                    if (int소분류ID == 0 || int변환소분류ID == 0)
                    {
                        MessageBox.Show("입력하신 소분류의 정보가 존재하지 않습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    sql += "update tb_고객등록 set 유입경로소분류=" + int변환소분류ID + " " + System.Environment.NewLine;
                    sql += " where 유입경로소분류=" + int소분류ID + " " + System.Environment.NewLine;
                }
                else
                {
                    sql += "update tb_고객등록 set " + str항목 + "='" + str변화된값 + "' " + System.Environment.NewLine;
                    if (str항목 == "수정일자")
                    {
                        str항목 = "convert(nvarchar," + str항목 + ",23)";
                        sql += " where " + str항목 + "='" + str변환이필요한값 + "' " + System.Environment.NewLine;
                    }
                    else
                    {
                        sql += " where " + str항목 + "='" + str변환이필요한값 + "' " + System.Environment.NewLine;
                    }
                }
                int result = this._SQLServer.Command_SQL(sql);
                if (result > 0)
                {
                    MessageBox.Show("변환이 완료 되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
