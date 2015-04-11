using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace LibraryManagement.App
{
    public class Utils
    {
        public static string ConvertDateTimeToText(string input)
        {
            CultureInfo provider = new CultureInfo("en-US");
            return DateTime.Parse(input, provider).ToString("MM/dd/yyyy");
        }
    }
}
