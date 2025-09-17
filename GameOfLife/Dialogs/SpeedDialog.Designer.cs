namespace GameOfLife.Dialogs
{
    partial class SpeedDialog
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
            tableLayoutPanel = new TableLayoutPanel();
            labelDelay = new Label();
            numericUpDownSpeed = new NumericUpDown();
            buttonCancel = new Button();
            buttonConfirm = new Button();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(labelDelay, 0, 0);
            tableLayoutPanel.Controls.Add(numericUpDownSpeed, 1, 0);
            tableLayoutPanel.Controls.Add(buttonCancel, 1, 1);
            tableLayoutPanel.Controls.Add(buttonConfirm, 0, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(195, 86);
            tableLayoutPanel.TabIndex = 0;
            // 
            // labelDelay
            // 
            labelDelay.Anchor = AnchorStyles.Right;
            labelDelay.AutoSize = true;
            labelDelay.Location = new Point(29, 14);
            labelDelay.Margin = new Padding(2, 0, 2, 0);
            labelDelay.Name = "labelDelay";
            labelDelay.Size = new Size(66, 15);
            labelDelay.TabIndex = 0;
            labelDelay.Text = "Delay (ms):";
            // 
            // numericUpDownSpeed
            // 
            numericUpDownSpeed.Anchor = AnchorStyles.Left;
            numericUpDownSpeed.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownSpeed.Location = new Point(99, 10);
            numericUpDownSpeed.Margin = new Padding(2, 2, 2, 2);
            numericUpDownSpeed.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownSpeed.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownSpeed.Name = "numericUpDownSpeed";
            numericUpDownSpeed.Size = new Size(78, 23);
            numericUpDownSpeed.TabIndex = 1;
            numericUpDownSpeed.Value = new decimal(new int[] { 100, 0, 0, 0 });
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
            // SpeedDialog
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
            Name = "SpeedDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Speed";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Button buttonCancel;
        private Button buttonConfirm;
        private Label labelDelay;
        private NumericUpDown numericUpDownSpeed;
    }
}