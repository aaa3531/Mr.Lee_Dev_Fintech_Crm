using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DH_CRM
{
    internal class iniFile
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string in_Section, string in_Key, string in_Value, string in_FilePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string in_Section, string in_Key, string in_Default, StringBuilder in_retValue, int in_Size, string in_FilePath);

        /// <summary>
        /// 섹션 그룹에 속해있는 키에 값을 입력하여 INI 구성설정 파일에 저장합니다.
        /// </summary>
        /// <param name="in_Section">섹션 (그룹)</param>
        /// <param name="in_Key">키 (변수)</param>
        /// <param name="in_Value">데이터 (값)</param>
        /// <param name="in_FilePath">파일 경로</param>
        public void Write(string in_Section, string in_Key, string in_Value, string in_FilePath)
        {
            byte[] _Byte = Encoding.UTF8.GetBytes(in_Value);
            string _Data = Encoding.UTF8.GetString(_Byte);

            WritePrivateProfileString(in_Section, in_Key, _Data, in_FilePath);
        }

        /// <summary>
        /// INI 구성설정 파일에 있는 키 값을 불러옵니다.
        /// </summary>
        /// <param name="in_Section">섹션 (그룹)</param>
        /// <param name="in_Key">키 (변수)</param>
        /// <param name="in_FilePath">파일 경로</param>
        /// <returns></returns>
        public string Reader(string in_Section, string in_Key, string in_FilePath)
        {
            StringBuilder _ReadData = new StringBuilder(255);
            GetPrivateProfileString(in_Section, in_Key, "", _ReadData, _ReadData.Capacity, in_FilePath);

            byte[] _Byte = Encoding.UTF8.GetBytes(_ReadData.ToString());
            string _Data = Encoding.UTF8.GetString(_Byte);

            return _Data;
        }
    }
}
