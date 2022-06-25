namespace DH_CRM
{
    partial class frm환경설정비밀번호
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm환경설정비밀번호));
            this.txtPW = new C1.Win.C1Input.C1TextBox();
            this.txtID = new C1.Win.C1Input.C1TextBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPW
            // 
            this.txtPW.AutoSize = false;
            this.txtPW.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.txtPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPW.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.txtPW.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.Location = new System.Drawing.Point(23, 205);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '●';
            this.txtPW.Size = new System.Drawing.Size(362, 32);
            this.txtPW.TabIndex = 33;
            this.txtPW.Tag = null;
            this.txtPW.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txtPW.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // txtID
            // 
            this.txtID.AutoSize = false;
            this.txtID.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(23, 133);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(362, 31);
            this.txtID.TabIndex = 32;
            this.txtID.Tag = null;
            this.txtID.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.txtID.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClose.Location = new System.Drawing.Point(369, 6);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(38, 31);
            this.lblClose.TabIndex = 31;
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLogin.Location = new System.Drawing.Point(22, 252);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(363, 32);
            this.lblLogin.TabIndex = 30;
            // 
            // frm환경설정비밀번호
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(410, 306);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblLogin);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm환경설정비밀번호";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "환경설정비밀번호";
            ((System.ComponentModel.ISupportInitialize)(this.txtPW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Input.C1TextBox txtPW;
        private C1.Win.C1Input.C1TextBox txtID;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblLogin;
    }
}