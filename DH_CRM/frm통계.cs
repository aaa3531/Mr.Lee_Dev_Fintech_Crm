using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;

namespace DH_CRM
{
    public partial class frm통계 : Form
    {
        private SQLServer _SQLServer;
        public frm통계()
        {
            InitializeComponent();
            this._SQLServer = SQLServer.Instance();
        }

        private void frm통계_Load(object sender, EventArgs e)
        {
            this.settingComboData();
        }
        private void settingComboData()
        {
            this.cbo통계항목.Items.Add("유입경로");
            this.cbo통계항목.Items.Add("최초분배일(일별)");
            this.cbo통계항목.Items.Add("최초분배일(월별)");
            this.cbo통계항목.Items.Add("예약일(일별)");
            this.cbo통계항목.Items.Add("예약일(월별)");
            this.cbo통계항목.Items.Add("담당자별");
            this.cbo통계항목.SelectedIndex = 0;
        }

        private void cbo통계항목_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbo통계항목.SelectedIndex == 0)
            {
                if (this.tabControl1.SelectedIndex == 0)
                    this.searchData유입경로();
                else if (this.tabControl1.SelectedIndex == 1)
                    this.searchData유입경로1();
                else if (this.tabControl1.SelectedIndex == 2)
                    this.searchData유입경로2();
            }
            else if (this.cbo통계항목.SelectedIndex == 1)
            {
                if (this.tabControl1.SelectedIndex == 0)
                    this.searchData최초분배일일별();
                else if (this.tabControl1.SelectedIndex == 1)
                    this.searchData최초분배일일별1();
                else if (this.tabControl1.SelectedIndex == 2)
                    this.searchData최초분배일일별2();
            }
            else if (this.cbo통계항목.SelectedIndex == 2)
            {
                if (this.tabControl1.SelectedIndex == 0)
                    this.searchData최초분배일월별();
                else if (this.tabControl1.SelectedIndex == 1)
                    this.searchData최초분배일월별1();
                else if (this.tabControl1.SelectedIndex == 2)
                    this.searchData최초분배일월별2();
            }
            else if (this.cbo통계항목.SelectedIndex == 3)
            {
                if (this.tabControl1.SelectedIndex == 0)
                    this.searchData예약일설정일별();
                else if (this.tabControl1.SelectedIndex == 1)
                    this.searchData예약일설정일별1();
                else if (this.tabControl1.SelectedIndex == 2)
                    this.searchData예약일설정일별2();
            }
            else if (this.cbo통계항목.SelectedIndex == 4)
            {
                if (this.tabControl1.SelectedIndex == 0)
                    this.searchData예약일설정월별();
                else if (this.tabControl1.SelectedIndex == 1)
                    this.searchData예약일설정월별1();
                else if (this.tabControl1.SelectedIndex == 2)
                    this.searchData예약일설정월별2();
            }
            else if (this.cbo통계항목.SelectedIndex == 5)
            {
                if (this.tabControl1.SelectedIndex == 0)
                    this.searchData담당자별();
                else if (this.tabControl1.SelectedIndex == 1)
                    this.searchData담당자별1();
                else if (this.tabControl1.SelectedIndex == 2)
                    this.searchData담당자별2();
            }
        }
        private void searchData최초분배일일별()
        {
            try
            {
                Dictionary<int, string> dicResult = new Dictionary<int, string>();
                Dictionary<int, string> dicResult1 = new Dictionary<int, string>();

                this.chart1.Series.Clear();
                int Cnt = 0;
                double x = 0.5;
                string sql = "";
                sql += "select 최초분배일, 건수=count(최초분배일) " + System.Environment.NewLine;
                sql += "from tb_고객등록" + System.Environment.NewLine;
                sql += "where 최초분배일<>''" + System.Environment.NewLine;
                sql += "group by 최초분배일" + System.Environment.NewLine;
                sql += "order by 최초분배일" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    Series series = new Series(Convert.ToString(sd["최초분배일"]));
                    series.Points.AddXY(x, sd["건수"]);
                    
                    this.chart1.Series.Add(series);

                    if (this.opt단위표시2.Checked == true || this.opt단위표시3.Checked == true)
                        dicResult.Add(Cnt, Convert.ToString(sd["건수"]));

                    if (this.opt단위표시4.Checked == true)
                        dicResult.Add(Cnt, Convert.ToString(sd["최초분배일"]));

                    if (this.opt단위표시5.Checked == true)
                    {
                        dicResult.Add(Cnt, Convert.ToString(sd["최초분배일"]));
                        dicResult1.Add(Cnt, Convert.ToString(sd["건수"]));
                    }

                    if (this.opt단위표시6.Checked == true)
                    {
                        dicResult.Add(Cnt, Convert.ToString(sd["최초분배일"]));
                        dicResult1.Add(Cnt, Convert.ToString(sd["건수"]));
                    }

                    Cnt++;
                    x++;
                }
                sd.Close();
                this.chart1.ChartAreas[0].AxisX.Interval = 1;
                this.chart1.Update();

                if (this.opt단위표시2.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                }

                if (this.opt단위표시3.Checked == true)
                {
                    Cnt = 0;
                    double dblCount = this.chart1.ChartAreas[0].AxisY.Maximum;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        int data = Convert.ToInt32(items.Value);
                        this.chart1.Series[Cnt].Points[0].Label = Convert.ToString(Math.Round((Convert.ToDouble(data) / dblCount) * 100)) + "%";
                        Cnt++;
                    }
                }
                if (this.opt단위표시4.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                }
                if (this.opt단위표시5.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult1)
                    {
                        this.chart1.Series[Cnt].Points[0].Label += " " + items.Value;
                        Cnt++;
                    }
                }
                if (this.opt단위표시6.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                    Cnt = 0;
                    double dblCount = this.chart1.ChartAreas[0].AxisY.Maximum;
                    foreach (KeyValuePair<int, string> items in dicResult1)
                    {
                        int data = Convert.ToInt32(items.Value);
                        this.chart1.Series[Cnt].Points[0].Label += " " + Convert.ToString(Math.Round((Convert.ToDouble(data) / dblCount) * 100)) + "%";
                        Cnt++;
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void searchData예약일설정일별()
        {
            try
            {
                Dictionary<int, string> dicResult = new Dictionary<int, string>();
                Dictionary<int, string> dicResult1 = new Dictionary<int, string>();
                
                this.chart1.Series.Clear();
                int Cnt = 0;
                double x = 0.5;
                string sql = "";
                sql += "select 예약일설정, 건수=count(예약일설정) " + System.Environment.NewLine;
                sql += "from tb_고객등록" + System.Environment.NewLine;
                sql += "where 예약일설정<>'' " + System.Environment.NewLine;
                sql += "group by 예약일설정" + System.Environment.NewLine;
                sql += "order by 예약일설정" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    Series series = new Series(Convert.ToString(sd["예약일설정"]));
                    series.Points.AddXY(x, sd["건수"]);
                    
                    this.chart1.Series.Add(series);

                    if (this.opt단위표시2.Checked == true || this.opt단위표시3.Checked == true)
                        dicResult.Add(Cnt, Convert.ToString(sd["건수"]));

                    if (this.opt단위표시4.Checked == true)
                        dicResult.Add(Cnt, Convert.ToString(sd["예약일설정"]));

                    if (this.opt단위표시5.Checked == true)
                    {
                        dicResult.Add(Cnt, Convert.ToString(sd["예약일설정"]));
                        dicResult1.Add(Cnt, Convert.ToString(sd["건수"]));
                    }

                    if (this.opt단위표시6.Checked == true)
                    {
                        dicResult.Add(Cnt, Convert.ToString(sd["예약일설정"]));
                        dicResult1.Add(Cnt, Convert.ToString(sd["건수"]));
                    }

                    Cnt++;
                    x++;
                }
                sd.Close();
                this.chart1.ChartAreas[0].AxisX.Interval = 1;
                this.chart1.Update();

                if (this.opt단위표시2.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                }

                if (this.opt단위표시3.Checked == true)
                {
                    Cnt = 0;
                    double dblCount = this.chart1.ChartAreas[0].AxisY.Maximum;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        int data = Convert.ToInt32(items.Value);
                        this.chart1.Series[Cnt].Points[0].Label = Convert.ToString(Math.Round((Convert.ToDouble(data) / dblCount) * 100)) + "%";
                        Cnt++;
                    }
                }
                if (this.opt단위표시4.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                }
                if (this.opt단위표시5.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult1)
                    {
                        this.chart1.Series[Cnt].Points[0].Label += " " + items.Value;
                        Cnt++;
                    }
                }
                if (this.opt단위표시6.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                    Cnt = 0;
                    double dblCount = this.chart1.ChartAreas[0].AxisY.Maximum;
                    foreach (KeyValuePair<int, string> items in dicResult1)
                    {
                        int data = Convert.ToInt32(items.Value);
                        this.chart1.Series[Cnt].Points[0].Label += " " + Convert.ToString(Math.Round((Convert.ToDouble(data) / dblCount) * 100)) + "%";
                        Cnt++;
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void searchData예약일설정월별()
        {
            try
            {
                Dictionary<int, string> dicResult = new Dictionary<int, string>();
                Dictionary<int, string> dicResult1 = new Dictionary<int, string>();

                this.chart1.Series.Clear();
                int Cnt = 0;
                double x = 0.5;
                string sql = "";
                sql += "select 예약일설정=SUBSTRING(예약일설정,1,7), 건수=count(예약일설정) " + System.Environment.NewLine;
                sql += "from tb_고객등록" + System.Environment.NewLine;
                sql += "where 예약일설정<>'' " + System.Environment.NewLine;
                sql += "group by SUBSTRING(예약일설정,1,7)" + System.Environment.NewLine;
                sql += "order by SUBSTRING(예약일설정,1,7)" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    Series series = new Series(Convert.ToString(sd["예약일설정"]));
                    series.Points.AddXY(x, sd["건수"]);
                    
                    this.chart1.Series.Add(series);

                    if (this.opt단위표시2.Checked == true || this.opt단위표시3.Checked == true)
                        dicResult.Add(Cnt, Convert.ToString(sd["건수"]));

                    if (this.opt단위표시4.Checked == true)
                        dicResult.Add(Cnt, Convert.ToString(sd["예약일설정"]));

                    if (this.opt단위표시5.Checked == true)
                    {
                        dicResult.Add(Cnt, Convert.ToString(sd["예약일설정"]));
                        dicResult1.Add(Cnt, Convert.ToString(sd["건수"]));
                    }

                    if (this.opt단위표시6.Checked == true)
                    {
                        dicResult.Add(Cnt, Convert.ToString(sd["예약일설정"]));
                        dicResult1.Add(Cnt, Convert.ToString(sd["건수"]));
                    }

                    Cnt++;
                    x++;
                }
                sd.Close();
                this.chart1.ChartAreas[0].AxisX.Interval = 1;
                this.chart1.Update();

                if (this.opt단위표시2.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                }

                if (this.opt단위표시3.Checked == true)
                {
                    Cnt = 0;
                    double dblCount = this.chart1.ChartAreas[0].AxisY.Maximum;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        int data = Convert.ToInt32(items.Value);
                        this.chart1.Series[Cnt].Points[0].Label = Convert.ToString(Math.Round((Convert.ToDouble(data) / dblCount) * 100)) + "%";
                        Cnt++;
                    }
                }
                if (this.opt단위표시4.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                }
                if (this.opt단위표시5.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult1)
                    {
                        this.chart1.Series[Cnt].Points[0].Label += " " + items.Value;
                        Cnt++;
                    }
                }
                if (this.opt단위표시6.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                    Cnt = 0;
                    double dblCount = this.chart1.ChartAreas[0].AxisY.Maximum;
                    foreach (KeyValuePair<int, string> items in dicResult1)
                    {
                        int data = Convert.ToInt32(items.Value);
                        this.chart1.Series[Cnt].Points[0].Label += " " + Convert.ToString(Math.Round((Convert.ToDouble(data) / dblCount) * 100)) + "%";
                        Cnt++;
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void searchData최초분배일월별()
        {
            try
            {
                Dictionary<int, string> dicResult = new Dictionary<int, string>();
                Dictionary<int, string> dicResult1 = new Dictionary<int, string>();

                this.chart1.Series.Clear();
                int Cnt = 0;
                double x = 0.5;
                string sql = "";
                sql += "select 최초분배일=SUBSTRING(최초분배일,1,7), 건수=count(최초분배일) " + System.Environment.NewLine;
                sql += "from tb_고객등록" + System.Environment.NewLine;
                sql += "where 최초분배일<>''" + System.Environment.NewLine;
                sql += "group by SUBSTRING(최초분배일,1,7)" + System.Environment.NewLine;
                sql += "order by 최초분배일" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    Series series = new Series(Convert.ToString(sd["최초분배일"]));
                    series.Points.AddXY(x, sd["건수"]);
                    
                    this.chart1.Series.Add(series);

                    if (this.opt단위표시2.Checked == true || this.opt단위표시3.Checked == true)
                        dicResult.Add(Cnt, Convert.ToString(sd["건수"]));

                    if (this.opt단위표시4.Checked == true)
                        dicResult.Add(Cnt, Convert.ToString(sd["최초분배일"]));

                    if (this.opt단위표시5.Checked == true)
                    {
                        dicResult.Add(Cnt, Convert.ToString(sd["최초분배일"]));
                        dicResult1.Add(Cnt, Convert.ToString(sd["건수"]));
                    }

                    if (this.opt단위표시6.Checked == true)
                    {
                        dicResult.Add(Cnt, Convert.ToString(sd["최초분배일"]));
                        dicResult1.Add(Cnt, Convert.ToString(sd["건수"]));
                    }

                    Cnt++;
                    x++;
                }
                sd.Close();
                this.chart1.ChartAreas[0].AxisX.Interval = 1;
                this.chart1.Update();

                if (this.opt단위표시2.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                }

                if (this.opt단위표시3.Checked == true)
                {
                    Cnt = 0;
                    double dblCount = this.chart1.ChartAreas[0].AxisY.Maximum;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        int data = Convert.ToInt32(items.Value);
                        this.chart1.Series[Cnt].Points[0].Label = Convert.ToString(Math.Round((Convert.ToDouble(data) / dblCount) * 100)) + "%";
                        Cnt++;
                    }
                }
                if (this.opt단위표시4.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                }
                if (this.opt단위표시5.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult1)
                    {
                        this.chart1.Series[Cnt].Points[0].Label += " " + items.Value;
                        Cnt++;
                    }
                }
                if (this.opt단위표시6.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                    Cnt = 0;
                    double dblCount = this.chart1.ChartAreas[0].AxisY.Maximum;
                    foreach (KeyValuePair<int, string> items in dicResult1)
                    {
                        int data = Convert.ToInt32(items.Value);
                        this.chart1.Series[Cnt].Points[0].Label += " " + Convert.ToString(Math.Round((Convert.ToDouble(data) / dblCount) * 100)) + "%";
                        Cnt++;
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void searchData유입경로()
        {
            try
            {
                Dictionary<int, string> dicResult = new Dictionary<int, string>();
                Dictionary<int, string> dicResult1 = new Dictionary<int, string>();

                this.chart1.Series.Clear();
                int Cnt = 0;
                double x = 0.5;
                string sql = "";
                sql += "select a.유입경로, 유입경로Count=count(a.유입경로) " + System.Environment.NewLine;
                sql += "From tb_고객등록 a left join TB_유입경로설정 b" + System.Environment.NewLine;
                sql += "on a.유입경로=b.유입경로" + System.Environment.NewLine;
                sql += "where 1=1" + System.Environment.NewLine;
                sql += "and   a.유입경로<>''" + System.Environment.NewLine;
                sql += "group by a.유입경로" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    Series series = new Series(Convert.ToString(sd["유입경로"]));
                    //series.ChartType = SeriesChartType.Line;
                    //series.Color = Color.Red;

                    //for (double i = 0; i < 2 * Math.PI; i += 0.1)
                    //{
                    //    series.Points.AddXY(i, Math.Sin(i));
                    //}

                    //Series series = new Series("유입경로");
                    //this.chart1.Series.Add(series);

                    //this.chart1.Series[1].Points.AddXY(Convert.ToString(sd["대분류"]), sd["유입경로대분류"]);

                    series.Points.AddXY(x, sd["유입경로Count"]);

                    //series.Points[0].AxisLabel = Convert.ToString(sd["대분류"]);
                    //chart1.Series[0].Points.AddXY(Convert.ToString(sd["대분류"]), sd["유입경로대분류"]);

                    //if (Cnt == 0)
                    //    chart1.Series[0].Points[Cnt].Color = Color.Red;
                    //else if (Cnt == 1)
                    //    chart1.Series[0].Points[Cnt].Color = Color.Green;
                    //else if (Cnt == 2)
                    //    chart1.Series[0].Points[Cnt].Color = Color.Blue;
                    //else if (Cnt == 3)
                    //    chart1.Series[0].Points[Cnt].Color = Color.Orange;
                    //else if (Cnt == 4)
                    //    chart1.Series[0].Points[Cnt].Color = Color.Purple;

                    //chart1.Series[0].Points[Cnt].Label = sd["유입경로대분류"].ToString();
                    
                    this.chart1.Series.Add(series);

                    if (this.opt단위표시2.Checked == true || this.opt단위표시3.Checked == true)
                        dicResult.Add(Cnt, Convert.ToString(sd["유입경로Count"]));

                    if (this.opt단위표시4.Checked == true)
                        dicResult.Add(Cnt, Convert.ToString(sd["유입경로"]));

                    if (this.opt단위표시5.Checked == true)
                    {
                        dicResult.Add(Cnt, Convert.ToString(sd["유입경로"]));
                        dicResult1.Add(Cnt, Convert.ToString(sd["유입경로Count"]));
                    }

                    if (this.opt단위표시6.Checked == true)
                    {
                        dicResult.Add(Cnt, Convert.ToString(sd["유입경로"]));
                        dicResult1.Add(Cnt, Convert.ToString(sd["유입경로Count"]));
                    }

                    Cnt++;
                    x++;
                }
                sd.Close();
                this.chart1.ChartAreas[0].AxisX.Interval = 1;
                this.chart1.Update();

                if (this.opt단위표시2.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                }

                if (this.opt단위표시3.Checked == true)
                {
                    Cnt = 0;
                    double dblCount = this.chart1.ChartAreas[0].AxisY.Maximum;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        int data = Convert.ToInt32(items.Value);
                        this.chart1.Series[Cnt].Points[0].Label = Convert.ToString(Math.Round((Convert.ToDouble(data) / dblCount) * 100)) + "%";
                        Cnt++;
                    }
                }
                if (this.opt단위표시4.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                }
                if (this.opt단위표시5.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult1)
                    {
                        this.chart1.Series[Cnt].Points[0].Label += " " + items.Value;
                        Cnt++;
                    }
                }
                if (this.opt단위표시6.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                    Cnt = 0;
                    double dblCount = this.chart1.ChartAreas[0].AxisY.Maximum;
                    foreach (KeyValuePair<int, string> items in dicResult1)
                    {
                        int data = Convert.ToInt32(items.Value);
                        this.chart1.Series[Cnt].Points[0].Label += " " + Convert.ToString(Math.Round((Convert.ToDouble(data) / dblCount) * 100)) + "%";
                        Cnt++;
                    }
                }
                //chart1.Titles[0].Text = this.cbo통계항목.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
            }
        }
        private void searchData담당자별()
        {
            try
            {
                Dictionary<int, string> dicResult = new Dictionary<int, string>();
                Dictionary<int, string> dicResult1 = new Dictionary<int, string>();

                this.chart1.Series.Clear();
                int Cnt = 0;
                double x = 0.5;
                string sql = "";
                sql += "select b.이름, 건수=count(a.담당자) " + System.Environment.NewLine;
                sql += "from tb_고객등록 a left join tb_사용자정보 b" + System.Environment.NewLine;
                sql += "on a.담당자=b.사용자정보ID" + System.Environment.NewLine;
                sql += "where 1=1" + System.Environment.NewLine;
                sql += "and a.담당자>0" + System.Environment.NewLine;
                sql += "group by b.이름" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    Series series = new Series(Convert.ToString(sd["이름"]));
                    series.Points.AddXY(x, sd["건수"]);

                    this.chart1.Series.Add(series);

                    if (this.opt단위표시2.Checked == true || this.opt단위표시3.Checked == true)
                        dicResult.Add(Cnt, Convert.ToString(sd["건수"]));

                    if (this.opt단위표시4.Checked == true)
                        dicResult.Add(Cnt, Convert.ToString(sd["이름"]));

                    if (this.opt단위표시5.Checked == true)
                    {
                        dicResult.Add(Cnt, Convert.ToString(sd["이름"]));
                        dicResult1.Add(Cnt, Convert.ToString(sd["건수"]));
                    }

                    if (this.opt단위표시6.Checked == true)
                    {
                        dicResult.Add(Cnt, Convert.ToString(sd["이름"]));
                        dicResult1.Add(Cnt, Convert.ToString(sd["건수"]));
                    }

                    Cnt++;
                    x++;
                }
                sd.Close();
                this.chart1.ChartAreas[0].AxisX.Interval = 1;
                this.chart1.Update();

                if (this.opt단위표시2.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                }

                if (this.opt단위표시3.Checked == true)
                {
                    Cnt = 0;
                    double dblCount = this.chart1.ChartAreas[0].AxisY.Maximum;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        int data = Convert.ToInt32(items.Value);
                        this.chart1.Series[Cnt].Points[0].Label = Convert.ToString(Math.Round((Convert.ToDouble(data) / dblCount) * 100)) + "%";
                        Cnt++;
                    }
                }
                if (this.opt단위표시4.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                }
                if (this.opt단위표시5.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult1)
                    {
                        this.chart1.Series[Cnt].Points[0].Label += " " + items.Value;
                        Cnt++;
                    }
                }
                if (this.opt단위표시6.Checked == true)
                {
                    Cnt = 0;
                    foreach (KeyValuePair<int, string> items in dicResult)
                    {
                        this.chart1.Series[Cnt].Points[0].Label = items.Value;
                        Cnt++;
                    }
                    Cnt = 0;
                    double dblCount = this.chart1.ChartAreas[0].AxisY.Maximum;
                    foreach (KeyValuePair<int, string> items in dicResult1)
                    {
                        int data = Convert.ToInt32(items.Value);
                        this.chart1.Series[Cnt].Points[0].Label += " " + Convert.ToString(Math.Round((Convert.ToDouble(data) / dblCount) * 100)) + "%";
                        Cnt++;
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void searchData유입경로1()
        {
            try
            {
                string strStartDate = "";
                string strEndDate = "";

                this.chart2.Series.Clear();
                Series series = null;
                string beforeData = "";
                string sql = "";
                sql += "select 등록일자=convert(nvarchar,등록일자,23), a.유입경로, 유입경로Count=count(a.유입경로)" + System.Environment.NewLine;
                sql += "from tb_고객등록 a left join TB_유입경로설정 b" + System.Environment.NewLine;
                sql += "on a.유입경로=b.유입경로" + System.Environment.NewLine;
                sql += "where 1=1" + System.Environment.NewLine;
                sql += "and   a.유입경로<>''" + System.Environment.NewLine;
                sql += "group by convert(nvarchar,등록일자,23), 유입경로대분류, a.유입경로" + System.Environment.NewLine;
                sql += "order by a.유입경로, convert(nvarchar,등록일자,23)" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    if (beforeData == "" || beforeData != Convert.ToString(sd["유입경로"]))
                    {
                        if (beforeData != "")
                            this.chart2.Series.Add(series);
                        series = new Series(Convert.ToString(sd["유입경로"]));
                        series.ChartType = SeriesChartType.Line;
                    }
                    DateTime dt = Convert.ToDateTime(sd["등록일자"]);
                    series.Points.AddXY(dt, Convert.ToInt32(sd["유입경로Count"]));
                    beforeData = Convert.ToString(sd["유입경로"]);

                    if (strStartDate == "" || Convert.ToDateTime(strStartDate) > Convert.ToDateTime(sd["등록일자"]))
                        strStartDate = Convert.ToString(sd["등록일자"]);

                    if (strEndDate == "" || Convert.ToDateTime(sd["등록일자"]) > Convert.ToDateTime(strEndDate))
                        strEndDate = Convert.ToString(sd["등록일자"]);
                }
                sd.Close();

                if (beforeData != "")
                    this.chart2.Series.Add(series);

                this.chart2.Series[0].XValueType = ChartValueType.DateTime;
                this.chart2.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";

                this.chart2.ChartAreas[0].AxisX.Interval = 1;
                this.chart2.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                this.chart2.ChartAreas[0].AxisX.IntervalOffset = 1;

                this.chart2.Series[0].XValueType = ChartValueType.DateTime;

                DateTime minDate = Convert.ToDateTime(strStartDate).AddSeconds(-1);
                DateTime maxDate = Convert.ToDateTime(strEndDate);

                this.chart2.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                this.chart2.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
            }
            catch (Exception ex)
            {
            }
        }
        private void searchData담당자별1()
        {
            try
            {
                string strStartDate = "";
                string strEndDate = "";

                this.chart2.Series.Clear();
                Series series = null;
                string beforeData = "";
                string sql = "";
                sql += "select 등록일자=convert(nvarchar,등록일자,23), b.이름, 건수=count(a.담당자) " + System.Environment.NewLine;
                sql += "from tb_고객등록 a left join tb_사용자정보 b" + System.Environment.NewLine;
                sql += "on a.담당자=b.사용자정보ID" + System.Environment.NewLine;
                sql += "where 1=1" + System.Environment.NewLine;
                sql += "and a.담당자>0" + System.Environment.NewLine;
                sql += "group by convert(nvarchar,등록일자,23), b.이름" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    if (beforeData == "" || beforeData != Convert.ToString(sd["이름"]))
                    {
                        if (beforeData != "")
                            this.chart2.Series.Add(series);
                        series = new Series(Convert.ToString(sd["이름"]));
                        series.ChartType = SeriesChartType.Line;
                    }
                    DateTime dt = Convert.ToDateTime(sd["등록일자"]);
                    series.Points.AddXY(dt, Convert.ToInt32(sd["건수"]));
                    beforeData = Convert.ToString(sd["이름"]);

                    if (strStartDate == "" || Convert.ToDateTime(strStartDate) > Convert.ToDateTime(sd["등록일자"]))
                        strStartDate = Convert.ToString(sd["등록일자"]);

                    if (strEndDate == "" || Convert.ToDateTime(sd["등록일자"]) > Convert.ToDateTime(strEndDate))
                        strEndDate = Convert.ToString(sd["등록일자"]);
                }
                sd.Close();

                if (beforeData != "")
                    this.chart2.Series.Add(series);

                this.chart2.Series[0].XValueType = ChartValueType.DateTime;
                this.chart2.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";

                this.chart2.ChartAreas[0].AxisX.Interval = 1;
                this.chart2.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                this.chart2.ChartAreas[0].AxisX.IntervalOffset = 1;

                this.chart2.Series[0].XValueType = ChartValueType.DateTime;

                DateTime minDate = Convert.ToDateTime(strStartDate).AddSeconds(-1);
                DateTime maxDate = Convert.ToDateTime(strEndDate);

                this.chart2.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                this.chart2.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
            }
            catch (Exception ex)
            {
            }
        }
        private void searchData담당자별2()
        {
            try
            {
                this.chart3.Series.Clear();
                Series series = new Series();
                series.ChartType = SeriesChartType.Pie;

                string sql = "";
                sql += "select b.이름, 건수=count(a.담당자) " + System.Environment.NewLine;
                sql += "from tb_고객등록 a left join tb_사용자정보 b" + System.Environment.NewLine;
                sql += "on a.담당자=b.사용자정보ID" + System.Environment.NewLine;
                sql += "where 1=1" + System.Environment.NewLine;
                sql += "and a.담당자>0" + System.Environment.NewLine;
                sql += "group by b.이름" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    series.Points.AddXY(Convert.ToString(sd["이름"]), Convert.ToInt32(sd["건수"]));
                }
                sd.Close();
                this.chart3.Series.Add(series);
            }
            catch (Exception ex)
            {
            }
        }
        private void searchData유입경로2()
        {
            try
            {
                this.chart3.Series.Clear();
                Series series = new Series();
                series.ChartType = SeriesChartType.Pie;

                string sql = "";
                sql += "select a.유입경로, 유입경로CNT=count(a.유입경로)" + System.Environment.NewLine;
                sql += "from tb_고객등록 a left join tb_유입경로설정 b" + System.Environment.NewLine;
                sql += "on a.유입경로=b.유입경로" + System.Environment.NewLine;
                sql += "where 1=1" + System.Environment.NewLine;
                sql += "and a.유입경로<>''" + System.Environment.NewLine;
                sql += "group by a.유입경로" + System.Environment.NewLine;
                sql += "order by a.유입경로" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {        
                    series.Points.AddXY(Convert.ToString(sd["유입경로"]), Convert.ToInt32(sd["유입경로CNT"]));
                }
                sd.Close();
                this.chart3.Series.Add(series);
            }
            catch (Exception ex)
            {
            }
        }
        private void searchData최초분배일일별1()
        {
            try
            {
                string strStartDate = "";
                string strEndDate = "";

                this.chart2.Series.Clear();
                Series series = null;
                bool isData = false;
                string sql = "";
                sql += "select 최초분배일, 건수=count(최초분배일)" + System.Environment.NewLine;
                sql += "from tb_고객등록" + System.Environment.NewLine;
                sql += "where 최초분배일<>''" + System.Environment.NewLine;
                sql += "group by 최초분배일" + System.Environment.NewLine;
                sql += "order by 최초분배일" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    if (!isData)
                    {
                        series = new Series("최초분배일(일별)");
                        series.ChartType = SeriesChartType.Line;
                        isData = true;
                    }
                    DateTime dt = Convert.ToDateTime(sd["최초분배일"]);
                    series.Points.AddXY(dt, Convert.ToInt32(sd["건수"]));

                    if (strStartDate == "" || Convert.ToDateTime(strStartDate) > Convert.ToDateTime(sd["최초분배일"]))
                        strStartDate = Convert.ToString(sd["최초분배일"]);

                    if (strEndDate == "" || Convert.ToDateTime(sd["최초분배일"]) > Convert.ToDateTime(strEndDate))
                        strEndDate = Convert.ToString(sd["최초분배일"]);
                }
                this.chart2.Series.Add(series);
                sd.Close();

                this.chart2.Series[0].XValueType = ChartValueType.DateTime;
                this.chart2.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";

                this.chart2.ChartAreas[0].AxisX.Interval = 1;
                this.chart2.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                this.chart2.ChartAreas[0].AxisX.IntervalOffset = 1;

                this.chart2.Series[0].XValueType = ChartValueType.DateTime;

                DateTime minDate = Convert.ToDateTime(strStartDate).AddSeconds(-1);
                DateTime maxDate = Convert.ToDateTime(strEndDate);

                this.chart2.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                this.chart2.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
            }
            catch (Exception ex)
            {
            }
        }
        private void searchData예약일설정일별1()
        {
            try
            {
                string strStartDate = "";
                string strEndDate = "";

                this.chart2.Series.Clear();
                Series series = null;
                bool isData = false;
                string sql = "";
                sql += "select 예약일설정, 건수=count(예약일설정)" + System.Environment.NewLine;
                sql += "from tb_고객등록" + System.Environment.NewLine;
                sql += "where 예약일설정<>''" + System.Environment.NewLine;
                sql += "group by 예약일설정" + System.Environment.NewLine;
                sql += "order by 예약일설정" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    if (!isData)
                    {
                        series = new Series("예약일(일별)");
                        series.ChartType = SeriesChartType.Line;
                        isData = true;
                    }
                    DateTime dt = Convert.ToDateTime(sd["예약일설정"]);
                    series.Points.AddXY(dt, Convert.ToInt32(sd["건수"]));

                    if (strStartDate == "" || Convert.ToDateTime(strStartDate) > Convert.ToDateTime(sd["예약일설정"]))
                        strStartDate = Convert.ToString(sd["예약일설정"]);

                    if (strEndDate == "" || Convert.ToDateTime(sd["예약일설정"]) > Convert.ToDateTime(strEndDate))
                        strEndDate = Convert.ToString(sd["예약일설정"]);
                }
                this.chart2.Series.Add(series);
                sd.Close();

                this.chart2.Series[0].XValueType = ChartValueType.DateTime;
                this.chart2.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";

                this.chart2.ChartAreas[0].AxisX.Interval = 1;
                this.chart2.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                this.chart2.ChartAreas[0].AxisX.IntervalOffset = 1;

                this.chart2.Series[0].XValueType = ChartValueType.DateTime;

                DateTime minDate = Convert.ToDateTime(strStartDate).AddSeconds(-1);
                DateTime maxDate = Convert.ToDateTime(strEndDate);

                this.chart2.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                this.chart2.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
            }
            catch (Exception ex)
            {
            }
        }
        private void searchData예약일설정월별1()
        {
            try
            {
                string strStartDate = "";
                string strEndDate = "";

                this.chart2.Series.Clear();
                Series series = null;
                bool isData = false;
                string sql = "";
                sql += "select 예약일설정=SUBSTRING(예약일설정,1,7), 건수=count(예약일설정)" + System.Environment.NewLine;
                sql += "from tb_고객등록" + System.Environment.NewLine;
                sql += "where 예약일설정<>''" + System.Environment.NewLine;
                sql += "group by SUBSTRING(예약일설정,1,7)" + System.Environment.NewLine;
                sql += "order by SUBSTRING(예약일설정,1,7)" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    if (!isData)
                    {
                        series = new Series("예약일(월별)");
                        series.ChartType = SeriesChartType.Line;
                        isData = true;
                    }
                    DateTime dt = Convert.ToDateTime(sd["예약일설정"]);
                    series.Points.AddXY(dt, Convert.ToInt32(sd["건수"]));

                    if (strStartDate == "" || Convert.ToDateTime(strStartDate) > Convert.ToDateTime(sd["예약일설정"]))
                        strStartDate = Convert.ToString(sd["예약일설정"]);

                    if (strEndDate == "" || Convert.ToDateTime(sd["예약일설정"]) > Convert.ToDateTime(strEndDate))
                        strEndDate = Convert.ToString(sd["예약일설정"]);
                }
                this.chart2.Series.Add(series);
                sd.Close();

                this.chart2.Series[0].XValueType = ChartValueType.DateTime;
                this.chart2.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM";

                this.chart2.ChartAreas[0].AxisX.Interval = 1;
                this.chart2.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
                this.chart2.ChartAreas[0].AxisX.IntervalOffset = 1;

                this.chart2.Series[0].XValueType = ChartValueType.DateTime;

                DateTime minDate = Convert.ToDateTime(strStartDate).AddSeconds(-1);
                DateTime maxDate = Convert.ToDateTime(strEndDate);

                this.chart2.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                this.chart2.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
            }
            catch (Exception ex)
            {
            }
        }
        private void searchData최초분배일월별1()
        {
            try
            {
                string strStartDate = "";
                string strEndDate = "";

                this.chart2.Series.Clear();
                Series series = null;
                bool isData = false;
                string sql = "";
                sql += "select 최초분배일=SUBSTRING(최초분배일,1,7), 건수=count(최초분배일)" + System.Environment.NewLine;
                sql += "from tb_고객등록" + System.Environment.NewLine;
                sql += "where 최초분배일<>''" + System.Environment.NewLine;
                sql += "group by SUBSTRING(최초분배일,1,7)" + System.Environment.NewLine;
                sql += "order by SUBSTRING(최초분배일,1,7)" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    if (!isData)
                    {
                        series = new Series("최초분배일(월별)");
                        series.ChartType = SeriesChartType.Line;
                        isData = true;
                    }
                    DateTime dt = Convert.ToDateTime(sd["최초분배일"]);
                    series.Points.AddXY(dt, Convert.ToInt32(sd["건수"]));

                    if (strStartDate == "" || Convert.ToDateTime(strStartDate) > Convert.ToDateTime(sd["최초분배일"]))
                        strStartDate = Convert.ToString(sd["최초분배일"]);

                    if (strEndDate == "" || Convert.ToDateTime(sd["최초분배일"]) > Convert.ToDateTime(strEndDate))
                        strEndDate = Convert.ToString(sd["최초분배일"]);
                }
                this.chart2.Series.Add(series);
                sd.Close();

                this.chart2.Series[0].XValueType = ChartValueType.DateTime;
                this.chart2.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM";

                this.chart2.ChartAreas[0].AxisX.Interval = 1;
                this.chart2.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
                this.chart2.ChartAreas[0].AxisX.IntervalOffset = 1;

                this.chart2.Series[0].XValueType = ChartValueType.DateTime;

                DateTime minDate = Convert.ToDateTime(strStartDate).AddSeconds(-1);
                DateTime maxDate = Convert.ToDateTime(strEndDate);

                this.chart2.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                this.chart2.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
            }
            catch (Exception ex)
            {
            }
        }
        private void searchData최초분배일일별2()
        {
            try
            {
                this.chart3.Series.Clear();
                Series series = new Series("최초분배일(일별)");
                series.ChartType = SeriesChartType.Pie;

                string sql = "";
                sql += "select 최초분배일, 건수=count(최초분배일)" + System.Environment.NewLine;
                sql += "from tb_고객등록" + System.Environment.NewLine;
                sql += "where 최초분배일<>''" + System.Environment.NewLine;
                sql += "group by 최초분배일" + System.Environment.NewLine;
                sql += "order by 최초분배일" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    series.Points.AddXY(Convert.ToString(sd["최초분배일"]), Convert.ToInt32(sd["건수"]));
                }
                sd.Close();
                this.chart3.Series.Add(series);
            }
            catch (Exception ex)
            {
            }
        }
        private void searchData예약일설정일별2()
        {
            try
            {
                this.chart3.Series.Clear();
                Series series = new Series("예약일(일별)");
                series.ChartType = SeriesChartType.Pie;

                string sql = "";
                sql += "select 예약일설정, 건수=count(예약일설정)" + System.Environment.NewLine;
                sql += "from tb_고객등록" + System.Environment.NewLine;
                sql += "where 예약일설정<>''" + System.Environment.NewLine;
                sql += "group by 예약일설정" + System.Environment.NewLine;
                sql += "order by 예약일설정" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    series.Points.AddXY(Convert.ToString(sd["예약일설정"]), Convert.ToInt32(sd["건수"]));
                }
                sd.Close();
                this.chart3.Series.Add(series);
            }
            catch (Exception ex)
            {
            }
        }
        private void searchData예약일설정월별2()
        {
            try
            {
                this.chart3.Series.Clear();
                Series series = new Series("예약일(월별)");
                series.ChartType = SeriesChartType.Pie;

                string sql = "";
                sql += "select 예약일설정=SUBSTRING(예약일설정,1,7), 건수=count(예약일설정)" + System.Environment.NewLine;
                sql += "from tb_고객등록" + System.Environment.NewLine;
                sql += "where 예약일설정<>''" + System.Environment.NewLine;
                sql += "group by SUBSTRING(예약일설정,1,7)" + System.Environment.NewLine;
                sql += "order by SUBSTRING(예약일설정,1,7)" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    series.Points.AddXY(Convert.ToString(sd["예약일설정"]), Convert.ToInt32(sd["건수"]));
                }
                sd.Close();
                this.chart3.Series.Add(series);
            }
            catch (Exception ex)
            {
            }
        }
        private void searchData최초분배일월별2()
        {
            try
            {
                this.chart3.Series.Clear();
                Series series = new Series("최초분배일(월별)");
                series.ChartType = SeriesChartType.Pie;

                string sql = "";
                sql += "select 최초분배일=SUBSTRING(최초분배일,1,7), 건수=count(최초분배일)" + System.Environment.NewLine;
                sql += "from tb_고객등록" + System.Environment.NewLine;
                sql += "where 최초분배일<>''" + System.Environment.NewLine;
                sql += "group by SUBSTRING(최초분배일,1,7)" + System.Environment.NewLine;
                sql += "order by SUBSTRING(최초분배일,1,7)" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    series.Points.AddXY(Convert.ToString(sd["최초분배일"]), Convert.ToInt32(sd["건수"]));
                }
                sd.Close();
                this.chart3.Series.Add(series);
            }
            catch (Exception ex)
            {
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 0)
            {
                if (this.cbo통계항목.SelectedIndex == 0)
                    this.searchData유입경로();
                else if (this.cbo통계항목.SelectedIndex == 1)
                    this.searchData최초분배일일별();
                else if (this.cbo통계항목.SelectedIndex == 2)
                    this.searchData최초분배일월별();
                else if (this.cbo통계항목.SelectedIndex == 3)
                    this.searchData예약일설정일별();
                else if (this.cbo통계항목.SelectedIndex == 4)
                    this.searchData예약일설정월별();
                else if (this.cbo통계항목.SelectedIndex == 5)
                    this.searchData담당자별();
            }
            else if (this.tabControl1.SelectedIndex == 1)
            {
                if (this.cbo통계항목.SelectedIndex == 0)
                    this.searchData유입경로1();
                else if (this.cbo통계항목.SelectedIndex == 1)
                    this.searchData최초분배일일별1();
                else if (this.cbo통계항목.SelectedIndex == 2)
                    this.searchData최초분배일월별1();
                else if (this.cbo통계항목.SelectedIndex == 3)
                    this.searchData예약일설정일별1();
                else if (this.cbo통계항목.SelectedIndex == 4)
                    this.searchData예약일설정월별1();
                else if (this.cbo통계항목.SelectedIndex == 5)
                    this.searchData담당자별1();
            }
            else if (this.tabControl1.SelectedIndex == 2)
            {
                if (this.cbo통계항목.SelectedIndex == 0)
                    this.searchData유입경로2();
                else if (this.cbo통계항목.SelectedIndex == 1)
                    this.searchData최초분배일일별2();
                else if (this.cbo통계항목.SelectedIndex == 2)
                    this.searchData최초분배일월별2();
                else if (this.cbo통계항목.SelectedIndex == 3)
                    this.searchData예약일설정일별2();
                else if (this.cbo통계항목.SelectedIndex == 4)
                    this.searchData예약일설정월별2();
                else if (this.cbo통계항목.SelectedIndex == 5)
                    this.searchData담당자별2();
            }
        }

        private void lblPrint_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 0)
                this.chart1.Printing.PrintPreview();
            else if (this.tabControl1.SelectedIndex == 1)
                this.chart2.Printing.PrintPreview();
            else if (this.tabControl1.SelectedIndex == 2)
                this.chart3.Printing.PrintPreview();
        }

        private void opt단위표시2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 0)
            {
                if (this.cbo통계항목.SelectedIndex == 0)
                    this.searchData유입경로();
                else if (this.cbo통계항목.SelectedIndex == 1)
                    this.searchData최초분배일일별();
                else if (this.cbo통계항목.SelectedIndex == 2)
                    this.searchData최초분배일월별();
                else if (this.cbo통계항목.SelectedIndex == 3)
                    this.searchData예약일설정일별();
                else if (this.cbo통계항목.SelectedIndex == 4)
                    this.searchData예약일설정월별();
                else if (this.cbo통계항목.SelectedIndex == 5)
                    this.searchData담당자별();
            }
        }

        private void opt단위표시3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 0)
            {
                if (this.cbo통계항목.SelectedIndex == 0)
                    this.searchData유입경로();
                else if (this.cbo통계항목.SelectedIndex == 1)
                    this.searchData최초분배일일별();
                else if (this.cbo통계항목.SelectedIndex == 2)
                    this.searchData최초분배일월별();
                else if (this.cbo통계항목.SelectedIndex == 3)
                    this.searchData예약일설정일별();
                else if (this.cbo통계항목.SelectedIndex == 4)
                    this.searchData예약일설정월별();
                else if (this.cbo통계항목.SelectedIndex == 5)
                    this.searchData담당자별();
            }
        }

        private void opt단위표시4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 0)
            {
                if (this.cbo통계항목.SelectedIndex == 0)
                    this.searchData유입경로();
                else if (this.cbo통계항목.SelectedIndex == 1)
                    this.searchData최초분배일일별();
                else if (this.cbo통계항목.SelectedIndex == 2)
                    this.searchData최초분배일월별();
                else if (this.cbo통계항목.SelectedIndex == 3)
                    this.searchData예약일설정일별();
                else if (this.cbo통계항목.SelectedIndex == 4)
                    this.searchData예약일설정월별();
                else if (this.cbo통계항목.SelectedIndex == 5)
                    this.searchData담당자별();
            }
        }

        private void opt단위표시5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 0)
            {
                if (this.cbo통계항목.SelectedIndex == 0)
                    this.searchData유입경로();
                else if (this.cbo통계항목.SelectedIndex == 1)
                    this.searchData최초분배일일별();
                else if (this.cbo통계항목.SelectedIndex == 2)
                    this.searchData최초분배일월별();
                else if (this.cbo통계항목.SelectedIndex == 3)
                    this.searchData예약일설정일별();
                else if (this.cbo통계항목.SelectedIndex == 4)
                    this.searchData예약일설정월별();
                else if (this.cbo통계항목.SelectedIndex == 5)
                    this.searchData담당자별();
            }
        }

        private void opt단위표시6_CheckedChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 0)
            {
                if (this.cbo통계항목.SelectedIndex == 0)
                    this.searchData유입경로();
                else if (this.cbo통계항목.SelectedIndex == 1)
                    this.searchData최초분배일일별();
                else if (this.cbo통계항목.SelectedIndex == 2)
                    this.searchData최초분배일월별();
                else if (this.cbo통계항목.SelectedIndex == 3)
                    this.searchData예약일설정일별();
                else if (this.cbo통계항목.SelectedIndex == 4)
                    this.searchData예약일설정월별();
                else if (this.cbo통계항목.SelectedIndex == 5)
                    this.searchData담당자별();
            }
        }
    }
}
