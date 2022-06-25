namespace DH_CRM
{
    partial class frm엑셀자료변환옵션
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm엑셀자료변환옵션));
            this.picMain = new System.Windows.Forms.PictureBox();
            this.chk모두추가 = new System.Windows.Forms.CheckBox();
            this.chk중복체크 = new System.Windows.Forms.CheckBox();
            this.chk공백초기화 = new System.Windows.Forms.CheckBox();
            this.chk휴대전화 = new System.Windows.Forms.CheckBox();
            this.chk이름 = new System.Windows.Forms.CheckBox();
            this.opt중복체크1 = new System.Windows.Forms.RadioButton();
            this.opt중복체크2 = new System.Windows.Forms.RadioButton();
            this.opt중복체크3 = new System.Windows.Forms.RadioButton();
            this.cbo유입경로대분류 = new C1.Win.C1Input.C1ComboBox();
            this.cbo담당자 = new C1.Win.C1Input.C1ComboBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblTopBar = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo유입경로대분류)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo담당자)).BeginInit();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.BackColor = System.Drawing.SystemColors.Control;
            this.picMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(0, 0);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(608, 653);
            this.picMain.TabIndex = 11;
            this.picMain.TabStop = false;
            // 
            // chk모두추가
            // 
            this.chk모두추가.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.chk모두추가.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk모두추가.Location = new System.Drawing.Point(19, 145);
            this.chk모두추가.Name = "chk모두추가";
            this.chk모두추가.Size = new System.Drawing.Size(30, 28);
            this.chk모두추가.TabIndex = 23;
            this.chk모두추가.UseVisualStyleBackColor = false;
            this.chk모두추가.CheckedChanged += new System.EventHandler(this.chk모두추가_CheckedChanged);
            // 
            // chk중복체크
            // 
            this.chk중복체크.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.chk중복체크.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk중복체크.Location = new System.Drawing.Point(19, 180);
            this.chk중복체크.Name = "chk중복체크";
            this.chk중복체크.Size = new System.Drawing.Size(30, 28);
            this.chk중복체크.TabIndex = 24;
            this.chk중복체크.UseVisualStyleBackColor = false;
            this.chk중복체크.CheckedChanged += new System.EventHandler(this.chk중복체크_CheckedChanged);
            // 
            // chk공백초기화
            // 
            this.chk공백초기화.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.chk공백초기화.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk공백초기화.Location = new System.Drawing.Point(82, 303);
            this.chk공백초기화.Name = "chk공백초기화";
            this.chk공백초기화.Size = new System.Drawing.Size(30, 28);
            this.chk공백초기화.TabIndex = 25;
            this.chk공백초기화.UseVisualStyleBackColor = false;
            // 
            // chk휴대전화
            // 
            this.chk휴대전화.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.chk휴대전화.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk휴대전화.Location = new System.Drawing.Point(209, 337);
            this.chk휴대전화.Name = "chk휴대전화";
            this.chk휴대전화.Size = new System.Drawing.Size(30, 28);
            this.chk휴대전화.TabIndex = 26;
            this.chk휴대전화.UseVisualStyleBackColor = false;
            this.chk휴대전화.CheckedChanged += new System.EventHandler(this.chk휴대전화_CheckedChanged);
            // 
            // chk이름
            // 
            this.chk이름.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.chk이름.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk이름.Location = new System.Drawing.Point(312, 337);
            this.chk이름.Name = "chk이름";
            this.chk이름.Size = new System.Drawing.Size(30, 28);
            this.chk이름.TabIndex = 27;
            this.chk이름.UseVisualStyleBackColor = false;
            this.chk이름.CheckedChanged += new System.EventHandler(this.chk이름_CheckedChanged);
            // 
            // opt중복체크1
            // 
            this.opt중복체크1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.opt중복체크1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opt중복체크1.Location = new System.Drawing.Point(50, 219);
            this.opt중복체크1.Name = "opt중복체크1";
            this.opt중복체크1.Size = new System.Drawing.Size(24, 24);
            this.opt중복체크1.TabIndex = 124;
            this.opt중복체크1.UseVisualStyleBackColor = false;
            // 
            // opt중복체크2
            // 
            this.opt중복체크2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.opt중복체크2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opt중복체크2.Location = new System.Drawing.Point(50, 249);
            this.opt중복체크2.Name = "opt중복체크2";
            this.opt중복체크2.Size = new System.Drawing.Size(24, 24);
            this.opt중복체크2.TabIndex = 125;
            this.opt중복체크2.UseVisualStyleBackColor = false;
            // 
            // opt중복체크3
            // 
            this.opt중복체크3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.opt중복체크3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opt중복체크3.Location = new System.Drawing.Point(50, 279);
            this.opt중복체크3.Name = "opt중복체크3";
            this.opt중복체크3.Size = new System.Drawing.Size(24, 24);
            this.opt중복체크3.TabIndex = 126;
            this.opt중복체크3.UseVisualStyleBackColor = false;
            // 
            // cbo유입경로대분류
            // 
            this.cbo유입경로대분류.AllowSpinLoop = false;
            this.cbo유입경로대분류.AutoSize = false;
            this.cbo유입경로대분류.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo유입경로대분류.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo유입경로대분류.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo유입경로대분류.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo유입경로대분류.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo유입경로대분류.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo유입경로대분류.GapHeight = 0;
            this.cbo유입경로대분류.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo유입경로대분류.ItemsDisplayMember = "";
            this.cbo유입경로대분류.ItemsValueMember = "";
            this.cbo유입경로대분류.Location = new System.Drawing.Point(34, 459);
            this.cbo유입경로대분류.Name = "cbo유입경로대분류";
            this.cbo유입경로대분류.Size = new System.Drawing.Size(246, 31);
            this.cbo유입경로대분류.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo유입경로대분류.TabIndex = 127;
            this.cbo유입경로대분류.Tag = null;
            this.cbo유입경로대분류.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo유입경로대분류.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // cbo담당자
            // 
            this.cbo담당자.AllowSpinLoop = false;
            this.cbo담당자.AutoSize = false;
            this.cbo담당자.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo담당자.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo담당자.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo담당자.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo담당자.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo담당자.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo담당자.GapHeight = 0;
            this.cbo담당자.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo담당자.ItemsDisplayMember = "";
            this.cbo담당자.ItemsValueMember = "";
            this.cbo담당자.Location = new System.Drawing.Point(388, 456);
            this.cbo담당자.Name = "cbo담당자";
            this.cbo담당자.Size = new System.Drawing.Size(184, 30);
            this.cbo담당자.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo담당자.TabIndex = 129;
            this.cbo담당자.Tag = null;
            this.cbo담당자.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo담당자.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStart.ForeColor = System.Drawing.Color.Transparent;
            this.lblStart.Location = new System.Drawing.Point(229, 606);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(142, 38);
            this.lblStart.TabIndex = 131;
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // lblTopBar
            // 
            this.lblTopBar.BackColor = System.Drawing.Color.Transparent;
            this.lblTopBar.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTopBar.Location = new System.Drawing.Point(6, 5);
            this.lblTopBar.Name = "lblTopBar";
            this.lblTopBar.Size = new System.Drawing.Size(557, 28);
            this.lblTopBar.TabIndex = 132;
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClose.Location = new System.Drawing.Point(579, 5);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 28);
            this.lblClose.TabIndex = 133;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // frm엑셀자료변환옵션
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(608, 653);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTopBar);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.cbo담당자);
            this.Controls.Add(this.cbo유입경로대분류);
            this.Controls.Add(this.opt중복체크3);
            this.Controls.Add(this.opt중복체크2);
            this.Controls.Add(this.opt중복체크1);
            this.Controls.Add(this.chk이름);
            this.Controls.Add(this.chk휴대전화);
            this.Controls.Add(this.chk공백초기화);
            this.Controls.Add(this.chk중복체크);
            this.Controls.Add(this.chk모두추가);
            this.Controls.Add(this.picMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm엑셀자료변환옵션";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm엑셀자료변환옵션";
            this.Load += new System.EventHandler(this.frm엑셀자료변환옵션_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo유입경로대분류)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo담당자)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.CheckBox chk모두추가;
        private System.Windows.Forms.CheckBox chk중복체크;
        private System.Windows.Forms.CheckBox chk공백초기화;
        private System.Windows.Forms.CheckBox chk휴대전화;
        private System.Windows.Forms.CheckBox chk이름;
        private System.Windows.Forms.RadioButton opt중복체크1;
        private System.Windows.Forms.RadioButton opt중복체크2;
        private System.Windows.Forms.RadioButton opt중복체크3;
        private C1.Win.C1Input.C1ComboBox cbo유입경로대분류;
        private C1.Win.C1Input.C1ComboBox cbo담당자;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblTopBar;
        private System.Windows.Forms.Label lblClose;
    }
}