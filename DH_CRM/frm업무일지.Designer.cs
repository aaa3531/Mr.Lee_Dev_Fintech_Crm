namespace DH_CRM
{
    partial class frm업무일지
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm업무일지));
            this.lblUser = new System.Windows.Forms.Label();
            this.dtp작성일자 = new C1.Win.Calendar.C1DateEdit();
            this.cbo상태 = new C1.Win.C1Input.C1ComboBox();
            this.txt금일업무 = new C1.Win.C1Input.C1TextBox();
            this.txt예정업무 = new C1.Win.C1Input.C1TextBox();
            this.grdWork = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.lblNew = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblPrevDay = new System.Windows.Forms.Label();
            this.lblPrevMonth = new System.Windows.Forms.Label();
            this.lblNextDay = new System.Windows.Forms.Label();
            this.lblNextMonth = new System.Windows.Forms.Label();
            this.lblYearMonth = new System.Windows.Forms.Label();
            this.grdCalender = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.lblPrint = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt댓글 = new C1.Win.C1Input.C1TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.c1Sizer2 = new C1.Win.C1Sizer.C1Sizer();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtp작성일자)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo상태)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt금일업무)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt예정업무)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCalender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt댓글)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer2)).BeginInit();
            this.c1Sizer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(44)))), ((int)(((byte)(81)))));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(120, 49);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(103, 29);
            this.lblUser.TabIndex = 11;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dtp작성일자.Location = new System.Drawing.Point(359, 48);
            this.dtp작성일자.Name = "dtp작성일자";
            this.dtp작성일자.Size = new System.Drawing.Size(120, 29);
            this.dtp작성일자.TabIndex = 18;
            this.dtp작성일자.Tag = null;
            this.dtp작성일자.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dtp작성일자.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            this.dtp작성일자.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // cbo상태
            // 
            this.cbo상태.AllowSpinLoop = false;
            this.cbo상태.AutoSize = false;
            this.cbo상태.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo상태.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo상태.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo상태.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo상태.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo상태.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo상태.GapHeight = 0;
            this.cbo상태.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo상태.ItemsDisplayMember = "";
            this.cbo상태.ItemsValueMember = "";
            this.cbo상태.Location = new System.Drawing.Point(610, 48);
            this.cbo상태.Name = "cbo상태";
            this.cbo상태.Size = new System.Drawing.Size(120, 29);
            this.cbo상태.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo상태.TabIndex = 25;
            this.cbo상태.Tag = null;
            this.cbo상태.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo상태.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // txt금일업무
            // 
            this.txt금일업무.AutoSize = false;
            this.txt금일업무.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt금일업무.Location = new System.Drawing.Point(104, 104);
            this.txt금일업무.Multiline = true;
            this.txt금일업무.Name = "txt금일업무";
            this.txt금일업무.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt금일업무.Size = new System.Drawing.Size(1164, 274);
            this.txt금일업무.TabIndex = 86;
            this.txt금일업무.Tag = null;
            // 
            // txt예정업무
            // 
            this.txt예정업무.AutoSize = false;
            this.txt예정업무.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt예정업무.Location = new System.Drawing.Point(104, 386);
            this.txt예정업무.Multiline = true;
            this.txt예정업무.Name = "txt예정업무";
            this.txt예정업무.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt예정업무.Size = new System.Drawing.Size(1164, 277);
            this.txt예정업무.TabIndex = 87;
            this.txt예정업무.Tag = null;
            // 
            // grdWork
            // 
            this.grdWork.AllowEditing = false;
            this.grdWork.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.grdWork.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.grdWork.ExtendLastCol = true;
            this.grdWork.Location = new System.Drawing.Point(0, 394);
            this.grdWork.Name = "grdWork";
            this.grdWork.Size = new System.Drawing.Size(650, 353);
            this.grdWork.StyleInfo = resources.GetString("grdWork.StyleInfo");
            this.grdWork.TabIndex = 88;
            this.grdWork.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            this.grdWork.DoubleClick += new System.EventHandler(this.grdWork_DoubleClick);
            // 
            // lblNew
            // 
            this.lblNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lblNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNew.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNew.ForeColor = System.Drawing.Color.Transparent;
            this.lblNew.Location = new System.Drawing.Point(10, 10);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(140, 31);
            this.lblNew.TabIndex = 89;
            this.lblNew.Text = "신규 등록";
            this.lblNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNew.Click += new System.EventHandler(this.lblNew_Click);
            // 
            // lblSave
            // 
            this.lblSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lblSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSave.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSave.ForeColor = System.Drawing.Color.Transparent;
            this.lblSave.Location = new System.Drawing.Point(163, 10);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(140, 31);
            this.lblSave.TabIndex = 90;
            this.lblSave.Text = "저장 하기";
            this.lblSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lblDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDelete.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDelete.ForeColor = System.Drawing.Color.Transparent;
            this.lblDelete.Location = new System.Drawing.Point(152, 9);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(74, 33);
            this.lblDelete.TabIndex = 91;
            this.lblDelete.Text = "삭제";
            this.lblDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDelete.Click += new System.EventHandler(this.lblDelete_Click);
            // 
            // lblPrevDay
            // 
            this.lblPrevDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lblPrevDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrevDay.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPrevDay.ForeColor = System.Drawing.Color.Transparent;
            this.lblPrevDay.Location = new System.Drawing.Point(211, 54);
            this.lblPrevDay.Name = "lblPrevDay";
            this.lblPrevDay.Size = new System.Drawing.Size(38, 33);
            this.lblPrevDay.TabIndex = 92;
            this.lblPrevDay.Text = "<";
            this.lblPrevDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrevDay.Click += new System.EventHandler(this.lblPrevDay_Click);
            // 
            // lblPrevMonth
            // 
            this.lblPrevMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lblPrevMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrevMonth.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPrevMonth.ForeColor = System.Drawing.Color.Transparent;
            this.lblPrevMonth.Location = new System.Drawing.Point(165, 54);
            this.lblPrevMonth.Name = "lblPrevMonth";
            this.lblPrevMonth.Size = new System.Drawing.Size(38, 33);
            this.lblPrevMonth.TabIndex = 93;
            this.lblPrevMonth.Text = "<<";
            this.lblPrevMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrevMonth.Click += new System.EventHandler(this.lblPrevMonth_Click);
            // 
            // lblNextDay
            // 
            this.lblNextDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lblNextDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNextDay.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNextDay.ForeColor = System.Drawing.Color.Transparent;
            this.lblNextDay.Location = new System.Drawing.Point(383, 54);
            this.lblNextDay.Name = "lblNextDay";
            this.lblNextDay.Size = new System.Drawing.Size(38, 33);
            this.lblNextDay.TabIndex = 94;
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
            this.lblNextMonth.Location = new System.Drawing.Point(428, 54);
            this.lblNextMonth.Name = "lblNextMonth";
            this.lblNextMonth.Size = new System.Drawing.Size(38, 33);
            this.lblNextMonth.TabIndex = 95;
            this.lblNextMonth.Text = ">>";
            this.lblNextMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNextMonth.Click += new System.EventHandler(this.lblNextMonth_Click);
            // 
            // lblYearMonth
            // 
            this.lblYearMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.lblYearMonth.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblYearMonth.ForeColor = System.Drawing.Color.White;
            this.lblYearMonth.Location = new System.Drawing.Point(270, 54);
            this.lblYearMonth.Name = "lblYearMonth";
            this.lblYearMonth.Size = new System.Drawing.Size(90, 33);
            this.lblYearMonth.TabIndex = 96;
            this.lblYearMonth.Text = "2021.01";
            this.lblYearMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grdCalender
            // 
            this.grdCalender.AllowEditing = false;
            this.grdCalender.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.grdCalender.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.grdCalender.ExtendLastCol = true;
            this.grdCalender.Location = new System.Drawing.Point(0, 0);
            this.grdCalender.Name = "grdCalender";
            this.grdCalender.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.grdCalender.Size = new System.Drawing.Size(650, 377);
            this.grdCalender.StyleInfo = resources.GetString("grdCalender.StyleInfo");
            this.grdCalender.TabIndex = 97;
            this.grdCalender.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            this.grdCalender.Click += new System.EventHandler(this.grdCalender_Click);
            // 
            // lblPrint
            // 
            this.lblPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lblPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrint.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPrint.ForeColor = System.Drawing.Color.Transparent;
            this.lblPrint.Location = new System.Drawing.Point(232, 9);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(74, 33);
            this.lblPrint.TabIndex = 99;
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
            this.c1Sizer1.Controls.Add(this.panel2);
            this.c1Sizer1.Controls.Add(this.panel5);
            this.c1Sizer1.Controls.Add(this.txt댓글);
            this.c1Sizer1.Controls.Add(this.panel3);
            this.c1Sizer1.Controls.Add(this.c1Sizer2);
            this.c1Sizer1.Controls.Add(this.label9);
            this.c1Sizer1.Controls.Add(this.label8);
            this.c1Sizer1.Controls.Add(this.txt예정업무);
            this.c1Sizer1.Controls.Add(this.txt금일업무);
            this.c1Sizer1.Controls.Add(this.label6);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Sizer1.GridDefinition = resources.GetString("c1Sizer1.GridDefinition");
            this.c1Sizer1.Location = new System.Drawing.Point(0, 0);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1922, 905);
            this.c1Sizer1.SplitterWidth = 0;
            this.c1Sizer1.TabIndex = 100;
            this.c1Sizer1.Text = "c1Sizer1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.lblPrevMonth);
            this.panel2.Controls.Add(this.lblPrevDay);
            this.panel2.Controls.Add(this.lblNextDay);
            this.panel2.Controls.Add(this.lblNextMonth);
            this.panel2.Controls.Add(this.lblYearMonth);
            this.panel2.Location = new System.Drawing.Point(1268, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 100);
            this.panel2.TabIndex = 120;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.lblPrint);
            this.panel5.Controls.Add(this.lblDelete);
            this.panel5.Location = new System.Drawing.Point(1268, 851);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(650, 50);
            this.panel5.TabIndex = 229;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 33);
            this.label1.TabIndex = 100;
            this.label1.Text = "상태";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt댓글
            // 
            this.txt댓글.AutoSize = false;
            this.txt댓글.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt댓글.Location = new System.Drawing.Point(104, 671);
            this.txt댓글.Multiline = true;
            this.txt댓글.Name = "txt댓글";
            this.txt댓글.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt댓글.Size = new System.Drawing.Size(1164, 180);
            this.txt댓글.TabIndex = 121;
            this.txt댓글.Tag = null;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.panel3.Controls.Add(this.lblNew);
            this.panel3.Controls.Add(this.lblSave);
            this.panel3.Location = new System.Drawing.Point(4, 851);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1264, 50);
            this.panel3.TabIndex = 120;
            // 
            // c1Sizer2
            // 
            this.c1Sizer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.c1Sizer2.Controls.Add(this.grdCalender);
            this.c1Sizer2.Controls.Add(this.grdWork);
            this.c1Sizer2.GridDefinition = "9.77242302543507:False:False;40.6961178045515:False:False;2.27576974564926:False:" +
    "False;47.2556894243641:False:False;\t100:False:False;";
            this.c1Sizer2.Location = new System.Drawing.Point(1268, 104);
            this.c1Sizer2.Name = "c1Sizer2";
            this.c1Sizer2.Padding = new System.Windows.Forms.Padding(0);
            this.c1Sizer2.Size = new System.Drawing.Size(650, 747);
            this.c1Sizer2.SplitterWidth = 0;
            this.c1Sizer2.TabIndex = 119;
            this.c1Sizer2.Text = "c1Sizer2";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(119)))));
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(4, 671);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 180);
            this.label9.TabIndex = 118;
            this.label9.Text = "댓글";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(119)))));
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(4, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 277);
            this.label8.TabIndex = 117;
            this.label8.Text = "예정 업무";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(119)))));
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 274);
            this.label6.TabIndex = 115;
            this.label6.Text = "금일 업무";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbo상태);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtp작성일자);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 100);
            this.panel1.TabIndex = 110;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(119)))));
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(509, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 116;
            this.label5.Text = "상태";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(119)))));
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(258, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 115;
            this.label4.Text = "작성날짜";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(119)))));
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 114;
            this.label3.Text = "작성자";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 113;
            this.label2.Text = "업무등록";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm업무일지
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1922, 905);
            this.Controls.Add(this.c1Sizer1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm업무일지";
            this.Text = "frm업무일지";
            this.Load += new System.EventHandler(this.frm업무일지_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtp작성일자)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo상태)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt금일업무)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt예정업무)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCalender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt댓글)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer2)).EndInit();
            this.c1Sizer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUser;
        private C1.Win.Calendar.C1DateEdit dtp작성일자;
        private C1.Win.C1Input.C1ComboBox cbo상태;
        private C1.Win.C1Input.C1TextBox txt금일업무;
        private C1.Win.C1Input.C1TextBox txt예정업무;
        private C1.Win.C1FlexGrid.C1FlexGrid grdWork;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblPrevDay;
        private System.Windows.Forms.Label lblPrevMonth;
        private System.Windows.Forms.Label lblNextDay;
        private System.Windows.Forms.Label lblNextMonth;
        private System.Windows.Forms.Label lblYearMonth;
        private C1.Win.C1FlexGrid.C1FlexGrid grdCalender;
        private System.Windows.Forms.Label lblPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private C1.Win.C1Sizer.C1Sizer c1Sizer1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Sizer.C1Sizer c1Sizer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1Input.C1TextBox txt댓글;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
    }
}