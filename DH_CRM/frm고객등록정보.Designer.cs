namespace DH_CRM
{
    partial class frm고객등록정보
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm고객등록정보));
            this.picMain = new System.Windows.Forms.PictureBox();
            this.txt고객명 = new C1.Win.C1Input.C1TextBox();
            this.lbl검색 = new System.Windows.Forms.Label();
            this.lblTopBar = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.grdWork = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt고객명)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).BeginInit();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.BackColor = System.Drawing.SystemColors.Control;
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(0, 0);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(610, 367);
            this.picMain.TabIndex = 10;
            this.picMain.TabStop = false;
            // 
            // txt고객명
            // 
            this.txt고객명.AutoSize = false;
            this.txt고객명.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt고객명.Location = new System.Drawing.Point(131, 38);
            this.txt고객명.Name = "txt고객명";
            this.txt고객명.Size = new System.Drawing.Size(307, 32);
            this.txt고객명.TabIndex = 90;
            this.txt고객명.Tag = null;
            this.txt고객명.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt고객명.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // lbl검색
            // 
            this.lbl검색.BackColor = System.Drawing.Color.Transparent;
            this.lbl검색.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl검색.Location = new System.Drawing.Point(442, 38);
            this.lbl검색.Name = "lbl검색";
            this.lbl검색.Size = new System.Drawing.Size(83, 32);
            this.lbl검색.TabIndex = 125;
            this.lbl검색.Click += new System.EventHandler(this.lbl검색_Click);
            // 
            // lblTopBar
            // 
            this.lblTopBar.BackColor = System.Drawing.Color.Transparent;
            this.lblTopBar.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTopBar.Location = new System.Drawing.Point(-4, 0);
            this.lblTopBar.Name = "lblTopBar";
            this.lblTopBar.Size = new System.Drawing.Size(575, 27);
            this.lblTopBar.TabIndex = 126;
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClose.Location = new System.Drawing.Point(576, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(34, 37);
            this.lblClose.TabIndex = 127;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.BackColor = System.Drawing.Color.Transparent;
            this.lblCheck.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCheck.Location = new System.Drawing.Point(236, 317);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(146, 39);
            this.lblCheck.TabIndex = 128;
            // 
            // grdWork
            // 
            this.grdWork.AllowEditing = false;
            this.grdWork.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.grdWork.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.grdWork.ExtendLastCol = true;
            this.grdWork.Location = new System.Drawing.Point(12, 76);
            this.grdWork.Name = "grdWork";
            this.grdWork.Size = new System.Drawing.Size(586, 229);
            this.grdWork.StyleInfo = resources.GetString("grdWork.StyleInfo");
            this.grdWork.TabIndex = 129;
            this.grdWork.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            this.grdWork.DoubleClick += new System.EventHandler(this.grdWork_DoubleClick);
            // 
            // frm고객등록정보
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(610, 365);
            this.Controls.Add(this.grdWork);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTopBar);
            this.Controls.Add(this.lbl검색);
            this.Controls.Add(this.txt고객명);
            this.Controls.Add(this.picMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm고객등록정보";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "고객등록정보";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt고객명)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private C1.Win.C1Input.C1TextBox txt고객명;
        private System.Windows.Forms.Label lbl검색;
        private System.Windows.Forms.Label lblTopBar;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblCheck;
        private C1.Win.C1FlexGrid.C1FlexGrid grdWork;
    }
}