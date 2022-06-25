using System;
using System.Collections.Generic;
using OfficeOpenXml;

namespace DH_CRM
{
    internal class Data_Processing
    {
        public List<Data_Member> get_Member_List(ExcelWorksheet product_sheet)
        {
            List<Data_Member> Member = new List<Data_Member>();
            ExcelCellAddress start = product_sheet.Dimension.Start;
            ExcelCellAddress end = product_sheet.Dimension.End;
            for (int index = start.Row + 1; index <= end.Row; ++index)
            {
                try
                {
                    Member.Add(new Data_Member()
                    {
                        이름 = product_sheet.Cells[index, 1].Text,
                        카톡아이디 = product_sheet.Cells[index, 2].Text,
                        네이버아이디 = product_sheet.Cells[index, 3].Text,
                        핸드폰번호 = product_sheet.Cells[index, 4].Text,
                        유입경로 = product_sheet.Cells[index, 5].Text,

                        대분류 = product_sheet.Cells[index, 6].Text,
                        소분류 = product_sheet.Cells[index, 7].Text,
                        수정일자 = product_sheet.Cells[index, 8].Text,
                        최초분배일 = product_sheet.Cells[index, 9].Text,
                        체험기수 = product_sheet.Cells[index, 10].Text,

                        검색어 = product_sheet.Cells[index, 11].Text,
                        회원메모 = product_sheet.Cells[index, 12].Text,
                        무료리딩시작 = product_sheet.Cells[index, 13].Text,
                        무료리딩종료 = product_sheet.Cells[index, 14].Text,
                        예약일 = product_sheet.Cells[index, 15].Text,

                        담당자 = product_sheet.Cells[index, 16].Text,
                        예수금 = product_sheet.Cells[index, 17].Text,
                        소속팀 = product_sheet.Cells[index, 18].Text,
                        증권사 = product_sheet.Cells[index, 19].Text,
                        날짜 = product_sheet.Cells[index, 20].Text,

                        금액 = product_sheet.Cells[index, 21].Text,
                        가입반 = product_sheet.Cells[index, 22].Text,
                        카드사 = product_sheet.Cells[index, 23].Text,
                        결제방식 = product_sheet.Cells[index, 24].Text,
                        PG = product_sheet.Cells[index, 25].Text,

                        할부 = product_sheet.Cells[index, 26].Text,
                        현금영수증발행유무 = product_sheet.Cells[index, 27].Text,
                        현금영수증번호 = product_sheet.Cells[index, 28].Text,
                        VIP회원메모 = product_sheet.Cells[index, 29].Text,
                    });
                }
                catch (Exception ex)
                {

                }
            }
            return Member;
        }
    }
}

