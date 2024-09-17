using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation
{
    internal class SeoHelper
    {
        public static DateTime NowDate { get; private set; } = DateTime.Now;

        public static bool ChangeNowDSate(DateTime time)
        {
            if (!(time < DateTime.Now.AddDays(2)))
            {
                return false;
                //throw new Exception("");
            }


            NowDate = time;
            return true;
        }

        public static string GetSeoFriendlyUl(string url)
        {
            return url.Replace("ö", "o");
        }

        public static string GetShortDate(DateTime dateTime)
        {
            return dateTime.ToShortDateString();
        }
    }
}