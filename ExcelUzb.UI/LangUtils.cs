using System.Collections.Generic;
using System.Text;

namespace ExcelUzb.UI
{
    internal static class LangUtils
    {
        private static readonly IDictionary<string, string> CyrlToLatn;

        static LangUtils()
        {
            CyrlToLatn = new Dictionary<string, string>
            {
                {"а", "a"},
                {"б", "b"},
                {"ч", "ch"},
                {"д", "d"},
                {"е", "e"},
                {"э", "e"},
                {"ф", "f"},
                {"г", "g"},
                {"ғ", "g‘"},
                {"ҳ", "h"},
                {"и", "i"},
                {"ж", "j"},
                {"к", "k"},
                {"қ", "q"},
                {"л", "l"},
                {"м", "m"},
                {"н", "n"},
                {"о", "o"},
                {"ў", "o‘"},
                {"п", "p"},
                {"р", "r"},
                {"с", "s"},
                {"ш", "sh"},
                {"т", "t"},
                {"у", "u"},
                {"в", "v"},
                {"х", "x"},
                {"й", "y"},
                {"з", "z"},
                {"ъ", ""},
                {"ю", "yu"},
                {"я", "ya"},

                {"А", "A"},
                {"Б", "B"},
                {"Ч", "Ch"},
                {"Д", "D"},
                {"Е", "E"},
                {"Э", "E"},
                {"Ф", "F"},
                {"Г", "G"},
                {"Ғ", "G‘"},
                {"Ҳ", "H"},
                {"И", "I"},
                {"Ж", "J"},
                {"К", "K"},
                {"Қ", "Q"},
                {"Л", "L"},
                {"М", "M"},
                {"Н", "N"},
                {"О", "O"},
                {"Ў", "O‘"},
                {"П", "P"},
                {"Р", "R"},
                {"С", "S"},
                {"Ш", "Sh"},
                {"Т", "T"},
                {"У", "U"},
                {"В", "V"},
                {"Х", "X"},
                {"Й", "Y"},
                {"З", "Z"},
                {"Ъ", ""},
                {"Ю", "Yu"},
                {"Я", "Ya"}
            };
        }

        public static string ToLatn(string s)
        {

            for (var i = 0; i < s.Length; i++)
            {
                var key = $"{s[i]}";

                if (CyrlToLatn.ContainsKey(key))
                {
                    s = s.Replace(key, CyrlToLatn[key]);
                }
            }

            return s;
        }
    }
}
