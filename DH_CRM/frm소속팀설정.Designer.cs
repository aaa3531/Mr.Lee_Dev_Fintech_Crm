namespace DH_CRM
{
    partial class frm소속팀설정
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm소속팀설정));
            this.picMain = new System.Windows.Forms.PictureBox();
            this.txt소속팀명 = new C1.Win.C1Input.C1TextBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTopBar = new System.Windows.Forms.Label();
            this.lbl추가 = new System.Windows.Forms.Label();
            this.lbl삭제 = new System.Windows.Forms.Label();
            this.lbl저장 = new System.Windows.Forms.Label();
            this.txt본부설정 = new C1.Win.C1Input.C1TextBox();
            this.lbl추가2 = new System.Windows.Forms.Label();
            this.lbl수정2 = new System.Windows.Forms.Label();
            this.lbl삭제2 = new System.Windows.Forms.Label();
            this.grdWork2 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.grdWork = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt소속팀명)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt본부설정)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).BeginInit();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.BackColor = System.Drawing.SystemColors.Control;
            this.picMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(0, 0);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(636, 555);
            this.picMain.TabIndex = 11;
            this.picMain.TabStop = false;
            // 
            // txt소속팀명
            // 
            this.txt소속팀명.AutoSize = false;
            this.txt소속팀명.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt소속팀명.Location = new System.Drawing.Point(325, 438);
            this.txt소속팀명.Name = "txt소속팀명";
            this.txt소속팀명.Size = new System.Drawing.Size(299, 47);
            this.txt소속팀명.TabIndex = 90;
            this.txt소속팀명.Tag = null;
            this.txt소속팀명.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt소속팀명.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClose.Location = new System.Drawing.Point(595, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 28);
            this.lblClose.TabIndex = 92;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblTopBar
            // 
            this.lblTopBar.BackColor = System.Drawing.Color.Transparent;
            this.lblTopBar.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTopBar.Location = new System.Drawing.Point(9, 9);
            this.lblTopBar.Name = "lblTopBar";
            this.lblTopBar.Size = new System.Drawing.Size(580, 28);
            this.lblTopBar.TabIndex = 91;
            // 
            // lbl추가
            // 
            this.lbl추가.BackColor = System.Drawing.Color.Transparent;
            this.lbl추가.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl추가.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl추가.Location = new System.Drawing.Point(327, 492);
            this.lbl추가.Name = "lbl추가";
            this.lbl추가.Size = new System.Drawing.Size(94, 50);
            this.lbl추가.TabIndex = 93;
            this.lbl추가.Click += new System.EventHandler(this.lbl추가_Click);
            // 
            // lbl삭제
            // 
            this.lbl삭제.BackColor = System.Drawing.Color.Transparent;
            this.lbl삭제.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl삭제.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl삭제.Location = new System.Drawing.Point(428, 492);
            this.lbl삭제.Name = "lbl삭제";
            this.lbl삭제.Size = new System.Drawing.Size(94, 50);
            this.lbl삭제.TabIndex = 94;
            this.lbl삭제.Click += new System.EventHandler(this.lbl삭제_Click);
            // 
            // lbl저장
            // 
            this.lbl저장.BackColor = System.Drawing.Color.Transparent;
            this.lbl저장.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl저장.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl저장.Location = new System.Drawing.Point(529, 493);
            this.lbl저장.Name = "lbl저장";
            this.lbl저장.Size = new System.Drawing.Size(94, 50);
            this.lbl저장.TabIndex = 95;
            this.lbl저장.Click += new System.EventHandler(this.lbl저장_Click);
            // 
            // txt본부설정
            // 
            this.txt본부설정.AutoSize = false;
            this.txt본부설정.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt본부설정.Location = new System.Drawing.Point(14, 438);
            this.txt본부설정.Name = "txt본부설정";
            this.txt본부설정.Size = new System.Drawing.Size(297, 47);
            this.txt본부설정.TabIndex = 97;
            this.txt본부설정.Tag = null;
            this.txt본부설정.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt본부설정.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // lbl추가2
            // 
            this.lbl추가2.BackColor = System.Drawing.Color.Transparent;
            this.lbl추가2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl추가2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl추가2.Location = new System.Drawing.Point(15, 492);
            this.lbl추가2.Name = "lbl추가2";
            this.lbl추가2.Size = new System.Drawing.Size(94, 50);
            this.lbl추가2.TabIndex = 98;
            this.lbl추가2.Click += new System.EventHandler(this.lbl추가2_Click);
            // 
            // lbl수정2
            // 
            this.lbl수정2.BackColor = System.Drawing.Color.Transparent;
            this.lbl수정2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl수정2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl수정2.Location = new System.Drawing.Point(216, 492);
            this.lbl수정2.Name = "lbl수정2";
            this.lbl수정2.Size = new System.Drawing.Size(94, 50);
            this.lbl수정2.TabIndex = 99;
            this.lbl수정2.Click += new System.EventHandler(this.lbl수정2_Click);
            // 
            // lbl삭제2
            // 
            this.lbl삭제2.BackColor = System.Drawing.Color.Transparent;
            this.lbl삭제2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl삭제2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl삭제2.Location = new System.Drawing.Point(115, 493);
            this.lbl삭제2.Name = "lbl삭제2";
            this.lbl삭제2.Size = new System.Drawing.Size(94, 50);
            this.lbl삭제2.TabIndex = 100;
            this.lbl삭제2.Click += new System.EventHandler(this.lbl삭제2_Click);
            // 
            // grdWork2
            // 
            this.grdWork2.AllowEditing = false;
            this.grdWork2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.grdWork2.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.grdWork2.DropMode = C1.Win.C1FlexGrid.DropModeEnum.Manual;
            this.grdWork2.ExtendLastCol = true;
            this.grdWork2.Location = new System.Drawing.Point(14, 88);
            this.grdWork2.Name = "grdWork2";
            this.grdWork2.Size = new System.Drawing.Size(298, 340);
            this.grdWork2.StyleInfo = resources.GetString("grdWork2.StyleInfo");
            this.grdWork2.TabIndex = 112;
            this.grdWork2.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            this.grdWork2.BeforeMouseDown += new C1.Win.C1FlexGrid.BeforeMouseDownEventHandler(this.grdWork2_BeforeMouseDown);
            this.grdWork2.DragDrop += new System.Windows.Forms.DragEventHandler(this.grdWork2_DragDrop);
            this.grdWork2.DragOver += new System.Windows.Forms.DragEventHandler(this.grdWork2_DragOver);
            // 
            // grdWork
            // 
            this.grdWork.AllowEditing = false;
            this.grdWork.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.grdWork.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.grdWork.DropMode = C1.Win.C1FlexGrid.DropModeEnum.Manual;
            this.grdWork.ExtendLastCol = true;
            this.grdWork.Location = new System.Drawing.Point(326, 88);
            this.grdWork.Name = "grdWork";
            this.grdWork.Size = new System.Drawing.Size(299, 340);
            this.grdWork.StyleInfo = resources.GetString("grdWork.StyleInfo");
            this.grdWork.TabIndex = 113;
            this.grdWork.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            this.grdWork.BeforeMouseDown += new C1.Win.C1FlexGrid.BeforeMouseDownEventHandler(this.grdWork_BeforeMouseDown);
            this.grdWork.DragDrop += new System.Windows.Forms.DragEventHandler(this.grdWork_DragDrop);
            this.grdWork.DragOver += new System.Windows.Forms.DragEventHandler(this.grdWork_DragOver);
            // 
            // frm소속팀설정
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(636, 555);
            this.Controls.Add(this.grdWork);
            this.Controls.Add(this.grdWork2);
            this.Controls.Add(this.lbl삭제2);
            this.Controls.Add(this.lbl수정2);
            this.Controls.Add(this.lbl추가2);
            this.Controls.Add(this.txt본부설정);
            this.Controls.Add(this.lbl저장);
            this.Controls.Add(this.lbl삭제);
            this.Controls.Add(this.lbl추가);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTopBar);
            this.Controls.Add(this.txt소속팀명);
            this.Controls.Add(this.picMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm소속팀설정";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "소속팀추가";
            this.Load += new System.EventHandler(this.frm소속팀설정_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt소속팀명)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt본부설정)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private C1.Win.C1Input.C1TextBox txt소속팀명;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblTopBar;
        private System.Windows.Forms.Label lbl추가;
        private System.Windows.Forms.Label lbl삭제;
        private System.Windows.Forms.Label lbl저장;
        private C1.Win.C1Input.C1TextBox txt본부설정;
        private System.Windows.Forms.Label lbl추가2;
        private System.Windows.Forms.Label lbl수정2;
        private System.Windows.Forms.Label lbl삭제2;
        private C1.Win.C1FlexGrid.C1FlexGrid grdWork2;
        private C1.Win.C1FlexGrid.C1FlexGrid grdWork;
    }
}