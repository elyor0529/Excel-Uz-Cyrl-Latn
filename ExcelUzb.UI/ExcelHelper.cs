using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using GemBox.Spreadsheet;

namespace ExcelUzb.UI
{
    internal static class ExcelHelper
    {
        static ExcelHelper()
        {
            var cracks = new[]
            {
                "ERDC-FN4O-YKYN-4DBM",
                "EQU2-1KBF-UZ0D-DJ14",
                "EQU2-1000-0000-000U"
            };
            var rand = new Random();

            SpreadsheetInfo.SetLicense(cracks[rand.Next(0, 2)]);
        }

        public static string[] GetSheets(string path)
        {
            var workbook = ExcelFile.Load(path);

            return workbook.Worksheets.Select(a => a.Name).ToArray();
        }

        public static SheetInfo GetSheetInfo(string filePath, string sheetName)
        {
            var workbook = ExcelFile.Load(filePath);
            var worksheet = workbook.Worksheets[sheetName];
            var usedColumns = worksheet.CalculateMaxUsedColumns();

            return new SheetInfo
            {
                Columns = Enumerable.Range(0, usedColumns).Select(a => worksheet.Columns[a].Name).ToArray(),
                Info = $"{usedColumns} columns / {worksheet.Rows.Count} rows",
                Rows = worksheet.Rows.Select(a => a.Cells.Select(b => $"{b.Value}".Trim()).ToArray())
            };
        }

        public static void ProcessConvert(string filePath, string sheetName, bool ignoreHeader, string[] acceptColumns, Action<int> process)
        {
            var workbook = ExcelFile.Load(filePath);
            var worksheet = workbook.Worksheets[sheetName];
            var usedColumns = worksheet.CalculateMaxUsedColumns();

            foreach (var row in worksheet.Rows)
            {
                if (row.Index == 0 && ignoreHeader)
                    continue;

                if (acceptColumns.Length > 0)
                {
                    for (var i = 0; i < usedColumns; i++)
                    {

                        if (!acceptColumns.Contains(worksheet.Columns[i].Name))
                            continue;

                        var value = $"{row.Cells[i].Value}".Trim();
                        if (!string.IsNullOrWhiteSpace(value))
                        {
                            row.Cells[i].SetValue(LangUtils.ToLatn(value));
                        }
                    }
                }
                else
                {
                    for (var i = 0; i < usedColumns; i++)
                    {
                        var value = $"{row.Cells[i].Value}".Trim();

                        if (!string.IsNullOrWhiteSpace(value))
                        {
                            row.Cells[i].SetValue(LangUtils.ToLatn(value));
                        }
                    }
                }


                process(row.Index);
            }

            var save = Path.Combine(Path.GetTempPath(), Path.ChangeExtension(Path.GetRandomFileName(), ".xlsx"));
            workbook.Save(save);
            Process.Start(save);
        }
    }
}