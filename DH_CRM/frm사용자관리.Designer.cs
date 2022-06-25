namespace DH_CRM
{
    partial class frm사용자관리
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm사용자관리));
            this.picMain = new System.Windows.Forms.PictureBox();
            this.grdWork = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.lbl사용자검색 = new System.Windows.Forms.Label();
            this.lbl사용자추가 = new System.Windows.Forms.Label();
            this.lbl사용자편집 = new System.Windows.Forms.Label();
            this.lbl삭제하기 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTopBar = new System.Windows.Forms.Label();
            this.txt사용자ID = new C1.Win.C1Input.C1TextBox();
            this.cbo소속팀 = new C1.Win.C1Input.C1ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt사용자ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo소속팀)).BeginInit();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.BackColor = System.Drawing.SystemColors.Control;
            this.picMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(0, 0);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(744, 469);
            this.picMain.TabIndex = 10;
            this.picMain.TabStop = false;
            // 
            // grdWork
            // 
            this.grdWork.AllowEditing = false;
            this.grdWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdWork.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.grdWork.ColumnInfo = "10,1,0,0,0,-1,Columns:0{Style:\"TextAlign:GeneralCenter;\";}\t";
            this.grdWork.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.grdWork.ExtendLastCol = true;
            this.grdWork.Location = new System.Drawing.Point(8, 83);
            this.grdWork.Name = "grdWork";
            this.grdWork.Size = new System.Drawing.Size(724, 333);
            this.grdWork.StyleInfo = resources.GetString("grdWork.StyleInfo");
            this.grdWork.TabIndex = 39;
            this.grdWork.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            this.grdWork.DoubleClick += new System.EventHandler(this.grdWork_DoubleClick);
            // 
            // lbl사용자검색
            // 
            this.lbl사용자검색.BackColor = System.Drawing.Color.Transparent;
            this.lbl사용자검색.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl사용자검색.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl사용자검색.Location = new System.Drawing.Point(416, 42);
            this.lbl사용자검색.Name = "lbl사용자검색";
            this.lbl사용자검색.Size = new System.Drawing.Size(114, 34);
            this.lbl사용자검색.TabIndex = 94;
            this.lbl사용자검색.Click += new System.EventHandler(this.lbl사용자검색_Click);
            // 
            // lbl사용자추가
            // 
            this.lbl사용자추가.BackColor = System.Drawing.Color.Transparent;
            this.lbl사용자추가.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl사용자추가.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl사용자추가.Location = new System.Drawing.Point(176, 425);
            this.lbl사용자추가.Name = "lbl사용자추가";
            this.lbl사용자추가.Size = new System.Drawing.Size(114, 31);
            this.lbl사용자추가.TabIndex = 95;
            this.lbl사용자추가.Click += new System.EventHandler(this.lbl사용자추가_Click);
            // 
            // lbl사용자편집
            // 
            this.lbl사용자편집.BackColor = System.Drawing.Color.Transparent;
            this.lbl사용자편집.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl사용자편집.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl사용자편집.Location = new System.Drawing.Point(296, 425);
            this.lbl사용자편집.Name = "lbl사용자편집";
            this.lbl사용자편집.Size = new System.Drawing.Size(114, 31);
            this.lbl사용자편집.TabIndex = 96;
            this.lbl사용자편집.Click += new System.EventHandler(this.lbl사용자편집_Click);
            // 
            // lbl삭제하기
            // 
            this.lbl삭제하기.BackColor = System.Drawing.Color.Transparent;
            this.lbl삭제하기.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl삭제하기.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl삭제하기.Location = new System.Drawing.Point(416, 425);
            this.lbl삭제하기.Name = "lbl삭제하기";
            this.lbl삭제하기.Size = new System.Drawing.Size(114, 31);
            this.lbl삭제하기.TabIndex = 97;
            this.lbl삭제하기.Click += new System.EventHandler(this.lbl삭제하기_Click);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClose.Location = new System.Drawing.Point(707, 5);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 28);
            this.lblClose.TabIndex = 99;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblTopBar
            // 
            this.lblTopBar.BackColor = System.Drawing.Color.Transparent;
            this.lblTopBar.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTopBar.Location = new System.Drawing.Point(4, 5);
            this.lblTopBar.Name = "lblTopBar";
            this.lblTopBar.Size = new System.Drawing.Size(697, 28);
            this.lblTopBar.TabIndex = 98;
            // 
            // txt사용자ID
            // 
            this.txt사용자ID.AutoSize = false;
            this.txt사용자ID.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt사용자ID.Location = new System.Drawing.Point(76, 42);
            this.txt사용자ID.Name = "txt사용자ID";
            this.txt사용자ID.Size = new System.Drawing.Size(131, 29);
            this.txt사용자ID.TabIndex = 100;
            this.txt사용자ID.Tag = null;
            this.txt사용자ID.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt사용자ID.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            this.txt사용자ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt사용자ID_KeyDown);
            // 
            // cbo소속팀
            // 
            this.cbo소속팀.AllowSpinLoop = false;
            this.cbo소속팀.AutoSize = false;
            this.cbo소속팀.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo소속팀.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo소속팀.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo소속팀.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo소속팀.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo소속팀.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo소속팀.GapHeight = 0;
            this.cbo소속팀.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo소속팀.ItemsDisplayMember = "";
            this.cbo소속팀.ItemsValueMember = "";
            this.cbo소속팀.Location = new System.Drawing.Point(278, 42);
            this.cbo소속팀.Name = "cbo소속팀";
            this.cbo소속팀.Size = new System.Drawing.Size(132, 29);
            this.cbo소속팀.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo소속팀.TabIndex = 101;
            this.cbo소속팀.Tag = null;
            this.cbo소속팀.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo소속팀.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // frm사용자관리
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(744, 469);
            this.Controls.Add(this.cbo소속팀);
            this.Controls.Add(this.txt사용자ID);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTopBar);
            this.Controls.Add(this.lbl삭제하기);
            this.Controls.Add(this.lbl사용자편집);
            this.Controls.Add(this.lbl사용자추가);
            this.Controls.Add(this.lbl사용자검색);
            this.Controls.Add(this.grdWork);
            this.Controls.Add(this.picMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm사용자관리";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm사용자관리";
            this.Load += new System.EventHandler(this.frm사용자관리_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt사용자ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo소속팀)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private C1.Win.C1FlexGrid.C1FlexGrid grdWork;
        private System.Windows.Forms.Label lbl사용자검색;
        private System.Windows.Forms.Label lbl사용자추가;
        private System.Windows.Forms.Label lbl사용자편집;
        private System.Windows.Forms.Label lbl삭제하기;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblTopBar;
        private C1.Win.C1Input.C1TextBox txt사용자ID;
        private C1.Win.C1Input.C1ComboBox cbo소속팀;
    }
}