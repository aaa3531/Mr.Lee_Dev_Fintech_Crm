using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DH_CRM
{
    internal class getConfig
    {
        public static Dictionary<int, string> dic연락처정보 = new Dictionary<int, string>();
        public static DataTable searchDt = new DataTable();

        public static int 고객등록ID;

        public static DataTable getData사용자본부정보(SQLServer SQLServer, int 소속팀정보ID)
        {
            try
            {
                string sql = "";
                sql += "select 본부설정ID" + System.Environment.NewLine;
                sql += "from   tb_소속팀정보" + System.Environment.NewLine;
                sql += "where  소속팀정보ID=" + 소속팀정보ID + "" + System.Environment.NewLine;

                SqlDataReader sd = SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                return dt;
            }
            catch (Exception ex)
            {
            }
            return null;
        }

        public static DataTable getData소속팀정보(SQLServer SQLServer, int 본부설정ID)
        {
            try
            {
                string sql = "";
                sql += "select 소속팀정보ID, 소속팀명" + System.Environment.NewLine;
                sql += "from   tb_소속팀정보" + System.Environment.NewLine;
                sql += "where  본부설정ID=" + 본부설정ID + "" + System.Environment.NewLine;
                sql += "order by 소속팀명" + System.Environment.NewLine;

                SqlDataReader sd = SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                return dt;
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public static DataTable getData본부설정(SQLServer SQLServer)
        {
            try
            {
                string sql = "";
                sql += "select 본부설정ID, 본부" + System.Environment.NewLine;
                sql += "from   tb_본부설정" + System.Environment.NewLine;
                sql += "where  본부<>''" + System.Environment.NewLine;
                sql += "order by 본부" + System.Environment.NewLine;

                SqlDataReader sd = SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                return dt;
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public static DataTable getData사용자정보(SQLServer SQLServer)
        {
            try
            {
                string sql = "";
                sql += "select 사용자정보ID, 이름" + System.Environment.NewLine;
                sql += "from   tb_사용자정보" + System.Environment.NewLine;
                sql += "order by 이름" + System.Environment.NewLine;

                SqlDataReader sd = SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                return dt;
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public static DataTable getData소속사용자정보(SQLServer SQLServer, int 소속팀정보ID)
        {
            try
            {
                string sql = "";
                sql += "select 사용자정보ID, 이름" + System.Environment.NewLine;
                sql += "from   tb_사용자정보" + System.Environment.NewLine;
                sql += "where  소속팀정보ID=" + 소속팀정보ID + "" + System.Environment.NewLine;
                sql += "order by 이름" + System.Environment.NewLine;

                SqlDataReader sd = SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                return dt;
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public static DataTable getData상태설정(SQLServer SQLServer)
        {
            try
            {
                string sql = "";
                sql += "select 상태설정ID, 내용" + System.Environment.NewLine;
                sql += "from   tb_상태설정" + System.Environment.NewLine;
                sql += "order by isnull(순서,0)" + System.Environment.NewLine;

                SqlDataReader sd = SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                return dt;
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public static DataTable getData가입반정보(SQLServer SQLServer)
        {
            try
            {
                string sql = "";
                sql += "select 가입반설정ID, 가입반" + System.Environment.NewLine;
                sql += "from   tb_가입반설정" + System.Environment.NewLine;
                sql += "order by isnull(순서,0)" + System.Environment.NewLine;

                SqlDataReader sd = SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                return dt;
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public static DataTable getData본부정보(SQLServer SQLServer)
        {
            try
            {
                string sql = "";
                sql += "select 본부설정ID, 본부" + System.Environment.NewLine;
                sql += "from   TB_본부설정" + System.Environment.NewLine;
                sql += "order by isnull(순서,0)" + System.Environment.NewLine;

                SqlDataReader sd = SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                return dt;
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public static DataTable getDt유입경로대분류(SQLServer SQLServer)
        {
            try
            {
                string sql = "";
                sql += "select 대분류ID, 대분류" + System.Environment.NewLine;
                sql += "from   TB_대분류" + System.Environment.NewLine;
                sql += "order by isnull(순서,0)" + System.Environment.NewLine;

                SqlDataReader sd = SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                
                return dt;
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public static DataTable getDt유입경로소분류(SQLServer SQLServer)
        {
            try
            {
                string sql = "";
                sql += "select 소분류ID, 소분류" + System.Environment.NewLine;
                sql += "from   tb_소분류" + System.Environment.NewLine;
                sql += "order by isnull(순서,0)" + System.Environment.NewLine;

                SqlDataReader sd = SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                return dt;
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public static DataTable getDtPG사항목(SQLServer SQLServer)
        {
            try
            {
                string sql = "";
                sql += "select PG사항목설정ID, PG사항목" + System.Environment.NewLine;
                sql += "from   TB_PG사항목설정" + System.Environment.NewLine;
                sql += "order by isnull(순서,0)" + System.Environment.NewLine;

                SqlDataReader sd = SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                return dt;
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public static DataTable getDt유입경로(SQLServer SQLServer)
        {
            try
            {
                string sql = "";
                sql += "select 유입경로설정ID, 유입경로" + System.Environment.NewLine;
                sql += "from   TB_유입경로설정" + System.Environment.NewLine;
                sql += "order by isnull(순서,0)" + System.Environment.NewLine;

                SqlDataReader sd = SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                return dt;
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public static DataTable getDt카드사항목(SQLServer SQLServer)
        {
            try
            {
                string sql = "";
                sql += "select 카드사항목설정ID, 내용" + System.Environment.NewLine;
                sql += "from   TB_카드사항목설정" + System.Environment.NewLine;
                sql += "order by isnull(순서,0)" + System.Environment.NewLine;

                SqlDataReader sd = SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                return dt;
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public static DataTable getDt소속팀정보(SQLServer SQLServer, int 본부설정ID)
        {
            try
            {
                string sql = "";
                sql += "select 소속팀정보ID, 소속팀명" + System.Environment.NewLine;
                sql += "from   TB_소속팀정보" + System.Environment.NewLine;
                sql += "where  1=1" + System.Environment.NewLine;
                if (본부설정ID > 0)
                    sql += "and  본부설정ID=" + 본부설정ID + "" + System.Environment.NewLine;
                sql += "order by 소속팀명" + System.Environment.NewLine;

                SqlDataReader sd = SQLServer.GetDataReader(sql);
                DataTable dt = new DataTable();
                dt.Load(sd);
                sd.Close();
                return dt;
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public static string getData환경설정(SQLServer SQLServer, int 사용자정보ID, string 설정구분)
        {
            try
            {
                string result = "";
                string sql = "";
                sql += "select 환경설정" + System.Environment.NewLine;
                sql += "from   tb_환경설정" + System.Environment.NewLine;
                sql += "where  사용자정보ID=" + 사용자정보ID + "" + System.Environment.NewLine;
                sql += "and    설정구분='" + 설정구분 + "'" + System.Environment.NewLine;

                SqlDataReader sd = SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    result = Convert.ToString(sd["환경설정"]);
                }
                sd.Close();
                return result;
            }
            catch (Exception ex)
            {
            }
            return "";
        }
        private static int getData환경설정ID(SQLServer SQLServer, int 사용자정보ID, string 설정구분, string str환경설정)
        {
            try
            {
                int int환경설정ID = 0;
                string sql = "";
                sql += "select 환경설정ID" + System.Environment.NewLine;
                sql += "from   tb_환경설정" + System.Environment.NewLine;
                sql += "where  사용자정보ID=" + 사용자정보ID + "" + System.Environment.NewLine;
                sql += "and    설정구분='" + 설정구분 + "'" + System.Environment.NewLine;

                SqlDataReader sd = SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    int환경설정ID = Convert.ToInt32(sd["환경설정ID"]);
                }
                sd.Close();
                return int환경설정ID;
            }
            catch (Exception ex)
            {
            }
            return 0;
        }
        public static int getData고객담당자(SQLServer SQLServer, int 고객등록ID)
        {
            //2021-10-22 이찬명
            try
            {
                int result = 0;
                string sql = "";
                sql += "select 담당자" + System.Environment.NewLine;
                sql += "from   tb_고객등록" + System.Environment.NewLine;
                sql += "where  고객등록ID=" + 고객등록ID + "" +System.Environment.NewLine;
                
                SqlDataReader sd = SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    result = Convert.ToInt32(sd["담당자"]);
                }
                sd.Close();
                return result;
            }
            catch (Exception ex)
            {
            }
            return 0;
        }
        public static string getData사용자공유범위(SQLServer SQLServer, int 사용자정보ID, string 범위구분)
        {
            try
            {
                string result = "";
                string sql = "";
                sql += "select 범위설정" + System.Environment.NewLine;
                sql += "from   tb_사용자공유범위" + System.Environment.NewLine;
                sql += "where  사용자정보ID=" + 사용자정보ID + "" + System.Environment.NewLine;
                sql += "and    범위구분='" + 범위구분 + "'" + System.Environment.NewLine;

                SqlDataReader sd = SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    result = Convert.ToString(sd["범위설정"]);
                }
                sd.Close();
                return result;
            }
            catch (Exception ex)
            {
            }
            return "";
        }
        private static int getData사용자공유범위ID(SQLServer SQLServer, int 사용자정보ID, string 범위구분, string 범위설정)
        {
            try
            {
                int int사용자공유범위ID = 0;
                string sql = "";
                sql += "select 사용자공유범위ID" + System.Environment.NewLine;
                sql += "from   tb_사용자공유범위" + System.Environment.NewLine;
                sql += "where  사용자정보ID=" + 사용자정보ID + "" + System.Environment.NewLine;
                sql += "and    범위구분='" + 범위구분 + "'" + System.Environment.NewLine;

                SqlDataReader sd = SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    int사용자공유범위ID = Convert.ToInt32(sd["사용자공유범위ID"]);
                }
                sd.Close();
                return int사용자공유범위ID;
            }
            catch (Exception ex)
            {
            }
            return 0;
        }
        public static void saveData환경설정(SQLServer SQLServer, userInfo userInfo, string 설정구분, string 환경설정)
        {
            try
            {
                int int환경설정ID = getData환경설정ID(SQLServer, userInfo.사용자정보ID, 설정구분, 환경설정);
                string sql = "";
                if (int환경설정ID == 0)
                {
                    sql += "insert into tb_환경설정(" + System.Environment.NewLine;
                    sql += "       [사용자정보ID], [설정구분], [환경설정], [등록자], [등록일자], " + System.Environment.NewLine;
                    sql += "       [수정자], [수정일자]) " + System.Environment.NewLine;
                    sql += "values ( " + System.Environment.NewLine;
                    sql += "       @사용자정보ID, @설정구분, @환경설정, @등록자, @등록일자, " + System.Environment.NewLine;
                    sql += "       @수정자, @수정일자) " + System.Environment.NewLine;
                    sql += "select convert(int,scope_identity())" + System.Environment.NewLine;
                }
                else
                {
                    sql += "update tb_환경설정 set" + System.Environment.NewLine;
                    sql += "       [사용자정보ID]=@사용자정보ID, [설정구분]=@설정구분, [환경설정]=@환경설정, [수정자]=@수정자, [수정일자]=@수정일자" + System.Environment.NewLine;
                    sql += "where  환경설정ID=@환경설정ID " + System.Environment.NewLine;
                }
                SQLServer.paraClear();
                SQLServer.addPara("사용자정보ID", userInfo.사용자정보ID, SqlDbType.Int);
                SQLServer.addPara("설정구분", 설정구분, SqlDbType.NVarChar);
                SQLServer.addPara("환경설정", 환경설정, SqlDbType.NVarChar);
                if (int환경설정ID == 0)
                {
                    SQLServer.addPara("등록자", userInfo.사용자ID, SqlDbType.NVarChar);
                    SQLServer.addPara("등록일자", DateTime.Now, SqlDbType.DateTime);
                    SQLServer.addPara("수정자", userInfo.사용자ID, SqlDbType.NVarChar);
                    SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);
                }
                else
                {
                    SQLServer.addPara("수정자", userInfo.사용자ID, SqlDbType.NVarChar);
                    SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);
                }
                SQLServer.Command_SQL(sql, "환경설정ID", int환경설정ID);
            }
            catch (Exception ex)
            {
            }
        }
        public static void saveData사용자공유범위(SQLServer SQLServer, userInfo userInfo, string 범위구분, string 범위설정)
        {
            try
            {
                int int사용자공유범위ID = getData사용자공유범위ID(SQLServer, userInfo.사용자정보ID, 범위구분, 범위설정);
                string sql = "";
                if (int사용자공유범위ID == 0)
                {
                    sql += "insert into tb_사용자공유범위(" + System.Environment.NewLine;
                    sql += "       [사용자정보ID], [범위구분], [범위설정], [등록자], [등록일자], " + System.Environment.NewLine;
                    sql += "       [수정자], [수정일자]) " + System.Environment.NewLine;
                    sql += "values ( " + System.Environment.NewLine;
                    sql += "       @사용자정보ID, @범위구분, @범위설정, @등록자, @등록일자, " + System.Environment.NewLine;
                    sql += "       @수정자, @수정일자) " + System.Environment.NewLine;
                    sql += "select convert(int,scope_identity())" + System.Environment.NewLine;
                }
                else
                {
                    sql += "update tb_사용자공유범위 set" + System.Environment.NewLine;
                    sql += "       [사용자정보ID]=@사용자정보ID, [범위구분]=@범위구분, [범위설정]=@범위설정, [수정자]=@수정자, [수정일자]=@수정일자" + System.Environment.NewLine;
                    sql += "where  사용자공유범위ID=@사용자공유범위ID " + System.Environment.NewLine;
                }
                SQLServer.paraClear();
                SQLServer.addPara("사용자정보ID", userInfo.사용자정보ID, SqlDbType.Int);
                SQLServer.addPara("범위구분", 범위구분, SqlDbType.NVarChar);
                SQLServer.addPara("범위설정", 범위설정, SqlDbType.NVarChar);
                if (int사용자공유범위ID == 0)
                {
                    SQLServer.addPara("등록자", userInfo.사용자ID, SqlDbType.NVarChar);
                    SQLServer.addPara("등록일자", DateTime.Now, SqlDbType.DateTime);
                    SQLServer.addPara("수정자", userInfo.사용자ID, SqlDbType.NVarChar);
                    SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);
                }
                else
                {
                    SQLServer.addPara("수정자", userInfo.사용자ID, SqlDbType.NVarChar);
                    SQLServer.addPara("수정일자", DateTime.Now, SqlDbType.DateTime);
                }
                SQLServer.Command_SQL(sql, "사용자공유범위ID", int사용자공유범위ID);
            }
            catch (Exception ex)
            {
            }
        }
        public static void getData사용자환경설정(SQLServer SQLServer, userInfo userInfo)
        {
            try
            {
                string sql = "";
                sql += "select 사용자정보ID, 엑셀업로드, 엑셀다운로드, 자료삭제, 담당자변경" + System.Environment.NewLine;
                sql += "from   tb_사용자정보" + System.Environment.NewLine;
                sql += "where  사용자정보ID=" + userInfo.사용자정보ID + "" + System.Environment.NewLine;
                sql += "order by 이름" + System.Environment.NewLine;

                SqlDataReader sd = SQLServer.GetDataReader(sql);
                while (sd.Read())
                {
                    userInfo.엑셀업로드 = Convert.ToInt32(sd["엑셀업로드"]);
                    userInfo.엑셀다운로드 = Convert.ToInt32(sd["엑셀다운로드"]);
                    userInfo.자료삭제 = Convert.ToInt32(sd["자료삭제"]);
                    userInfo.담당자변경 = Convert.ToInt32(sd["담당자변경"]);
                }
                sd.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
