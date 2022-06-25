namespace DH_CRM
{
    partial class frm고객정보
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm고객정보));
            this.grdWork = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.txt검색어 = new C1.Win.C1Input.C1TextBox();
            this.txt휴대폰 = new C1.Win.C1Input.C1TextBox();
            this.cbo담당자 = new C1.Win.C1Input.C1ComboBox();
            this.txt이름 = new C1.Win.C1Input.C1TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbo유입경로소분류 = new C1.Win.C1Input.C1ComboBox();
            this.cbo유입경로대분류 = new C1.Win.C1Input.C1ComboBox();
            this.sizeMain = new C1.Win.C1Sizer.C1Sizer();
            this.tabList = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grdList1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grdList2 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo유입경로 = new C1.Win.C1Input.C1ComboBox();
            this.lbl전체보기 = new System.Windows.Forms.Label();
            this.lbl검색 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt검색어)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt휴대폰)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo담당자)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt이름)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo유입경로소분류)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo유입경로대분류)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeMain)).BeginInit();
            this.sizeMain.SuspendLayout();
            this.tabList.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdList1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdList2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo유입경로)).BeginInit();
            this.SuspendLayout();
            // 
            // grdWork
            // 
            this.grdWork.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.grdWork.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.grdWork.ExtendLastCol = true;
            this.grdWork.Location = new System.Drawing.Point(4, 49);
            this.grdWork.Name = "grdWork";
            this.grdWork.Size = new System.Drawing.Size(1913, 634);
            this.grdWork.StyleInfo = resources.GetString("grdWork.StyleInfo");
            this.grdWork.TabIndex = 36;
            this.grdWork.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            this.grdWork.AfterResizeColumn += new C1.Win.C1FlexGrid.RowColEventHandler(this.grdWork_AfterResizeColumn);
            this.grdWork.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.grdWork_AfterEdit);
            this.grdWork.Click += new System.EventHandler(this.grdWork_Click);
            this.grdWork.DoubleClick += new System.EventHandler(this.grdWork_DoubleClick);
            // 
            // txt검색어
            // 
            this.txt검색어.AutoSize = false;
            this.txt검색어.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt검색어.Location = new System.Drawing.Point(881, 6);
            this.txt검색어.Name = "txt검색어";
            this.txt검색어.Size = new System.Drawing.Size(100, 29);
            this.txt검색어.TabIndex = 106;
            this.txt검색어.Tag = null;
            this.txt검색어.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt검색어.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // txt휴대폰
            // 
            this.txt휴대폰.AutoSize = false;
            this.txt휴대폰.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt휴대폰.Location = new System.Drawing.Point(743, 7);
            this.txt휴대폰.Name = "txt휴대폰";
            this.txt휴대폰.Size = new System.Drawing.Size(83, 29);
            this.txt휴대폰.TabIndex = 105;
            this.txt휴대폰.Tag = null;
            this.txt휴대폰.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt휴대폰.VisualStyle = C1.Win.C1Input.VisualStyle.System;
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
            this.cbo담당자.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo담당자.GapHeight = 0;
            this.cbo담당자.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo담당자.ItemsDisplayMember = "";
            this.cbo담당자.ItemsValueMember = "";
            this.cbo담당자.Location = new System.Drawing.Point(553, 7);
            this.cbo담당자.Name = "cbo담당자";
            this.cbo담당자.Size = new System.Drawing.Size(135, 29);
            this.cbo담당자.Style.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo담당자.TabIndex = 104;
            this.cbo담당자.Tag = null;
            this.cbo담당자.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo담당자.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // txt이름
            // 
            this.txt이름.AutoSize = false;
            this.txt이름.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt이름.Location = new System.Drawing.Point(52, 7);
            this.txt이름.Name = "txt이름";
            this.txt이름.Size = new System.Drawing.Size(80, 29);
            this.txt이름.TabIndex = 103;
            this.txt이름.Tag = null;
            this.txt이름.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt이름.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.ItemSize = new System.Drawing.Size(64, 40);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1913, 45);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 108;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1905, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "전체";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.cbo유입경로소분류.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo유입경로소분류.GapHeight = 0;
            this.cbo유입경로소분류.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo유입경로소분류.ItemsDisplayMember = "";
            this.cbo유입경로소분류.ItemsValueMember = "";
            this.cbo유입경로소분류.Location = new System.Drawing.Point(389, 7);
            this.cbo유입경로소분류.Name = "cbo유입경로소분류";
            this.cbo유입경로소분류.Size = new System.Drawing.Size(109, 29);
            this.cbo유입경로소분류.Style.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo유입경로소분류.TabIndex = 110;
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
            this.cbo유입경로대분류.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo유입경로대분류.GapHeight = 0;
            this.cbo유입경로대분류.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo유입경로대분류.ItemsDisplayMember = "";
            this.cbo유입경로대분류.ItemsValueMember = "";
            this.cbo유입경로대분류.Location = new System.Drawing.Point(274, 7);
            this.cbo유입경로대분류.Name = "cbo유입경로대분류";
            this.cbo유입경로대분류.Size = new System.Drawing.Size(109, 29);
            this.cbo유입경로대분류.Style.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo유입경로대분류.TabIndex = 109;
            this.cbo유입경로대분류.Tag = null;
            this.cbo유입경로대분류.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo유입경로대분류.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.cbo유입경로대분류.SelectedIndexChanged += new System.EventHandler(this.cbo유입경로대분류_SelectedIndexChanged);
            // 
            // sizeMain
            // 
            this.sizeMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.sizeMain.Controls.Add(this.tabList);
            this.sizeMain.Controls.Add(this.panel1);
            this.sizeMain.Controls.Add(this.tabControl1);
            this.sizeMain.Controls.Add(this.grdWork);
            this.sizeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizeMain.GridDefinition = "5.04484304932735:False:True;71.0762331838565:False:False;5.04484304932735:False:F" +
    "alse;17.9372197309417:False:True;\t49.5575221238938:False:False;50.0260281103592:" +
    "False:False;";
            this.sizeMain.Location = new System.Drawing.Point(0, 0);
            this.sizeMain.Name = "sizeMain";
            this.sizeMain.Size = new System.Drawing.Size(1921, 892);
            this.sizeMain.SplitterWidth = 0;
            this.sizeMain.TabIndex = 112;
            this.sizeMain.Text = "c1Sizer1";
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.tabPage2);
            this.tabList.Controls.Add(this.tabPage3);
            this.tabList.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabList.ItemSize = new System.Drawing.Size(80, 25);
            this.tabList.Location = new System.Drawing.Point(4, 728);
            this.tabList.Name = "tabList";
            this.tabList.SelectedIndex = 0;
            this.tabList.Size = new System.Drawing.Size(1913, 160);
            this.tabList.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabList.TabIndex = 110;
            this.tabList.SelectedIndexChanged += new System.EventHandler(this.tabList_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grdList1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1905, 127);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "회원메모";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grdList1
            // 
            this.grdList1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.grdList1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.grdList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdList1.ExtendLastCol = true;
            this.grdList1.Location = new System.Drawing.Point(3, 3);
            this.grdList1.Name = "grdList1";
            this.grdList1.Size = new System.Drawing.Size(1899, 121);
            this.grdList1.StyleInfo = resources.GetString("grdList1.StyleInfo");
            this.grdList1.TabIndex = 37;
            this.grdList1.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grdList2);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1905, 127);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "매출내역";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grdList2
            // 
            this.grdList2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.grdList2.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.grdList2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdList2.ExtendLastCol = true;
            this.grdList2.Location = new System.Drawing.Point(0, 0);
            this.grdList2.Name = "grdList2";
            this.grdList2.Size = new System.Drawing.Size(1905, 127);
            this.grdList2.StyleInfo = resources.GetString("grdList2.StyleInfo");
            this.grdList2.TabIndex = 38;
            this.grdList2.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.cbo유입경로);
            this.panel1.Controls.Add(this.lbl전체보기);
            this.panel1.Controls.Add(this.lbl검색);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbo유입경로대분류);
            this.panel1.Controls.Add(this.cbo유입경로소분류);
            this.panel1.Controls.Add(this.txt이름);
            this.panel1.Controls.Add(this.cbo담당자);
            this.panel1.Controls.Add(this.txt검색어);
            this.panel1.Controls.Add(this.txt휴대폰);
            this.panel1.Location = new System.Drawing.Point(4, 683);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1913, 45);
            this.panel1.TabIndex = 109;
            // 
            // cbo유입경로
            // 
            this.cbo유입경로.AllowSpinLoop = false;
            this.cbo유입경로.AutoSize = false;
            this.cbo유입경로.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo유입경로.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo유입경로.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo유입경로.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo유입경로.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo유입경로.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo유입경로.GapHeight = 0;
            this.cbo유입경로.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo유입경로.ItemsDisplayMember = "";
            this.cbo유입경로.ItemsValueMember = "";
            this.cbo유입경로.Location = new System.Drawing.Point(138, 7);
            this.cbo유입경로.Name = "cbo유입경로";
            this.cbo유입경로.Size = new System.Drawing.Size(130, 29);
            this.cbo유입경로.Style.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo유입경로.TabIndex = 118;
            this.cbo유입경로.Tag = null;
            this.cbo유입경로.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo유입경로.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // lbl전체보기
            // 
            this.lbl전체보기.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lbl전체보기.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl전체보기.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl전체보기.ForeColor = System.Drawing.Color.White;
            this.lbl전체보기.Location = new System.Drawing.Point(1072, 7);
            this.lbl전체보기.Name = "lbl전체보기";
            this.lbl전체보기.Size = new System.Drawing.Size(79, 29);
            this.lbl전체보기.TabIndex = 117;
            this.lbl전체보기.Text = "전체 보기";
            this.lbl전체보기.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl전체보기.Click += new System.EventHandler(this.lbl전체보기_Click);
            // 
            // lbl검색
            // 
            this.lbl검색.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lbl검색.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl검색.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl검색.ForeColor = System.Drawing.Color.White;
            this.lbl검색.Location = new System.Drawing.Point(987, 7);
            this.lbl검색.Name = "lbl검색";
            this.lbl검색.Size = new System.Drawing.Size(79, 29);
            this.lbl검색.TabIndex = 116;
            this.lbl검색.Text = "검색";
            this.lbl검색.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl검색.Click += new System.EventHandler(this.lbl검색_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(832, 14);
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
            this.label4.Location = new System.Drawing.Point(694, 14);
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
            this.label3.Location = new System.Drawing.Point(504, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 113;
            this.label3.Text = "담당자";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 111;
            this.label1.Text = "이름";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm고객정보
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1921, 892);
            this.Controls.Add(this.sizeMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm고객정보";
            this.Text = "frm고객정보";
            this.Load += new System.EventHandler(this.frm고객정보_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt검색어)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt휴대폰)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo담당자)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt이름)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbo유입경로소분류)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo유입경로대분류)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeMain)).EndInit();
            this.sizeMain.ResumeLayout(false);
            this.tabList.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdList1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdList2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo유입경로)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.C1FlexGrid.C1FlexGrid grdWork;
        private C1.Win.C1Input.C1TextBox txt검색어;
        private C1.Win.C1Input.C1TextBox txt휴대폰;
        private C1.Win.C1Input.C1ComboBox cbo담당자;
        private C1.Win.C1Input.C1TextBox txt이름;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private C1.Win.C1Input.C1ComboBox cbo유입경로소분류;
        private C1.Win.C1Input.C1ComboBox cbo유입경로대분류;
        private C1.Win.C1Sizer.C1Sizer sizeMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl전체보기;
        private System.Windows.Forms.Label lbl검색;
        private C1.Win.C1Input.C1ComboBox cbo유입경로;
        private System.Windows.Forms.TabControl tabList;
        private System.Windows.Forms.TabPage tabPage2;
        private C1.Win.C1FlexGrid.C1FlexGrid grdList1;
        private System.Windows.Forms.TabPage tabPage3;
        private C1.Win.C1FlexGrid.C1FlexGrid grdList2;
    }
}