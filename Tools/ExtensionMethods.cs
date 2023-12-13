using System.Globalization;

namespace Tools
{
    public static class ExtensionMethods
    {
        #region ToToman
        /// <summary>
        /// برای جداکننده 3 رقمی روی قیمت ها 
        /// </summary>
        /// <param name="Amount"></param>
        /// <returns></returns>
        public static string ToToman(this int Amount)
        {
            return Amount.ToString("#,0 Toman");
        }

        #endregion

        #region Turn Dates To Persian Date ( ToShamsi )
        public static string ToShamsi(this DateTime Tarikh)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(Tarikh)+"/"+pc.GetMonth(Tarikh).ToString("00")+
                   "/"+pc.GetDayOfMonth(Tarikh).ToString("00");
        }
        #endregion
    }
}
