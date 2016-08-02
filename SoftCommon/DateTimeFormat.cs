using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Soft.Common
{
    public class DateTimeFormat
    {
        /// <summary>
        /// 返回星期的整数值周一至周日为1-7
        /// </summary>
        /// <param name="DT"></param>
        /// <returns></returns>
        public static int GetDayofTheWeek(DateTime DT)
        {
            int iDay = Int32.Parse(DT.DayOfWeek.ToString("d"));
            return (iDay == 0 ? 7 : iDay);
        }
        public static int GetDayofTheWeek()
        {
            return GetDayofTheWeek(DateTime.Now);
        }

        public static DateTime StrTimeToDateTimeDef(string _sTime, DateTime _dtDef)
        {
            DateTime dtOut;
            if (DateTime.TryParse(string.Format("2014-04-04 {0}:00", _sTime), out dtOut))
            {
                return dtOut;
            }
            else
            {
                return _dtDef;
            }
        }
    }
}
