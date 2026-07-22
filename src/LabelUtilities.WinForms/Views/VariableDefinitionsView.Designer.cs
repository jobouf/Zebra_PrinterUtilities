namespace LabelUtilities.WinForms.Views
{
    partial class VariableDefinitionsView
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
            tableLayoutPanel1 = new TableLayoutPanel();
            sampleTextBox = new TextBox();
            sampleReferenceTextBox = new TextBox();
            consumeableTextBox = new TextBox();
            consumeableReferenceTextBox = new TextBox();
            labelBatchLabel = new System.Windows.Forms.Label();
            consumeablelabel = new System.Windows.Forms.Label();
            consumeableReferenceLabel = new System.Windows.Forms.Label();
            labelSKUlabel = new System.Windows.Forms.Label();
            printerFeedPathLabel = new System.Windows.Forms.Label();
            printerFeedPathTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(printerFeedPathLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(printerFeedPathTextBox, 1, 4);
            tableLayoutPanel1.Controls.Add(sampleTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(sampleReferenceTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(consumeableTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(consumeableReferenceTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(labelBatchLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(consumeablelabel, 0, 2);
            tableLayoutPanel1.Controls.Add(consumeableReferenceLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(labelSKUlabel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(320, 374);
            tableLayoutPanel1.TabIndex = 20;
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
            // VariableDefinitionsView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "VariableDefinitionsView";
            Size = new System.Drawing.Size(320, 374);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
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
