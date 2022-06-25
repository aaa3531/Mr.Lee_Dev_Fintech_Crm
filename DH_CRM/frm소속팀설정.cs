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

namespace DH_CRM
{
    public partial class frm소속팀설정 : Form
    {
        private SQLServer _SQLServer;
        private userInfo _userInfo;

        private bool IsMouseMoveStart;
        private Point mousePoint;

        private int _int소속팀정보ID;
        private int _int본부설정ID;
        public frm소속팀설정()
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
            this.lbl추가2.Parent = this.picMain;
            this.lbl수정2.Parent = this.picMain;
            this.lbl삭제2.Parent = this.picMain;
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
            this.updateData본부idx();
            this.updateData소속팀idx();
            this.Close();
        }

        private void frm소속팀설정_Load(object sender, EventArgs e)
        {
            this.settingData본부설정();
            this.viewData소속팀정보(0);
        }
        private void viewData소속팀정보(int 본부설정ID)
        {
            try
            {
                //2021-03-06 임권호
                this.grdWork.Rows.Count = 1;
                this.grdWork.Cols.Count = 4;
                this.grdWork[0, 2] = "소속팀명";
                this.grdWork.Cols[0].Visible = false;
                this.grdWork.Cols[1].Visible = false;
                this.grdWork.Cols[3].Visible = false;

                string sql = "";
                sql += "select 소속팀정보ID, 소속팀명, 순서=isnull(순서,0) " + System.Environment.NewLine;
                sql += "from   tb_소속팀정보" + System.Environment.NewLine;
                sql += "where  본부설정ID=" + 본부설정ID + "" + System.Environment.NewLine;
                sql += "order by isnull(순서,0)" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this.grdWork.Rows.Count++;
                    int maxRows = this.grdWork.Rows.Count - 1;
                    this.grdWork[maxRows, 1] = sd["소속팀정보ID"];
                    this.grdWork[maxRows, 2] = sd["소속팀명"];
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
            this.addData소속팀정보();
        }
        private bool checkData소속팀정보()
        {
            try
            {
                bool isData = false;
                string sql = "";
                sql += "select 소속팀정보ID" + System.Environment.NewLine;
                sql += "from   tb_소속팀정보" + System.Environment.NewLine;
                sql += "where  소속팀명='" + this.txt소속팀명.Text.Trim() + "'" + System.Environment.NewLine;
                sql += "and    본부설정ID=" + this._int본부설정ID + "" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    isData = true;
                }
                sd.Close();
                return isData;
            }
            catch (Exception ex)
            {
            }
            return false;
        }
        private void addData소속팀정보()
        {
            try
            {
                if (this.txt소속팀명.Text.Trim() == "")
                    return;
                if (checkData소속팀정보())
                {
                    MessageBox.Show("이미 중복된 소속팀 명칭이 존재합니다. 확인하시기 바랍니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (MessageBox.Show("추가하시겠습니까?", "소속팀 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                string sql = "";
                if (this._int소속팀정보ID == 0)
                {
                    sql += "insert into tb_소속팀정보(" + System.Environment.NewLine;
                    sql += "       [소속팀명], [등록자], [등록일자], [수정자], [수정일자], " + System.Environment.NewLine;
                    sql += "       [본부설정ID] )" + System.Environment.NewLine;
                    sql += "values (" + System.Environment.NewLine;
                    sql += "       @소속팀명, @등록자, @등록일자, @수정자, @수정일자," + System.Environment.NewLine;
                    sql += "       @본부설정ID )" + System.Environment.NewLine;
                    sql += "select convert(int,scope_identity())" + System.Environment.NewLine;
                }
                else
                {
                    sql += "update tb_소속팀정보 set" + System.Environment.NewLine;
                    sql += "       [소속팀명]=@소속팀명, [수정자]=@수정자, [수정일자]=@수정일자" + System.Environment.NewLine;
                    sql += "where  소속팀정보ID=@소속팀정보ID" + System.Environment.NewLine;
                }
                this._SQLServer.paraClear();
                this._SQLServer.addPara("소속팀명", this.txt소속팀명.Text.Trim(), SqlDbType.NVarChar);
                if (this._int소속팀정보ID == 0)
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
                this._SQLServer.addPara("본부설정ID", this._int본부설정ID, SqlDbType.Int);

                this._int소속팀정보ID = this._SQLServer.Command_SQL(sql, "소속팀정보ID", this._int소속팀정보ID);

                if (this._int소속팀정보ID > 0)
                {
                    this.controlClear();
                    this.viewData소속팀정보(0);
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void controlClear()
        {
            this._int소속팀정보ID = 0;
            this.txt소속팀명.Clear();
        }

        private void lbl저장_Click(object sender, EventArgs e)
        {
            this.addData소속팀정보();
        }

        private void lbl삭제_Click(object sender, EventArgs e)
        {
            this.deleteData소속팀정보();
        }
        private void deleteData소속팀정보()
        {
            try
            {
                if (this._int소속팀정보ID == 0)
                    return;
                if (MessageBox.Show("선택한 소속팀정보를 삭제하시겠습니까?", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;
                string sql = "";
                sql += "delete from tb_소속팀정보 where 소속팀정보ID=" + this._int소속팀정보ID + "" + System.Environment.NewLine;
                int result = this._SQLServer.Command_SQL(sql);
                if (result > 0)
                {
                    this.controlClear();
                    this.viewData소속팀정보(0);
                }
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
            this._int소속팀정보ID = Convert.ToInt32(this.grdWork[row, 1]);
            this.txt소속팀명.Text = Convert.ToString(this.grdWork[row, 2]);
            this.viewData소속팀정보(this._int본부설정ID);
        }

        private void settingData본부설정()
        {
            try
            {
                //2021-03-06 임권호
                this.grdWork2.Rows.Count = 1;
                this.grdWork2.Cols.Count = 4;
                this.grdWork2[0, 2] = "본부";
                this.grdWork2.Cols[0].Visible = false;
                this.grdWork2.Cols[1].Visible = false;
                this.grdWork2.Cols[3].Visible = false;

                string sql = "";
                sql += "select 본부설정ID, 본부, 순서=isnull(순서,0) " + System.Environment.NewLine;
                sql += "from tb_본부설정 " + System.Environment.NewLine;
                sql += "order by isnull(순서,0)" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this.grdWork2.Rows.Count++;
                    int maxRows = this.grdWork2.Rows.Count - 1;
                    this.grdWork2[maxRows, 1] = sd["본부설정ID"];
                    this.grdWork2[maxRows, 2] = sd["본부"];
                    this.grdWork2[maxRows, 3] = sd["순서"];
                }
                sd.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void lbl추가2_Click(object sender, EventArgs e)
        {
            this.saveData본부설정();
        }

        private void saveData본부설정()
        {
            try
            {
                if (MessageBox.Show("추가하시겠습니까?", "본부 설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                    return;

                if (this.txt본부설정.Text.Trim() == "")
                {
                    MessageBox.Show("본부명을 입력하시기 바랍니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string sql = "";
                sql += "insert into tb_본부설정 ( " + System.Environment.NewLine;
                sql += "          본부) " + System.Environment.NewLine;
                sql += "values ( " + System.Environment.NewLine;
                sql += "          @본부) " + System.Environment.NewLine;
                sql += "select convert(int,scope_identity())" + System.Environment.NewLine;

                this._SQLServer.paraClear();
                this._SQLServer.addPara("본부", this.txt본부설정.Text, SqlDbType.NVarChar);
                this._SQLServer.addPara("본부설정ID", 0, SqlDbType.Int);
                this._SQLServer.Command_SQL(sql);

                this.settingData본부설정();
            }
            catch (Exception ex)
            {
            }
        }

        private void grdWork2_DoubleClick(object sender, EventArgs e)
        {
            int row = this.grdWork2.MouseRow;
            if (row < 1)
                return;
            this._int본부설정ID = Convert.ToInt32(this.grdWork2[row, 1]);
            this.txt본부설정.Text = Convert.ToString(grdWork2[row, 2]);
            this.viewData소속팀정보(this._int본부설정ID);
        }

        private void lbl삭제2_Click(object sender, EventArgs e)
        {
            //2021-10-26 이찬명
            if (MessageBox.Show("삭제하시겠습니까?", "본부설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string sql = "delete from tb_본부설정 where 본부설정ID=" + _int본부설정ID + "" + System.Environment.NewLine;
                sql += "delete from tb_소속팀정보 where 본부설정ID=" + _int본부설정ID + "";

                int result = this._SQLServer.Command_SQL(sql);

                if (result > 0)
                {
                    this.txt본부설정.Clear();
                    this.settingData본부설정();
                    MessageBox.Show("삭제되었습니다");
                }
            }
        }

        private void lbl수정2_Click(object sender, EventArgs e)
        {
            if (this.txt본부설정.Text.Trim() == "")
            {
                MessageBox.Show("본부명을 입력하시기 바랍니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("변경하시겠습니까?", "본부설정", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            string str정보 = this.txt본부설정.Text.Trim();
            string sql = "";
            sql += "update tb_본부설정 set 본부 = '" + str정보 + "' " + System.Environment.NewLine;
            sql += "where 본부설정ID = '" + this._int본부설정ID + "' " + System.Environment.NewLine;

            int result = this._SQLServer.Command_SQL(sql);
            if (result > 0)
            {
                MessageBox.Show("변환이 완료 되었습니다.", Assembly.GetEntryAssembly().GetName().Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.txt본부설정.Clear();
            this.settingData본부설정();
        }

        private void grdWork2_DragDrop(object sender, DragEventArgs e)
        {
            C1FlexGrid flex = (C1FlexGrid)sender;
            Point pt = flex.PointToClient(new Point(e.X, e.Y));
            HitTestInfo hti = flex.HitTest(pt.X, pt.Y);

            //newindex - the index where the row is to be moved to
            //oldindex - the index from where the row was moved from
            int newindex = hti.Row;
            int oldindex = flex.RowSel;

            if (newindex < 0)
                newindex = flex.Rows.Count;

            if (newindex < 1)
                newindex = 1;

            C1.Win.C1FlexGrid.Row row = default(C1.Win.C1FlexGrid.Row);

            //going upwards
            if (oldindex > 1 & newindex < oldindex)
            {
                row = flex.Rows[oldindex];
            }

            //coming downwards
            if (newindex > oldindex & (oldindex + 1) < flex.Rows.Count)
            {
                row = flex.Rows[oldindex + 1];
            }

            // remove the row from the earlier position
            flex.Rows.Remove(oldindex);

            // if the row to be added is the last row
            if (newindex > flex.Rows.Count)
            {
                //insert a new row at the drop position
                flex.Rows.Insert(newindex - 1);

                //copy data from source row
                flex.Select(newindex - 1, 0, newindex - 1, flex.Cols.Count - 1, false);
                flex.Clip = Convert.ToString(e.Data.GetData(typeof(string)));
            }
            else
            {
                //insert a new row at the drop position
                flex.Rows.Insert(newindex);

                //copy data from source row
                flex.Select(newindex, 0, newindex, flex.Cols.Count - 1, false);
                flex.Clip = Convert.ToString(e.Data.GetData(typeof(string)));

            }

            flex.Rows.Insert(oldindex);
        }

        private void grdWork_DragDrop(object sender, DragEventArgs e)
        {
            C1FlexGrid flex = (C1FlexGrid)sender;
            Point pt = flex.PointToClient(new Point(e.X, e.Y));
            HitTestInfo hti = flex.HitTest(pt.X, pt.Y);

            //newindex - the index where the row is to be moved to
            //oldindex - the index from where the row was moved from
            int newindex = hti.Row;
            int oldindex = flex.RowSel;

            if (newindex < 0)
                newindex = flex.Rows.Count;

            if (newindex < 1)
                newindex = 1;

            C1.Win.C1FlexGrid.Row row = default(C1.Win.C1FlexGrid.Row);

            //going upwards
            if (oldindex > 1 & newindex < oldindex)
            {
                row = flex.Rows[oldindex];
            }

            //coming downwards
            if (newindex > oldindex & (oldindex + 1) < flex.Rows.Count)
            {
                row = flex.Rows[oldindex + 1];
            }

            // remove the row from the earlier position
            flex.Rows.Remove(oldindex);

            // if the row to be added is the last row
            if (newindex > flex.Rows.Count)
            {
                //insert a new row at the drop position
                flex.Rows.Insert(newindex - 1);

                //copy data from source row
                flex.Select(newindex - 1, 0, newindex - 1, flex.Cols.Count - 1, false);
                flex.Clip = Convert.ToString(e.Data.GetData(typeof(string)));
            }
            else
            {
                //insert a new row at the drop position
                flex.Rows.Insert(newindex);

                //copy data from source row
                flex.Select(newindex, 0, newindex, flex.Cols.Count - 1, false);
                flex.Clip = Convert.ToString(e.Data.GetData(typeof(string)));

            }

            flex.Rows.Insert(oldindex);
        }

        private void grdWork2_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void grdWork_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void grdWork2_BeforeMouseDown(object sender, BeforeMouseDownEventArgs e)
        {
            HitTestInfo hti = this.grdWork2.HitTest(e.X, e.Y);
            if (hti.Type == HitTestTypeEnum.Cell)
            {
                //select the row 
                int index = hti.Row;
                this.grdWork2.Select(index, 0, index, this.grdWork2.Cols.Count - 1, false);

                //save info for target
                // _src = this.grdList5;

                //do drag drop
                DragDropEffects dd = this.grdWork2.DoDragDrop(this.grdWork2.Clip, DragDropEffects.Move);

                //if it worked, delete row from source (it's a move) 
                if (dd == DragDropEffects.Move)
                {
                    this.grdWork2.Rows.Remove(index);
                }

                if (this.grdWork.Rows.Count - 1 > 0)
                    this.updateData소속팀idx();
                    //done, reset info
                    //_src = null;
                this._int본부설정ID = Convert.ToInt32(this.grdWork2[index, 1]);
                this.txt본부설정.Text = Convert.ToString(this.grdWork2[index, 2]);
                this.viewData소속팀정보(this._int본부설정ID);
            }
        }
        private void updateData본부idx()
        {
            try
            {
                for (int i = 1; i < this.grdWork2.Rows.Count; i++)
                {
                    int int본부설정ID = Convert.ToInt32(this.grdWork2[i, 1]);
                    string sql = "";
                    sql += "update tb_본부설정 set 순서=" + i + "" + System.Environment.NewLine;
                    sql += "where  본부설정ID=" + int본부설정ID + "" + System.Environment.NewLine;

                    this._SQLServer.Command_SQL(sql);
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void updateData소속팀idx()
        {
            try
            {
                for (int i = 1; i < this.grdWork.Rows.Count; i++)
                {
                    int int소속팀정보ID = Convert.ToInt32(this.grdWork[i, 1]);
                    string sql = "";
                    sql += "update tb_소속팀정보 set 순서=" + i + "" + System.Environment.NewLine;
                    sql += "where  소속팀정보ID=" + int소속팀정보ID + "" + System.Environment.NewLine;

                    this._SQLServer.Command_SQL(sql);
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void grdWork_BeforeMouseDown(object sender, BeforeMouseDownEventArgs e)
        {
            HitTestInfo hti = this.grdWork.HitTest(e.X, e.Y);
            if (hti.Type == HitTestTypeEnum.Cell)
            {
                //select the row 
                int index = hti.Row;
                this.grdWork.Select(index, 0, index, this.grdWork.Cols.Count - 1, false);

                //save info for target
                //_src = this.grdList6;

                //do drag drop
                DragDropEffects dd = this.grdWork.DoDragDrop(this.grdWork.Clip, DragDropEffects.Move);

                //if it worked, delete row from source (it's a move) 
                if (dd == DragDropEffects.Move)
                {
                    this.grdWork.Rows.Remove(index);
                }

                //done, reset info
                //_src = null;
                this._int소속팀정보ID = Convert.ToInt32(this.grdWork[index, 1]);
                this.txt소속팀명.Text = Convert.ToString(this.grdWork[index, 2]);
            }
        }
    }
}
