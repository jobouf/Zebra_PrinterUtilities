namespace LabelUtilities.WinForms.Views
{
    partial class PrinterSettingsView
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
            tableLayoutPanel2 = new TableLayoutPanel();
            printerSetting2Label = new System.Windows.Forms.Label();
            printerSetting2TextBox = new TextBox();
            printerPrintMethodlabel = new System.Windows.Forms.Label();
            printerPrintMethodTextBox = new TextBox();
            printerSetting1Label = new System.Windows.Forms.Label();
            printerSetting1TextBox = new TextBox();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(printerSetting2Label, 0, 1);
            tableLayoutPanel2.Controls.Add(printerSetting2TextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(printerPrintMethodlabel, 0, 0);
            tableLayoutPanel2.Controls.Add(printerPrintMethodTextBox, 1, 0);
            tableLayoutPanel2.Controls.Add(printerSetting1Label, 0, 2);
            tableLayoutPanel2.Controls.Add(printerSetting1TextBox, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new System.Drawing.Size(285, 307);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // printerSetting2Label
            // 
            printerSetting2Label.AutoSize = true;
            printerSetting2Label.Dock = DockStyle.Fill;
            printerSetting2Label.Location = new System.Drawing.Point(6, 35);
            printerSetting2Label.Name = "printerSetting2Label";
            printerSetting2Label.Size = new System.Drawing.Size(132, 29);
            printerSetting2Label.TabIndex = 23;
            printerSetting2Label.Text = "Printer Setting2:";
            printerSetting2Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // printerSetting2TextBox
            // 
            printerSetting2TextBox.Dock = DockStyle.Fill;
            printerSetting2TextBox.Location = new System.Drawing.Point(147, 38);
            printerSetting2TextBox.Name = "printerSetting2TextBox";
            printerSetting2TextBox.PlaceholderText = "Printer Setting2";
            printerSetting2TextBox.Size = new System.Drawing.Size(132, 23);
            printerSetting2TextBox.TabIndex = 20;
            // 
            // printerPrintMethodlabel
            // 
            printerPrintMethodlabel.AutoSize = true;
            printerPrintMethodlabel.Dock = DockStyle.Fill;
            printerPrintMethodlabel.Location = new System.Drawing.Point(6, 3);
            printerPrintMethodlabel.Name = "printerPrintMethodlabel";
            printerPrintMethodlabel.Size = new System.Drawing.Size(132, 29);
            printerPrintMethodlabel.TabIndex = 30;
            printerPrintMethodlabel.Text = "Printer PrintMethod";
            printerPrintMethodlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // printerPrintMethodTextBox
            // 
            printerPrintMethodTextBox.Dock = DockStyle.Fill;
            printerPrintMethodTextBox.Location = new System.Drawing.Point(147, 6);
            printerPrintMethodTextBox.Name = "printerPrintMethodTextBox";
            printerPrintMethodTextBox.PlaceholderText = "Printer PrintMethod";
            printerPrintMethodTextBox.Size = new System.Drawing.Size(132, 23);
            printerPrintMethodTextBox.TabIndex = 29;
            // 
            // printerSetting1Label
            // 
            printerSetting1Label.AutoSize = true;
            printerSetting1Label.Dock = DockStyle.Fill;
            printerSetting1Label.Location = new System.Drawing.Point(6, 67);
            printerSetting1Label.Name = "printerSetting1Label";
            printerSetting1Label.Size = new System.Drawing.Size(132, 29);
            printerSetting1Label.TabIndex = 22;
            printerSetting1Label.Text = "Printer Setting1:";
            printerSetting1Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // printerSetting1TextBox
            // 
            printerSetting1TextBox.Dock = DockStyle.Fill;
            printerSetting1TextBox.Location = new System.Drawing.Point(147, 70);
            printerSetting1TextBox.Name = "printerSetting1TextBox";
            printerSetting1TextBox.PlaceholderText = "Printer Setting1";
            printerSetting1TextBox.Size = new System.Drawing.Size(132, 23);
            printerSetting1TextBox.TabIndex = 21;
            // 
            // PrinterSettingsView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "PrinterSettingsView";
            Size = new System.Drawing.Size(285, 307);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label printerSetting2Label;
        private TextBox printerSetting2TextBox;
        private System.Windows.Forms.Label printerPrintMethodlabel;
        private TextBox printerPrintMethodTextBox;
        private System.Windows.Forms.Label printerSetting1Label;
        private TextBox printerSetting1TextBox;
    }
}
