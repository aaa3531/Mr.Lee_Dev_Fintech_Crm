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
    public partial class frm연락처추가 : Form
    {
        private SQLServer _SQLServer;
        private bool IsMouseMoveStart;
        private Point mousePoint;
        public frm연락처추가()
        {
            InitializeComponent();
            this._SQLServer = SQLServer.Instance();

            this.lblTopBar.Parent = this.picMain;
            this.lblClose.Parent = this.picMain;

            this.lbl추가하기.Parent = this.picMain;

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

        private void frm연락처추가_Load(object sender, EventArgs e)
        {
            this.cbo회원목록.Items.Add("전체회원");
            this.cbo회원목록.SelectedIndex = 0;

            this.viewData회원정보();
        }
        private void viewData회원정보()
        {
            try
            {
                string sql = "";
                sql += "select 고객등록ID, 이름, 휴대전화" + System.Environment.NewLine;
                sql += "from   tb_고객등록" + System.Environment.NewLine;
                sql += "where  휴대전화<>''" + System.Environment.NewLine;
                sql += "order by 이름" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                this.grdWork.Redraw = false;
                this.grdWork.Cols[0].DataType = typeof(bool);
                this.grdWork.SetCellCheck(0, 0, C1.Win.C1FlexGrid.CheckEnum.Unchecked);
                this.grdWork.Cols[0].ImageAlignFixed = C1.Win.C1FlexGrid.ImageAlignEnum.CenterCenter;
                this.grdWork.DataSource = dt;
                this.grdWork.Cols[1].Visible = false;
                this.grdWork.Cols[2].Width = 130;
                for (int i = 1; i < this.grdWork.Cols.Count - 1; i++)
                {
                    this.grdWork.Cols[i + 1].AllowEditing = false;
                }
                this.grdWork.Redraw = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void lbl추가하기_Click(object sender, EventArgs e)
        {
            this.settingData회원정보();
        }
        private void settingData회원정보()
        {
            try
            {
                getConfig.dic연락처정보.Clear();
                for (int i = 1; i < this.grdWork.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(this.grdWork[i, 0]) == true)
                        getConfig.dic연락처정보.Add(Convert.ToInt32(this.grdWork[i, 1]), this.grdWork[i, 2].ToString() + "|" + this.grdWork[i, 3].ToString());
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
            }
        }

        private void grdwork_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
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

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
