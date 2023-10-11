using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReengagementAppAlpha2
{
    internal class SpreadSheetActions
    {
        public void GoogleUploadTest()
        {
            int rowId = 2;
            string SHEET_NAME = "Billy Bob";
            string spreadsheetId = SpreadSheetConnector.spreadSheetId;
            string range = $"{SHEET_NAME}!A{rowId}:V{rowId}";
            var values = new Item
            {
                WeekDay = "Monday",
                Date = "Today",
                Period0Grade = "",
                Period1Grade = "",
                Period2Grade = "",
                Period3Grade = "",
                Period4Grade = "",
                Period5Grade = "",
                Period6Grade = "",
                Period7Grade = "",
                Period8Grade = "",
                Period9Grade = "",
                Period0Attendance = "",
                Period1Attendance = "",
                Period2Attendance = "",
                Period3Attendance = "",
                Period4Attendance = "",
                Period5Attendance = "",
                Period6Attendance = "",
                Period7Attendance = "",
                Period8Attendance = "",
                Period9Attendance = ""
            };
            var valueRange = new ValueRange
            {
                Values = ItemsMapper.MapToRangeData(values)
            };

            var appendRequest = SpreadSheetConnector.Service.Spreadsheets.Values.Append(valueRange, spreadsheetId, range);
            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
            var appendResponse = appendRequest.Execute();
        }
    }
}
