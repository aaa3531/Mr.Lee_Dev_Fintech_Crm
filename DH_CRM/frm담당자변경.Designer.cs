namespace DH_CRM
{
    partial class frm담당자변경
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm담당자변경));
            this.picMain = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTopBar = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbo새담당자 = new C1.Win.C1Input.C1ComboBox();
            this.cbo현재담당자 = new C1.Win.C1Input.C1ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbo리스트새담당자 = new C1.Win.C1Input.C1ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl저장 = new System.Windows.Forms.Label();
            this.lbl닫기 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo새담당자)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo현재담당자)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo리스트새담당자)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.BackColor = System.Drawing.SystemColors.Control;
            this.picMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(0, 0);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(453, 385);
            this.picMain.TabIndex = 13;
            this.picMain.TabStop = false;
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClose.Location = new System.Drawing.Point(421, 5);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 28);
            this.lblClose.TabIndex = 105;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click_1);
            // 
            // lblTopBar
            // 
            this.lblTopBar.BackColor = System.Drawing.Color.Transparent;
            this.lblTopBar.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTopBar.Location = new System.Drawing.Point(4, 5);
            this.lblTopBar.Name = "lblTopBar";
            this.lblTopBar.Size = new System.Drawing.Size(411, 28);
            this.lblTopBar.TabIndex = 104;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Location = new System.Drawing.Point(12, 122);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(431, 198);
            this.tabMain.TabIndex = 106;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.tabPage1.Controls.Add(this.cbo새담당자);
            this.tabPage1.Controls.Add(this.cbo현재담당자);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(423, 170);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "기존 담당자 > 새담당자";
            // 
            // cbo새담당자
            // 
            this.cbo새담당자.AllowSpinLoop = false;
            this.cbo새담당자.AutoSize = false;
            this.cbo새담당자.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo새담당자.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo새담당자.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo새담당자.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo새담당자.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo새담당자.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo새담당자.GapHeight = 0;
            this.cbo새담당자.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo새담당자.ItemsDisplayMember = "";
            this.cbo새담당자.ItemsValueMember = "";
            this.cbo새담당자.Location = new System.Drawing.Point(116, 77);
            this.cbo새담당자.Name = "cbo새담당자";
            this.cbo새담당자.Size = new System.Drawing.Size(254, 29);
            this.cbo새담당자.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo새담당자.TabIndex = 26;
            this.cbo새담당자.Tag = null;
            this.cbo새담당자.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo새담당자.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // cbo현재담당자
            // 
            this.cbo현재담당자.AllowSpinLoop = false;
            this.cbo현재담당자.AutoSize = false;
            this.cbo현재담당자.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo현재담당자.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo현재담당자.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo현재담당자.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo현재담당자.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo현재담당자.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo현재담당자.GapHeight = 0;
            this.cbo현재담당자.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo현재담당자.ItemsDisplayMember = "";
            this.cbo현재담당자.ItemsValueMember = "";
            this.cbo현재담당자.Location = new System.Drawing.Point(116, 44);
            this.cbo현재담당자.Name = "cbo현재담당자";
            this.cbo현재담당자.Size = new System.Drawing.Size(254, 29);
            this.cbo현재담당자.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo현재담당자.TabIndex = 25;
            this.cbo현재담당자.Tag = null;
            this.cbo현재담당자.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo현재담당자.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.cbo현재담당자.SelectedItemChanged += new System.EventHandler(this.cbo현재담당자_SelectedItemChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 164);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.tabPage2.Controls.Add(this.cbo리스트새담당자);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(423, 172);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "리스트 > 새 담당자";
            // 
            // cbo리스트새담당자
            // 
            this.cbo리스트새담당자.AllowSpinLoop = false;
            this.cbo리스트새담당자.AutoSize = false;
            this.cbo리스트새담당자.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo리스트새담당자.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo리스트새담당자.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo리스트새담당자.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo리스트새담당자.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo리스트새담당자.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo리스트새담당자.GapHeight = 0;
            this.cbo리스트새담당자.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo리스트새담당자.ItemsDisplayMember = "";
            this.cbo리스트새담당자.ItemsValueMember = "";
            this.cbo리스트새담당자.Location = new System.Drawing.Point(117, 77);
            this.cbo리스트새담당자.Name = "cbo리스트새담당자";
            this.cbo리스트새담당자.Size = new System.Drawing.Size(254, 29);
            this.cbo리스트새담당자.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo리스트새담당자.TabIndex = 26;
            this.cbo리스트새담당자.Tag = null;
            this.cbo리스트새담당자.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo리스트새담당자.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(417, 166);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // lbl저장
            // 
            this.lbl저장.BackColor = System.Drawing.Color.Transparent;
            this.lbl저장.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl저장.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl저장.Location = new System.Drawing.Point(137, 335);
            this.lbl저장.Name = "lbl저장";
            this.lbl저장.Size = new System.Drawing.Size(81, 32);
            this.lbl저장.TabIndex = 108;
            // 
            // lbl닫기
            // 
            this.lbl닫기.BackColor = System.Drawing.Color.Transparent;
            this.lbl닫기.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl닫기.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl닫기.Location = new System.Drawing.Point(233, 335);
            this.lbl닫기.Name = "lbl닫기";
            this.lbl닫기.Size = new System.Drawing.Size(81, 32);
            this.lbl닫기.TabIndex = 110;
            this.lbl닫기.Click += new System.EventHandler(this.lbl닫기_Click);
            // 
            // frm담당자변경
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(453, 385);
            this.Controls.Add(this.lbl닫기);
            this.Controls.Add(this.lbl저장);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTopBar);
            this.Controls.Add(this.picMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm담당자변경";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "담당자변경";
            this.Load += new System.EventHandler(this.frm담당자변경_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbo새담당자)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo현재담당자)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbo리스트새담당자)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblTopBar;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private C1.Win.C1Input.C1ComboBox cbo새담당자;
        private C1.Win.C1Input.C1ComboBox cbo현재담당자;
        private C1.Win.C1Input.C1ComboBox cbo리스트새담당자;
        private System.Windows.Forms.Label lbl저장;
        private System.Windows.Forms.Label lbl닫기;
    }
}