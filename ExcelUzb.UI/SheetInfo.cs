using System.Collections.Generic;

namespace ExcelUzb.UI
{
    public class SheetInfo
    {
        public string Info { get; set; }

        public string[] Columns { get; set; }

        public IEnumerable<object[]> Rows { get; set; } = new List<object[]>();
    }
}