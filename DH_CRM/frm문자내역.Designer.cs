namespace DH_CRM
{
    partial class frm문자내역
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm문자내역));
            this.grdWork = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.txt이름 = new C1.Win.C1Input.C1TextBox();
            this.cbo담당자 = new C1.Win.C1Input.C1ComboBox();
            this.txt휴대폰 = new C1.Win.C1Input.C1TextBox();
            this.txt검색어 = new C1.Win.C1Input.C1TextBox();
            this.cbo유입경로소분류 = new C1.Win.C1Input.C1ComboBox();
            this.cbo유입경로대분류 = new C1.Win.C1Input.C1ComboBox();
            this.sizeMain = new C1.Win.C1Sizer.C1Sizer();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl검색 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt이름)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo담당자)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt휴대폰)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt검색어)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo유입경로소분류)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo유입경로대분류)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeMain)).BeginInit();
            this.sizeMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdWork
            // 
            this.grdWork.AllowEditing = false;
            this.grdWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdWork.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.grdWork.ColumnInfo = "10,1,0,0,0,-1,Columns:0{Caption:\"No\";Style:\"DataType:System.Int32;TextAlign:Gener" +
    "alCenter;\";}\t";
            this.grdWork.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.grdWork.ExtendLastCol = true;
            this.grdWork.Location = new System.Drawing.Point(4, 49);
            this.grdWork.Name = "grdWork";
            this.grdWork.Size = new System.Drawing.Size(1912, 790);
            this.grdWork.StyleInfo = resources.GetString("grdWork.StyleInfo");
            this.grdWork.TabIndex = 37;
            this.grdWork.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            this.grdWork.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this.grdWork_OwnerDrawCell);
            this.grdWork.DoubleClick += new System.EventHandler(this.grdWork_DoubleClick);
            // 
            // txt이름
            // 
            this.txt이름.AutoSize = false;
            this.txt이름.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt이름.Location = new System.Drawing.Point(58, 10);
            this.txt이름.Name = "txt이름";
            this.txt이름.Size = new System.Drawing.Size(131, 29);
            this.txt이름.TabIndex = 104;
            this.txt이름.Tag = null;
            this.txt이름.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt이름.VisualStyle = C1.Win.C1Input.VisualStyle.System;
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
            this.cbo담당자.Location = new System.Drawing.Point(705, 10);
            this.cbo담당자.Name = "cbo담당자";
            this.cbo담당자.Size = new System.Drawing.Size(132, 29);
            this.cbo담당자.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo담당자.TabIndex = 105;
            this.cbo담당자.Tag = null;
            this.cbo담당자.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo담당자.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // txt휴대폰
            // 
            this.txt휴대폰.AutoSize = false;
            this.txt휴대폰.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt휴대폰.Location = new System.Drawing.Point(903, 11);
            this.txt휴대폰.Name = "txt휴대폰";
            this.txt휴대폰.Size = new System.Drawing.Size(139, 29);
            this.txt휴대폰.TabIndex = 106;
            this.txt휴대폰.Tag = null;
            this.txt휴대폰.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt휴대폰.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // txt검색어
            // 
            this.txt검색어.AutoSize = false;
            this.txt검색어.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt검색어.Location = new System.Drawing.Point(1115, 11);
            this.txt검색어.Name = "txt검색어";
            this.txt검색어.Size = new System.Drawing.Size(168, 29);
            this.txt검색어.TabIndex = 107;
            this.txt검색어.Tag = null;
            this.txt검색어.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt검색어.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // cbo유입경로소분류
            // 
            this.cbo유입경로소분류.AllowSpinLoop = false;
            this.cbo유입경로소분류.AutoSize = false;
            this.cbo유입경로소분류.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo유입경로소분류.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo유입경로소분류.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo유입경로소분류.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo유입경로소분류.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo유입경로소분류.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo유입경로소분류.GapHeight = 0;
            this.cbo유입경로소분류.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo유입경로소분류.ItemsDisplayMember = "";
            this.cbo유입경로소분류.ItemsValueMember = "";
            this.cbo유입경로소분류.Location = new System.Drawing.Point(435, 10);
            this.cbo유입경로소분류.Name = "cbo유입경로소분류";
            this.cbo유입경로소분류.Size = new System.Drawing.Size(193, 29);
            this.cbo유입경로소분류.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo유입경로소분류.TabIndex = 114;
            this.cbo유입경로소분류.Tag = null;
            this.cbo유입경로소분류.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo유입경로소분류.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
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
            this.cbo유입경로대분류.Location = new System.Drawing.Point(298, 10);
            this.cbo유입경로대분류.Name = "cbo유입경로대분류";
            this.cbo유입경로대분류.Size = new System.Drawing.Size(132, 29);
            this.cbo유입경로대분류.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo유입경로대분류.TabIndex = 113;
            this.cbo유입경로대분류.Tag = null;
            this.cbo유입경로대분류.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo유입경로대분류.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.cbo유입경로대분류.SelectedIndexChanged += new System.EventHandler(this.cbo유입경로대분류_SelectedIndexChanged);
            // 
            // sizeMain
            // 
            this.sizeMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.sizeMain.Controls.Add(this.label6);
            this.sizeMain.Controls.Add(this.panel1);
            this.sizeMain.Controls.Add(this.grdWork);
            this.sizeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizeMain.GridDefinition = "5.03919372900336:False:True;88.4658454647256:False:False;5.59910414333707:False:T" +
    "rue;\t49.5833333333333:False:False;50:False:False;";
            this.sizeMain.Location = new System.Drawing.Point(0, 0);
            this.sizeMain.Name = "sizeMain";
            this.sizeMain.Size = new System.Drawing.Size(1920, 893);
            this.sizeMain.SplitterWidth = 0;
            this.sizeMain.TabIndex = 115;
            this.sizeMain.Text = "c1Sizer1";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1912, 45);
            this.label6.TabIndex = 112;
            this.label6.Text = "문자내역";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.lbl검색);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbo유입경로소분류);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbo유입경로대분류);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt검색어);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt휴대폰);
            this.panel1.Controls.Add(this.cbo담당자);
            this.panel1.Controls.Add(this.txt이름);
            this.panel1.Location = new System.Drawing.Point(4, 839);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1912, 50);
            this.panel1.TabIndex = 109;
            // 
            // lbl검색
            // 
            this.lbl검색.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lbl검색.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl검색.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl검색.ForeColor = System.Drawing.Color.White;
            this.lbl검색.Location = new System.Drawing.Point(1289, 11);
            this.lbl검색.Name = "lbl검색";
            this.lbl검색.Size = new System.Drawing.Size(122, 29);
            this.lbl검색.TabIndex = 117;
            this.lbl검색.Text = "검색";
            this.lbl검색.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl검색.Click += new System.EventHandler(this.lbl검색_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1066, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 115;
            this.label5.Text = "검색어";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(859, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 114;
            this.label4.Text = "휴대폰";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(658, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 113;
            this.label3.Text = "담당자";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(243, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 112;
            this.label2.Text = "유입경로";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 111;
            this.label1.Text = "이름";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm문자내역
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 893);
            this.Controls.Add(this.sizeMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm문자내역";
            this.Text = "frm문자내역";
            this.Load += new System.EventHandler(this.frm문자내역_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt이름)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo담당자)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt휴대폰)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt검색어)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo유입경로소분류)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo유입경로대분류)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeMain)).EndInit();
            this.sizeMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.C1FlexGrid.C1FlexGrid grdWork;
        private C1.Win.C1Input.C1TextBox txt이름;
        private C1.Win.C1Input.C1ComboBox cbo담당자;
        private C1.Win.C1Input.C1TextBox txt휴대폰;
        private C1.Win.C1Input.C1TextBox txt검색어;
        private C1.Win.C1Input.C1ComboBox cbo유입경로소분류;
        private C1.Win.C1Input.C1ComboBox cbo유입경로대분류;
        private C1.Win.C1Sizer.C1Sizer sizeMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl검색;
    }
}