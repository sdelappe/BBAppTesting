using System.Collections.Generic;

namespace ReengagementAppAlpha2
{
    internal class ItemsMapper
    {
        // Turns every line in the Google Sheet into an object
        public static List<Item> MapFromRangeData(IList<IList<object>> values)
        {
            var items = new List<Item>();

            foreach (var value in values)
            {
                Item item = new Item()
                {
                    WeekDay = value[0].ToString(),
                    Date = value[1].ToString(),
                    Period0Grade = value[2].ToString(),
                    Period1Grade = value[3].ToString(),
                    Period2Grade = value[4].ToString(),
                    Period3Grade = value[5].ToString(),
                    Period4Grade = value[6].ToString(),
                    Period5Grade = value[7].ToString(),
                    Period6Grade = value[8].ToString(),
                    Period7Grade = value[9].ToString(),
                    Period8Grade = value[10].ToString(),
                    Period9Grade = value[11].ToString(),
                    Period0Attendance = value[12].ToString(),
                    Period1Attendance = value[13].ToString(),
                    Period2Attendance = value[14].ToString(),
                    Period3Attendance = value[15].ToString(),
                    Period4Attendance = value[16].ToString(),
                    Period5Attendance = value[17].ToString(),
                    Period6Attendance = value[18].ToString(),
                    Period7Attendance = value[19].ToString(),
                    Period8Attendance = value[20].ToString(),
                    Period9Attendance = value[21].ToString()
                };

                items.Add(item);
            }

            return items;
        }

        // Creates a new row of data for Google Sheet out of an object
        public static IList<IList<object>> MapToRangeData(Item item)
        {
            var objectList = new List<object>() { item.WeekDay,
                item.Date,
                item.Period0Grade,
                item.Period1Grade,
                item.Period2Grade,
                item.Period3Grade,
                item.Period4Grade,
                item.Period5Grade,
                item.Period6Grade,
                item.Period7Grade,
                item.Period8Grade,
                item.Period9Grade,
                item.Period0Attendance,
                item.Period1Attendance,
                item.Period2Attendance,
                item.Period3Attendance,
                item.Period4Attendance,
                item.Period5Attendance,
                item.Period6Attendance,
                item.Period7Attendance,
                item.Period8Attendance,
                item.Period9Attendance
            };

            var rangeData = new List<IList<object>> { objectList };
            return rangeData;
        }
    }
}
