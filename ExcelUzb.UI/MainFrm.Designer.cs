namespace ExcelUzb.UI
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this._openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sheetInfo = new System.Windows.Forms.Label();
            this._groupBox1 = new System.Windows.Forms.GroupBox();
            this.previewGrid = new System.Windows.Forms.DataGridView();
            this.ignoreHeader = new System.Windows.Forms.CheckBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this._label2 = new System.Windows.Forms.Label();
            this._splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._groupBox2 = new System.Windows.Forms.GroupBox();
            this._label3 = new System.Windows.Forms.Label();
            this.sheetListing = new System.Windows.Forms.ComboBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.columnsListing = new System.Windows.Forms.CheckedListBox();
            this.chooseFileBox = new System.Windows.Forms.PictureBox();
            this._label1 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar = new System.Windows.Forms.ToolStripProgressBar();
            this._statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer1)).BeginInit();
            this._splitContainer1.Panel1.SuspendLayout();
            this._splitContainer1.Panel2.SuspendLayout();
            this._splitContainer1.SuspendLayout();
            this._groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chooseFileBox)).BeginInit();
            this._statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _openFileDialog1
            // 
            this._openFileDialog1.DefaultExt = "*.xlsx";
            this._openFileDialog1.FileName = "openFileDialog1";
            this._openFileDialog1.Filter = "Excel files | *.xlsx";
            this._openFileDialog1.InitialDirectory = ".";
            this._openFileDialog1.Title = "Select Excel file";
            // 
            // sheetInfo
            // 
            this.sheetInfo.BackColor = System.Drawing.SystemColors.Control;
            this.sheetInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sheetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sheetInfo.ForeColor = System.Drawing.Color.Black;
            this.sheetInfo.Location = new System.Drawing.Point(3, 894);
            this.sheetInfo.Name = "sheetInfo";
            this.sheetInfo.Size = new System.Drawing.Size(1195, 50);
            this.sheetInfo.TabIndex = 2;
            this.sheetInfo.Text = "0 cols 0 rows";
            this.sheetInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _groupBox1
            // 
            this._groupBox1.Controls.Add(this.sheetInfo);
            this._groupBox1.Controls.Add(this.previewGrid);
            this._groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._groupBox1.Location = new System.Drawing.Point(0, 0);
            this._groupBox1.Name = "_groupBox1";
            this._groupBox1.Size = new System.Drawing.Size(1201, 947);
            this._groupBox1.TabIndex = 0;
            this._groupBox1.TabStop = false;
            this._groupBox1.Text = "Preview data";
            // 
            // previewGrid
            // 
            this.previewGrid.AllowUserToAddRows = false;
            this.previewGrid.AllowUserToDeleteRows = false;
            this.previewGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.previewGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.previewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previewGrid.EnableHeadersVisualStyles = false;
            this.previewGrid.Location = new System.Drawing.Point(23, 37);
            this.previewGrid.MultiSelect = false;
            this.previewGrid.Name = "previewGrid";
            this.previewGrid.ReadOnly = true;
            this.previewGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.previewGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.previewGrid.RowTemplate.Height = 40;
            this.previewGrid.ShowCellErrors = false;
            this.previewGrid.ShowCellToolTips = false;
            this.previewGrid.ShowEditingIcon = false;
            this.previewGrid.ShowRowErrors = false;
            this.previewGrid.Size = new System.Drawing.Size(1813, 814);
            this.previewGrid.TabIndex = 1;
            // 
            // ignoreHeader
            // 
            this.ignoreHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ignoreHeader.AutoSize = true;
            this.ignoreHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ignoreHeader.Location = new System.Drawing.Point(28, 796);
            this.ignoreHeader.Name = "ignoreHeader";
            this.ignoreHeader.Size = new System.Drawing.Size(286, 43);
            this.ignoreHeader.TabIndex = 7;
            this.ignoreHeader.Text = "Ignore header?";
            this.ignoreHeader.UseVisualStyleBackColor = true;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileNameLabel.Location = new System.Drawing.Point(30, 160);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(184, 39);
            this.fileNameLabel.TabIndex = 6;
            this.fileNameLabel.Text = "Browse file";
            this.fileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _label2
            // 
            this._label2.AutoSize = true;
            this._label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._label2.Location = new System.Drawing.Point(30, 329);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(271, 39);
            this._label2.TabIndex = 5;
            this._label2.Text = "Choose columns";
            // 
            // _splitContainer1
            // 
            this._splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainer1.Location = new System.Drawing.Point(0, 100);
            this._splitContainer1.Name = "_splitContainer1";
            // 
            // _splitContainer1.Panel1
            // 
            this._splitContainer1.Panel1.Controls.Add(this._groupBox2);
            // 
            // _splitContainer1.Panel2
            // 
            this._splitContainer1.Panel2.Controls.Add(this._groupBox1);
            this._splitContainer1.Size = new System.Drawing.Size(1568, 947);
            this._splitContainer1.SplitterDistance = 363;
            this._splitContainer1.TabIndex = 5;
            // 
            // _groupBox2
            // 
            this._groupBox2.Controls.Add(this.ignoreHeader);
            this._groupBox2.Controls.Add(this.fileNameLabel);
            this._groupBox2.Controls.Add(this._label2);
            this._groupBox2.Controls.Add(this._label3);
            this._groupBox2.Controls.Add(this.sheetListing);
            this._groupBox2.Controls.Add(this.convertButton);
            this._groupBox2.Controls.Add(this.columnsListing);
            this._groupBox2.Controls.Add(this.chooseFileBox);
            this._groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._groupBox2.Location = new System.Drawing.Point(0, 0);
            this._groupBox2.Name = "_groupBox2";
            this._groupBox2.Size = new System.Drawing.Size(363, 947);
            this._groupBox2.TabIndex = 0;
            this._groupBox2.TabStop = false;
            this._groupBox2.Text = "File controls";
            // 
            // _label3
            // 
            this._label3.AutoSize = true;
            this._label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._label3.Location = new System.Drawing.Point(30, 220);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(204, 39);
            this._label3.TabIndex = 4;
            this._label3.Text = "Select sheet";
            // 
            // sheetListing
            // 
            this.sheetListing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sheetListing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sheetListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sheetListing.FormattingEnabled = true;
            this.sheetListing.Location = new System.Drawing.Point(28, 262);
            this.sheetListing.Name = "sheetListing";
            this.sheetListing.Size = new System.Drawing.Size(312, 46);
            this.sheetListing.TabIndex = 3;
            this.sheetListing.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // convertButton
            // 
            this.convertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.convertButton.BackColor = System.Drawing.SystemColors.Control;
            this.convertButton.Enabled = false;
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.convertButton.ForeColor = System.Drawing.Color.Black;
            this.convertButton.Location = new System.Drawing.Point(28, 859);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(180, 60);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // columnsListing
            // 
            this.columnsListing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.columnsListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnsListing.FormattingEnabled = true;
            this.columnsListing.HorizontalScrollbar = true;
            this.columnsListing.Location = new System.Drawing.Point(28, 371);
            this.columnsListing.Name = "columnsListing";
            this.columnsListing.Size = new System.Drawing.Size(312, 404);
            this.columnsListing.TabIndex = 1;
            // 
            // chooseFileBox
            // 
            this.chooseFileBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseFileBox.Image = global::ExcelUzb.UI.Properties.Resources.logo;
            this.chooseFileBox.Location = new System.Drawing.Point(88, 57);
            this.chooseFileBox.Name = "chooseFileBox";
            this.chooseFileBox.Size = new System.Drawing.Size(100, 100);
            this.chooseFileBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chooseFileBox.TabIndex = 0;
            this.chooseFileBox.TabStop = false;
            this.chooseFileBox.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // _label1
            // 
            this._label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._label1.Dock = System.Windows.Forms.DockStyle.Top;
            this._label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._label1.ForeColor = System.Drawing.Color.White;
            this._label1.Location = new System.Drawing.Point(0, 0);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(1568, 100);
            this._label1.TabIndex = 4;
            this._label1.Text = "Excel workbook UZ converter";
            this._label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(78, 60);
            this.statusLabel.Text = "0%";
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(144, 59);
            // 
            // _statusStrip1
            // 
            this._statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this._statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar,
            this.statusLabel});
            this._statusStrip1.Location = new System.Drawing.Point(0, 1047);
            this._statusStrip1.Name = "_statusStrip1";
            this._statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 20, 0);
            this._statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this._statusStrip1.ShowItemToolTips = true;
            this._statusStrip1.Size = new System.Drawing.Size(1568, 65);
            this._statusStrip1.TabIndex = 3;
            this._statusStrip1.Text = "statusStrip1";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 1112);
            this.Controls.Add(this._splitContainer1);
            this.Controls.Add(this._label1);
            this.Controls.Add(this._statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cyrl2Latn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewGrid)).EndInit();
            this._splitContainer1.Panel1.ResumeLayout(false);
            this._splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainer1)).EndInit();
            this._splitContainer1.ResumeLayout(false);
            this._groupBox2.ResumeLayout(false);
            this._groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chooseFileBox)).EndInit();
            this._statusStrip1.ResumeLayout(false);
            this._statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog _openFileDialog1;
        private System.Windows.Forms.Label sheetInfo;
        private System.Windows.Forms.GroupBox _groupBox1;
        private System.Windows.Forms.DataGridView previewGrid;
        private System.Windows.Forms.CheckBox ignoreHeader;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label _label2;
        private System.Windows.Forms.SplitContainer _splitContainer1;
        private System.Windows.Forms.GroupBox _groupBox2;
        private System.Windows.Forms.Label _label3;
        private System.Windows.Forms.ComboBox sheetListing;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.CheckedListBox columnsListing;
        private System.Windows.Forms.PictureBox chooseFileBox;
        private System.Windows.Forms.Label _label1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar statusBar;
        private System.Windows.Forms.StatusStrip _statusStrip1;
    }
}