using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TeduCoreApp.Utilities.Helpers
{
    public static class TextHelper
    {
        public static string ToUnsignString(string input)
        {
            input = input.Trim();
            for (int i = 0x20; i < 0x30; i++)
            {
                input = input.Replace(((char)i).ToString(), " ");
            }
            input = input.Replace(".", "-");
            input = input.Replace(" ", "-");
            input = input.Replace(",", "-");
            input = input.Replace(";", "-");
            input = input.Replace(":", "-");
            input = input.Replace("  ", "-");
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string str = input.Normalize(NormalizationForm.FormD);
            string str2 = regex.Replace(str, string.Empty).Replace('đ', 'd').Replace('Đ', 'D');
            while (str2.IndexOf("?") >= 0)
            {
                str2 = str2.Remove(str2.IndexOf("?"), 1);
            }
            while (str2.Contains("--"))
            {
                str2 = str2.Replace("--", "-").ToLower();
            }
            return str2;
        }
        public static string ToString(decimal number)
        {
            string s = number.ToString("#");
            string[] numberWords = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] layer = new string[] { "", "nghìn", "triệu", "tỷ" };
            int i, j, unit, dozen, hundred;
            string str = " ";
            bool booAm = false;
            decimal decS = 0;
            //Tung addnew
            try
            {
                decS = Convert.ToDecimal(s.ToString());
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
                str = numberWords[0] + str;
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
                    if ((unit > 0) || (dozen > 0) || (hundred > 0) || (j == 3))
                        str = layer[j] + str;
                    j++;
                    if (j > 3) j = 1;
                    if ((unit == 1) && (dozen > 1))
                        str = "một " + str;
                    else
                    {
                        if ((unit == 5) && (dozen > 0))
                            str = "lăm " + str;
                        else if (unit > 0)
                            str = numberWords[unit] + " " + str;
                    }
                    if (dozen < 0)
                        break;
                    else
                    {
                        if ((dozen == 0) && (unit > 0)) str = "lẻ " + str;
                        if (dozen == 1) str = "mười " + str;
                        if (dozen > 1) str = numberWords[dozen] + " mươi " + str;
                    }
                    if (hundred < 0) break;
                    else
                    {
                        if ((hundred > 0) || (dozen > 0) || (unit > 0)) str = numberWords[hundred] + " trăm " + str;
                    }
                    str = " " + str;
                }
            }
            if (booAm) str = "Âm " + str;
            return str + "đồng chẵn";
        }

        public static string GetBackDate(DateTime date)
        {
            var result = string.Empty;

            var day = (DateTime.Now - date).Days;
            var hour = (DateTime.Now - date).Hours;
            var minute = (DateTime.Now - date).Minutes;
            var second = (DateTime.Now - date).Seconds;

            result = second + " giây trước";

            if (minute > 0)
            {
                result = minute + " phút trước";
            }

            if (hour > 0)
            {
                result = hour + " giờ trước";
            }

            if (day > 0)
            {
                result = day + " ngày trước";
            }

            if (day > 30)
            {
                result = "vào ngày " + date.ToString("dd/MM/yyyy");
            }

            return result;
        }

        /// <summary>
        /// Hàm format giá dạng 1.000.000
        /// Author      Date        Action
        /// CuongVD9    2019/29/09   Created
        /// </summary>
        /// <param name="price">Giá truyền vào kiểu decimal</param>
        /// <returns>Chuỗi giá sau khi được format</returns>
        public static string FormatPrice(decimal? price)
        {
            if (price.HasValue && price != 0)
            {
                string result = price.Value.ToString("#,#");
                if (result.Contains(","))
                    result = result.Replace(',', '.');
                return result;
            }
            return "0";
        }

        /// <summary>
        /// Hàm format giá dạng 1.000.000
        /// Author      Date        Action
        /// CuongVD9    2019/29/09   Created
        /// </summary>
        /// <param name="price">Giá truyền vào kiểu double</param>
        /// <returns>Chuỗi giá sau khi được format</returns>
        public static string FormatPrice(double? price)
        {
            if (price.HasValue && price != 0)
            {
                string result = price.Value.ToString("#,#");
                if (result.Contains(","))
                    result = result.Replace(',', '.');
                return result;
            }
            return "0";
        }
    }
}
