namespace DH_CRM
{
    partial class frm공휴일정보
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm공휴일정보));
            this.picMain = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTopBar = new System.Windows.Forms.Label();
            this.grdWork = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.txt날짜 = new C1.Win.C1Input.C1TextBox();
            this.txt기념일제목 = new C1.Win.C1Input.C1TextBox();
            this.lbl저장 = new System.Windows.Forms.Label();
            this.chk휴일 = new System.Windows.Forms.CheckBox();
            this.chk음력 = new System.Windows.Forms.CheckBox();
            this.lbl추가 = new System.Windows.Forms.Label();
            this.lbl삭제 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt날짜)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt기념일제목)).BeginInit();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.BackColor = System.Drawing.SystemColors.Control;
            this.picMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(0, 0);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(463, 538);
            this.picMain.TabIndex = 12;
            this.picMain.TabStop = false;
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClose.Location = new System.Drawing.Point(431, 6);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 28);
            this.lblClose.TabIndex = 103;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblTopBar
            // 
            this.lblTopBar.BackColor = System.Drawing.Color.Transparent;
            this.lblTopBar.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTopBar.Location = new System.Drawing.Point(6, 6);
            this.lblTopBar.Name = "lblTopBar";
            this.lblTopBar.Size = new System.Drawing.Size(419, 28);
            this.lblTopBar.TabIndex = 102;
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
            this.grdWork.Location = new System.Drawing.Point(8, 65);
            this.grdWork.Name = "grdWork";
            this.grdWork.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdWork.Size = new System.Drawing.Size(449, 335);
            this.grdWork.StyleInfo = resources.GetString("grdWork.StyleInfo");
            this.grdWork.TabIndex = 104;
            this.grdWork.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            // 
            // txt날짜
            // 
            this.txt날짜.AutoSize = false;
            this.txt날짜.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt날짜.Location = new System.Drawing.Point(110, 408);
            this.txt날짜.Name = "txt날짜";
            this.txt날짜.Size = new System.Drawing.Size(78, 29);
            this.txt날짜.TabIndex = 105;
            this.txt날짜.Tag = null;
            this.txt날짜.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt날짜.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // txt기념일제목
            // 
            this.txt기념일제목.AutoSize = false;
            this.txt기념일제목.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt기념일제목.Location = new System.Drawing.Point(289, 409);
            this.txt기념일제목.Name = "txt기념일제목";
            this.txt기념일제목.Size = new System.Drawing.Size(169, 29);
            this.txt기념일제목.TabIndex = 106;
            this.txt기념일제목.Tag = null;
            this.txt기념일제목.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt기념일제목.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // lbl저장
            // 
            this.lbl저장.BackColor = System.Drawing.Color.Transparent;
            this.lbl저장.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl저장.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl저장.Location = new System.Drawing.Point(188, 495);
            this.lbl저장.Name = "lbl저장";
            this.lbl저장.Size = new System.Drawing.Size(81, 32);
            this.lbl저장.TabIndex = 107;
            this.lbl저장.Click += new System.EventHandler(this.lbl저장_Click);
            // 
            // chk휴일
            // 
            this.chk휴일.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.chk휴일.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk휴일.Location = new System.Drawing.Point(8, 454);
            this.chk휴일.Name = "chk휴일";
            this.chk휴일.Size = new System.Drawing.Size(24, 21);
            this.chk휴일.TabIndex = 108;
            this.chk휴일.UseVisualStyleBackColor = false;
            // 
            // chk음력
            // 
            this.chk음력.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.chk음력.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk음력.Location = new System.Drawing.Point(82, 454);
            this.chk음력.Name = "chk음력";
            this.chk음력.Size = new System.Drawing.Size(24, 21);
            this.chk음력.TabIndex = 109;
            this.chk음력.UseVisualStyleBackColor = false;
            // 
            // lbl추가
            // 
            this.lbl추가.BackColor = System.Drawing.Color.Transparent;
            this.lbl추가.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl추가.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl추가.Location = new System.Drawing.Point(289, 448);
            this.lbl추가.Name = "lbl추가";
            this.lbl추가.Size = new System.Drawing.Size(81, 32);
            this.lbl추가.TabIndex = 110;
            this.lbl추가.Click += new System.EventHandler(this.lbl추가_Click);
            // 
            // lbl삭제
            // 
            this.lbl삭제.BackColor = System.Drawing.Color.Transparent;
            this.lbl삭제.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl삭제.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl삭제.Location = new System.Drawing.Point(375, 448);
            this.lbl삭제.Name = "lbl삭제";
            this.lbl삭제.Size = new System.Drawing.Size(81, 32);
            this.lbl삭제.TabIndex = 111;
            this.lbl삭제.Click += new System.EventHandler(this.lbl삭제_Click);
            // 
            // frm공휴일정보
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(463, 538);
            this.Controls.Add(this.lbl삭제);
            this.Controls.Add(this.lbl추가);
            this.Controls.Add(this.chk음력);
            this.Controls.Add(this.chk휴일);
            this.Controls.Add(this.lbl저장);
            this.Controls.Add(this.txt기념일제목);
            this.Controls.Add(this.txt날짜);
            this.Controls.Add(this.grdWork);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTopBar);
            this.Controls.Add(this.picMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm공휴일정보";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "공휴일정보";
            this.Load += new System.EventHandler(this.frm공휴일정보_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt날짜)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt기념일제목)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblTopBar;
        private C1.Win.C1FlexGrid.C1FlexGrid grdWork;
        private C1.Win.C1Input.C1TextBox txt날짜;
        private C1.Win.C1Input.C1TextBox txt기념일제목;
        private System.Windows.Forms.Label lbl저장;
        private System.Windows.Forms.CheckBox chk휴일;
        private System.Windows.Forms.CheckBox chk음력;
        private System.Windows.Forms.Label lbl추가;
        private System.Windows.Forms.Label lbl삭제;
    }
}