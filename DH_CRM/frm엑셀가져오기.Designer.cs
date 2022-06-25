namespace DH_CRM
{
    partial class frm엑셀가져오기
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm엑셀가져오기));
            this.picMain = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTopBar = new System.Windows.Forms.Label();
            this.grdWork = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.lbl엑셀읽기 = new System.Windows.Forms.Label();
            this.lbl자료변환 = new System.Windows.Forms.Label();
            this.lbl닫기 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblFile = new System.Windows.Forms.Label();
            this.lbl업로드취소 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).BeginInit();
            this.SuspendLayout();
            // 
            // picMain
            // 
            this.picMain.BackColor = System.Drawing.SystemColors.Control;
            this.picMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMain.Image = ((System.Drawing.Image)(resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(0, 0);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(610, 573);
            this.picMain.TabIndex = 12;
            this.picMain.TabStop = false;
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClose.Location = new System.Drawing.Point(576, 5);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(27, 28);
            this.lblClose.TabIndex = 103;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblTopBar
            // 
            this.lblTopBar.BackColor = System.Drawing.Color.Transparent;
            this.lblTopBar.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTopBar.Location = new System.Drawing.Point(5, 5);
            this.lblTopBar.Name = "lblTopBar";
            this.lblTopBar.Size = new System.Drawing.Size(565, 28);
            this.lblTopBar.TabIndex = 102;
            // 
            // grdWork
            // 
            this.grdWork.AllowEditing = false;
            this.grdWork.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.grdWork.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.grdWork.ExtendLastCol = true;
            this.grdWork.Location = new System.Drawing.Point(11, 128);
            this.grdWork.Name = "grdWork";
            this.grdWork.Size = new System.Drawing.Size(581, 259);
            this.grdWork.StyleInfo = resources.GetString("grdWork.StyleInfo");
            this.grdWork.TabIndex = 104;
            this.grdWork.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            // 
            // lbl엑셀읽기
            // 
            this.lbl엑셀읽기.BackColor = System.Drawing.Color.Transparent;
            this.lbl엑셀읽기.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl엑셀읽기.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl엑셀읽기.Location = new System.Drawing.Point(419, 430);
            this.lbl엑셀읽기.Name = "lbl엑셀읽기";
            this.lbl엑셀읽기.Size = new System.Drawing.Size(84, 32);
            this.lbl엑셀읽기.TabIndex = 105;
            this.lbl엑셀읽기.Click += new System.EventHandler(this.lbl엑셀읽기_Click);
            // 
            // lbl자료변환
            // 
            this.lbl자료변환.BackColor = System.Drawing.Color.Transparent;
            this.lbl자료변환.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl자료변환.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl자료변환.Location = new System.Drawing.Point(508, 430);
            this.lbl자료변환.Name = "lbl자료변환";
            this.lbl자료변환.Size = new System.Drawing.Size(84, 32);
            this.lbl자료변환.TabIndex = 106;
            this.lbl자료변환.Click += new System.EventHandler(this.lbl자료변환_Click);
            // 
            // lbl닫기
            // 
            this.lbl닫기.BackColor = System.Drawing.Color.Transparent;
            this.lbl닫기.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl닫기.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl닫기.Location = new System.Drawing.Point(234, 522);
            this.lbl닫기.Name = "lbl닫기";
            this.lbl닫기.Size = new System.Drawing.Size(143, 33);
            this.lbl닫기.TabIndex = 107;
            this.lbl닫기.Click += new System.EventHandler(this.lbl닫기_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 435);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(366, 22);
            this.progressBar1.TabIndex = 108;
            // 
            // lblFile
            // 
            this.lblFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.lblFile.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFile.ForeColor = System.Drawing.Color.White;
            this.lblFile.Location = new System.Drawing.Point(94, 398);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(408, 27);
            this.lblFile.TabIndex = 109;
            // 
            // lbl업로드취소
            // 
            this.lbl업로드취소.BackColor = System.Drawing.Color.Transparent;
            this.lbl업로드취소.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl업로드취소.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl업로드취소.Location = new System.Drawing.Point(508, 393);
            this.lbl업로드취소.Name = "lbl업로드취소";
            this.lbl업로드취소.Size = new System.Drawing.Size(84, 32);
            this.lbl업로드취소.TabIndex = 110;
            this.lbl업로드취소.Click += new System.EventHandler(this.lbl업로드취소_Click);
            // 
            // frm엑셀가져오기
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(610, 573);
            this.Controls.Add(this.lbl업로드취소);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl닫기);
            this.Controls.Add(this.lbl자료변환);
            this.Controls.Add(this.lbl엑셀읽기);
            this.Controls.Add(this.grdWork);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTopBar);
            this.Controls.Add(this.picMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm엑셀가져오기";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm엑셀가져오기";
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdWork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblTopBar;
        private C1.Win.C1FlexGrid.C1FlexGrid grdWork;
        private System.Windows.Forms.Label lbl엑셀읽기;
        private System.Windows.Forms.Label lbl자료변환;
        private System.Windows.Forms.Label lbl닫기;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lbl업로드취소;
    }
}