namespace DH_CRM
{
    partial class frm매출관리
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm매출관리));
            this.grdWork = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.sizeMain = new C1.Win.C1Sizer.C1Sizer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.chk결변 = new System.Windows.Forms.CheckBox();
            this.dtp조회기간2 = new C1.Win.Calendar.C1DateEdit();
            this.chk출금 = new System.Windows.Forms.CheckBox();
            this.lbl삭제 = new System.Windows.Forms.Label();
            this.chk입금 = new System.Windows.Forms.CheckBox();
            this.dtp조회기간1 = new C1.Win.Calendar.C1DateEdit();
            this.label16 = new System.Windows.Forms.Label();
            this.cbo결제방법 = new C1.Win.C1Input.C1ComboBox();
            this.lbl수정 = new System.Windows.Forms.Label();
            this.lbl검색 = new System.Windows.Forms.Label();
            this.lbl매출등록 = new System.Windows.Forms.Label();
            this.lbl자료검색 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo담당자 = new C1.Win.C1Input.C1ComboBox();
            this.txt이름 = new C1.Win.C1Input.C1TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt금액2 = new C1.Win.C1Input.C1TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt금액1 = new C1.Win.C1Input.C1TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt수입지출 = new C1.Win.C1Input.C1TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt지출합계 = new C1.Win.C1Input.C1TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt수입합계 = new C1.Win.C1Input.C1TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeMain)).BeginInit();
            this.sizeMain.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp조회기간2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp조회기간1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo결제방법)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo담당자)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt이름)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt금액2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt금액1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt수입지출)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt지출합계)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt수입합계)).BeginInit();
            this.SuspendLayout();
            // 
            // grdWork
            // 
            this.grdWork.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.grdWork.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.grdWork.ExtendLastCol = true;
            this.grdWork.Location = new System.Drawing.Point(4, 66);
            this.grdWork.Name = "grdWork";
            this.grdWork.Size = new System.Drawing.Size(1912, 770);
            this.grdWork.StyleInfo = resources.GetString("grdWork.StyleInfo");
            this.grdWork.TabIndex = 37;
            this.grdWork.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            this.grdWork.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.grdWork_AfterEdit);
            this.grdWork.DoubleClick += new System.EventHandler(this.grdWork_DoubleClick);
            // 
            // sizeMain
            // 
            this.sizeMain.Controls.Add(this.panel2);
            this.sizeMain.Controls.Add(this.panel1);
            this.sizeMain.Controls.Add(this.grdWork);
            this.sizeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizeMain.GridDefinition = "6.48769574944072:False:True;86.1297539149888:False:False;5.59284116331096:False:T" +
    "rue;\t49.6875:False:False;49.6875:False:False;";
            this.sizeMain.Location = new System.Drawing.Point(0, 0);
            this.sizeMain.Name = "sizeMain";
            this.sizeMain.Size = new System.Drawing.Size(1920, 894);
            this.sizeMain.TabIndex = 113;
            this.sizeMain.Text = "c1Sizer1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.chk결변);
            this.panel2.Controls.Add(this.dtp조회기간2);
            this.panel2.Controls.Add(this.chk출금);
            this.panel2.Controls.Add(this.lbl삭제);
            this.panel2.Controls.Add(this.chk입금);
            this.panel2.Controls.Add(this.dtp조회기간1);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.cbo결제방법);
            this.panel2.Controls.Add(this.lbl수정);
            this.panel2.Controls.Add(this.lbl검색);
            this.panel2.Controls.Add(this.lbl매출등록);
            this.panel2.Controls.Add(this.lbl자료검색);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbo담당자);
            this.panel2.Controls.Add(this.txt이름);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txt금액2);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txt금액1);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1912, 58);
            this.panel2.TabIndex = 111;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(710, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 135;
            this.label4.Text = "금액";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chk결변
            // 
            this.chk결변.AutoSize = true;
            this.chk결변.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk결변.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk결변.ForeColor = System.Drawing.Color.White;
            this.chk결변.Location = new System.Drawing.Point(1597, 21);
            this.chk결변.Name = "chk결변";
            this.chk결변.Size = new System.Drawing.Size(50, 19);
            this.chk결변.TabIndex = 132;
            this.chk결변.Text = "결변";
            this.chk결변.UseVisualStyleBackColor = true;
            // 
            // dtp조회기간2
            // 
            this.dtp조회기간2.AutoSize = false;
            this.dtp조회기간2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtp조회기간2.Calendar.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp조회기간2.Calendar.BackColor = System.Drawing.Color.White;
            this.dtp조회기간2.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp조회기간2.Calendar.DayNamesFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp조회기간2.Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp조회기간2.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.dtp조회기간2.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.dtp조회기간2.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp조회기간2.Calendar.TitleBackColor = System.Drawing.Color.White;
            this.dtp조회기간2.Calendar.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp조회기간2.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp조회기간2.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.dtp조회기간2.Calendar.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp조회기간2.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.dtp조회기간2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp조회기간2.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp조회기간2.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp조회기간2.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp조회기간2.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp조회기간2.EmptyAsNull = true;
            this.dtp조회기간2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp조회기간2.ImagePadding = new System.Windows.Forms.Padding(0);
            this.dtp조회기간2.Location = new System.Drawing.Point(1134, 14);
            this.dtp조회기간2.Name = "dtp조회기간2";
            this.dtp조회기간2.Size = new System.Drawing.Size(98, 30);
            this.dtp조회기간2.TabIndex = 134;
            this.dtp조회기간2.Tag = null;
            this.dtp조회기간2.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dtp조회기간2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            this.dtp조회기간2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // chk출금
            // 
            this.chk출금.AutoSize = true;
            this.chk출금.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk출금.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk출금.ForeColor = System.Drawing.Color.White;
            this.chk출금.Location = new System.Drawing.Point(1525, 21);
            this.chk출금.Name = "chk출금";
            this.chk출금.Size = new System.Drawing.Size(50, 19);
            this.chk출금.TabIndex = 131;
            this.chk출금.Text = "출금";
            this.chk출금.UseVisualStyleBackColor = true;
            // 
            // lbl삭제
            // 
            this.lbl삭제.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lbl삭제.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl삭제.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl삭제.ForeColor = System.Drawing.Color.White;
            this.lbl삭제.Location = new System.Drawing.Point(302, 11);
            this.lbl삭제.Name = "lbl삭제";
            this.lbl삭제.Size = new System.Drawing.Size(92, 37);
            this.lbl삭제.TabIndex = 122;
            this.lbl삭제.Text = "삭제";
            this.lbl삭제.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl삭제.Click += new System.EventHandler(this.lbl삭제_Click);
            // 
            // chk입금
            // 
            this.chk입금.AutoSize = true;
            this.chk입금.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk입금.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk입금.ForeColor = System.Drawing.Color.White;
            this.chk입금.Location = new System.Drawing.Point(1454, 21);
            this.chk입금.Name = "chk입금";
            this.chk입금.Size = new System.Drawing.Size(50, 19);
            this.chk입금.TabIndex = 130;
            this.chk입금.Text = "입금";
            this.chk입금.UseVisualStyleBackColor = true;
            // 
            // dtp조회기간1
            // 
            this.dtp조회기간1.AutoSize = false;
            this.dtp조회기간1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtp조회기간1.Calendar.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp조회기간1.Calendar.BackColor = System.Drawing.Color.White;
            this.dtp조회기간1.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp조회기간1.Calendar.DayNamesFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp조회기간1.Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp조회기간1.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.dtp조회기간1.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.dtp조회기간1.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp조회기간1.Calendar.TitleBackColor = System.Drawing.Color.White;
            this.dtp조회기간1.Calendar.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp조회기간1.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp조회기간1.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.dtp조회기간1.Calendar.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp조회기간1.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.dtp조회기간1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp조회기간1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp조회기간1.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp조회기간1.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp조회기간1.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp조회기간1.EmptyAsNull = true;
            this.dtp조회기간1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp조회기간1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.dtp조회기간1.Location = new System.Drawing.Point(1008, 14);
            this.dtp조회기간1.Name = "dtp조회기간1";
            this.dtp조회기간1.Size = new System.Drawing.Size(98, 30);
            this.dtp조회기간1.TabIndex = 133;
            this.dtp조회기간1.Tag = null;
            this.dtp조회기간1.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dtp조회기간1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            this.dtp조회기간1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(1238, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 15);
            this.label16.TabIndex = 129;
            this.label16.Text = "결제방법";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbo결제방법
            // 
            this.cbo결제방법.AllowSpinLoop = false;
            this.cbo결제방법.AutoSize = false;
            this.cbo결제방법.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo결제방법.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo결제방법.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo결제방법.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo결제방법.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo결제방법.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo결제방법.GapHeight = 0;
            this.cbo결제방법.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo결제방법.ItemsDisplayMember = "";
            this.cbo결제방법.ItemsValueMember = "";
            this.cbo결제방법.Location = new System.Drawing.Point(1299, 14);
            this.cbo결제방법.Name = "cbo결제방법";
            this.cbo결제방법.Size = new System.Drawing.Size(132, 29);
            this.cbo결제방법.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo결제방법.TabIndex = 128;
            this.cbo결제방법.Tag = null;
            this.cbo결제방법.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo결제방법.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // lbl수정
            // 
            this.lbl수정.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lbl수정.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl수정.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl수정.ForeColor = System.Drawing.Color.White;
            this.lbl수정.Location = new System.Drawing.Point(204, 11);
            this.lbl수정.Name = "lbl수정";
            this.lbl수정.Size = new System.Drawing.Size(92, 37);
            this.lbl수정.TabIndex = 121;
            this.lbl수정.Text = "수정";
            this.lbl수정.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl수정.Click += new System.EventHandler(this.lbl수정_Click);
            // 
            // lbl검색
            // 
            this.lbl검색.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lbl검색.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl검색.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl검색.ForeColor = System.Drawing.Color.White;
            this.lbl검색.Location = new System.Drawing.Point(1681, 15);
            this.lbl검색.Name = "lbl검색";
            this.lbl검색.Size = new System.Drawing.Size(122, 29);
            this.lbl검색.TabIndex = 117;
            this.lbl검색.Text = "검색";
            this.lbl검색.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl검색.Click += new System.EventHandler(this.lbl검색_Click_1);
            // 
            // lbl매출등록
            // 
            this.lbl매출등록.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lbl매출등록.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl매출등록.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl매출등록.ForeColor = System.Drawing.Color.White;
            this.lbl매출등록.Location = new System.Drawing.Point(106, 11);
            this.lbl매출등록.Name = "lbl매출등록";
            this.lbl매출등록.Size = new System.Drawing.Size(92, 37);
            this.lbl매출등록.TabIndex = 120;
            this.lbl매출등록.Text = "매출 등록";
            this.lbl매출등록.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl매출등록.Click += new System.EventHandler(this.lbl매출등록_Click);
            // 
            // lbl자료검색
            // 
            this.lbl자료검색.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lbl자료검색.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl자료검색.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl자료검색.ForeColor = System.Drawing.Color.White;
            this.lbl자료검색.Location = new System.Drawing.Point(8, 11);
            this.lbl자료검색.Name = "lbl자료검색";
            this.lbl자료검색.Size = new System.Drawing.Size(92, 37);
            this.lbl자료검색.TabIndex = 119;
            this.lbl자료검색.Text = "자료 검색";
            this.lbl자료검색.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl자료검색.Click += new System.EventHandler(this.lbl자료검색_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(400, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 111;
            this.label6.Text = "이름";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cbo담당자.Location = new System.Drawing.Point(572, 14);
            this.cbo담당자.Name = "cbo담당자";
            this.cbo담당자.Size = new System.Drawing.Size(132, 29);
            this.cbo담당자.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo담당자.TabIndex = 104;
            this.cbo담당자.Tag = null;
            this.cbo담당자.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo담당자.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // txt이름
            // 
            this.txt이름.AutoSize = false;
            this.txt이름.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt이름.Location = new System.Drawing.Point(437, 14);
            this.txt이름.Name = "txt이름";
            this.txt이름.Size = new System.Drawing.Size(80, 29);
            this.txt이름.TabIndex = 103;
            this.txt이름.Tag = null;
            this.txt이름.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt이름.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(1112, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 15);
            this.label15.TabIndex = 127;
            this.label15.Text = "~";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(523, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 113;
            this.label7.Text = "담당자";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(973, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 15);
            this.label14.TabIndex = 125;
            this.label14.Text = "기간";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(849, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 15);
            this.label13.TabIndex = 123;
            this.label13.Text = "~";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt금액2
            // 
            this.txt금액2.AutoSize = false;
            this.txt금액2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt금액2.Location = new System.Drawing.Point(871, 14);
            this.txt금액2.Name = "txt금액2";
            this.txt금액2.Size = new System.Drawing.Size(96, 29);
            this.txt금액2.TabIndex = 122;
            this.txt금액2.Tag = null;
            this.txt금액2.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt금액2.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(935, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 15);
            this.label12.TabIndex = 121;
            this.label12.Text = "금액";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt금액1
            // 
            this.txt금액1.AutoSize = false;
            this.txt금액1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt금액1.Location = new System.Drawing.Point(747, 14);
            this.txt금액1.Name = "txt금액1";
            this.txt금액1.Size = new System.Drawing.Size(96, 29);
            this.txt금액1.TabIndex = 120;
            this.txt금액1.Tag = null;
            this.txt금액1.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt금액1.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.txt수입지출);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt지출합계);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt수입합계);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 840);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1912, 50);
            this.panel1.TabIndex = 110;
            // 
            // txt수입지출
            // 
            this.txt수입지출.AutoSize = false;
            this.txt수입지출.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt수입지출.Location = new System.Drawing.Point(526, 12);
            this.txt수입지출.Name = "txt수입지출";
            this.txt수입지출.Size = new System.Drawing.Size(139, 29);
            this.txt수입지출.TabIndex = 134;
            this.txt수입지출.Tag = null;
            this.txt수입지출.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt수입지출.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(464, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 133;
            this.label8.Text = "수입-지출";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt지출합계
            // 
            this.txt지출합계.AutoSize = false;
            this.txt지출합계.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt지출합계.ForeColor = System.Drawing.Color.Red;
            this.txt지출합계.Location = new System.Drawing.Point(298, 12);
            this.txt지출합계.Name = "txt지출합계";
            this.txt지출합계.Size = new System.Drawing.Size(139, 29);
            this.txt지출합계.TabIndex = 132;
            this.txt지출합계.Tag = null;
            this.txt지출합계.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(236, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 131;
            this.label1.Text = "지출합계";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt수입합계
            // 
            this.txt수입합계.AutoSize = false;
            this.txt수입합계.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt수입합계.Location = new System.Drawing.Point(70, 12);
            this.txt수입합계.Name = "txt수입합계";
            this.txt수입합계.Size = new System.Drawing.Size(139, 29);
            this.txt수입합계.TabIndex = 130;
            this.txt수입합계.Tag = null;
            this.txt수입합계.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt수입합계.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 129;
            this.label2.Text = "수입합계";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm매출관리
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1920, 894);
            this.Controls.Add(this.sizeMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm매출관리";
            this.Text = "frm매출관리";
            this.Load += new System.EventHandler(this.frm매출관리_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeMain)).EndInit();
            this.sizeMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp조회기간2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp조회기간1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo결제방법)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo담당자)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt이름)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt금액2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt금액1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt수입지출)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt지출합계)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt수입합계)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.C1FlexGrid.C1FlexGrid grdWork;
        private C1.Win.C1Sizer.C1Sizer sizeMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl삭제;
        private System.Windows.Forms.Label lbl수정;
        private System.Windows.Forms.Label lbl매출등록;
        private System.Windows.Forms.Label lbl자료검색;
        private System.Windows.Forms.Label label6;
        private C1.Win.C1Input.C1ComboBox cbo담당자;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private C1.Win.C1Input.C1TextBox txt금액2;
        private System.Windows.Forms.Label label12;
        private C1.Win.C1Input.C1TextBox txt금액1;
        private C1.Win.Calendar.C1DateEdit dtp조회기간2;
        private C1.Win.Calendar.C1DateEdit dtp조회기간1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chk결변;
        private System.Windows.Forms.CheckBox chk출금;
        private System.Windows.Forms.CheckBox chk입금;
        private System.Windows.Forms.Label label16;
        private C1.Win.C1Input.C1ComboBox cbo결제방법;
        private System.Windows.Forms.Label lbl검색;
        private C1.Win.C1Input.C1TextBox txt이름;
        private System.Windows.Forms.Label label4;
        private C1.Win.C1Input.C1TextBox txt수입지출;
        private System.Windows.Forms.Label label8;
        private C1.Win.C1Input.C1TextBox txt지출합계;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Input.C1TextBox txt수입합계;
        private System.Windows.Forms.Label label2;
    }
}