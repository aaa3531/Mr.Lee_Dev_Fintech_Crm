namespace DH_CRM
{
    partial class frm연락처추가
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm연락처추가));
            this.picMain = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTopBar = new System.Windows.Forms.Label();
            this.cbo회원목록 = new C1.Win.C1Input.C1ComboBox();
            this.grdWork = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.lbl추가하기 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo회원목록)).BeginInit();
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
            this.picMain.Size = new System.Drawing.Size(463, 467);
            this.picMain.TabIndex = 14;
            this.picMain.TabStop = false;
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClose.Location = new System.Drawing.Point(432, 5);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 28);
            this.lblClose.TabIndex = 107;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblTopBar
            // 
            this.lblTopBar.BackColor = System.Drawing.Color.Transparent;
            this.lblTopBar.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTopBar.Location = new System.Drawing.Point(5, 5);
            this.lblTopBar.Name = "lblTopBar";
            this.lblTopBar.Size = new System.Drawing.Size(421, 28);
            this.lblTopBar.TabIndex = 106;
            // 
            // cbo회원목록
            // 
            this.cbo회원목록.AllowSpinLoop = false;
            this.cbo회원목록.AutoSize = false;
            this.cbo회원목록.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo회원목록.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo회원목록.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo회원목록.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo회원목록.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo회원목록.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo회원목록.GapHeight = 0;
            this.cbo회원목록.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo회원목록.ItemsDisplayMember = "";
            this.cbo회원목록.ItemsValueMember = "";
            this.cbo회원목록.Location = new System.Drawing.Point(79, 48);
            this.cbo회원목록.Name = "cbo회원목록";
            this.cbo회원목록.Size = new System.Drawing.Size(132, 29);
            this.cbo회원목록.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo회원목록.TabIndex = 113;
            this.cbo회원목록.Tag = null;
            this.cbo회원목록.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo회원목록.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // grdWork
            // 
            this.grdWork.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.grdWork.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.grdWork.ExtendLastCol = true;
            this.grdWork.Location = new System.Drawing.Point(13, 85);
            this.grdWork.Name = "grdWork";
            this.grdWork.Size = new System.Drawing.Size(438, 333);
            this.grdWork.StyleInfo = resources.GetString("grdWork.StyleInfo");
            this.grdWork.TabIndex = 114;
            this.grdWork.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            this.grdWork.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.grdwork_AfterEdit);
            // 
            // lbl추가하기
            // 
            this.lbl추가하기.BackColor = System.Drawing.Color.Transparent;
            this.lbl추가하기.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl추가하기.Location = new System.Drawing.Point(173, 428);
            this.lbl추가하기.Name = "lbl추가하기";
            this.lbl추가하기.Size = new System.Drawing.Size(114, 33);
            this.lbl추가하기.TabIndex = 115;
            this.lbl추가하기.Click += new System.EventHandler(this.lbl추가하기_Click);
            // 
            // frm연락처추가
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(463, 467);
            this.Controls.Add(this.lbl추가하기);
            this.Controls.Add(this.grdWork);
            this.Controls.Add(this.cbo회원목록);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTopBar);
            this.Controls.Add(this.picMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm연락처추가";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "연락처추가";
            this.Load += new System.EventHandler(this.frm연락처추가_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo회원목록)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblTopBar;
        private C1.Win.C1Input.C1ComboBox cbo회원목록;
        private C1.Win.C1FlexGrid.C1FlexGrid grdWork;
        private System.Windows.Forms.Label lbl추가하기;
    }
}