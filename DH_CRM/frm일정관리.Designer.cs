namespace DH_CRM
{
    partial class frm일정관리
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm일정관리));
            this.txt일정내용 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp작성일자 = new C1.Win.Calendar.C1DateEdit();
            this.cboFontSize = new C1.Win.C1Input.C1ComboBox();
            this.btn기울기 = new C1.Win.C1Input.C1Button();
            this.btn색상 = new C1.Win.C1Input.C1Button();
            this.btn밑줄 = new C1.Win.C1Input.C1Button();
            this.btn굵기 = new C1.Win.C1Input.C1Button();
            this.grdCalender = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.grdWork = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lbl항목등록 = new System.Windows.Forms.Label();
            this.lblPrint = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.c1Sizer2 = new C1.Win.C1Sizer.C1Sizer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPrevMonth = new System.Windows.Forms.Label();
            this.lblPrevDay = new System.Windows.Forms.Label();
            this.lblNextDay = new System.Windows.Forms.Label();
            this.lblNextMonth = new System.Windows.Forms.Label();
            this.lblYearMonth = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp작성일자)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn기울기)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn색상)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn밑줄)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn굵기)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCalender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer2)).BeginInit();
            this.c1Sizer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt일정내용
            // 
            this.txt일정내용.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt일정내용.Location = new System.Drawing.Point(4, 78);
            this.txt일정내용.Name = "txt일정내용";
            this.txt일정내용.Size = new System.Drawing.Size(1296, 782);
            this.txt일정내용.TabIndex = 226;
            this.txt일정내용.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtp작성일자);
            this.panel1.Controls.Add(this.cboFontSize);
            this.panel1.Controls.Add(this.btn기울기);
            this.panel1.Controls.Add(this.btn색상);
            this.panel1.Controls.Add(this.btn밑줄);
            this.panel1.Controls.Add(this.btn굵기);
            this.panel1.Location = new System.Drawing.Point(4, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 34);
            this.panel1.TabIndex = 227;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(119)))));
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(196, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 229;
            this.label4.Text = "작성날짜";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp작성일자
            // 
            this.dtp작성일자.AutoSize = false;
            this.dtp작성일자.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtp작성일자.Calendar.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp작성일자.Calendar.BackColor = System.Drawing.Color.White;
            this.dtp작성일자.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp작성일자.Calendar.DayNamesFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp작성일자.Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp작성일자.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.dtp작성일자.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.dtp작성일자.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp작성일자.Calendar.TitleBackColor = System.Drawing.Color.White;
            this.dtp작성일자.Calendar.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp작성일자.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp작성일자.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.dtp작성일자.Calendar.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp작성일자.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.dtp작성일자.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp작성일자.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp작성일자.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp작성일자.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp작성일자.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp작성일자.EmptyAsNull = true;
            this.dtp작성일자.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp작성일자.ImagePadding = new System.Windows.Forms.Padding(0);
            this.dtp작성일자.Location = new System.Drawing.Point(303, 4);
            this.dtp작성일자.Name = "dtp작성일자";
            this.dtp작성일자.Size = new System.Drawing.Size(120, 23);
            this.dtp작성일자.TabIndex = 228;
            this.dtp작성일자.Tag = null;
            this.dtp작성일자.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dtp작성일자.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            this.dtp작성일자.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // cboFontSize
            // 
            this.cboFontSize.AllowSpinLoop = false;
            this.cboFontSize.AutoSize = false;
            this.cboFontSize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cboFontSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cboFontSize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cboFontSize.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cboFontSize.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cboFontSize.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboFontSize.GapHeight = 0;
            this.cboFontSize.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cboFontSize.ItemsDisplayMember = "";
            this.cboFontSize.ItemsValueMember = "";
            this.cboFontSize.Location = new System.Drawing.Point(128, 4);
            this.cboFontSize.Name = "cboFontSize";
            this.cboFontSize.Size = new System.Drawing.Size(62, 23);
            this.cboFontSize.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboFontSize.TabIndex = 227;
            this.cboFontSize.Tag = null;
            this.cboFontSize.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cboFontSize.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.cboFontSize.SelectedIndexChanged += new System.EventHandler(this.cboFontSize_SelectedIndexChanged);
            // 
            // btn기울기
            // 
            this.btn기울기.Image = ((System.Drawing.Image)(resources.GetObject("btn기울기.Image")));
            this.btn기울기.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn기울기.Location = new System.Drawing.Point(35, 3);
            this.btn기울기.Name = "btn기울기";
            this.btn기울기.Size = new System.Drawing.Size(25, 25);
            this.btn기울기.TabIndex = 226;
            this.btn기울기.UseVisualStyleBackColor = true;
            this.btn기울기.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            this.btn기울기.Click += new System.EventHandler(this.btn기울기_Click);
            // 
            // btn색상
            // 
            this.btn색상.Image = ((System.Drawing.Image)(resources.GetObject("btn색상.Image")));
            this.btn색상.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn색상.Location = new System.Drawing.Point(4, 3);
            this.btn색상.Name = "btn색상";
            this.btn색상.Size = new System.Drawing.Size(25, 25);
            this.btn색상.TabIndex = 225;
            this.btn색상.UseVisualStyleBackColor = true;
            this.btn색상.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            this.btn색상.Click += new System.EventHandler(this.btn색상_Click);
            // 
            // btn밑줄
            // 
            this.btn밑줄.Image = ((System.Drawing.Image)(resources.GetObject("btn밑줄.Image")));
            this.btn밑줄.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn밑줄.Location = new System.Drawing.Point(97, 3);
            this.btn밑줄.Name = "btn밑줄";
            this.btn밑줄.Size = new System.Drawing.Size(25, 25);
            this.btn밑줄.TabIndex = 224;
            this.btn밑줄.UseVisualStyleBackColor = true;
            this.btn밑줄.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            this.btn밑줄.Click += new System.EventHandler(this.btn밑줄_Click);
            // 
            // btn굵기
            // 
            this.btn굵기.Image = ((System.Drawing.Image)(resources.GetObject("btn굵기.Image")));
            this.btn굵기.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn굵기.Location = new System.Drawing.Point(66, 3);
            this.btn굵기.Name = "btn굵기";
            this.btn굵기.Size = new System.Drawing.Size(25, 25);
            this.btn굵기.TabIndex = 223;
            this.btn굵기.UseVisualStyleBackColor = true;
            this.btn굵기.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            this.btn굵기.Click += new System.EventHandler(this.btn굵기_Click);
            // 
            // grdCalender
            // 
            this.grdCalender.AllowEditing = false;
            this.grdCalender.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.grdCalender.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.grdCalender.ExtendLastCol = true;
            this.grdCalender.Location = new System.Drawing.Point(0, 40);
            this.grdCalender.Name = "grdCalender";
            this.grdCalender.Size = new System.Drawing.Size(650, 325);
            this.grdCalender.StyleInfo = resources.GetString("grdCalender.StyleInfo");
            this.grdCalender.TabIndex = 234;
            this.grdCalender.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            this.grdCalender.Click += new System.EventHandler(this.grdCalender_Click);
            // 
            // grdWork
            // 
            this.grdWork.AllowEditing = false;
            this.grdWork.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.grdWork.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.grdWork.ExtendLastCol = true;
            this.grdWork.Location = new System.Drawing.Point(0, 385);
            this.grdWork.Name = "grdWork";
            this.grdWork.Size = new System.Drawing.Size(650, 471);
            this.grdWork.StyleInfo = resources.GetString("grdWork.StyleInfo");
            this.grdWork.TabIndex = 228;
            this.grdWork.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            this.grdWork.DoubleClick += new System.EventHandler(this.grdWork_DoubleClick);
            // 
            // lblSave
            // 
            this.lblSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lblSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSave.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSave.ForeColor = System.Drawing.Color.Transparent;
            this.lblSave.Location = new System.Drawing.Point(10, 9);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(141, 32);
            this.lblSave.TabIndex = 235;
            this.lblSave.Text = "메모 저장";
            this.lblSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lblUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUpdate.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.lblUpdate.Location = new System.Drawing.Point(84, 9);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(66, 32);
            this.lblUpdate.TabIndex = 236;
            this.lblUpdate.Text = "수정";
            this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUpdate.Click += new System.EventHandler(this.lblUpdate_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lblDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDelete.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDelete.ForeColor = System.Drawing.Color.Transparent;
            this.lblDelete.Location = new System.Drawing.Point(155, 9);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(74, 32);
            this.lblDelete.TabIndex = 237;
            this.lblDelete.Text = "삭제";
            this.lblDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDelete.Click += new System.EventHandler(this.lblDelete_Click);
            // 
            // lbl항목등록
            // 
            this.lbl항목등록.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lbl항목등록.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl항목등록.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl항목등록.ForeColor = System.Drawing.Color.Transparent;
            this.lbl항목등록.Location = new System.Drawing.Point(7, 9);
            this.lbl항목등록.Name = "lbl항목등록";
            this.lbl항목등록.Size = new System.Drawing.Size(72, 32);
            this.lbl항목등록.TabIndex = 238;
            this.lbl항목등록.Text = "항목 등록";
            this.lbl항목등록.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl항목등록.Click += new System.EventHandler(this.lbl항목등록_Click);
            // 
            // lblPrint
            // 
            this.lblPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lblPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrint.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPrint.ForeColor = System.Drawing.Color.Transparent;
            this.lblPrint.Location = new System.Drawing.Point(234, 9);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(74, 32);
            this.lblPrint.TabIndex = 239;
            this.lblPrint.Text = "프린트";
            this.lblPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrint.Click += new System.EventHandler(this.lblPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.c1Sizer1.Controls.Add(this.panel5);
            this.c1Sizer1.Controls.Add(this.panel3);
            this.c1Sizer1.Controls.Add(this.c1Sizer2);
            this.c1Sizer1.Controls.Add(this.panel4);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.txt일정내용);
            this.c1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Sizer1.GridDefinition = resources.GetString("c1Sizer1.GridDefinition");
            this.c1Sizer1.Location = new System.Drawing.Point(0, 0);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1954, 914);
            this.c1Sizer1.SplitterWidth = 0;
            this.c1Sizer1.TabIndex = 240;
            this.c1Sizer1.Text = "c1Sizer1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.panel5.Controls.Add(this.lbl항목등록);
            this.panel5.Controls.Add(this.lblPrint);
            this.panel5.Controls.Add(this.lblUpdate);
            this.panel5.Controls.Add(this.lblDelete);
            this.panel5.Location = new System.Drawing.Point(1300, 860);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(650, 50);
            this.panel5.TabIndex = 228;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.panel3.Controls.Add(this.lblSave);
            this.panel3.Location = new System.Drawing.Point(4, 860);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1296, 50);
            this.panel3.TabIndex = 120;
            // 
            // c1Sizer2
            // 
            this.c1Sizer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.c1Sizer2.Controls.Add(this.panel2);
            this.c1Sizer2.Controls.Add(this.grdCalender);
            this.c1Sizer2.Controls.Add(this.grdWork);
            this.c1Sizer2.GridDefinition = "4.67289719626168:False:True;37.9672897196262:False:True;2.33644859813084:False:Tr" +
    "ue;55.0233644859813:False:False;\t100:False:False;";
            this.c1Sizer2.Location = new System.Drawing.Point(1300, 4);
            this.c1Sizer2.Name = "c1Sizer2";
            this.c1Sizer2.Padding = new System.Windows.Forms.Padding(0);
            this.c1Sizer2.Size = new System.Drawing.Size(650, 856);
            this.c1Sizer2.SplitterWidth = 0;
            this.c1Sizer2.TabIndex = 119;
            this.c1Sizer2.Text = "c1Sizer2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.lblPrevMonth);
            this.panel2.Controls.Add(this.lblPrevDay);
            this.panel2.Controls.Add(this.lblNextDay);
            this.panel2.Controls.Add(this.lblNextMonth);
            this.panel2.Controls.Add(this.lblYearMonth);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 40);
            this.panel2.TabIndex = 235;
            // 
            // lblPrevMonth
            // 
            this.lblPrevMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lblPrevMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrevMonth.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPrevMonth.ForeColor = System.Drawing.Color.Transparent;
            this.lblPrevMonth.Location = new System.Drawing.Point(154, 5);
            this.lblPrevMonth.Name = "lblPrevMonth";
            this.lblPrevMonth.Size = new System.Drawing.Size(38, 33);
            this.lblPrevMonth.TabIndex = 98;
            this.lblPrevMonth.Text = "<<";
            this.lblPrevMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrevMonth.Click += new System.EventHandler(this.lblPrevMonth_Click);
            // 
            // lblPrevDay
            // 
            this.lblPrevDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lblPrevDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrevDay.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPrevDay.ForeColor = System.Drawing.Color.Transparent;
            this.lblPrevDay.Location = new System.Drawing.Point(200, 5);
            this.lblPrevDay.Name = "lblPrevDay";
            this.lblPrevDay.Size = new System.Drawing.Size(38, 33);
            this.lblPrevDay.TabIndex = 97;
            this.lblPrevDay.Text = "<";
            this.lblPrevDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrevDay.Click += new System.EventHandler(this.lblPrevDay_Click);
            // 
            // lblNextDay
            // 
            this.lblNextDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lblNextDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNextDay.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNextDay.ForeColor = System.Drawing.Color.Transparent;
            this.lblNextDay.Location = new System.Drawing.Point(372, 5);
            this.lblNextDay.Name = "lblNextDay";
            this.lblNextDay.Size = new System.Drawing.Size(38, 33);
            this.lblNextDay.TabIndex = 99;
            this.lblNextDay.Text = ">";
            this.lblNextDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNextDay.Click += new System.EventHandler(this.lblNextDay_Click);
            // 
            // lblNextMonth
            // 
            this.lblNextMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lblNextMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNextMonth.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNextMonth.ForeColor = System.Drawing.Color.Transparent;
            this.lblNextMonth.Location = new System.Drawing.Point(417, 5);
            this.lblNextMonth.Name = "lblNextMonth";
            this.lblNextMonth.Size = new System.Drawing.Size(38, 33);
            this.lblNextMonth.TabIndex = 100;
            this.lblNextMonth.Text = ">>";
            this.lblNextMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNextMonth.Click += new System.EventHandler(this.lblNextMonth_Click);
            // 
            // lblYearMonth
            // 
            this.lblYearMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.lblYearMonth.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblYearMonth.ForeColor = System.Drawing.Color.White;
            this.lblYearMonth.Location = new System.Drawing.Point(259, 5);
            this.lblYearMonth.Name = "lblYearMonth";
            this.lblYearMonth.Size = new System.Drawing.Size(90, 33);
            this.lblYearMonth.TabIndex = 101;
            this.lblYearMonth.Text = "2021.01";
            this.lblYearMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.panel4.Controls.Add(this.label13);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1296, 40);
            this.panel4.TabIndex = 110;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(19, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 15);
            this.label13.TabIndex = 113;
            this.label13.Text = "일정메모";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm일정관리
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1954, 914);
            this.Controls.Add(this.c1Sizer1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm일정관리";
            this.Text = "일정관리";
            this.Load += new System.EventHandler(this.frm일정관리_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtp작성일자)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn기울기)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn색상)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn밑줄)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn굵기)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCalender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer2)).EndInit();
            this.c1Sizer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox txt일정내용;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Input.C1Button btn기울기;
        private C1.Win.C1Input.C1Button btn색상;
        private C1.Win.C1Input.C1Button btn밑줄;
        private C1.Win.C1Input.C1Button btn굵기;
        private C1.Win.C1FlexGrid.C1FlexGrid grdCalender;
        private C1.Win.C1FlexGrid.C1FlexGrid grdWork;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblDelete;
        private C1.Win.C1Input.C1ComboBox cboFontSize;
        private System.Windows.Forms.Label lbl항목등록;
        private System.Windows.Forms.Label lblPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private C1.Win.C1Sizer.C1Sizer c1Sizer1;
        private System.Windows.Forms.Panel panel3;
        private C1.Win.C1Sizer.C1Sizer c1Sizer2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPrevMonth;
        private System.Windows.Forms.Label lblPrevDay;
        private System.Windows.Forms.Label lblNextDay;
        private System.Windows.Forms.Label lblNextMonth;
        private System.Windows.Forms.Label lblYearMonth;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private C1.Win.Calendar.C1DateEdit dtp작성일자;
    }
}