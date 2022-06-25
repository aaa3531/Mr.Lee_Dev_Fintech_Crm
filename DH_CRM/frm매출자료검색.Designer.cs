namespace DH_CRM
{
    partial class frm매출자료검색
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm매출자료검색));
            this.picMain = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTopBar = new System.Windows.Forms.Label();
            this.txt금액1 = new C1.Win.C1Input.C1TextBox();
            this.dtp결제일자1 = new C1.Win.Calendar.C1DateEdit();
            this.cbo결제수단 = new C1.Win.C1Input.C1ComboBox();
            this.dtp결제일자2 = new C1.Win.Calendar.C1DateEdit();
            this.txt금액2 = new C1.Win.C1Input.C1TextBox();
            this.cbo토스건담당자 = new C1.Win.C1Input.C1ComboBox();
            this.cbo담당자 = new C1.Win.C1Input.C1ComboBox();
            this.txt이름 = new C1.Win.C1Input.C1TextBox();
            this.txt카드사별적용내역 = new C1.Win.C1Input.C1TextBox();
            this.lbl검색 = new System.Windows.Forms.Label();
            this.chk입금 = new System.Windows.Forms.CheckBox();
            this.chk출금 = new System.Windows.Forms.CheckBox();
            this.cbo가입반 = new C1.Win.C1Input.C1ComboBox();
            this.chk결변 = new System.Windows.Forms.CheckBox();
            this.cbo가입경로 = new C1.Win.C1Input.C1ComboBox();
            this.cboPG사 = new C1.Win.C1Input.C1ComboBox();
            this.cbo카드사 = new C1.Win.C1Input.C1ComboBox();
            this.cbo현금영수증유무 = new C1.Win.C1Input.C1ComboBox();
            this.txt전화번호 = new C1.Win.C1Input.C1TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt금액1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp결제일자1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo결제수단)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp결제일자2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt금액2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo토스건담당자)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo담당자)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt이름)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt카드사별적용내역)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo가입반)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo가입경로)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPG사)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo카드사)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo현금영수증유무)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt전화번호)).BeginInit();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.BackColor = System.Drawing.SystemColors.Control;
            this.picMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(0, 0);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(505, 499);
            this.picMain.TabIndex = 13;
            this.picMain.TabStop = false;
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClose.Location = new System.Drawing.Point(470, 5);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 28);
            this.lblClose.TabIndex = 105;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblTopBar
            // 
            this.lblTopBar.BackColor = System.Drawing.Color.Transparent;
            this.lblTopBar.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTopBar.Location = new System.Drawing.Point(6, 6);
            this.lblTopBar.Name = "lblTopBar";
            this.lblTopBar.Size = new System.Drawing.Size(447, 28);
            this.lblTopBar.TabIndex = 104;
            // 
            // txt금액1
            // 
            this.txt금액1.AutoSize = false;
            this.txt금액1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt금액1.Location = new System.Drawing.Point(69, 77);
            this.txt금액1.Name = "txt금액1";
            this.txt금액1.Size = new System.Drawing.Size(161, 29);
            this.txt금액1.TabIndex = 108;
            this.txt금액1.Tag = null;
            this.txt금액1.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt금액1.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // dtp결제일자1
            // 
            this.dtp결제일자1.AutoSize = false;
            this.dtp결제일자1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtp결제일자1.Calendar.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp결제일자1.Calendar.BackColor = System.Drawing.Color.White;
            this.dtp결제일자1.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp결제일자1.Calendar.DayNamesFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp결제일자1.Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp결제일자1.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.dtp결제일자1.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.dtp결제일자1.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp결제일자1.Calendar.TitleBackColor = System.Drawing.Color.White;
            this.dtp결제일자1.Calendar.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp결제일자1.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp결제일자1.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.dtp결제일자1.Calendar.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp결제일자1.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.dtp결제일자1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp결제일자1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp결제일자1.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp결제일자1.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp결제일자1.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp결제일자1.EmptyAsNull = true;
            this.dtp결제일자1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp결제일자1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.dtp결제일자1.Location = new System.Drawing.Point(69, 38);
            this.dtp결제일자1.Name = "dtp결제일자1";
            this.dtp결제일자1.Size = new System.Drawing.Size(161, 29);
            this.dtp결제일자1.TabIndex = 106;
            this.dtp결제일자1.Tag = null;
            this.dtp결제일자1.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dtp결제일자1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            this.dtp결제일자1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
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
            this.cbo결제수단.Location = new System.Drawing.Point(68, 165);
            this.cbo결제수단.Name = "cbo결제수단";
            this.cbo결제수단.Size = new System.Drawing.Size(162, 29);
            this.cbo결제수단.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo결제수단.TabIndex = 107;
            this.cbo결제수단.Tag = null;
            this.cbo결제수단.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo결제수단.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // dtp결제일자2
            // 
            this.dtp결제일자2.AutoSize = false;
            this.dtp결제일자2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtp결제일자2.Calendar.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp결제일자2.Calendar.BackColor = System.Drawing.Color.White;
            this.dtp결제일자2.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp결제일자2.Calendar.DayNamesFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp결제일자2.Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp결제일자2.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.dtp결제일자2.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.dtp결제일자2.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp결제일자2.Calendar.TitleBackColor = System.Drawing.Color.White;
            this.dtp결제일자2.Calendar.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp결제일자2.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp결제일자2.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.dtp결제일자2.Calendar.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp결제일자2.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.dtp결제일자2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp결제일자2.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp결제일자2.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp결제일자2.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp결제일자2.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp결제일자2.EmptyAsNull = true;
            this.dtp결제일자2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp결제일자2.ImagePadding = new System.Windows.Forms.Padding(0);
            this.dtp결제일자2.Location = new System.Drawing.Point(285, 38);
            this.dtp결제일자2.Name = "dtp결제일자2";
            this.dtp결제일자2.Size = new System.Drawing.Size(157, 29);
            this.dtp결제일자2.TabIndex = 109;
            this.dtp결제일자2.Tag = null;
            this.dtp결제일자2.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dtp결제일자2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            this.dtp결제일자2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // txt금액2
            // 
            this.txt금액2.AutoSize = false;
            this.txt금액2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt금액2.Location = new System.Drawing.Point(285, 77);
            this.txt금액2.Name = "txt금액2";
            this.txt금액2.Size = new System.Drawing.Size(157, 29);
            this.txt금액2.TabIndex = 110;
            this.txt금액2.Tag = null;
            this.txt금액2.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt금액2.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // cbo토스건담당자
            // 
            this.cbo토스건담당자.AllowSpinLoop = false;
            this.cbo토스건담당자.AutoSize = false;
            this.cbo토스건담당자.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo토스건담당자.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo토스건담당자.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo토스건담당자.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo토스건담당자.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo토스건담당자.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo토스건담당자.GapHeight = 0;
            this.cbo토스건담당자.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo토스건담당자.ItemsDisplayMember = "";
            this.cbo토스건담당자.ItemsValueMember = "";
            this.cbo토스건담당자.Location = new System.Drawing.Point(285, 165);
            this.cbo토스건담당자.Name = "cbo토스건담당자";
            this.cbo토스건담당자.Size = new System.Drawing.Size(157, 29);
            this.cbo토스건담당자.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo토스건담당자.TabIndex = 111;
            this.cbo토스건담당자.Tag = null;
            this.cbo토스건담당자.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo토스건담당자.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
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
            this.cbo담당자.Location = new System.Drawing.Point(285, 202);
            this.cbo담당자.Name = "cbo담당자";
            this.cbo담당자.Size = new System.Drawing.Size(157, 29);
            this.cbo담당자.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo담당자.TabIndex = 112;
            this.cbo담당자.Tag = null;
            this.cbo담당자.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo담당자.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // txt이름
            // 
            this.txt이름.AutoSize = false;
            this.txt이름.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt이름.Location = new System.Drawing.Point(69, 356);
            this.txt이름.Name = "txt이름";
            this.txt이름.Size = new System.Drawing.Size(329, 29);
            this.txt이름.TabIndex = 113;
            this.txt이름.Tag = null;
            this.txt이름.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt이름.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // txt카드사별적용내역
            // 
            this.txt카드사별적용내역.AutoSize = false;
            this.txt카드사별적용내역.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt카드사별적용내역.Location = new System.Drawing.Point(69, 397);
            this.txt카드사별적용내역.Name = "txt카드사별적용내역";
            this.txt카드사별적용내역.Size = new System.Drawing.Size(329, 29);
            this.txt카드사별적용내역.TabIndex = 114;
            this.txt카드사별적용내역.Tag = null;
            this.txt카드사별적용내역.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt카드사별적용내역.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // lbl검색
            // 
            this.lbl검색.BackColor = System.Drawing.Color.Transparent;
            this.lbl검색.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl검색.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl검색.Location = new System.Drawing.Point(195, 451);
            this.lbl검색.Name = "lbl검색";
            this.lbl검색.Size = new System.Drawing.Size(114, 33);
            this.lbl검색.TabIndex = 115;
            this.lbl검색.Click += new System.EventHandler(this.lbl검색_Click);
            // 
            // chk입금
            // 
            this.chk입금.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.chk입금.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk입금.Location = new System.Drawing.Point(65, 120);
            this.chk입금.Name = "chk입금";
            this.chk입금.Size = new System.Drawing.Size(24, 21);
            this.chk입금.TabIndex = 116;
            this.chk입금.UseVisualStyleBackColor = false;
            // 
            // chk출금
            // 
            this.chk출금.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.chk출금.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk출금.Location = new System.Drawing.Point(131, 120);
            this.chk출금.Name = "chk출금";
            this.chk출금.Size = new System.Drawing.Size(24, 21);
            this.chk출금.TabIndex = 117;
            this.chk출금.UseVisualStyleBackColor = false;
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
            this.cbo가입반.Location = new System.Drawing.Point(68, 202);
            this.cbo가입반.Name = "cbo가입반";
            this.cbo가입반.Size = new System.Drawing.Size(162, 29);
            this.cbo가입반.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo가입반.TabIndex = 119;
            this.cbo가입반.Tag = null;
            this.cbo가입반.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo가입반.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // chk결변
            // 
            this.chk결변.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.chk결변.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk결변.Location = new System.Drawing.Point(208, 120);
            this.chk결변.Name = "chk결변";
            this.chk결변.Size = new System.Drawing.Size(24, 21);
            this.chk결변.TabIndex = 120;
            this.chk결변.UseVisualStyleBackColor = false;
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
            this.cbo가입경로.Location = new System.Drawing.Point(68, 240);
            this.cbo가입경로.Name = "cbo가입경로";
            this.cbo가입경로.Size = new System.Drawing.Size(162, 29);
            this.cbo가입경로.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo가입경로.TabIndex = 121;
            this.cbo가입경로.Tag = null;
            this.cbo가입경로.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo가입경로.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
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
            this.cboPG사.Location = new System.Drawing.Point(285, 240);
            this.cboPG사.Name = "cboPG사";
            this.cboPG사.Size = new System.Drawing.Size(157, 29);
            this.cboPG사.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboPG사.TabIndex = 122;
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
            this.cbo카드사.Location = new System.Drawing.Point(68, 278);
            this.cbo카드사.Name = "cbo카드사";
            this.cbo카드사.Size = new System.Drawing.Size(162, 29);
            this.cbo카드사.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo카드사.TabIndex = 123;
            this.cbo카드사.Tag = null;
            this.cbo카드사.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo카드사.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // cbo현금영수증유무
            // 
            this.cbo현금영수증유무.AllowSpinLoop = false;
            this.cbo현금영수증유무.AutoSize = false;
            this.cbo현금영수증유무.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo현금영수증유무.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo현금영수증유무.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo현금영수증유무.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo현금영수증유무.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo현금영수증유무.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo현금영수증유무.GapHeight = 0;
            this.cbo현금영수증유무.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo현금영수증유무.ItemsDisplayMember = "";
            this.cbo현금영수증유무.ItemsValueMember = "";
            this.cbo현금영수증유무.Location = new System.Drawing.Point(348, 278);
            this.cbo현금영수증유무.Name = "cbo현금영수증유무";
            this.cbo현금영수증유무.Size = new System.Drawing.Size(94, 29);
            this.cbo현금영수증유무.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo현금영수증유무.TabIndex = 124;
            this.cbo현금영수증유무.Tag = null;
            this.cbo현금영수증유무.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo현금영수증유무.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // txt전화번호
            // 
            this.txt전화번호.AutoSize = false;
            this.txt전화번호.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt전화번호.Location = new System.Drawing.Point(69, 318);
            this.txt전화번호.MaxLength = 4;
            this.txt전화번호.Name = "txt전화번호";
            this.txt전화번호.Size = new System.Drawing.Size(161, 29);
            this.txt전화번호.TabIndex = 125;
            this.txt전화번호.Tag = null;
            this.txt전화번호.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt전화번호.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // frm매출자료검색
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(505, 499);
            this.Controls.Add(this.txt전화번호);
            this.Controls.Add(this.cbo현금영수증유무);
            this.Controls.Add(this.cbo카드사);
            this.Controls.Add(this.cboPG사);
            this.Controls.Add(this.cbo가입경로);
            this.Controls.Add(this.chk결변);
            this.Controls.Add(this.cbo가입반);
            this.Controls.Add(this.chk출금);
            this.Controls.Add(this.chk입금);
            this.Controls.Add(this.lbl검색);
            this.Controls.Add(this.txt카드사별적용내역);
            this.Controls.Add(this.txt이름);
            this.Controls.Add(this.cbo담당자);
            this.Controls.Add(this.cbo토스건담당자);
            this.Controls.Add(this.txt금액2);
            this.Controls.Add(this.dtp결제일자2);
            this.Controls.Add(this.txt금액1);
            this.Controls.Add(this.dtp결제일자1);
            this.Controls.Add(this.cbo결제수단);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTopBar);
            this.Controls.Add(this.picMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm매출자료검색";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "매출자료검색";
            this.Load += new System.EventHandler(this.frm매출자료검색_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt금액1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp결제일자1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo결제수단)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp결제일자2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt금액2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo토스건담당자)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo담당자)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt이름)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt카드사별적용내역)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo가입반)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo가입경로)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPG사)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo카드사)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo현금영수증유무)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt전화번호)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblTopBar;
        private C1.Win.C1Input.C1TextBox txt금액1;
        private C1.Win.Calendar.C1DateEdit dtp결제일자1;
        private C1.Win.C1Input.C1ComboBox cbo결제수단;
        private C1.Win.Calendar.C1DateEdit dtp결제일자2;
        private C1.Win.C1Input.C1TextBox txt금액2;
        private C1.Win.C1Input.C1ComboBox cbo토스건담당자;
        private C1.Win.C1Input.C1ComboBox cbo담당자;
        private C1.Win.C1Input.C1TextBox txt이름;
        private C1.Win.C1Input.C1TextBox txt카드사별적용내역;
        private System.Windows.Forms.Label lbl검색;
        private System.Windows.Forms.CheckBox chk입금;
        private System.Windows.Forms.CheckBox chk출금;
        private C1.Win.C1Input.C1ComboBox cbo가입반;
        private System.Windows.Forms.CheckBox chk결변;
        private C1.Win.C1Input.C1ComboBox cbo가입경로;
        private C1.Win.C1Input.C1ComboBox cboPG사;
        private C1.Win.C1Input.C1ComboBox cbo카드사;
        private C1.Win.C1Input.C1ComboBox cbo현금영수증유무;
        private C1.Win.C1Input.C1TextBox txt전화번호;
    }
}