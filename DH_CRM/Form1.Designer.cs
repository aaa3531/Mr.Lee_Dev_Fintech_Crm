namespace DH_CRM
{
    partial class Form1
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.GridDefinition = "65.2173913043478:False:False;\t89.3333333333333:False:False;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 0);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(75, 23);
            this.c1Sizer1.TabIndex = 0;
            this.c1Sizer1.Text = "c1Sizer1";
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(800, 161);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1Ribbon1.ToolTipSettings.BackColor = System.Drawing.Color.White;
            this.c1Ribbon1.ToolTipSettings.BackgroundGradient = C1.Win.Ribbon.ToolTipGradient.None;
            this.c1Ribbon1.ToolTipSettings.Border = true;
            this.c1Ribbon1.ToolTipSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.c1Ribbon1.ToolTipSettings.Font = new System.Drawing.Font("굴림", 9F);
            this.c1Ribbon1.ToolTipSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.c1Ribbon1.ToolTipSettings.InitialDelay = 900;
            this.c1Ribbon1.ToolTipSettings.ReshowDelay = 180;
            this.c1Ribbon1.ToolTipSettings.Shadow = false;
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup1);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Tab";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Group";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.c1Ribbon1);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Sizer.C1Sizer c1Sizer1;
        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTab ribbonTab1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
    }
}