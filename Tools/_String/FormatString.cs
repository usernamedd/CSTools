using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _String
{
    class FormatString
    {
        public static string Format()
        {
            double tem = 789.54321;
            //以#作为点位符和以0作为占位符的区别：当#表示的位数超过实际位数时#号不显示，然而0会补位。
            //string.Format("{0:#####.####}", tem)  ;输出789.5432
            //string.Format("{0:00000.0000}", tem)  ;输出00789.5432
            return string.Format("{0:#####.####}", tem);
        }
    }
}
