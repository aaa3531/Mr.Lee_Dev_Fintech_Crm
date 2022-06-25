namespace DH_CRM
{
    partial class frm자료검색
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm자료검색));
            this.picMain = new System.Windows.Forms.PictureBox();
            this.lblTopBar = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.cbo담당자 = new C1.Win.C1Input.C1ComboBox();
            this.cbo소속팀정보 = new C1.Win.C1Input.C1ComboBox();
            this.txt이름 = new C1.Win.C1Input.C1TextBox();
            this.txt검색어 = new C1.Win.C1Input.C1TextBox();
            this.txt휴대폰 = new C1.Win.C1Input.C1TextBox();
            this.cbo유입경로소분류 = new C1.Win.C1Input.C1ComboBox();
            this.cbo유입경로대분류 = new C1.Win.C1Input.C1ComboBox();
            this.txt메모란 = new C1.Win.C1Input.C1TextBox();
            this.dtp등록시작일자 = new C1.Win.Calendar.C1DateEdit();
            this.dtp등록마감일자 = new C1.Win.Calendar.C1DateEdit();
            this.dtp수정시작일자 = new C1.Win.Calendar.C1DateEdit();
            this.dtp수정마감일자 = new C1.Win.Calendar.C1DateEdit();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cbo검색제한 = new C1.Win.C1Input.C1ComboBox();
            this.cbo유입경로 = new C1.Win.C1Input.C1ComboBox();
            this.txt기수검색 = new C1.Win.C1Input.C1TextBox();
            this.txt증권사 = new C1.Win.C1Input.C1TextBox();
            this.txt네이버아이디 = new C1.Win.C1Input.C1TextBox();
            this.txt카톡아이디 = new C1.Win.C1Input.C1TextBox();
            this.cbo가입반 = new C1.Win.C1Input.C1ComboBox();
            this.cbo인바운드 = new C1.Win.C1Input.C1ComboBox();
            this.dtp리딩기간1 = new C1.Win.Calendar.C1DateEdit();
            this.dtp리딩기간2 = new C1.Win.Calendar.C1DateEdit();
            this.dtp최초분배일 = new C1.Win.Calendar.C1DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo담당자)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo소속팀정보)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt이름)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt검색어)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt휴대폰)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo유입경로소분류)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo유입경로대분류)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt메모란)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp등록시작일자)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp등록마감일자)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp수정시작일자)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp수정마감일자)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo검색제한)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo유입경로)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt기수검색)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt증권사)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt네이버아이디)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt카톡아이디)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo가입반)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo인바운드)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp리딩기간1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp리딩기간2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp최초분배일)).BeginInit();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(-1, -1);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(584, 751);
            this.picMain.TabIndex = 0;
            this.picMain.TabStop = false;
            // 
            // lblTopBar
            // 
            this.lblTopBar.BackColor = System.Drawing.Color.Transparent;
            this.lblTopBar.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTopBar.Location = new System.Drawing.Point(3, 3);
            this.lblTopBar.Name = "lblTopBar";
            this.lblTopBar.Size = new System.Drawing.Size(518, 28);
            this.lblTopBar.TabIndex = 84;
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClose.Location = new System.Drawing.Point(540, 3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 28);
            this.lblClose.TabIndex = 85;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
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
            this.cbo담당자.Location = new System.Drawing.Point(93, 42);
            this.cbo담당자.Name = "cbo담당자";
            this.cbo담당자.Size = new System.Drawing.Size(172, 29);
            this.cbo담당자.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo담당자.TabIndex = 86;
            this.cbo담당자.Tag = null;
            this.cbo담당자.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo담당자.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // cbo소속팀정보
            // 
            this.cbo소속팀정보.AllowSpinLoop = false;
            this.cbo소속팀정보.AutoSize = false;
            this.cbo소속팀정보.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo소속팀정보.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo소속팀정보.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo소속팀정보.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo소속팀정보.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo소속팀정보.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo소속팀정보.GapHeight = 0;
            this.cbo소속팀정보.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo소속팀정보.ItemsDisplayMember = "";
            this.cbo소속팀정보.ItemsValueMember = "";
            this.cbo소속팀정보.Location = new System.Drawing.Point(370, 42);
            this.cbo소속팀정보.Name = "cbo소속팀정보";
            this.cbo소속팀정보.Size = new System.Drawing.Size(197, 29);
            this.cbo소속팀정보.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo소속팀정보.TabIndex = 87;
            this.cbo소속팀정보.Tag = null;
            this.cbo소속팀정보.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo소속팀정보.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // txt이름
            // 
            this.txt이름.AutoSize = false;
            this.txt이름.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt이름.Location = new System.Drawing.Point(93, 80);
            this.txt이름.Name = "txt이름";
            this.txt이름.Size = new System.Drawing.Size(173, 29);
            this.txt이름.TabIndex = 88;
            this.txt이름.Tag = null;
            this.txt이름.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt이름.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // txt검색어
            // 
            this.txt검색어.AutoSize = false;
            this.txt검색어.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt검색어.Location = new System.Drawing.Point(369, 80);
            this.txt검색어.Name = "txt검색어";
            this.txt검색어.Size = new System.Drawing.Size(197, 29);
            this.txt검색어.TabIndex = 89;
            this.txt검색어.Tag = null;
            this.txt검색어.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt검색어.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // txt휴대폰
            // 
            this.txt휴대폰.AutoSize = false;
            this.txt휴대폰.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt휴대폰.Location = new System.Drawing.Point(93, 294);
            this.txt휴대폰.MaxLength = 4;
            this.txt휴대폰.Name = "txt휴대폰";
            this.txt휴대폰.Size = new System.Drawing.Size(92, 29);
            this.txt휴대폰.TabIndex = 90;
            this.txt휴대폰.Tag = null;
            this.txt휴대폰.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt휴대폰.VisualStyle = C1.Win.C1Input.VisualStyle.System;
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
            this.cbo유입경로소분류.Location = new System.Drawing.Point(442, 254);
            this.cbo유입경로소분류.Name = "cbo유입경로소분류";
            this.cbo유입경로소분류.Size = new System.Drawing.Size(122, 29);
            this.cbo유입경로소분류.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo유입경로소분류.TabIndex = 92;
            this.cbo유입경로소분류.Tag = null;
            this.cbo유입경로소분류.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo유입경로소분류.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.cbo유입경로소분류.SelectedItemChanged += new System.EventHandler(this.cbo유입경로소분류_SelectedItemChanged);
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
            this.cbo유입경로대분류.Location = new System.Drawing.Point(254, 254);
            this.cbo유입경로대분류.Name = "cbo유입경로대분류";
            this.cbo유입경로대분류.Size = new System.Drawing.Size(123, 29);
            this.cbo유입경로대분류.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo유입경로대분류.TabIndex = 91;
            this.cbo유입경로대분류.Tag = null;
            this.cbo유입경로대분류.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo유입경로대분류.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.cbo유입경로대분류.SelectedItemChanged += new System.EventHandler(this.cbo유입경로대분류_SelectedItemChanged);
            this.cbo유입경로대분류.SelectedIndexChanged += new System.EventHandler(this.cbo유입경로대분류_SelectedIndexChanged);
            // 
            // txt메모란
            // 
            this.txt메모란.AutoSize = false;
            this.txt메모란.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt메모란.Location = new System.Drawing.Point(93, 333);
            this.txt메모란.Name = "txt메모란";
            this.txt메모란.Size = new System.Drawing.Size(474, 29);
            this.txt메모란.TabIndex = 93;
            this.txt메모란.Tag = null;
            this.txt메모란.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt메모란.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // dtp등록시작일자
            // 
            this.dtp등록시작일자.AutoSize = false;
            this.dtp등록시작일자.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtp등록시작일자.Calendar.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp등록시작일자.Calendar.BackColor = System.Drawing.Color.White;
            this.dtp등록시작일자.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp등록시작일자.Calendar.DayNamesFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp등록시작일자.Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp등록시작일자.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.dtp등록시작일자.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.dtp등록시작일자.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp등록시작일자.Calendar.TitleBackColor = System.Drawing.Color.White;
            this.dtp등록시작일자.Calendar.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp등록시작일자.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp등록시작일자.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.dtp등록시작일자.Calendar.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp등록시작일자.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.dtp등록시작일자.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp등록시작일자.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp등록시작일자.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp등록시작일자.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp등록시작일자.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp등록시작일자.EmptyAsNull = true;
            this.dtp등록시작일자.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp등록시작일자.ImagePadding = new System.Windows.Forms.Padding(0);
            this.dtp등록시작일자.Location = new System.Drawing.Point(93, 568);
            this.dtp등록시작일자.Name = "dtp등록시작일자";
            this.dtp등록시작일자.Size = new System.Drawing.Size(172, 29);
            this.dtp등록시작일자.TabIndex = 94;
            this.dtp등록시작일자.Tag = null;
            this.dtp등록시작일자.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dtp등록시작일자.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            this.dtp등록시작일자.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // dtp등록마감일자
            // 
            this.dtp등록마감일자.AutoSize = false;
            this.dtp등록마감일자.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtp등록마감일자.Calendar.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp등록마감일자.Calendar.BackColor = System.Drawing.Color.White;
            this.dtp등록마감일자.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp등록마감일자.Calendar.DayNamesFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp등록마감일자.Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp등록마감일자.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.dtp등록마감일자.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.dtp등록마감일자.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp등록마감일자.Calendar.TitleBackColor = System.Drawing.Color.White;
            this.dtp등록마감일자.Calendar.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp등록마감일자.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp등록마감일자.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.dtp등록마감일자.Calendar.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp등록마감일자.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.dtp등록마감일자.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp등록마감일자.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp등록마감일자.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp등록마감일자.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp등록마감일자.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp등록마감일자.EmptyAsNull = true;
            this.dtp등록마감일자.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp등록마감일자.ImagePadding = new System.Windows.Forms.Padding(0);
            this.dtp등록마감일자.Location = new System.Drawing.Point(370, 568);
            this.dtp등록마감일자.Name = "dtp등록마감일자";
            this.dtp등록마감일자.Size = new System.Drawing.Size(193, 29);
            this.dtp등록마감일자.TabIndex = 95;
            this.dtp등록마감일자.Tag = null;
            this.dtp등록마감일자.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dtp등록마감일자.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            this.dtp등록마감일자.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // dtp수정시작일자
            // 
            this.dtp수정시작일자.AutoSize = false;
            this.dtp수정시작일자.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtp수정시작일자.Calendar.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp수정시작일자.Calendar.BackColor = System.Drawing.Color.White;
            this.dtp수정시작일자.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp수정시작일자.Calendar.DayNamesFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp수정시작일자.Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp수정시작일자.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.dtp수정시작일자.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.dtp수정시작일자.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp수정시작일자.Calendar.TitleBackColor = System.Drawing.Color.White;
            this.dtp수정시작일자.Calendar.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp수정시작일자.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp수정시작일자.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.dtp수정시작일자.Calendar.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp수정시작일자.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.dtp수정시작일자.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp수정시작일자.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp수정시작일자.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp수정시작일자.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp수정시작일자.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp수정시작일자.EmptyAsNull = true;
            this.dtp수정시작일자.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp수정시작일자.ImagePadding = new System.Windows.Forms.Padding(0);
            this.dtp수정시작일자.Location = new System.Drawing.Point(93, 651);
            this.dtp수정시작일자.Name = "dtp수정시작일자";
            this.dtp수정시작일자.Size = new System.Drawing.Size(172, 29);
            this.dtp수정시작일자.TabIndex = 96;
            this.dtp수정시작일자.Tag = null;
            this.dtp수정시작일자.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dtp수정시작일자.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            this.dtp수정시작일자.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // dtp수정마감일자
            // 
            this.dtp수정마감일자.AutoSize = false;
            this.dtp수정마감일자.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtp수정마감일자.Calendar.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp수정마감일자.Calendar.BackColor = System.Drawing.Color.White;
            this.dtp수정마감일자.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp수정마감일자.Calendar.DayNamesFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp수정마감일자.Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp수정마감일자.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.dtp수정마감일자.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.dtp수정마감일자.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp수정마감일자.Calendar.TitleBackColor = System.Drawing.Color.White;
            this.dtp수정마감일자.Calendar.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp수정마감일자.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp수정마감일자.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.dtp수정마감일자.Calendar.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp수정마감일자.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.dtp수정마감일자.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp수정마감일자.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp수정마감일자.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp수정마감일자.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp수정마감일자.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp수정마감일자.EmptyAsNull = true;
            this.dtp수정마감일자.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp수정마감일자.ImagePadding = new System.Windows.Forms.Padding(0);
            this.dtp수정마감일자.Location = new System.Drawing.Point(370, 651);
            this.dtp수정마감일자.Name = "dtp수정마감일자";
            this.dtp수정마감일자.Size = new System.Drawing.Size(193, 29);
            this.dtp수정마감일자.TabIndex = 97;
            this.dtp수정마감일자.Tag = null;
            this.dtp수정마감일자.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dtp수정마감일자.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            this.dtp수정마감일자.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSearch.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSearch.ForeColor = System.Drawing.Color.Transparent;
            this.lblSearch.Location = new System.Drawing.Point(231, 703);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(114, 32);
            this.lblSearch.TabIndex = 98;
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // cbo검색제한
            // 
            this.cbo검색제한.AllowSpinLoop = false;
            this.cbo검색제한.AutoSize = false;
            this.cbo검색제한.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo검색제한.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo검색제한.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbo검색제한.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo검색제한.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo검색제한.GapHeight = 0;
            this.cbo검색제한.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo검색제한.ItemsDisplayMember = "";
            this.cbo검색제한.ItemsValueMember = "";
            this.cbo검색제한.Location = new System.Drawing.Point(93, 404);
            this.cbo검색제한.Name = "cbo검색제한";
            this.cbo검색제한.Size = new System.Drawing.Size(172, 29);
            this.cbo검색제한.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo검색제한.TabIndex = 99;
            this.cbo검색제한.Tag = null;
            this.cbo검색제한.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo검색제한.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
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
            this.cbo유입경로.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo유입경로.GapHeight = 0;
            this.cbo유입경로.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo유입경로.ItemsDisplayMember = "";
            this.cbo유입경로.ItemsValueMember = "";
            this.cbo유입경로.Location = new System.Drawing.Point(68, 254);
            this.cbo유입경로.Name = "cbo유입경로";
            this.cbo유입경로.Size = new System.Drawing.Size(123, 29);
            this.cbo유입경로.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo유입경로.TabIndex = 100;
            this.cbo유입경로.Tag = null;
            this.cbo유입경로.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo유입경로.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // txt기수검색
            // 
            this.txt기수검색.AutoSize = false;
            this.txt기수검색.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt기수검색.Location = new System.Drawing.Point(370, 404);
            this.txt기수검색.Name = "txt기수검색";
            this.txt기수검색.Size = new System.Drawing.Size(194, 29);
            this.txt기수검색.TabIndex = 101;
            this.txt기수검색.Tag = null;
            this.txt기수검색.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt기수검색.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // txt증권사
            // 
            this.txt증권사.AutoSize = false;
            this.txt증권사.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt증권사.Location = new System.Drawing.Point(369, 119);
            this.txt증권사.Name = "txt증권사";
            this.txt증권사.Size = new System.Drawing.Size(197, 29);
            this.txt증권사.TabIndex = 102;
            this.txt증권사.Tag = null;
            this.txt증권사.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt증권사.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // txt네이버아이디
            // 
            this.txt네이버아이디.AutoSize = false;
            this.txt네이버아이디.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt네이버아이디.Location = new System.Drawing.Point(369, 158);
            this.txt네이버아이디.Name = "txt네이버아이디";
            this.txt네이버아이디.Size = new System.Drawing.Size(197, 29);
            this.txt네이버아이디.TabIndex = 103;
            this.txt네이버아이디.Tag = null;
            this.txt네이버아이디.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt네이버아이디.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // txt카톡아이디
            // 
            this.txt카톡아이디.AutoSize = false;
            this.txt카톡아이디.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt카톡아이디.Location = new System.Drawing.Point(93, 158);
            this.txt카톡아이디.Name = "txt카톡아이디";
            this.txt카톡아이디.Size = new System.Drawing.Size(173, 29);
            this.txt카톡아이디.TabIndex = 104;
            this.txt카톡아이디.Tag = null;
            this.txt카톡아이디.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt카톡아이디.VisualStyle = C1.Win.C1Input.VisualStyle.System;
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
            this.cbo가입반.Location = new System.Drawing.Point(93, 119);
            this.cbo가입반.Name = "cbo가입반";
            this.cbo가입반.Size = new System.Drawing.Size(172, 29);
            this.cbo가입반.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo가입반.TabIndex = 105;
            this.cbo가입반.Tag = null;
            this.cbo가입반.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo가입반.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // cbo인바운드
            // 
            this.cbo인바운드.AllowSpinLoop = false;
            this.cbo인바운드.AutoSize = false;
            this.cbo인바운드.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo인바운드.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo인바운드.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo인바운드.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo인바운드.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo인바운드.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo인바운드.GapHeight = 0;
            this.cbo인바운드.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo인바운드.ItemsDisplayMember = "";
            this.cbo인바운드.ItemsValueMember = "";
            this.cbo인바운드.Location = new System.Drawing.Point(369, 197);
            this.cbo인바운드.Name = "cbo인바운드";
            this.cbo인바운드.Size = new System.Drawing.Size(197, 30);
            this.cbo인바운드.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo인바운드.TabIndex = 106;
            this.cbo인바운드.Tag = null;
            this.cbo인바운드.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo인바운드.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // dtp리딩기간1
            // 
            this.dtp리딩기간1.AutoSize = false;
            this.dtp리딩기간1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtp리딩기간1.Calendar.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp리딩기간1.Calendar.BackColor = System.Drawing.Color.White;
            this.dtp리딩기간1.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp리딩기간1.Calendar.DayNamesFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp리딩기간1.Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp리딩기간1.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.dtp리딩기간1.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.dtp리딩기간1.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp리딩기간1.Calendar.TitleBackColor = System.Drawing.Color.White;
            this.dtp리딩기간1.Calendar.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp리딩기간1.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp리딩기간1.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.dtp리딩기간1.Calendar.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp리딩기간1.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.dtp리딩기간1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp리딩기간1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp리딩기간1.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp리딩기간1.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp리딩기간1.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp리딩기간1.EmptyAsNull = true;
            this.dtp리딩기간1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp리딩기간1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.dtp리딩기간1.Location = new System.Drawing.Point(93, 489);
            this.dtp리딩기간1.Name = "dtp리딩기간1";
            this.dtp리딩기간1.Size = new System.Drawing.Size(172, 29);
            this.dtp리딩기간1.TabIndex = 107;
            this.dtp리딩기간1.Tag = null;
            this.dtp리딩기간1.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dtp리딩기간1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            this.dtp리딩기간1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // dtp리딩기간2
            // 
            this.dtp리딩기간2.AutoSize = false;
            this.dtp리딩기간2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtp리딩기간2.Calendar.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp리딩기간2.Calendar.BackColor = System.Drawing.Color.White;
            this.dtp리딩기간2.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp리딩기간2.Calendar.DayNamesFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp리딩기간2.Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp리딩기간2.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.dtp리딩기간2.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.dtp리딩기간2.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp리딩기간2.Calendar.TitleBackColor = System.Drawing.Color.White;
            this.dtp리딩기간2.Calendar.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp리딩기간2.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp리딩기간2.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.dtp리딩기간2.Calendar.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp리딩기간2.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.dtp리딩기간2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp리딩기간2.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp리딩기간2.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp리딩기간2.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp리딩기간2.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp리딩기간2.EmptyAsNull = true;
            this.dtp리딩기간2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp리딩기간2.ImagePadding = new System.Windows.Forms.Padding(0);
            this.dtp리딩기간2.Location = new System.Drawing.Point(371, 488);
            this.dtp리딩기간2.Name = "dtp리딩기간2";
            this.dtp리딩기간2.Size = new System.Drawing.Size(193, 29);
            this.dtp리딩기간2.TabIndex = 108;
            this.dtp리딩기간2.Tag = null;
            this.dtp리딩기간2.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dtp리딩기간2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            this.dtp리딩기간2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // dtp최초분배일
            // 
            this.dtp최초분배일.AutoSize = false;
            this.dtp최초분배일.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtp최초분배일.Calendar.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp최초분배일.Calendar.BackColor = System.Drawing.Color.White;
            this.dtp최초분배일.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp최초분배일.Calendar.DayNamesFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp최초분배일.Calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp최초분배일.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.dtp최초분배일.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.dtp최초분배일.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp최초분배일.Calendar.TitleBackColor = System.Drawing.Color.White;
            this.dtp최초분배일.Calendar.TitleFont = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp최초분배일.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtp최초분배일.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(192)))), ((int)(((byte)(224)))));
            this.dtp최초분배일.Calendar.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp최초분배일.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.dtp최초분배일.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.dtp최초분배일.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp최초분배일.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp최초분배일.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtp최초분배일.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.dtp최초분배일.EmptyAsNull = true;
            this.dtp최초분배일.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dtp최초분배일.ImagePadding = new System.Windows.Forms.Padding(0);
            this.dtp최초분배일.Location = new System.Drawing.Point(93, 197);
            this.dtp최초분배일.Name = "dtp최초분배일";
            this.dtp최초분배일.Size = new System.Drawing.Size(172, 29);
            this.dtp최초분배일.TabIndex = 109;
            this.dtp최초분배일.Tag = null;
            this.dtp최초분배일.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dtp최초분배일.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            this.dtp최초분배일.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // frm자료검색
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(578, 747);
            this.Controls.Add(this.dtp최초분배일);
            this.Controls.Add(this.dtp리딩기간2);
            this.Controls.Add(this.dtp리딩기간1);
            this.Controls.Add(this.cbo인바운드);
            this.Controls.Add(this.cbo가입반);
            this.Controls.Add(this.txt카톡아이디);
            this.Controls.Add(this.txt네이버아이디);
            this.Controls.Add(this.txt증권사);
            this.Controls.Add(this.txt기수검색);
            this.Controls.Add(this.cbo유입경로);
            this.Controls.Add(this.cbo검색제한);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dtp수정마감일자);
            this.Controls.Add(this.dtp수정시작일자);
            this.Controls.Add(this.dtp등록마감일자);
            this.Controls.Add(this.dtp등록시작일자);
            this.Controls.Add(this.txt메모란);
            this.Controls.Add(this.cbo유입경로소분류);
            this.Controls.Add(this.cbo유입경로대분류);
            this.Controls.Add(this.txt휴대폰);
            this.Controls.Add(this.txt검색어);
            this.Controls.Add(this.txt이름);
            this.Controls.Add(this.cbo소속팀정보);
            this.Controls.Add(this.cbo담당자);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTopBar);
            this.Controls.Add(this.picMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm자료검색";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "자료검색";
            this.Load += new System.EventHandler(this.frm자료검색_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo담당자)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo소속팀정보)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt이름)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt검색어)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt휴대폰)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo유입경로소분류)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo유입경로대분류)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt메모란)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp등록시작일자)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp등록마감일자)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp수정시작일자)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp수정마감일자)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo검색제한)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo유입경로)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt기수검색)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt증권사)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt네이버아이디)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt카톡아이디)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo가입반)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo인바운드)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp리딩기간1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp리딩기간2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp최초분배일)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Label lblTopBar;
        private System.Windows.Forms.Label lblClose;
        private C1.Win.C1Input.C1ComboBox cbo담당자;
        private C1.Win.C1Input.C1ComboBox cbo소속팀정보;
        private C1.Win.C1Input.C1TextBox txt이름;
        private C1.Win.C1Input.C1TextBox txt검색어;
        private C1.Win.C1Input.C1TextBox txt휴대폰;
        private C1.Win.C1Input.C1ComboBox cbo유입경로소분류;
        private C1.Win.C1Input.C1ComboBox cbo유입경로대분류;
        private C1.Win.C1Input.C1TextBox txt메모란;
        private C1.Win.Calendar.C1DateEdit dtp등록시작일자;
        private C1.Win.Calendar.C1DateEdit dtp등록마감일자;
        private C1.Win.Calendar.C1DateEdit dtp수정시작일자;
        private C1.Win.Calendar.C1DateEdit dtp수정마감일자;
        private System.Windows.Forms.Label lblSearch;
        private C1.Win.C1Input.C1ComboBox cbo검색제한;
        private C1.Win.C1Input.C1ComboBox cbo유입경로;
        private C1.Win.C1Input.C1TextBox txt기수검색;
        private C1.Win.C1Input.C1TextBox txt증권사;
        private C1.Win.C1Input.C1TextBox txt네이버아이디;
        private C1.Win.C1Input.C1TextBox txt카톡아이디;
        private C1.Win.C1Input.C1ComboBox cbo가입반;
        private C1.Win.C1Input.C1ComboBox cbo인바운드;
        private C1.Win.Calendar.C1DateEdit dtp리딩기간1;
        private C1.Win.Calendar.C1DateEdit dtp리딩기간2;
        private C1.Win.Calendar.C1DateEdit dtp최초분배일;
    }
}