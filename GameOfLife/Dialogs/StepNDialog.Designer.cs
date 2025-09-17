namespace GameOfLife.Dialogs
{
    partial class StepNDialog
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
            labelSteps = new Label();
            buttonCancel = new Button();
            buttonConfirm = new Button();
            numericUpDownSteps = new NumericUpDown();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSteps).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelSteps
            // 
            labelSteps.Anchor = AnchorStyles.Right;
            labelSteps.AutoSize = true;
            labelSteps.Location = new Point(57, 14);
            labelSteps.Margin = new Padding(2, 0, 2, 0);
            labelSteps.Name = "labelSteps";
            labelSteps.Size = new Size(38, 15);
            labelSteps.TabIndex = 0;
            labelSteps.Text = "Steps:";
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Left;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(99, 54);
            buttonCancel.Margin = new Padding(2, 2, 2, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(78, 20);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Anchor = AnchorStyles.Right;
            buttonConfirm.DialogResult = DialogResult.OK;
            buttonConfirm.Location = new Point(17, 54);
            buttonConfirm.Margin = new Padding(2, 2, 2, 2);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(78, 20);
            buttonConfirm.TabIndex = 2;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSteps
            // 
            numericUpDownSteps.Anchor = AnchorStyles.Left;
            numericUpDownSteps.Location = new Point(99, 10);
            numericUpDownSteps.Margin = new Padding(2, 2, 2, 2);
            numericUpDownSteps.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownSteps.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownSteps.Name = "numericUpDownSteps";
            numericUpDownSteps.Size = new Size(78, 23);
            numericUpDownSteps.TabIndex = 1;
            numericUpDownSteps.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelSteps, 0, 0);
            tableLayoutPanel1.Controls.Add(numericUpDownSteps, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonConfirm, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonCancel, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(195, 86);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // StepNDialog
            // 
            AcceptButton = buttonConfirm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(195, 86);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StepNDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Step × N";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSteps).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelSteps;
        private Button buttonCancel;
        private Button buttonConfirm;
        private NumericUpDown numericUpDownSteps;
        private TableLayoutPanel tableLayoutPanel1;
    }
}