using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Data.SqlClient;

namespace DH_CRM
{
    public partial class frm문자정보 : Form
    {
        private SQLServer _SQLServer;
        private int _int문자정보ID;
        public frm문자정보(int 문자정보ID)
        {
            this._int문자정보ID = 문자정보ID;
            InitializeComponent();
        }

        private void frm문자정보_Load(object sender, EventArgs e)
        {
            this._SQLServer = SQLServer.Instance();

            this.lblTopBar.Parent = this.picMain;
            this.lblClose.Parent = this.picMain;

            this.viewSMSData();
        }
        private void viewSMSData()
        {
            try
            {
                string sql = "";
                sql += "select a.*, b.이름, b.휴대전화 " + System.Environment.NewLine;
                sql += "from   tb_문자발송 a left join tb_고객등록 b" + System.Environment.NewLine;
                sql += "on     a.고객등록id=b.고객등록id" + System.Environment.NewLine;
                sql += "where  a.문자발송ID=" + this._int문자정보ID + "" + System.Environment.NewLine;

                SqlDataReader sd = this._SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    this.txt전송시간.Text = Convert.ToDateTime(sd["전송일자"]).ToString("yyyy-MM-dd HH:mm:ss");
                    this.txt전송결과.Text = Convert.ToString(sd["전송결과"]);
                    this.txt회원명.Text = Convert.ToString(sd["이름"]);
                    this.txt휴대전화.Text = Convert.ToString(sd["휴대전화"]);
                    this.txt문자내용.Text = Convert.ToString(sd["문자내용"]);
                }
                sd.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
