namespace DH_CRM
{
    partial class frm매출등록
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm매출등록));
            this.picMain = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTopBar = new System.Windows.Forms.Label();
            this.lbl등록 = new System.Windows.Forms.Label();
            this.txt이름 = new C1.Win.C1Input.C1TextBox();
            this.dtp매출일자 = new C1.Win.Calendar.C1DateEdit();
            this.cbo가입경로 = new C1.Win.C1Input.C1ComboBox();
            this.cbo담당자 = new C1.Win.C1Input.C1ComboBox();
            this.txt휴대폰 = new C1.Win.C1Input.C1TextBox();
            this.dtp결제일자 = new C1.Win.Calendar.C1DateEdit();
            this.txt금액 = new C1.Win.C1Input.C1TextBox();
            this.txt카드사별적용내역 = new C1.Win.C1Input.C1TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.opt영업자별매출2 = new System.Windows.Forms.RadioButton();
            this.opt영업자별매출1 = new System.Windows.Forms.RadioButton();
            this.cbo결제수단 = new C1.Win.C1Input.C1ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.opt현금영수증발행2 = new System.Windows.Forms.RadioButton();
            this.opt현금영수증발행1 = new System.Windows.Forms.RadioButton();
            this.txt현금영수증번호 = new C1.Win.C1Input.C1TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.opt토스건결제유무2 = new System.Windows.Forms.RadioButton();
            this.opt토스건결제유무1 = new System.Windows.Forms.RadioButton();
            this.cbo토스담당자 = new C1.Win.C1Input.C1ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.opt인바운드유무2 = new System.Windows.Forms.RadioButton();
            this.opt인바운드유무1 = new System.Windows.Forms.RadioButton();
            this.lbl고객정보 = new System.Windows.Forms.Label();
            this.cbo결제구분 = new C1.Win.C1Input.C1ComboBox();
            this.cbo가입반 = new C1.Win.C1Input.C1ComboBox();
            this.cboPG사 = new C1.Win.C1Input.C1ComboBox();
            this.cbo카드사 = new C1.Win.C1Input.C1ComboBox();
            this.cbo할부변경 = new C1.Win.C1Input.C1ComboBox();
            this.lbl결제수단변경 = new System.Windows.Forms.Label();
            this.lbl환불처리 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt이름)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp매출일자)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo가입경로)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo담당자)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt휴대폰)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp결제일자)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt금액)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt카드사별적용내역)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo결제수단)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt현금영수증번호)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo토스담당자)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo결제구분)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo가입반)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPG사)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo카드사)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo할부변경)).BeginInit();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.BackColor = System.Drawing.SystemColors.Control;
            this.picMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(0, 0);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(542, 886);
            this.picMain.TabIndex = 13;
            this.picMain.TabStop = false;
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClose.Location = new System.Drawing.Point(503, 6);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 28);
            this.lblClose.TabIndex = 13;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblTopBar
            // 
            this.lblTopBar.BackColor = System.Drawing.Color.Transparent;
            this.lblTopBar.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTopBar.Location = new System.Drawing.Point(6, 6);
            this.lblTopBar.Name = "lblTopBar";
            this.lblTopBar.Size = new System.Drawing.Size(491, 28);
            this.lblTopBar.TabIndex = 104;
            // 
            // lbl등록
            // 
            this.lbl등록.BackColor = System.Drawing.Color.Transparent;
            this.lbl등록.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl등록.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl등록.Location = new System.Drawing.Point(337, 831);
            this.lbl등록.Name = "lbl등록";
            this.lbl등록.Size = new System.Drawing.Size(121, 38);
            this.lbl등록.TabIndex = 12;
            this.lbl등록.Click += new System.EventHandler(this.lbl등록_Click);
            // 
            // txt이름
            // 
            this.txt이름.AutoSize = false;
            this.txt이름.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt이름.Location = new System.Drawing.Point(83, 115);
            this.txt이름.Name = "txt이름";
            this.txt이름.Size = new System.Drawing.Size(181, 29);
            this.txt이름.TabIndex = 1;
            this.txt이름.Tag = null;
            this.txt이름.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt이름.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // dtp매출일자
            // 
            this.dtp매출일자.AutoSize = false;
            this.dtp매출일자.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtp매출일자.Calendar.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp매출일자.Calendar.BackColor = System.Drawing.Color.White;
            this.dtp매출일자.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp매출일자.Calendar.DayNamesFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp매출일자.Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp매출일자.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.dtp매출일자.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.dtp매출일자.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp매출일자.Calendar.TitleBackColor = System.Drawing.Color.White;
            this.dtp매출일자.Calendar.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp매출일자.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp매출일자.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.dtp매출일자.Calendar.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp매출일자.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.dtp매출일자.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp매출일자.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp매출일자.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp매출일자.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp매출일자.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp매출일자.EmptyAsNull = true;
            this.dtp매출일자.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp매출일자.ImagePadding = new System.Windows.Forms.Padding(0);
            this.dtp매출일자.Location = new System.Drawing.Point(83, 75);
            this.dtp매출일자.Name = "dtp매출일자";
            this.dtp매출일자.Size = new System.Drawing.Size(181, 29);
            this.dtp매출일자.TabIndex = 0;
            this.dtp매출일자.Tag = null;
            this.dtp매출일자.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dtp매출일자.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            this.dtp매출일자.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // cbo가입경로
            // 
            this.cbo가입경로.AllowSpinLoop = false;
            this.cbo가입경로.AutoSize = false;
            this.cbo가입경로.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo가입경로.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo가입경로.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo가입경로.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo가입경로.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo가입경로.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo가입경로.GapHeight = 0;
            this.cbo가입경로.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo가입경로.ItemsDisplayMember = "";
            this.cbo가입경로.ItemsValueMember = "";
            this.cbo가입경로.Location = new System.Drawing.Point(83, 156);
            this.cbo가입경로.Name = "cbo가입경로";
            this.cbo가입경로.Size = new System.Drawing.Size(181, 29);
            this.cbo가입경로.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo가입경로.TabIndex = 3;
            this.cbo가입경로.Tag = null;
            this.cbo가입경로.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo가입경로.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
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
            this.cbo담당자.Location = new System.Drawing.Point(83, 195);
            this.cbo담당자.Name = "cbo담당자";
            this.cbo담당자.Size = new System.Drawing.Size(181, 29);
            this.cbo담당자.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo담당자.TabIndex = 4;
            this.cbo담당자.Tag = null;
            this.cbo담당자.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo담당자.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // txt휴대폰
            // 
            this.txt휴대폰.AutoSize = false;
            this.txt휴대폰.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt휴대폰.Location = new System.Drawing.Point(353, 115);
            this.txt휴대폰.Name = "txt휴대폰";
            this.txt휴대폰.Size = new System.Drawing.Size(178, 29);
            this.txt휴대폰.TabIndex = 2;
            this.txt휴대폰.Tag = null;
            this.txt휴대폰.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt휴대폰.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // dtp결제일자
            // 
            this.dtp결제일자.AutoSize = false;
            this.dtp결제일자.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtp결제일자.Calendar.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp결제일자.Calendar.BackColor = System.Drawing.Color.White;
            this.dtp결제일자.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp결제일자.Calendar.DayNamesFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp결제일자.Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp결제일자.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.dtp결제일자.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.dtp결제일자.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp결제일자.Calendar.TitleBackColor = System.Drawing.Color.White;
            this.dtp결제일자.Calendar.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp결제일자.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp결제일자.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.dtp결제일자.Calendar.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp결제일자.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.dtp결제일자.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp결제일자.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp결제일자.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp결제일자.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp결제일자.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp결제일자.EmptyAsNull = true;
            this.dtp결제일자.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp결제일자.ImagePadding = new System.Windows.Forms.Padding(0);
            this.dtp결제일자.Location = new System.Drawing.Point(352, 278);
            this.dtp결제일자.Name = "dtp결제일자";
            this.dtp결제일자.Size = new System.Drawing.Size(178, 29);
            this.dtp결제일자.TabIndex = 6;
            this.dtp결제일자.Tag = null;
            this.dtp결제일자.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dtp결제일자.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            this.dtp결제일자.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // txt금액
            // 
            this.txt금액.AutoSize = false;
            this.txt금액.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt금액.Location = new System.Drawing.Point(85, 278);
            this.txt금액.Name = "txt금액";
            this.txt금액.Size = new System.Drawing.Size(178, 29);
            this.txt금액.TabIndex = 5;
            this.txt금액.Tag = null;
            this.txt금액.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt금액.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // txt카드사별적용내역
            // 
            this.txt카드사별적용내역.AutoSize = false;
            this.txt카드사별적용내역.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt카드사별적용내역.Location = new System.Drawing.Point(83, 400);
            this.txt카드사별적용내역.Name = "txt카드사별적용내역";
            this.txt카드사별적용내역.Size = new System.Drawing.Size(447, 29);
            this.txt카드사별적용내역.TabIndex = 9;
            this.txt카드사별적용내역.Tag = null;
            this.txt카드사별적용내역.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt카드사별적용내역.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.opt영업자별매출2);
            this.panel1.Controls.Add(this.opt영업자별매출1);
            this.panel1.Location = new System.Drawing.Point(10, 483);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 42);
            this.panel1.TabIndex = 117;
            // 
            // opt영업자별매출2
            // 
            this.opt영업자별매출2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.opt영업자별매출2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opt영업자별매출2.Location = new System.Drawing.Point(241, 9);
            this.opt영업자별매출2.Name = "opt영업자별매출2";
            this.opt영업자별매출2.Size = new System.Drawing.Size(24, 24);
            this.opt영업자별매출2.TabIndex = 1;
            this.opt영업자별매출2.UseVisualStyleBackColor = false;
            // 
            // opt영업자별매출1
            // 
            this.opt영업자별매출1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.opt영업자별매출1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opt영업자별매출1.Checked = true;
            this.opt영업자별매출1.Location = new System.Drawing.Point(3, 9);
            this.opt영업자별매출1.Name = "opt영업자별매출1";
            this.opt영업자별매출1.Size = new System.Drawing.Size(24, 24);
            this.opt영업자별매출1.TabIndex = 0;
            this.opt영업자별매출1.TabStop = true;
            this.opt영업자별매출1.UseVisualStyleBackColor = false;
            // 
            // cbo결제수단
            // 
            this.cbo결제수단.AllowSpinLoop = false;
            this.cbo결제수단.AutoSize = false;
            this.cbo결제수단.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo결제수단.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo결제수단.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo결제수단.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo결제수단.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo결제수단.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo결제수단.GapHeight = 0;
            this.cbo결제수단.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo결제수단.ItemsDisplayMember = "";
            this.cbo결제수단.ItemsValueMember = "";
            this.cbo결제수단.Location = new System.Drawing.Point(85, 317);
            this.cbo결제수단.Name = "cbo결제수단";
            this.cbo결제수단.Size = new System.Drawing.Size(178, 29);
            this.cbo결제수단.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo결제수단.TabIndex = 7;
            this.cbo결제수단.Tag = null;
            this.cbo결제수단.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo결제수단.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.cbo결제수단.SelectedIndexChanged += new System.EventHandler(this.cbo결제수단_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.opt현금영수증발행2);
            this.panel2.Controls.Add(this.opt현금영수증발행1);
            this.panel2.Location = new System.Drawing.Point(11, 578);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 42);
            this.panel2.TabIndex = 119;
            // 
            // opt현금영수증발행2
            // 
            this.opt현금영수증발행2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.opt현금영수증발행2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opt현금영수증발행2.Location = new System.Drawing.Point(241, 9);
            this.opt현금영수증발행2.Name = "opt현금영수증발행2";
            this.opt현금영수증발행2.Size = new System.Drawing.Size(24, 24);
            this.opt현금영수증발행2.TabIndex = 1;
            this.opt현금영수증발행2.UseVisualStyleBackColor = false;
            this.opt현금영수증발행2.CheckedChanged += new System.EventHandler(this.opt현금영수증발행2_CheckedChanged);
            // 
            // opt현금영수증발행1
            // 
            this.opt현금영수증발행1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.opt현금영수증발행1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opt현금영수증발행1.Checked = true;
            this.opt현금영수증발행1.Location = new System.Drawing.Point(3, 9);
            this.opt현금영수증발행1.Name = "opt현금영수증발행1";
            this.opt현금영수증발행1.Size = new System.Drawing.Size(24, 24);
            this.opt현금영수증발행1.TabIndex = 0;
            this.opt현금영수증발행1.TabStop = true;
            this.opt현금영수증발행1.UseVisualStyleBackColor = false;
            this.opt현금영수증발행1.CheckedChanged += new System.EventHandler(this.opt현금영수증발행1_CheckedChanged);
            // 
            // txt현금영수증번호
            // 
            this.txt현금영수증번호.AutoSize = false;
            this.txt현금영수증번호.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt현금영수증번호.Location = new System.Drawing.Point(352, 581);
            this.txt현금영수증번호.Name = "txt현금영수증번호";
            this.txt현금영수증번호.Size = new System.Drawing.Size(180, 29);
            this.txt현금영수증번호.TabIndex = 10;
            this.txt현금영수증번호.Tag = null;
            this.txt현금영수증번호.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt현금영수증번호.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.opt토스건결제유무2);
            this.panel3.Controls.Add(this.opt토스건결제유무1);
            this.panel3.Location = new System.Drawing.Point(8, 672);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 42);
            this.panel3.TabIndex = 121;
            // 
            // opt토스건결제유무2
            // 
            this.opt토스건결제유무2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.opt토스건결제유무2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opt토스건결제유무2.Location = new System.Drawing.Point(241, 9);
            this.opt토스건결제유무2.Name = "opt토스건결제유무2";
            this.opt토스건결제유무2.Size = new System.Drawing.Size(24, 24);
            this.opt토스건결제유무2.TabIndex = 1;
            this.opt토스건결제유무2.UseVisualStyleBackColor = false;
            // 
            // opt토스건결제유무1
            // 
            this.opt토스건결제유무1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.opt토스건결제유무1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opt토스건결제유무1.Checked = true;
            this.opt토스건결제유무1.Location = new System.Drawing.Point(3, 9);
            this.opt토스건결제유무1.Name = "opt토스건결제유무1";
            this.opt토스건결제유무1.Size = new System.Drawing.Size(24, 24);
            this.opt토스건결제유무1.TabIndex = 0;
            this.opt토스건결제유무1.TabStop = true;
            this.opt토스건결제유무1.UseVisualStyleBackColor = false;
            // 
            // cbo토스담당자
            // 
            this.cbo토스담당자.AllowSpinLoop = false;
            this.cbo토스담당자.AutoSize = false;
            this.cbo토스담당자.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo토스담당자.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo토스담당자.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo토스담당자.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo토스담당자.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo토스담당자.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo토스담당자.GapHeight = 0;
            this.cbo토스담당자.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo토스담당자.ItemsDisplayMember = "";
            this.cbo토스담당자.ItemsValueMember = "";
            this.cbo토스담당자.Location = new System.Drawing.Point(352, 675);
            this.cbo토스담당자.Name = "cbo토스담당자";
            this.cbo토스담당자.Size = new System.Drawing.Size(180, 29);
            this.cbo토스담당자.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo토스담당자.TabIndex = 11;
            this.cbo토스담당자.Tag = null;
            this.cbo토스담당자.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo토스담당자.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.opt인바운드유무2);
            this.panel4.Controls.Add(this.opt인바운드유무1);
            this.panel4.Location = new System.Drawing.Point(8, 770);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(335, 42);
            this.panel4.TabIndex = 123;
            // 
            // opt인바운드유무2
            // 
            this.opt인바운드유무2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.opt인바운드유무2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opt인바운드유무2.Location = new System.Drawing.Point(241, 9);
            this.opt인바운드유무2.Name = "opt인바운드유무2";
            this.opt인바운드유무2.Size = new System.Drawing.Size(24, 24);
            this.opt인바운드유무2.TabIndex = 1;
            this.opt인바운드유무2.UseVisualStyleBackColor = false;
            // 
            // opt인바운드유무1
            // 
            this.opt인바운드유무1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.opt인바운드유무1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opt인바운드유무1.Checked = true;
            this.opt인바운드유무1.Location = new System.Drawing.Point(3, 9);
            this.opt인바운드유무1.Name = "opt인바운드유무1";
            this.opt인바운드유무1.Size = new System.Drawing.Size(24, 24);
            this.opt인바운드유무1.TabIndex = 0;
            this.opt인바운드유무1.TabStop = true;
            this.opt인바운드유무1.UseVisualStyleBackColor = false;
            // 
            // lbl고객정보
            // 
            this.lbl고객정보.BackColor = System.Drawing.Color.Transparent;
            this.lbl고객정보.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl고객정보.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl고객정보.Location = new System.Drawing.Point(425, 37);
            this.lbl고객정보.Name = "lbl고객정보";
            this.lbl고객정보.Size = new System.Drawing.Size(104, 28);
            this.lbl고객정보.TabIndex = 125;
            this.lbl고객정보.Click += new System.EventHandler(this.lbl고객정보_Click);
            // 
            // cbo결제구분
            // 
            this.cbo결제구분.AllowSpinLoop = false;
            this.cbo결제구분.AutoSize = false;
            this.cbo결제구분.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo결제구분.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo결제구분.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo결제구분.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo결제구분.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo결제구분.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo결제구분.GapHeight = 0;
            this.cbo결제구분.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo결제구분.ItemsDisplayMember = "";
            this.cbo결제구분.ItemsValueMember = "";
            this.cbo결제구분.Location = new System.Drawing.Point(353, 77);
            this.cbo결제구분.Name = "cbo결제구분";
            this.cbo결제구분.Size = new System.Drawing.Size(178, 29);
            this.cbo결제구분.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo결제구분.TabIndex = 126;
            this.cbo결제구분.Tag = null;
            this.cbo결제구분.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo결제구분.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // cbo가입반
            // 
            this.cbo가입반.AllowSpinLoop = false;
            this.cbo가입반.AutoSize = false;
            this.cbo가입반.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo가입반.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo가입반.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo가입반.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo가입반.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo가입반.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo가입반.GapHeight = 0;
            this.cbo가입반.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo가입반.ItemsDisplayMember = "";
            this.cbo가입반.ItemsValueMember = "";
            this.cbo가입반.Location = new System.Drawing.Point(353, 156);
            this.cbo가입반.Name = "cbo가입반";
            this.cbo가입반.Size = new System.Drawing.Size(178, 29);
            this.cbo가입반.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo가입반.TabIndex = 127;
            this.cbo가입반.Tag = null;
            this.cbo가입반.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo가입반.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // cboPG사
            // 
            this.cboPG사.AllowSpinLoop = false;
            this.cboPG사.AutoSize = false;
            this.cboPG사.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cboPG사.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cboPG사.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cboPG사.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cboPG사.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cboPG사.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboPG사.GapHeight = 0;
            this.cboPG사.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cboPG사.ItemsDisplayMember = "";
            this.cboPG사.ItemsValueMember = "";
            this.cboPG사.Location = new System.Drawing.Point(352, 317);
            this.cboPG사.Name = "cboPG사";
            this.cboPG사.Size = new System.Drawing.Size(178, 29);
            this.cboPG사.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboPG사.TabIndex = 128;
            this.cboPG사.Tag = null;
            this.cboPG사.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cboPG사.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // cbo카드사
            // 
            this.cbo카드사.AllowSpinLoop = false;
            this.cbo카드사.AutoSize = false;
            this.cbo카드사.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo카드사.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo카드사.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo카드사.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo카드사.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo카드사.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo카드사.GapHeight = 0;
            this.cbo카드사.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo카드사.ItemsDisplayMember = "";
            this.cbo카드사.ItemsValueMember = "";
            this.cbo카드사.Location = new System.Drawing.Point(85, 355);
            this.cbo카드사.Name = "cbo카드사";
            this.cbo카드사.Size = new System.Drawing.Size(178, 29);
            this.cbo카드사.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo카드사.TabIndex = 129;
            this.cbo카드사.Tag = null;
            this.cbo카드사.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo카드사.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // cbo할부변경
            // 
            this.cbo할부변경.AllowSpinLoop = false;
            this.cbo할부변경.AutoSize = false;
            this.cbo할부변경.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo할부변경.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo할부변경.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo할부변경.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo할부변경.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo할부변경.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo할부변경.GapHeight = 0;
            this.cbo할부변경.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo할부변경.ItemsDisplayMember = "";
            this.cbo할부변경.ItemsValueMember = "";
            this.cbo할부변경.Location = new System.Drawing.Point(352, 355);
            this.cbo할부변경.Name = "cbo할부변경";
            this.cbo할부변경.Size = new System.Drawing.Size(178, 29);
            this.cbo할부변경.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo할부변경.TabIndex = 130;
            this.cbo할부변경.Tag = null;
            this.cbo할부변경.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo할부변경.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // lbl결제수단변경
            // 
            this.lbl결제수단변경.BackColor = System.Drawing.Color.Transparent;
            this.lbl결제수단변경.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl결제수단변경.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl결제수단변경.Location = new System.Drawing.Point(210, 831);
            this.lbl결제수단변경.Name = "lbl결제수단변경";
            this.lbl결제수단변경.Size = new System.Drawing.Size(121, 38);
            this.lbl결제수단변경.TabIndex = 131;
            this.lbl결제수단변경.Click += new System.EventHandler(this.lbl결제수단변경_Click);
            // 
            // lbl환불처리
            // 
            this.lbl환불처리.BackColor = System.Drawing.Color.Transparent;
            this.lbl환불처리.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl환불처리.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl환불처리.Location = new System.Drawing.Point(82, 832);
            this.lbl환불처리.Name = "lbl환불처리";
            this.lbl환불처리.Size = new System.Drawing.Size(121, 38);
            this.lbl환불처리.TabIndex = 132;
            this.lbl환불처리.Click += new System.EventHandler(this.lbl환불처리_Click);
            // 
            // frm매출등록
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(542, 886);
            this.Controls.Add(this.lbl환불처리);
            this.Controls.Add(this.lbl결제수단변경);
            this.Controls.Add(this.cbo할부변경);
            this.Controls.Add(this.cbo카드사);
            this.Controls.Add(this.cboPG사);
            this.Controls.Add(this.cbo가입반);
            this.Controls.Add(this.cbo결제구분);
            this.Controls.Add(this.lbl고객정보);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.cbo토스담당자);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt현금영수증번호);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbo결제수단);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt카드사별적용내역);
            this.Controls.Add(this.txt금액);
            this.Controls.Add(this.dtp결제일자);
            this.Controls.Add(this.txt휴대폰);
            this.Controls.Add(this.cbo담당자);
            this.Controls.Add(this.txt이름);
            this.Controls.Add(this.dtp매출일자);
            this.Controls.Add(this.cbo가입경로);
            this.Controls.Add(this.lbl등록);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTopBar);
            this.Controls.Add(this.picMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm매출등록";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "매출등록";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm매출등록_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt이름)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp매출일자)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo가입경로)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo담당자)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt휴대폰)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp결제일자)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt금액)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt카드사별적용내역)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbo결제수단)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt현금영수증번호)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbo토스담당자)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbo결제구분)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo가입반)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPG사)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo카드사)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo할부변경)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblTopBar;
        private System.Windows.Forms.Label lbl등록;
        private C1.Win.C1Input.C1TextBox txt이름;
        private C1.Win.Calendar.C1DateEdit dtp매출일자;
        private C1.Win.C1Input.C1ComboBox cbo가입경로;
        private C1.Win.C1Input.C1ComboBox cbo담당자;
        private C1.Win.C1Input.C1TextBox txt휴대폰;
        private C1.Win.Calendar.C1DateEdit dtp결제일자;
        private C1.Win.C1Input.C1TextBox txt금액;
        private C1.Win.C1Input.C1TextBox txt카드사별적용내역;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton opt영업자별매출2;
        private System.Windows.Forms.RadioButton opt영업자별매출1;
        private C1.Win.C1Input.C1ComboBox cbo결제수단;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton opt현금영수증발행2;
        private System.Windows.Forms.RadioButton opt현금영수증발행1;
        private C1.Win.C1Input.C1TextBox txt현금영수증번호;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton opt토스건결제유무2;
        private System.Windows.Forms.RadioButton opt토스건결제유무1;
        private C1.Win.C1Input.C1ComboBox cbo토스담당자;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton opt인바운드유무2;
        private System.Windows.Forms.RadioButton opt인바운드유무1;
        private System.Windows.Forms.Label lbl고객정보;
        private C1.Win.C1Input.C1ComboBox cbo결제구분;
        private C1.Win.C1Input.C1ComboBox cbo가입반;
        private C1.Win.C1Input.C1ComboBox cboPG사;
        private C1.Win.C1Input.C1ComboBox cbo카드사;
        private C1.Win.C1Input.C1ComboBox cbo할부변경;
        private System.Windows.Forms.Label lbl결제수단변경;
        private System.Windows.Forms.Label lbl환불처리;
    }
}