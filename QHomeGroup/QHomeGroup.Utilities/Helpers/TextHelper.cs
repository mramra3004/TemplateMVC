using System;
using System.Text;
using System.Text.RegularExpressions;

namespace QHomeGroup.Utilities.Helpers
{
    public static class TextHelper
    {
        public static string ToUnsignString(string input)
        {
            input = input.Trim();
            for (var i = 0x20; i < 0x30; i++) input = input.Replace(((char) i).ToString(), " ");

            input = input.Replace(".", "-");
            input = input.Replace(" ", "-");
            input = input.Replace(",", "-");
            input = input.Replace(";", "-");
            input = input.Replace(":", "-");
            input = input.Replace("  ", "-");
            var regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            var str = input.Normalize(NormalizationForm.FormD);
            var str2 = regex.Replace(str, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
            while (str2.IndexOf("?") >= 0) str2 = str2.Remove(str2.IndexOf("?"), 1);

            while (str2.Contains("--")) str2 = str2.Replace("--", "-").ToLower();

            return str2;
        }

        public static string ToString(decimal number)
        {
            var s = number.ToString("#");
            string[] numberWords = {"không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín"};
            string[] layer = {"", "nghìn", "triệu", "tỷ"};
            int i, j, unit, dozen, hundred;
            var str = " ";
            var booAm = false;
            decimal decS = 0;
            //Tung addnew
            try
            {
                decS = Convert.ToDecimal(s);
            }
            catch
            {
            }

            if (decS < 0)
            {
                decS = -decS;
                s = decS.ToString();
                booAm = true;
            }

            i = s.Length;
            if (i == 0)
            {
                str = numberWords[0] + str;
            }
            else
            {
                j = 0;
                while (i > 0)
                {
                    unit = Convert.ToInt32(s.Substring(i - 1, 1));
                    i--;
                    if (i > 0)
                        dozen = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        dozen = -1;
                    i--;
                    if (i > 0)
                        hundred = Convert.ToInt32(s.Substring(i - 1, 1));
                    else
                        hundred = -1;
                    i--;
                    if (unit > 0 || dozen > 0 || hundred > 0 || j == 3)
                        str = layer[j] + str;
                    j++;
                    if (j > 3) j = 1;
                    if (unit == 1 && dozen > 1)
                    {
                        str = "một " + str;
                    }
                    else
                    {
                        if (unit == 5 && dozen > 0)
                            str = "lăm " + str;
                        else if (unit > 0)
                            str = numberWords[unit] + " " + str;
                    }

                    if (dozen < 0) break;

                    if (dozen == 0 && unit > 0) str = "lẻ " + str;
                    if (dozen == 1) str = "mười " + str;
                    if (dozen > 1) str = numberWords[dozen] + " mươi " + str;

                    if (hundred < 0)
                    {
                        break;
                    }

                    if (hundred > 0 || dozen > 0 || unit > 0) str = numberWords[hundred] + " trăm " + str;

                    str = " " + str;
                }
            }

            if (booAm) str = "Âm " + str;
            return str + "đồng chẵn";
        }
    }
}