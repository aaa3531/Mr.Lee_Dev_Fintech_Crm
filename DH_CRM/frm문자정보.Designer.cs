namespace DH_CRM
{
    partial class frm문자정보
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm문자정보));
            this.picMain = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTopBar = new System.Windows.Forms.Label();
            this.txt문자내용 = new C1.Win.C1Input.C1TextBox();
            this.txt전송시간 = new C1.Win.C1Input.C1TextBox();
            this.txt회원명 = new C1.Win.C1Input.C1TextBox();
            this.txt전송결과 = new C1.Win.C1Input.C1TextBox();
            this.txt휴대전화 = new C1.Win.C1Input.C1TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt문자내용)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt전송시간)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt회원명)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt전송결과)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt휴대전화)).BeginInit();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.BackColor = System.Drawing.SystemColors.Control;
            this.picMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(0, 0);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(463, 422);
            this.picMain.TabIndex = 9;
            this.picMain.TabStop = false;
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClose.Location = new System.Drawing.Point(429, 5);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 28);
            this.lblClose.TabIndex = 87;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblTopBar
            // 
            this.lblTopBar.BackColor = System.Drawing.Color.Transparent;
            this.lblTopBar.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTopBar.Location = new System.Drawing.Point(5, 5);
            this.lblTopBar.Name = "lblTopBar";
            this.lblTopBar.Size = new System.Drawing.Size(418, 28);
            this.lblTopBar.TabIndex = 86;
            // 
            // txt문자내용
            // 
            this.txt문자내용.AutoSize = false;
            this.txt문자내용.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt문자내용.Location = new System.Drawing.Point(10, 118);
            this.txt문자내용.Multiline = true;
            this.txt문자내용.Name = "txt문자내용";
            this.txt문자내용.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt문자내용.Size = new System.Drawing.Size(441, 292);
            this.txt문자내용.TabIndex = 88;
            this.txt문자내용.Tag = null;
            // 
            // txt전송시간
            // 
            this.txt전송시간.AutoSize = false;
            this.txt전송시간.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt전송시간.Location = new System.Drawing.Point(85, 47);
            this.txt전송시간.Name = "txt전송시간";
            this.txt전송시간.Size = new System.Drawing.Size(142, 29);
            this.txt전송시간.TabIndex = 89;
            this.txt전송시간.Tag = null;
            this.txt전송시간.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt전송시간.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // txt회원명
            // 
            this.txt회원명.AutoSize = false;
            this.txt회원명.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt회원명.Location = new System.Drawing.Point(85, 83);
            this.txt회원명.Name = "txt회원명";
            this.txt회원명.Size = new System.Drawing.Size(142, 29);
            this.txt회원명.TabIndex = 90;
            this.txt회원명.Tag = null;
            this.txt회원명.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt회원명.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // txt전송결과
            // 
            this.txt전송결과.AutoSize = false;
            this.txt전송결과.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt전송결과.Location = new System.Drawing.Point(309, 47);
            this.txt전송결과.Name = "txt전송결과";
            this.txt전송결과.Size = new System.Drawing.Size(142, 29);
            this.txt전송결과.TabIndex = 91;
            this.txt전송결과.Tag = null;
            this.txt전송결과.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt전송결과.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // txt휴대전화
            // 
            this.txt휴대전화.AutoSize = false;
            this.txt휴대전화.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt휴대전화.Location = new System.Drawing.Point(309, 83);
            this.txt휴대전화.Name = "txt휴대전화";
            this.txt휴대전화.Size = new System.Drawing.Size(142, 29);
            this.txt휴대전화.TabIndex = 92;
            this.txt휴대전화.Tag = null;
            this.txt휴대전화.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txt휴대전화.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // frm문자정보
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(463, 422);
            this.Controls.Add(this.txt휴대전화);
            this.Controls.Add(this.txt전송결과);
            this.Controls.Add(this.txt회원명);
            this.Controls.Add(this.txt전송시간);
            this.Controls.Add(this.txt문자내용);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTopBar);
            this.Controls.Add(this.picMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm문자정보";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "문자정보";
            this.Load += new System.EventHandler(this.frm문자정보_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt문자내용)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt전송시간)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt회원명)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt전송결과)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt휴대전화)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblTopBar;
        private C1.Win.C1Input.C1TextBox txt문자내용;
        private C1.Win.C1Input.C1TextBox txt전송시간;
        private C1.Win.C1Input.C1TextBox txt회원명;
        private C1.Win.C1Input.C1TextBox txt전송결과;
        private C1.Win.C1Input.C1TextBox txt휴대전화;
    }
}