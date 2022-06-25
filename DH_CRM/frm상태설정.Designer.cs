namespace DH_CRM
{
    partial class 상태설정
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(상태설정));
            this.picMain = new System.Windows.Forms.PictureBox();
            this.grdWork = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.txt상태설정 = new C1.Win.C1Input.C1TextBox();
            this.lbl추가 = new System.Windows.Forms.Label();
            this.lbl삭제 = new System.Windows.Forms.Label();
            this.lbl저장 = new System.Windows.Forms.Label();
            this.lblTopBar = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt상태설정)).BeginInit();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.BackColor = System.Drawing.SystemColors.Control;
            this.picMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(0, 0);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(321, 514);
            this.picMain.TabIndex = 12;
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
            this.grdWork.Location = new System.Drawing.Point(13, 48);
            this.grdWork.Name = "grdWork";
            this.grdWork.Size = new System.Drawing.Size(298, 344);
            this.grdWork.StyleInfo = resources.GetString("grdWork.StyleInfo");
            this.grdWork.TabIndex = 39;
            this.grdWork.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            this.grdWork.DoubleClick += new System.EventHandler(this.grdWork_DoubleClick);
            // 
            // txt상태설정
            // 
            this.txt상태설정.AutoSize = false;
            this.txt상태설정.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt상태설정.Location = new System.Drawing.Point(13, 398);
            this.txt상태설정.Name = "txt상태설정";
            this.txt상태설정.Size = new System.Drawing.Size(297, 47);
            this.txt상태설정.TabIndex = 98;
            this.txt상태설정.Tag = null;
            this.txt상태설정.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt상태설정.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // lbl추가
            // 
            this.lbl추가.BackColor = System.Drawing.Color.Transparent;
            this.lbl추가.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl추가.Location = new System.Drawing.Point(12, 454);
            this.lbl추가.Name = "lbl추가";
            this.lbl추가.Size = new System.Drawing.Size(94, 50);
            this.lbl추가.TabIndex = 99;
            this.lbl추가.Click += new System.EventHandler(this.lbl추가_Click);
            // 
            // lbl삭제
            // 
            this.lbl삭제.BackColor = System.Drawing.Color.Transparent;
            this.lbl삭제.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl삭제.Location = new System.Drawing.Point(114, 454);
            this.lbl삭제.Name = "lbl삭제";
            this.lbl삭제.Size = new System.Drawing.Size(94, 50);
            this.lbl삭제.TabIndex = 100;
            this.lbl삭제.Click += new System.EventHandler(this.lbl삭제_Click);
            // 
            // lbl저장
            // 
            this.lbl저장.BackColor = System.Drawing.Color.Transparent;
            this.lbl저장.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl저장.Location = new System.Drawing.Point(217, 454);
            this.lbl저장.Name = "lbl저장";
            this.lbl저장.Size = new System.Drawing.Size(94, 50);
            this.lbl저장.TabIndex = 101;
            this.lbl저장.Click += new System.EventHandler(this.lbl저장_Click);
            // 
            // lblTopBar
            // 
            this.lblTopBar.BackColor = System.Drawing.Color.Transparent;
            this.lblTopBar.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTopBar.Location = new System.Drawing.Point(4, 7);
            this.lblTopBar.Name = "lblTopBar";
            this.lblTopBar.Size = new System.Drawing.Size(277, 28);
            this.lblTopBar.TabIndex = 102;
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClose.Location = new System.Drawing.Point(287, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 28);
            this.lblClose.TabIndex = 103;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // 상태설정
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(321, 514);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTopBar);
            this.Controls.Add(this.lbl저장);
            this.Controls.Add(this.lbl삭제);
            this.Controls.Add(this.lbl추가);
            this.Controls.Add(this.txt상태설정);
            this.Controls.Add(this.grdWork);
            this.Controls.Add(this.picMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "상태설정";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "상태설정";
            this.Load += new System.EventHandler(this.상태설정_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt상태설정)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private C1.Win.C1FlexGrid.C1FlexGrid grdWork;
        private C1.Win.C1Input.C1TextBox txt상태설정;
        private System.Windows.Forms.Label lbl추가;
        private System.Windows.Forms.Label lbl삭제;
        private System.Windows.Forms.Label lbl저장;
        private System.Windows.Forms.Label lblTopBar;
        private System.Windows.Forms.Label lblClose;
    }
}