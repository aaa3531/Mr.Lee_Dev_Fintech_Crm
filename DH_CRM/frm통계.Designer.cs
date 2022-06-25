namespace DH_CRM
{
    partial class frm통계
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm통계));
            this.cbo통계항목 = new C1.Win.C1Input.C1ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblPrint = new System.Windows.Forms.Label();
            this.opt단위표시1 = new System.Windows.Forms.RadioButton();
            this.opt단위표시2 = new System.Windows.Forms.RadioButton();
            this.opt단위표시3 = new System.Windows.Forms.RadioButton();
            this.opt단위표시4 = new System.Windows.Forms.RadioButton();
            this.opt단위표시5 = new System.Windows.Forms.RadioButton();
            this.opt단위표시6 = new System.Windows.Forms.RadioButton();
            this.sizeMain = new C1.Win.C1Sizer.C1Sizer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cbo통계항목)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeMain)).BeginInit();
            this.sizeMain.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo통계항목
            // 
            this.cbo통계항목.AllowSpinLoop = false;
            this.cbo통계항목.AutoSize = false;
            this.cbo통계항목.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.cbo통계항목.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbo통계항목.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbo통계항목.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.cbo통계항목.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbo통계항목.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo통계항목.GapHeight = 0;
            this.cbo통계항목.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbo통계항목.ItemsDisplayMember = "";
            this.cbo통계항목.ItemsValueMember = "";
            this.cbo통계항목.Location = new System.Drawing.Point(1577, 62);
            this.cbo통계항목.Name = "cbo통계항목";
            this.cbo통계항목.Size = new System.Drawing.Size(400, 40);
            this.cbo통계항목.Style.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbo통계항목.TabIndex = 106;
            this.cbo통계항목.Tag = null;
            this.cbo통계항목.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.cbo통계항목.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.cbo통계항목.SelectedIndexChanged += new System.EventHandler(this.cbo통계항목_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1555, 1009);
            this.chart1.TabIndex = 107;
            this.chart1.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.ItemSize = new System.Drawing.Size(80, 30);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1569, 1053);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 109;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1561, 1015);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "막대그래프";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1561, 1025);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "라인그래프";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(1561, 1025);
            this.chart2.TabIndex = 108;
            this.chart2.Text = "chart2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart3);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1561, 1025);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "파이그래프";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(0, 0);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(1561, 1025);
            this.chart3.TabIndex = 109;
            this.chart3.Text = "chart3";
            // 
            // lblPrint
            // 
            this.lblPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.lblPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrint.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPrint.ForeColor = System.Drawing.Color.White;
            this.lblPrint.Location = new System.Drawing.Point(8, 8);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(111, 33);
            this.lblPrint.TabIndex = 110;
            this.lblPrint.Text = "프린트";
            this.lblPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrint.Click += new System.EventHandler(this.lblPrint_Click);
            // 
            // opt단위표시1
            // 
            this.opt단위표시1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.opt단위표시1.Checked = true;
            this.opt단위표시1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.opt단위표시1.ForeColor = System.Drawing.Color.White;
            this.opt단위표시1.Location = new System.Drawing.Point(4, 3);
            this.opt단위표시1.Name = "opt단위표시1";
            this.opt단위표시1.Size = new System.Drawing.Size(422, 41);
            this.opt단위표시1.TabIndex = 113;
            this.opt단위표시1.TabStop = true;
            this.opt단위표시1.Text = "보이지 않음";
            this.opt단위표시1.UseVisualStyleBackColor = false;
            // 
            // opt단위표시2
            // 
            this.opt단위표시2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.opt단위표시2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.opt단위표시2.ForeColor = System.Drawing.Color.White;
            this.opt단위표시2.Location = new System.Drawing.Point(4, 50);
            this.opt단위표시2.Name = "opt단위표시2";
            this.opt단위표시2.Size = new System.Drawing.Size(422, 41);
            this.opt단위표시2.TabIndex = 114;
            this.opt단위표시2.Text = "데이터값";
            this.opt단위표시2.UseVisualStyleBackColor = false;
            this.opt단위표시2.CheckedChanged += new System.EventHandler(this.opt단위표시2_CheckedChanged);
            // 
            // opt단위표시3
            // 
            this.opt단위표시3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.opt단위표시3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.opt단위표시3.ForeColor = System.Drawing.Color.White;
            this.opt단위표시3.Location = new System.Drawing.Point(4, 97);
            this.opt단위표시3.Name = "opt단위표시3";
            this.opt단위표시3.Size = new System.Drawing.Size(422, 41);
            this.opt단위표시3.TabIndex = 115;
            this.opt단위표시3.Text = "점유비율(%)";
            this.opt단위표시3.UseVisualStyleBackColor = false;
            this.opt단위표시3.CheckedChanged += new System.EventHandler(this.opt단위표시3_CheckedChanged);
            // 
            // opt단위표시4
            // 
            this.opt단위표시4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.opt단위표시4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.opt단위표시4.ForeColor = System.Drawing.Color.White;
            this.opt단위표시4.Location = new System.Drawing.Point(4, 144);
            this.opt단위표시4.Name = "opt단위표시4";
            this.opt단위표시4.Size = new System.Drawing.Size(422, 41);
            this.opt단위표시4.TabIndex = 116;
            this.opt단위표시4.Text = "항목이름";
            this.opt단위표시4.UseVisualStyleBackColor = false;
            this.opt단위표시4.CheckedChanged += new System.EventHandler(this.opt단위표시4_CheckedChanged);
            // 
            // opt단위표시5
            // 
            this.opt단위표시5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.opt단위표시5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.opt단위표시5.ForeColor = System.Drawing.Color.White;
            this.opt단위표시5.Location = new System.Drawing.Point(4, 191);
            this.opt단위표시5.Name = "opt단위표시5";
            this.opt단위표시5.Size = new System.Drawing.Size(422, 41);
            this.opt단위표시5.TabIndex = 117;
            this.opt단위표시5.Text = "항목이름 + 데이터값";
            this.opt단위표시5.UseVisualStyleBackColor = false;
            this.opt단위표시5.CheckedChanged += new System.EventHandler(this.opt단위표시5_CheckedChanged);
            // 
            // opt단위표시6
            // 
            this.opt단위표시6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.opt단위표시6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.opt단위표시6.ForeColor = System.Drawing.Color.White;
            this.opt단위표시6.Location = new System.Drawing.Point(4, 238);
            this.opt단위표시6.Name = "opt단위표시6";
            this.opt단위표시6.Size = new System.Drawing.Size(422, 41);
            this.opt단위표시6.TabIndex = 118;
            this.opt단위표시6.Text = "항목이름 + 점유비율(%)";
            this.opt단위표시6.UseVisualStyleBackColor = false;
            this.opt단위표시6.CheckedChanged += new System.EventHandler(this.opt단위표시6_CheckedChanged);
            // 
            // sizeMain
            // 
            this.sizeMain.Controls.Add(this.panel5);
            this.sizeMain.Controls.Add(this.panel1);
            this.sizeMain.Controls.Add(this.label1);
            this.sizeMain.Controls.Add(this.label4);
            this.sizeMain.Controls.Add(this.tabControl1);
            this.sizeMain.Controls.Add(this.cbo통계항목);
            this.sizeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizeMain.GridDefinition = resources.GetString("sizeMain.GridDefinition");
            this.sizeMain.Location = new System.Drawing.Point(0, 0);
            this.sizeMain.Name = "sizeMain";
            this.sizeMain.Size = new System.Drawing.Size(1981, 1061);
            this.sizeMain.TabIndex = 108;
            this.sizeMain.Text = "c1Sizer1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.panel5.Controls.Add(this.lblPrint);
            this.panel5.Location = new System.Drawing.Point(1577, 1007);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 50);
            this.panel5.TabIndex = 230;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.opt단위표시1);
            this.panel1.Controls.Add(this.opt단위표시6);
            this.panel1.Controls.Add(this.opt단위표시2);
            this.panel1.Controls.Add(this.opt단위표시5);
            this.panel1.Controls.Add(this.opt단위표시3);
            this.panel1.Controls.Add(this.opt단위표시4);
            this.panel1.Location = new System.Drawing.Point(1577, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 829);
            this.panel1.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(119)))));
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1577, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 40);
            this.label1.TabIndex = 117;
            this.label1.Text = "단위표시";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(65)))), ((int)(((byte)(119)))));
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1577, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 40);
            this.label4.TabIndex = 116;
            this.label4.Text = "통계 항목 선택";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm통계
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1981, 1061);
            this.Controls.Add(this.sizeMain);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm통계";
            this.Text = "통계";
            this.Load += new System.EventHandler(this.frm통계_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbo통계항목)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeMain)).EndInit();
            this.sizeMain.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.C1Input.C1ComboBox cbo통계항목;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.RadioButton opt단위표시1;
        private System.Windows.Forms.RadioButton opt단위표시2;
        private System.Windows.Forms.RadioButton opt단위표시3;
        private System.Windows.Forms.RadioButton opt단위표시4;
        private System.Windows.Forms.RadioButton opt단위표시5;
        private System.Windows.Forms.RadioButton opt단위표시6;
        private C1.Win.C1Sizer.C1Sizer sizeMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
    }
}