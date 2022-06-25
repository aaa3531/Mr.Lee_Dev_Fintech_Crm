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
    public partial class frm공휴일정보 : Form
    {
        private SQLServer _SQLServer;

        private bool IsMouseMoveStart;
        private Point mousePoint;

        public frm공휴일정보()
        {
            InitializeComponent();
            this._SQLServer = SQLServer.Instance();

            this.lblTopBar.Parent = this.picMain;
            this.lblClose.Parent = this.picMain;

            this.lbl저장.Parent = this.picMain;
            this.lbl추가.Parent = this.picMain;
            this.lbl삭제.Parent = this.picMain;

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

        private void frm공휴일정보_Load(object sender, EventArgs e)
        {
            this.viewData공휴일정보();
        }
        private void viewData공휴일정보()
        {
            try
            {
                this.grdWork.Cols.Count = 6;
                this.grdWork.Rows.Count = 1;
                this.grdWork[0, 1] = "공휴일정보ID";
                this.grdWork[0, 2] = "일자(월-일)";
                this.grdWork[0, 3] = "기념일";
                this.grdWork.Cols[3].Width = 170;
                this.grdWork[0, 4] = "휴일";
                this.grdWork.Cols[4].Width = 78;
                this.grdWork.Cols[5].Width = 78;
                this.grdWork.Cols[4].DataType = typeof(bool);
                this.grdWork[0, 5] = "음력";
                this.grdWork.Cols[5].DataType = typeof(bool);

                this.grdWork.Cols[0].Visible = false;
                this.grdWork.Cols[1].Visible = false;

                string sql = "";
                sql += "select * " + System.Environment.NewLine;
                sql += "from   tb_공휴일정보" + System.Environment.NewLine;
                sql += "order by 일자 " + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.grdWork.Rows.Count++;
                    int maxRows = this.grdWork.Rows.Count - 1;
                    this.grdWork[maxRows, 1] = dt.Rows[i]["공휴일정보ID"];
                    this.grdWork[maxRows, 2] = dt.Rows[i]["일자"];
                    this.grdWork[maxRows, 3] = dt.Rows[i]["기념일"];
                    this.grdWork[maxRows, 4] = Convert.ToInt32(dt.Rows[i]["휴일"]);
                    this.grdWork[maxRows, 5] = Convert.ToInt32(dt.Rows[i]["음력"]);
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void controlClear()
        {
            this.txt날짜.Clear();
            this.chk휴일.Checked = false;
            this.chk음력.Checked = false;
            this.txt기념일제목.Clear();
        }

        private void lbl추가_Click(object sender, EventArgs e)
        {
            this.addData공휴일정보();
        }
        private void addData공휴일정보()
        {
            try
            {
                this.grdWork.Rows.Count++;
                int maxRows = this.grdWork.Rows.Count - 1;
                this.grdWork[maxRows, 1] = 0;
                this.grdWork[maxRows, 2] = this.txt날짜.Text;
                this.grdWork[maxRows, 3] = this.txt기념일제목.Text;
                this.grdWork[maxRows, 4] = this.chk휴일.Checked == true ? 1 : 0;
                this.grdWork[maxRows, 5] = this.chk음력.Checked == true ? 1 : 0;
            }
            catch (Exception ex)
            {
            }
        }
        private void delete공휴일정보()
        {
            int row = this.grdWork.RowSel;
            this.grdWork.Rows[row].Visible = false;
        }
        private void lbl삭제_Click(object sender, EventArgs e)
        {
            this.delete공휴일정보();
        }
        private void deleteData공휴일정보(int 공휴일정보ID)
        {
            try
            {
                string sql = "";
                sql += "delete from tb_공휴일정보 where 공휴일정보ID=" + 공휴일정보ID + "" + System.Environment.NewLine;
                this._SQLServer.Command_SQL(sql);
            }
            catch (Exception ex)
            {
            }
        }
        private void saveData공휴일정보()
        {
            try
            {
                if (MessageBox.Show("저장하시겠습니까?", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                int result = 0;
                for (int i = 1; i < this.grdWork.Rows.Count; i++)
                {
                    int int공휴일정보ID = Convert.ToInt32(this.grdWork[i, 1]);
                    if (this.grdWork.Rows[i].Visible == false)
                    {
                        if (int공휴일정보ID == 0)
                            continue;
                        this.deleteData공휴일정보(int공휴일정보ID);
                        continue;
                    }
                    string sql = "";
                    if (int공휴일정보ID == 0)
                    {
                        sql += "insert into tb_공휴일정보(" + System.Environment.NewLine;
                        sql += "       [일자], [기념일], [휴일], [음력])" + System.Environment.NewLine;
                        sql += "values (" + System.Environment.NewLine;
                        sql += "       @일자, @기념일, @휴일, @음력)" + System.Environment.NewLine;
                        sql += "select convert(int,scope_identity())" + System.Environment.NewLine;
                    }
                    else
                    {
                        sql += "update tb_공휴일정보 set" + System.Environment.NewLine;
                        sql += "       [일자]=@일자, [기념일]=@기념일, [휴일]=@휴일, [음력]=@음력" + System.Environment.NewLine;
                        sql += "where  공휴일정보ID=@공휴일정보ID" + System.Environment.NewLine;
                    }
                    this._SQLServer.paraClear();
                    this._SQLServer.addPara("일자", this.grdWork[i, 2], SqlDbType.NVarChar);
                    this._SQLServer.addPara("기념일", this.grdWork[i, 3], SqlDbType.NVarChar);
                    this._SQLServer.addPara("휴일", Convert.ToInt32(this.grdWork[i, 4]), SqlDbType.TinyInt);
                    this._SQLServer.addPara("음력", Convert.ToInt32(this.grdWork[i, 5]), SqlDbType.TinyInt);
                    int공휴일정보ID = this._SQLServer.Command_SQL(sql, "공휴일정보ID", int공휴일정보ID);
                    this.grdWork[i, 1] = int공휴일정보ID;
                    result += int공휴일정보ID;
                }
                if (result > 0)
                {
                    MessageBox.Show("저장이 완료되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void lbl저장_Click(object sender, EventArgs e)
        {
            this.saveData공휴일정보();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
