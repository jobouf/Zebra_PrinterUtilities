namespace LabelUtilities.WinForms.Views
{
    partial class VariableSettingsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            variableTableLayoutPanel = new TableLayoutPanel();
            printerFeedPathLabel = new System.Windows.Forms.Label();
            printerFeedPathTextBox = new TextBox();
            sampleTextBox = new TextBox();
            sampleReferenceTextBox = new TextBox();
            consumeableTextBox = new TextBox();
            consumeableReferenceTextBox = new TextBox();
            labelBatchLabel = new System.Windows.Forms.Label();
            consumeablelabel = new System.Windows.Forms.Label();
            consumeableReferenceLabel = new System.Windows.Forms.Label();
            labelSKUlabel = new System.Windows.Forms.Label();
            variableTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // variableTableLayoutPanel
            // 
            variableTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            variableTableLayoutPanel.ColumnCount = 2;
            variableTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            variableTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            variableTableLayoutPanel.Controls.Add(printerFeedPathLabel, 0, 4);
            variableTableLayoutPanel.Controls.Add(printerFeedPathTextBox, 1, 4);
            variableTableLayoutPanel.Controls.Add(sampleTextBox, 1, 0);
            variableTableLayoutPanel.Controls.Add(sampleReferenceTextBox, 1, 1);
            variableTableLayoutPanel.Controls.Add(consumeableTextBox, 1, 2);
            variableTableLayoutPanel.Controls.Add(consumeableReferenceTextBox, 1, 3);
            variableTableLayoutPanel.Controls.Add(labelBatchLabel, 0, 1);
            variableTableLayoutPanel.Controls.Add(consumeablelabel, 0, 2);
            variableTableLayoutPanel.Controls.Add(consumeableReferenceLabel, 0, 3);
            variableTableLayoutPanel.Controls.Add(labelSKUlabel, 0, 0);
            variableTableLayoutPanel.Dock = DockStyle.Fill;
            variableTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            variableTableLayoutPanel.Name = "variableTableLayoutPanel";
            variableTableLayoutPanel.RowCount = 6;
            variableTableLayoutPanel.RowStyles.Add(new RowStyle());
            variableTableLayoutPanel.RowStyles.Add(new RowStyle());
            variableTableLayoutPanel.RowStyles.Add(new RowStyle());
            variableTableLayoutPanel.RowStyles.Add(new RowStyle());
            variableTableLayoutPanel.RowStyles.Add(new RowStyle());
            variableTableLayoutPanel.RowStyles.Add(new RowStyle());
            variableTableLayoutPanel.Size = new System.Drawing.Size(320, 374);
            variableTableLayoutPanel.TabIndex = 20;
            // 
            // printerFeedPathLabel
            // 
            printerFeedPathLabel.AutoSize = true;
            printerFeedPathLabel.Dock = DockStyle.Fill;
            printerFeedPathLabel.Location = new System.Drawing.Point(6, 131);
            printerFeedPathLabel.Name = "printerFeedPathLabel";
            printerFeedPathLabel.Size = new System.Drawing.Size(149, 29);
            printerFeedPathLabel.TabIndex = 26;
            printerFeedPathLabel.Text = "Printer FeedPath:";
            printerFeedPathLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // printerFeedPathTextBox
            // 
            printerFeedPathTextBox.Dock = DockStyle.Fill;
            printerFeedPathTextBox.Location = new System.Drawing.Point(164, 134);
            printerFeedPathTextBox.Name = "printerFeedPathTextBox";
            printerFeedPathTextBox.PlaceholderText = "Printer FeedPath";
            printerFeedPathTextBox.Size = new System.Drawing.Size(150, 23);
            printerFeedPathTextBox.TabIndex = 25;
            // 
            // sampleTextBox
            // 
            sampleTextBox.Dock = DockStyle.Fill;
            sampleTextBox.Location = new System.Drawing.Point(164, 6);
            sampleTextBox.Name = "sampleTextBox";
            sampleTextBox.PlaceholderText = "Sample";
            sampleTextBox.Size = new System.Drawing.Size(150, 23);
            sampleTextBox.TabIndex = 11;
            // 
            // sampleReferenceTextBox
            // 
            sampleReferenceTextBox.Dock = DockStyle.Fill;
            sampleReferenceTextBox.Location = new System.Drawing.Point(164, 38);
            sampleReferenceTextBox.Name = "sampleReferenceTextBox";
            sampleReferenceTextBox.PlaceholderText = "Sample Reference:";
            sampleReferenceTextBox.Size = new System.Drawing.Size(150, 23);
            sampleReferenceTextBox.TabIndex = 12;
            // 
            // consumeableTextBox
            // 
            consumeableTextBox.Dock = DockStyle.Fill;
            consumeableTextBox.Location = new System.Drawing.Point(164, 70);
            consumeableTextBox.Name = "consumeableTextBox";
            consumeableTextBox.PlaceholderText = "Consumeable";
            consumeableTextBox.Size = new System.Drawing.Size(150, 23);
            consumeableTextBox.TabIndex = 13;
            // 
            // consumeableReferenceTextBox
            // 
            consumeableReferenceTextBox.Dock = DockStyle.Fill;
            consumeableReferenceTextBox.Location = new System.Drawing.Point(164, 102);
            consumeableReferenceTextBox.Name = "consumeableReferenceTextBox";
            consumeableReferenceTextBox.PlaceholderText = "Consumeable Reference:";
            consumeableReferenceTextBox.Size = new System.Drawing.Size(150, 23);
            consumeableReferenceTextBox.TabIndex = 15;
            // 
            // labelBatchLabel
            // 
            labelBatchLabel.AutoSize = true;
            labelBatchLabel.Dock = DockStyle.Fill;
            labelBatchLabel.Location = new System.Drawing.Point(6, 35);
            labelBatchLabel.Name = "labelBatchLabel";
            labelBatchLabel.Size = new System.Drawing.Size(149, 29);
            labelBatchLabel.TabIndex = 18;
            labelBatchLabel.Text = "Sample Reference:";
            labelBatchLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // consumeablelabel
            // 
            consumeablelabel.AutoSize = true;
            consumeablelabel.Dock = DockStyle.Fill;
            consumeablelabel.Location = new System.Drawing.Point(6, 67);
            consumeablelabel.Name = "consumeablelabel";
            consumeablelabel.Size = new System.Drawing.Size(149, 29);
            consumeablelabel.TabIndex = 18;
            consumeablelabel.Text = "Consumeable:";
            consumeablelabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // consumeableReferenceLabel
            // 
            consumeableReferenceLabel.AutoSize = true;
            consumeableReferenceLabel.Dock = DockStyle.Fill;
            consumeableReferenceLabel.Location = new System.Drawing.Point(6, 99);
            consumeableReferenceLabel.Name = "consumeableReferenceLabel";
            consumeableReferenceLabel.Size = new System.Drawing.Size(149, 29);
            consumeableReferenceLabel.TabIndex = 18;
            consumeableReferenceLabel.Text = "Consumeable Reference:";
            consumeableReferenceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSKUlabel
            // 
            labelSKUlabel.AutoSize = true;
            labelSKUlabel.Dock = DockStyle.Fill;
            labelSKUlabel.Location = new System.Drawing.Point(6, 3);
            labelSKUlabel.Name = "labelSKUlabel";
            labelSKUlabel.Size = new System.Drawing.Size(149, 29);
            labelSKUlabel.TabIndex = 18;
            labelSKUlabel.Text = "Sample:";
            labelSKUlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VariableDefinitionsView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(variableTableLayoutPanel);
            Name = "VariableDefinitionsView";
            Size = new System.Drawing.Size(320, 374);
            variableTableLayoutPanel.ResumeLayout(false);
            variableTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel variableTableLayoutPanel;
        private TextBox sampleTextBox;
        private TextBox sampleReferenceTextBox;
        private TextBox consumeableTextBox;
        private TextBox consumeableReferenceTextBox;
        private System.Windows.Forms.Label labelBatchLabel;
        private System.Windows.Forms.Label consumeablelabel;
        private System.Windows.Forms.Label consumeableReferenceLabel;
        private System.Windows.Forms.Label labelSKUlabel;
        private System.Windows.Forms.Label printerFeedPathLabel;
        private TextBox printerFeedPathTextBox;
    }
}
