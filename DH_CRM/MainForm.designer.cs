namespace DH_CRM
{
    partial class MainForm
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
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.backgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.Color.White;
            this.backgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundPanel.Controls.Add(this.label1);
            this.backgroundPanel.Controls.Add(this.closePictureBox);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(220, 120);
            this.backgroundPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "무료리딩 만료되기 3일전 고객이 있습니다.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // closePictureBox
            // 
            this.closePictureBox.Location = new System.Drawing.Point(198, 3);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(17, 17);
            this.closePictureBox.TabIndex = 0;
            this.closePictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(220, 120);
            this.Controls.Add(this.backgroundPanel);
            this.Font = new System.Drawing.Font("나눔고딕코딩", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Load);
            this.backgroundPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.Label label1;
    }
}

