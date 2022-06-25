using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading;

namespace DH_CRM
{
    internal class SQLServer
    {
        private static SQLServer m_CSQLServer = null;
        public SqlConnection _DBCon = new SqlConnection();
        public SqlCommand _sqlCommand = new SqlCommand();

        private iniFile _ini = null;
        private userInfo _TB사용자정보 = null;

        public static SQLServer Instance()
        {
            if (m_CSQLServer == null)
                m_CSQLServer = new SQLServer();

            return m_CSQLServer;
        }

        public SQLServer()
        {
            _ini = new iniFile();
        }


        /// <summary>
        /// SQL DB를 연결합니다.
        /// </summary>
        public void Connection_DB()
        {
            string _iFilePath = System.Windows.Forms.Application.StartupPath + @"\Version.ini";

            //본 서버
            //string _SQLServer = "sqlsw16ssd-010.cafe24.com";
            //string _SQLServerDB = "moneycrm";
            //string _SQLServerID = "moneycrm";
            //string _SQLServerPW = "Dnfl1q2w!@";

            //테스트 서버
            string _SQLServer = "sqlsw16ssd-011.cafe24.com";
            string _SQLServerDB = "moneycrmtest";
            string _SQLServerID = "moneycrmtest";
            string _SQLServerPW = "Dnfl1q2w!@";

            if (_DBCon.State == ConnectionState.Closed)
            {
                string strCon = "Password='" + _SQLServerPW + "';Persist Security Info=True;User ID='" + _SQLServerID + "';Initial Catalog='" + _SQLServerDB + "';Data Source='" + _SQLServer + "'";

                _DBCon.ConnectionString = strCon;
                _DBCon.Open();

            }
        }

        /// <summary>
        /// 연결된 SQL DB를 종료합니다.
        /// </summary>
        public void Disconnection_DB()
        {
            _DBCon.Close();
        }

        /// <summary>
        /// 입력한 SQL 명령어를 실행합니다.
        /// </summary>
        /// <param name="in_Sql">명령어</param>
        public int Command_SQL(string in_Sql, string in_KeyName = "", int in_keyValue = 0)
        {
            int cmdResult = 0;
            bool _keyValue = false;
            SqlParameter pOutput = new SqlParameter(in_KeyName, SqlDbType.Int);

            try
            {
                if (in_KeyName != "")
                {
                    pOutput.Direction = ParameterDirection.InputOutput;
                    pOutput.Value = in_keyValue;
                    _sqlCommand.Parameters.Add(pOutput);
                    _keyValue = true;
                }
                ReaderWriterLockSlim _Test = new ReaderWriterLockSlim();
                _Test.EnterWriteLock();
                Connection_DB();

                _sqlCommand.CommandText = in_Sql;
                _sqlCommand.Connection = _DBCon;

                if (_keyValue == true && in_keyValue == 0)
                {
                    cmdResult = (int)_sqlCommand.ExecuteScalar();
                }
                else if (_keyValue == true && in_keyValue != 0)
                {
                    cmdResult = _sqlCommand.ExecuteNonQuery();
                    cmdResult = Int32.Parse(pOutput.Value.ToString());
                }
                else
                {
                    cmdResult = _sqlCommand.ExecuteNonQuery();
                }
                Disconnection_DB();
                _Test.ExitWriteLock();
                return cmdResult;
            }
            catch(Exception ex)
            {
                return cmdResult;
            }
            //catch (SqlException ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.ToString());
            //    return cmdResult;
            //}
        }

        /// <summary>
        /// 프로그램 실행시 최초 실행으로 DB 경로를 저장하고, DB 파일이 존재하지 않을 경우 생성합니다.
        /// </summary>
        //public void Create_DB()
        //{
        //    if (!File.Exists(String.Format(@"{0}", _SQLServer)))
        //        SQLiteConnection.CreateFile(_SQLServerDB);
        //}

        /// <summary>
        /// 연결된 DB에 존재하는 Table을 찾아 입력한 데이터를 추가합니다.
        /// </summary>
        /// <param name="in_TableName">테이블명</param>
        /// <param name="in_Values">입력 데이터, string 값에 속해있는 int 값은 자동으로 변환되어 저장됩니다.</param>
        //public void Insert_Table(string in_TableName, string@] in_Values)
        //{
        //    string _Sql = String.Format("INSERT INTO {0} values(null", in_TableName);
        //    ReaderWriterLockSlim _Test = new ReaderWriterLockSlim();
        //    _Test.EnterWriteLock();
        //    Connection_DB();

        //    foreach (string _sValue in in_Values)
        //    {
        //        int _iValue = 0;
        //        bool _isNumber = int.TryParse(_sValue, out _iValue);

        //        if (!_isNumber)
        //            _Sql += String.Format(", '{0}'", _sValue);
        //        else
        //            _Sql += String.Format(", {0}", _iValue);
        //    }

        //    _Sql += ");";
        //    Command_SQL(_Sql);

        //    Disconnection_DB();
        //    _Test.ExitWriteLock();
        //}

        public void paraClear()
        {
            _sqlCommand.Parameters.Clear();
        }

        //public void addPara(string in_ColName, string in_Value, SqlDbType in_ColType, ParameterDirection in_para = ParameterDirection.Input)
        public void addPara(string in_ColName, object in_Value, SqlDbType in_ColType)
        {
            _sqlCommand.Parameters.Add("@" + in_ColName, in_ColType);
            _sqlCommand.Parameters["@" + in_ColName].Value = in_Value == null ? "" : in_Value;
        }
        public void addParaImage(string in_ColName, byte[] in_Byte)
        {
            _sqlCommand.Parameters.Add("@" + in_ColName, SqlDbType.Image, in_Byte.Length);
            _sqlCommand.Parameters["@" + in_ColName].Value = in_Byte;
        }

        public bool Check_Userinfo(string in_TableName, string in_UserID, string in_Password)
        {
            string _Sql = String.Format("SELECT * FROM {0};", in_TableName);

            Connection_DB();

            SqlCommand _SQLCommand = new SqlCommand(_Sql, _DBCon);
            SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();

            while (_SQLDataReader.Read())
            {
                string _UserID = _SQLDataReader["사용자ID"].ToString();
                string _Password = _SQLDataReader["비밀번호"].ToString();
                int 권한 = Convert.ToInt32(_SQLDataReader["권한"]);
                int 사용자정보ID = Convert.ToInt32(_SQLDataReader["사용자정보ID"]);
                string name = _SQLDataReader["이름"].ToString();

                int int엑셀업로드 = Convert.ToInt32(_SQLDataReader["엑셀업로드"] == DBNull.Value ? 0 : _SQLDataReader["엑셀업로드"]);
                int int엑셀다운로드 = Convert.ToInt32(_SQLDataReader["엑셀다운로드"] == DBNull.Value ? 0 : _SQLDataReader["엑셀다운로드"]);
                int int자료삭제 = Convert.ToInt32(_SQLDataReader["자료삭제"] == DBNull.Value ? 0 : _SQLDataReader["자료삭제"]);
                int int담당자변경 = Convert.ToInt32(_SQLDataReader["담당자변경"] == DBNull.Value ? 0 : _SQLDataReader["담당자변경"]);
                
                string str엑셀경로 = Convert.ToString(_SQLDataReader["엑셀경로"] == DBNull.Value ? "" : _SQLDataReader["엑셀경로"]);

                int int자료검색 = Convert.ToInt32(_SQLDataReader["자료검색"] == DBNull.Value ? 0 : _SQLDataReader["자료검색"]);
                int int소속팀정보ID = Convert.ToInt32(_SQLDataReader["소속팀정보ID"] == DBNull.Value ? 0 : _SQLDataReader["소속팀정보ID"]);
                int int검색범위사용자정보ID = Convert.ToInt32(_SQLDataReader["검색범위사용자정보ID"] == DBNull.Value ? 0 : _SQLDataReader["검색범위사용자정보ID"]);

                if (in_UserID.Equals(_UserID) && in_Password.Equals(_Password))
                {
                    _TB사용자정보 = userInfo.Instance();
                    _TB사용자정보.사용자ID = _UserID;
                    _TB사용자정보.권한 = 권한;
                    _TB사용자정보.사용자정보ID = 사용자정보ID;
                    _TB사용자정보.이름 = name;

                    _TB사용자정보.엑셀업로드 = int엑셀업로드;
                    _TB사용자정보.엑셀다운로드 = int엑셀다운로드;
                    _TB사용자정보.담당자변경 = int담당자변경;
                    _TB사용자정보.자료삭제 = int자료삭제;
                    _TB사용자정보.엑셀경로 = str엑셀경로;
                    _TB사용자정보.자료검색 = int자료검색;
                    _TB사용자정보.소속팀정보ID = int소속팀정보ID;
                    _TB사용자정보.검색범위사용자정보ID = int검색범위사용자정보ID;

                    Disconnection_DB();
                    return true;
                }
            }

            Disconnection_DB();

            return false;
        }

        /// <summary>
        /// 연결된 DB에 존재하는 Table을 찾아 입력된 데이터를 불러옵니다.
        /// </summary>
        /// <param name="in_TableName">테이블명</param>
        /// <returns></returns>
        public SqlDataReader Select_Teble(string in_TableName, string in_WhereText)
        {
            string _Sql = String.Format("SELECT * FROM {0} {1};", in_TableName, in_WhereText);

            Connection_DB();

            SqlCommand _SQLCommand = new SqlCommand(_Sql, _DBCon);
            SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();

            return _SQLDataReader;
        }
        public SqlDataReader GetDataReader(string in_Sql)
        {
            Connection_DB();

            SqlCommand _SQLCommand = new SqlCommand(in_Sql, _DBCon);
            SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();

            return _SQLDataReader;
        }
        public SqlCommand select_cmd_table(string in_TableName, string in_WhereText, string in_FieldName)
        {
            string _Sql = String.Format("SELECT {0} FROM {1} {2};", in_FieldName, in_TableName, in_WhereText);

            Connection_DB();

            SqlCommand _SQLCommand = new SqlCommand(_Sql, _DBCon);
            return _SQLCommand;
        }
        public string GetTablefieldData(string in_TableName, string in_fieldText, string in_WhereText, string in_fieldName)
        {
            string _fieldData = "";
            string _Sql = String.Format("SELECT {2} FROM {0} {1};", in_TableName, in_WhereText, in_fieldText);

            Connection_DB();

            SqlCommand _SQLCommand = new SqlCommand(_Sql, _DBCon);
            SqlDataReader _SQLDataReader = _SQLCommand.ExecuteReader();

            while (_SQLDataReader.Read())
            {
                _fieldData = _SQLDataReader[in_fieldName].ToString();
            }
            _SQLDataReader.Close();
            return _fieldData;
        }
    }
}
