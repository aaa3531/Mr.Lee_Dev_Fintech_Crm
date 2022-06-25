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
    public partial class 상태설정 : Form
    {
        private SQLServer _SQLServer;
        private userInfo _userInfo;

        private bool IsMouseMoveStart;
        private Point mousePoint;

        private int _int상태설정ID;

        public 상태설정()
        {
            InitializeComponent();
            this._SQLServer = SQLServer.Instance();
            this._userInfo = userInfo.Instance();

            this.lblTopBar.MouseDown += this.Form_MouseDown;
            this.lblTopBar.MouseMove += this.Form_MouseMove;
            this.lblTopBar.MouseUp += this.Form_MouseUp;

            this.lblTopBar.Parent = this.picMain;
            this.lblClose.Parent = this.picMain;

            this.lbl추가.Parent = this.picMain;
            this.lbl저장.Parent = this.picMain;
            this.lbl삭제.Parent = this.picMain;
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
            this.DialogResult = DialogResult.OK;
        }

        private void 상태설정_Load(object sender, EventArgs e)
        {
            this.settingData상태설정();
        }

        private void settingData상태설정()
        {
            try
            {
                this.grdWork.Rows.Count = 1;
                this.grdWork.Cols.Count = 4;
                this.grdWork[0, 2] = "진행상태";
                this.grdWork.Cols[0].Visible = false;
                this.grdWork.Cols[1].Visible = false;
                this.grdWork.Cols[3].Visible = false;

                string sql = "";
                sql += "select 상태설정ID, 내용, 순서=isnull(순서,0) " + System.Environment.NewLine;
                sql += "from tb_상태설정 " + System.Environment.NewLine;
                sql += "order by isnull(순서,0) " + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this.grdWork.Rows.Count++;
                    int maxRows = this.grdWork.Rows.Count - 1;
                    this.grdWork[maxRows, 1] = sd["상태설정ID"];
                    this.grdWork[maxRows, 2] = sd["내용"];
                    this.grdWork[maxRows, 3] = sd["순서"];
                }
                sd.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void lbl추가_Click(object sender, EventArgs e)
        {
            this.Save상태설정Data();
        }

        private void Save상태설정Data()
        {
            try
            {
                if (this.txt상태설정.Text.Trim() == "")
                {
                    MessageBox.Show("상태 내용을 입력해 주시기 바랍니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show("추가하시겠습니까?", "상태 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;

                string sql = "";
                sql += "insert into tb_상태설정 ( " + System.Environment.NewLine;
                sql += "       [내용] ) " + System.Environment.NewLine;
                sql += "values ( " + System.Environment.NewLine;
                sql += "       @내용 ) " + System.Environment.NewLine;

                this._SQLServer.paraClear();
                this._SQLServer.addPara("내용", this.txt상태설정.Text.Trim(), SqlDbType.NVarChar);
                this._SQLServer.Command_SQL(sql);

                this.txt상태설정.Clear();
                this.settingData상태설정();
            }

            catch (Exception ex)
            {
            }

        }

        private void lbl삭제_Click(object sender, EventArgs e)
        {
            this.deleteData상태설정();
        }

        private void deleteData상태설정()
        {
            try
            {
                if (MessageBox.Show("삭제하시겠습니까?", "상태 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                string sql = "";
                sql += "delete from tb_상태설정 where 상태설정ID =" + this._int상태설정ID + "" + System.Environment.NewLine;
                this._SQLServer.Command_SQL(sql);
                this.txt상태설정.Clear();
                this._int상태설정ID = 0;
                this.settingData상태설정();
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
            this._int상태설정ID = Convert.ToInt32(this.grdWork[row, 1]);
            this.txt상태설정.Text = Convert.ToString(this.grdWork[row, 2]);
        }

        private void lbl저장_Click(object sender, EventArgs e)
        {
            this.update상태설정Data();
        }

        private void update상태설정Data()
        {
            try
            {
                if (MessageBox.Show("변경하시겠습니까?", "가입반 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                string str정보 = this.txt상태설정.Text.Trim();
                string sql = "";
                sql += "update tb_상태설정 set 내용 = '" + str정보 + "' " + System.Environment.NewLine;
                sql += "where 상태설정ID= '" + this._int상태설정ID + "' " + System.Environment.NewLine;

                int result = this._SQLServer.Command_SQL(sql);
                if (result > 0)
                {
                    MessageBox.Show("변환이 완료 되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.txt상태설정.Clear();
                this.settingData상태설정();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
