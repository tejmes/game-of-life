namespace GameOfLife.Dialogs
{
    partial class ResizeDialog
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
            buttonCancel = new Button();
            buttonConfirm = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            labelWidth = new Label();
            labelHeight = new Label();
            numericUpDownWidth = new NumericUpDown();
            numericUpDownHeight = new NumericUpDown();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).BeginInit();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Left;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(99, 61);
            buttonCancel.Margin = new Padding(2, 2, 2, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(78, 20);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Anchor = AnchorStyles.Right;
            buttonConfirm.DialogResult = DialogResult.OK;
            buttonConfirm.Location = new Point(17, 61);
            buttonConfirm.Margin = new Padding(2, 2, 2, 2);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(78, 20);
            buttonConfirm.TabIndex = 4;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(buttonConfirm, 0, 2);
            tableLayoutPanel.Controls.Add(buttonCancel, 1, 2);
            tableLayoutPanel.Controls.Add(labelWidth, 0, 0);
            tableLayoutPanel.Controls.Add(labelHeight, 0, 1);
            tableLayoutPanel.Controls.Add(numericUpDownWidth, 1, 0);
            tableLayoutPanel.Controls.Add(numericUpDownHeight, 1, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.Size = new Size(195, 86);
            tableLayoutPanel.TabIndex = 8;
            // 
            // labelWidth
            // 
            labelWidth.Anchor = AnchorStyles.Right;
            labelWidth.AutoSize = true;
            labelWidth.Location = new Point(53, 6);
            labelWidth.Margin = new Padding(2, 0, 2, 0);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(42, 15);
            labelWidth.TabIndex = 0;
            labelWidth.Text = "Width:";
            // 
            // labelHeight
            // 
            labelHeight.Anchor = AnchorStyles.Right;
            labelHeight.AutoSize = true;
            labelHeight.Location = new Point(49, 34);
            labelHeight.Margin = new Padding(2, 0, 2, 0);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(46, 15);
            labelHeight.TabIndex = 2;
            labelHeight.Text = "Height:";
            // 
            // numericUpDownWidth
            // 
            numericUpDownWidth.Anchor = AnchorStyles.Left;
            numericUpDownWidth.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownWidth.Location = new Point(99, 2);
            numericUpDownWidth.Margin = new Padding(2, 2, 2, 2);
            numericUpDownWidth.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownWidth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownWidth.Name = "numericUpDownWidth";
            numericUpDownWidth.Size = new Size(93, 23);
            numericUpDownWidth.TabIndex = 1;
            numericUpDownWidth.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Anchor = AnchorStyles.Left;
            numericUpDownHeight.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownHeight.Location = new Point(99, 30);
            numericUpDownHeight.Margin = new Padding(2, 2, 2, 2);
            numericUpDownHeight.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.Size = new Size(93, 23);
            numericUpDownHeight.TabIndex = 3;
            numericUpDownHeight.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // ResizeDialog
            // 
            AcceptButton = buttonConfirm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(195, 86);
            Controls.Add(tableLayoutPanel);
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ResizeDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Resize";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCancel;
        private Button buttonConfirm;
        private TableLayoutPanel tableLayoutPanel;
        private Label labelWidth;
        private Label labelHeight;
        private NumericUpDown numericUpDownWidth;
        private NumericUpDown numericUpDownHeight;
    }
}