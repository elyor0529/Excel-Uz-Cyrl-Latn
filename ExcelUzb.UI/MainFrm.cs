using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelUzb.UI
{
    public partial class MainFrm : Form
    {
        private string _file;

        public MainFrm()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (_openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                convertButton.Enabled = false;
                _file = "";
                return;
            }

            _file = _openFileDialog1.FileName;
            sheetListing.Items.Clear();
            var sheets = ExcelHelper.GetSheets(_file);
            if (sheets != null)
            {
                sheetListing.Items.AddRange(sheets);
            }

            sheetListing.SelectedIndex = -1;
            fileNameLabel.Text = Path.GetFileNameWithoutExtension(_file);
            MessageBox.Show("Please select sheet", "Workbook ready", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            columnsListing.Items.Clear();
            previewGrid.Rows.Clear();
            previewGrid.Columns.Clear();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sheetListing.SelectedIndex == -1)
                return;

            var sheetName = (string)sheetListing.SelectedItem;
            var info = ExcelHelper.GetSheetInfo(_file, sheetName);
            sheetInfo.Text = info.Info;
            previewGrid.Columns.Clear();
            var cols = info.Columns;
            if (cols != null)
            {
                var items = columnsListing.Items;
                items.AddRange(cols);
                foreach (var column in cols)
                {
                    previewGrid.Columns.Add(column, column);
                    previewGrid.Columns[previewGrid.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }

            previewGrid.Rows.Clear();
            var rows = info.Rows;
            if (rows != null)
            {
                foreach (var row in rows)
                {
                    previewGrid.Rows.Add(row);
                    var count = previewGrid.Rows.Count;
                    previewGrid.Rows[count - 1].HeaderCell.Value = $"{count}";

                    var percent = (int)Math.Ceiling(count * 100m / row.Length);
                    statusLabel.Text = $"{percent}%";
                    statusBar.Value = percent;

                    Application.DoEvents();
                }
            }

            statusLabel.Text = "0%";
            statusBar.Value = 0;
            convertButton.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (sheetListing.SelectedIndex == -1)
                return;

            var sheetName = (string)sheetListing.SelectedItem;
            var rowCount = previewGrid.RowCount;
            var columns = columnsListing.SelectedItems.Count > 0
                ? columnsListing.SelectedItems.Cast<string>().ToArray()
                : new string[0];

            ExcelHelper.ProcessConvert(_file, sheetName, ignoreHeader.Checked, columns, delegate (int i)
            {

                if (columns.Length > 0)
                {
                    foreach (var cell in previewGrid.Rows[i].Cells.Cast<DataGridViewCell>())
                    {
                        if (!columns.Contains(cell.OwningColumn.Name))
                            continue;

                        var value = $"{cell.Value}".Trim();

                        if (!string.IsNullOrWhiteSpace(value))
                            cell.Value = LangUtils.ToLatn(value);
                    }
                }
                else
                {
                    foreach (var cell in previewGrid.Rows[i].Cells.Cast<DataGridViewCell>())
                    {
                        var value = $"{cell.Value}".Trim();

                        if (!string.IsNullOrWhiteSpace(value))
                            cell.Value = LangUtils.ToLatn(value);
                    }
                }

                var percent = (int)Math.Ceiling(i * 100m / rowCount);
                statusLabel.Text = $"{percent}%";
                statusBar.Value = percent;

                Application.DoEvents();

            });
            statusLabel.Text = "0%";
            statusBar.Value = 0;
            convertButton.Enabled = true;
        }
    }
}
