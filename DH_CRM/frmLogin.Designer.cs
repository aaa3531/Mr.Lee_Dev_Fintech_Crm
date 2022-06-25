namespace DH_CRM
{
    partial class frmLogin
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.txtID = new C1.Win.C1Input.C1TextBox();
            this.txtPW = new C1.Win.C1Input.C1TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPW)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLogin.Location = new System.Drawing.Point(25, 253);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(363, 32);
            this.lblLogin.TabIndex = 2;
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClose.Location = new System.Drawing.Point(372, 7);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(38, 31);
            this.lblClose.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.AutoSize = false;
            this.txtID.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(26, 134);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(362, 31);
            this.txtID.TabIndex = 28;
            this.txtID.Tag = null;
            this.txtID.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txtID.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // txtPW
            // 
            this.txtPW.AutoSize = false;
            this.txtPW.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.txtPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPW.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.txtPW.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.Location = new System.Drawing.Point(26, 206);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '●';
            this.txtPW.Size = new System.Drawing.Size(362, 32);
            this.txtPW.TabIndex = 29;
            this.txtPW.Tag = null;
            this.txtPW.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txtPW.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(412, 309);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblLogin);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "로그인";
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblClose;
        private C1.Win.C1Input.C1TextBox txtID;
        private C1.Win.C1Input.C1TextBox txtPW;
    }
}

