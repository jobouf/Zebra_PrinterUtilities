using Size = System.Drawing.Size;

namespace Zebra_LabelProfile
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            toolStrip1 = new ToolStrip();
            toolStripComboBoxPrinterList = new ToolStripComboBox();
            toolStripButtonDiscoverPrinters = new ToolStripButton();
            toolStripButtonStartProfile = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            labelLBatch = new System.Windows.Forms.Label();
            labelLSKU = new System.Windows.Forms.Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBoxPrinterList, toolStripButtonDiscoverPrinters, toolStripButtonStartProfile });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBoxPrinterList
            // 
            toolStripComboBoxPrinterList.Name = "toolStripComboBoxPrinterList";
            toolStripComboBoxPrinterList.Size = new Size(480, 25);
            toolStripComboBoxPrinterList.Text = "Select Zebra Printer";
            // 
            // toolStripButtonDiscoverPrinters
            // 
            toolStripButtonDiscoverPrinters.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDiscoverPrinters.Image = (System.Drawing.Image)resources.GetObject("toolStripButtonDiscoverPrinters.Image");
            toolStripButtonDiscoverPrinters.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonDiscoverPrinters.Name = "toolStripButtonDiscoverPrinters";
            toolStripButtonDiscoverPrinters.Size = new Size(23, 22);
            toolStripButtonDiscoverPrinters.Text = "toolStripButtonDiscoverPrinters";
            toolStripButtonDiscoverPrinters.Click += toolStripButtonDiscoverPrinters_Click;
            // 
            // toolStripButtonStartProfile
            // 
            toolStripButtonStartProfile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonStartProfile.Image = (System.Drawing.Image)resources.GetObject("toolStripButtonStartProfile.Image");
            toolStripButtonStartProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripButtonStartProfile.Name = "toolStripButtonStartProfile";
            toolStripButtonStartProfile.Size = new Size(23, 22);
            toolStripButtonStartProfile.Text = "toolStripButtonStartProfile";
            toolStripButtonStartProfile.Click += toolStripButtonStartProfile_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(labelLBatch);
            splitContainer1.Panel1.Controls.Add(labelLSKU);
            splitContainer1.Panel1.Controls.Add(textBox2);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Size = new Size(800, 425);
            splitContainer1.SplitterDistance = 410;
            splitContainer1.TabIndex = 1;
            // 
            // labelLBatch
            // 
            labelLBatch.AutoSize = true;
            labelLBatch.Location = new System.Drawing.Point(18, 47);
            labelLBatch.Name = "labelLBatch";
            labelLBatch.Size = new Size(68, 15);
            labelLBatch.TabIndex = 3;
            labelLBatch.Text = "Label Batch";
            // 
            // labelLSKU
            // 
            labelLSKU.AutoSize = true;
            labelLSKU.Location = new System.Drawing.Point(18, 18);
            labelLSKU.Name = "labelLSKU";
            labelLSKU.Size = new Size(59, 15);
            labelLSKU.TabIndex = 2;
            labelLSKU.Text = "Label SKU";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(92, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(92, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // MainView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "MainView";
            Text = "MainForm";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripComboBox toolStripComboBoxPrinterList;
        private ToolStripButton toolStripButtonDiscoverPrinters;
        private ToolStripButton toolStripButtonStartProfile;
        private SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelLSKU;
        private TextBox textBox2;
        private TextBox textBox1;
        private System.Windows.Forms.Label labelLBatch;
    }
}
