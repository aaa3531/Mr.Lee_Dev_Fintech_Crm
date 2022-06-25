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
    public partial class frm사용자관리 : Form
    {
        private SQLServer _SQLServer;

        private bool IsMouseMoveStart;
        private Point mousePoint;

        public frm사용자관리()
        {
            InitializeComponent();
            this._SQLServer = SQLServer.Instance();

            this.lblTopBar.MouseDown += this.Form_MouseDown;
            this.lblTopBar.MouseMove += this.Form_MouseMove;
            this.lblTopBar.MouseUp += this.Form_MouseUp;

            this.lblTopBar.Parent = this.picMain;
            this.lblClose.Parent = this.picMain;

            this.lbl사용자검색.Parent = this.picMain;
            this.lbl사용자추가.Parent = this.picMain;
            this.lbl사용자편집.Parent = this.picMain;
            this.lbl삭제하기.Parent = this.picMain;
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
        private void setComboBoxData()
        {
            try
            {
                DataTable dt = getConfig.getDt소속팀정보(this._SQLServer, 0);
                this.cbo소속팀.ItemsDataSource = dt;
                this.cbo소속팀.ItemsDisplayMember = "소속팀명";
                this.cbo소속팀.ItemsValueMember = "소속팀정보ID";
                this.cbo소속팀.TranslateValue = true;
                DataRow row = dt.NewRow();
                row["소속팀정보ID"] = 0;
                row["소속팀명"] = "전체";
                dt.Rows.InsertAt(row, 0);
                this.cbo소속팀.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
            }
        }
        private void frm사용자관리_Load(object sender, EventArgs e)
        {
            this.setComboBoxData();
            this.viewData사용자정보();
        }
        private void viewData사용자정보()
        {
            try
            {
                string sql = "";
                sql += "select a.[사용자정보ID], a.[사용자ID], a.[이름], d.[본부], b.[소속팀명], a.[휴대폰], " + System.Environment.NewLine;
                sql += "       a.[내선] " + System.Environment.NewLine;
                sql += "from   tb_사용자정보 a left join tb_소속팀정보 b" + System.Environment.NewLine;
                sql += "on     a.소속팀정보ID=b.소속팀정보ID" + System.Environment.NewLine;
                sql += "left join tb_본부설정 d " + System.Environment.NewLine;
                sql += "on     b.본부설정ID=d.본부설정ID " + System.Environment.NewLine;
                sql += "where  1=1" + System.Environment.NewLine;

                if (this.cbo소속팀.SelectedIndex > 0)
                    sql += "and b.소속팀정보ID=" + this.cbo소속팀.SelectedItem + "" + System.Environment.NewLine;

                if (this.txt사용자ID.Text.Trim() != "")
                    sql += "and a.사용자ID like '%" + this.txt사용자ID.Text.Trim() + "'" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                this.grdWork.DataSource = dt;
                this.grdWork.Cols[0].Visible = false;
                this.grdWork.Cols[1].Visible = false;
            }
            catch (Exception ex)
            {
            }
        }

        private void lbl사용자검색_Click(object sender, EventArgs e)
        {
            this.viewData사용자정보();
        }

        private void txt사용자ID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.viewData사용자정보();
        }

        private void lbl사용자추가_Click(object sender, EventArgs e)
        {
            frm사용자추가 f사용자추가 = new frm사용자추가(0);
            f사용자추가.ShowDialog();
        }

        private void grdWork_DoubleClick(object sender, EventArgs e)
        {
            int row = this.grdWork.MouseRow;
            if (row < 1)
                return;
            int int사용자정보ID = Convert.ToInt32(this.grdWork[row, 1]);
            frm사용자추가 f사용자추가 = new frm사용자추가(int사용자정보ID);
            f사용자추가.ShowDialog();
        }

        private void lbl삭제하기_Click(object sender, EventArgs e)
        {
            this.deleteData사용자정보();
        }
        private void deleteData사용자정보()
        {
            try
            {
                int row = this.grdWork.RowSel;
                string str사용자ID = Convert.ToString(this.grdWork[row, 1]);
                string str사용자이름 = Convert.ToString(this.grdWork[row, 2]);

                if (MessageBox.Show("사용자ID : " + str사용자ID + System.Environment.NewLine + "이름 : " + str사용자이름 + System.Environment.NewLine + System.Environment.NewLine + "삭제하시겠습니까?", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;

                int int사용자정보ID = Convert.ToInt32(this.grdWork[row, 1]);
                string sql = "";
                sql += "delete from tb_사용자정보 where 사용자정보ID=" + int사용자정보ID + "" + System.Environment.NewLine;
                int result = this._SQLServer.Command_SQL(sql);
                if (result > 0)
                {
                    this.viewData사용자정보();
                    MessageBox.Show("삭제가 완료되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void lbl사용자편집_Click(object sender, EventArgs e)
        {
            int row = this.grdWork.RowSel;
            int int사용자정보ID = Convert.ToInt32(this.grdWork[row, 1]);
            frm사용자추가 f사용자추가 = new frm사용자추가(int사용자정보ID);
            f사용자추가.ShowDialog();
        }
    }
}
