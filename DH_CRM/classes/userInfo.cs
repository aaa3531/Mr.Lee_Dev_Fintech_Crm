using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH_CRM
{
    internal class userInfo
    {
        private static userInfo TB_사용자정보 = null;

        public static userInfo Instance()
        {
            if (TB_사용자정보 == null)
                TB_사용자정보 = new userInfo();

            return TB_사용자정보;
        }

        public string 사용자ID = "";
        public int 권한 = 0;
        public int 사용자정보ID = 0;
        public string 이름 = "";

        public int 엑셀업로드 = 0;
        public int 엑셀다운로드 = 0;
        public int 자료삭제 = 0;
        public int 담당자변경 = 0;
        public string 엑셀경로 = "";
        public int 자료검색 = 0;
        public int 검색범위사용자정보ID = 0;

        public int 중복체크 = 0;
        public int 중복체크1 = 0;
        public int 중복체크2 = 0;
        public int 중복체크기준 = 0;
        public int 대분류ID = 0;
        public int 담당자ID = 0;
        public int 소속팀정보ID = 0;
    }
}
