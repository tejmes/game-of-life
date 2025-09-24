namespace GameOfLife.WinForms.Dialogs
{
    partial class RandomFillDialog
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
            tableLayoutPanelDensity = new TableLayoutPanel();
            labelDensity = new Label();
            numericUpDownDensity = new NumericUpDown();
            tableLayoutPanelSeed = new TableLayoutPanel();
            buttonSeed = new Button();
            checkBoxSeed = new CheckBox();
            numericUpDownSeed = new NumericUpDown();
            tableLayoutPanelButtons = new TableLayoutPanel();
            buttonConfirm = new Button();
            buttonCancel = new Button();
            groupBoxTarget = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            radioButtonCurrentView = new RadioButton();
            radioButtonEntireMap = new RadioButton();
            tableLayoutPanel.SuspendLayout();
            tableLayoutPanelDensity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDensity).BeginInit();
            tableLayoutPanelSeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeed).BeginInit();
            tableLayoutPanelButtons.SuspendLayout();
            groupBoxTarget.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Controls.Add(tableLayoutPanelDensity, 0, 0);
            tableLayoutPanel.Controls.Add(tableLayoutPanelSeed, 0, 1);
            tableLayoutPanel.Controls.Add(tableLayoutPanelButtons, 0, 3);
            tableLayoutPanel.Controls.Add(groupBoxTarget, 0, 2);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel.Size = new Size(384, 261);
            tableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanelDensity
            // 
            tableLayoutPanelDensity.ColumnCount = 2;
            tableLayoutPanelDensity.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelDensity.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelDensity.Controls.Add(labelDensity, 0, 0);
            tableLayoutPanelDensity.Controls.Add(numericUpDownDensity, 1, 0);
            tableLayoutPanelDensity.Dock = DockStyle.Fill;
            tableLayoutPanelDensity.Location = new Point(3, 3);
            tableLayoutPanelDensity.Name = "tableLayoutPanelDensity";
            tableLayoutPanelDensity.RowCount = 1;
            tableLayoutPanelDensity.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelDensity.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelDensity.Size = new Size(378, 59);
            tableLayoutPanelDensity.TabIndex = 0;
            // 
            // labelDensity
            // 
            labelDensity.Anchor = AnchorStyles.Right;
            labelDensity.AutoSize = true;
            labelDensity.Location = new Point(116, 22);
            labelDensity.Name = "labelDensity";
            labelDensity.Size = new Size(70, 15);
            labelDensity.TabIndex = 0;
            labelDensity.Text = "Density (%):";
            // 
            // numericUpDownDensity
            // 
            numericUpDownDensity.Anchor = AnchorStyles.Left;
            numericUpDownDensity.Location = new Point(192, 18);
            numericUpDownDensity.Name = "numericUpDownDensity";
            numericUpDownDensity.Size = new Size(120, 23);
            numericUpDownDensity.TabIndex = 1;
            numericUpDownDensity.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // tableLayoutPanelSeed
            // 
            tableLayoutPanelSeed.ColumnCount = 3;
            tableLayoutPanelSeed.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelSeed.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelSeed.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelSeed.Controls.Add(buttonSeed, 2, 0);
            tableLayoutPanelSeed.Controls.Add(checkBoxSeed, 0, 0);
            tableLayoutPanelSeed.Controls.Add(numericUpDownSeed, 1, 0);
            tableLayoutPanelSeed.Dock = DockStyle.Fill;
            tableLayoutPanelSeed.Location = new Point(3, 68);
            tableLayoutPanelSeed.Name = "tableLayoutPanelSeed";
            tableLayoutPanelSeed.RowCount = 1;
            tableLayoutPanelSeed.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelSeed.Size = new Size(378, 59);
            tableLayoutPanelSeed.TabIndex = 1;
            // 
            // buttonSeed
            // 
            buttonSeed.Anchor = AnchorStyles.Left;
            buttonSeed.Location = new Point(255, 18);
            buttonSeed.Name = "buttonSeed";
            buttonSeed.Size = new Size(75, 23);
            buttonSeed.TabIndex = 4;
            buttonSeed.Text = "Random";
            buttonSeed.UseVisualStyleBackColor = true;
            buttonSeed.Click += buttonSeed_Click;
            // 
            // checkBoxSeed
            // 
            checkBoxSeed.Anchor = AnchorStyles.Right;
            checkBoxSeed.AutoSize = true;
            checkBoxSeed.Location = new Point(50, 20);
            checkBoxSeed.Name = "checkBoxSeed";
            checkBoxSeed.Size = new Size(73, 19);
            checkBoxSeed.TabIndex = 2;
            checkBoxSeed.Text = "Use Seed";
            checkBoxSeed.UseVisualStyleBackColor = true;
            checkBoxSeed.CheckedChanged += checkBoxSeed_CheckedChanged;
            // 
            // numericUpDownSeed
            // 
            numericUpDownSeed.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownSeed.Location = new Point(129, 18);
            numericUpDownSeed.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownSeed.Name = "numericUpDownSeed";
            numericUpDownSeed.Size = new Size(120, 23);
            numericUpDownSeed.TabIndex = 3;
            // 
            // tableLayoutPanelButtons
            // 
            tableLayoutPanelButtons.ColumnCount = 2;
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.Controls.Add(buttonConfirm, 0, 0);
            tableLayoutPanelButtons.Controls.Add(buttonCancel, 1, 0);
            tableLayoutPanelButtons.Dock = DockStyle.Fill;
            tableLayoutPanelButtons.Location = new Point(3, 198);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelButtons.Size = new Size(378, 60);
            tableLayoutPanelButtons.TabIndex = 2;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Anchor = AnchorStyles.Right;
            buttonConfirm.DialogResult = DialogResult.OK;
            buttonConfirm.Location = new Point(109, 20);
            buttonConfirm.Margin = new Padding(2);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(78, 20);
            buttonConfirm.TabIndex = 8;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Left;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(191, 20);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(78, 20);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBoxTarget
            // 
            groupBoxTarget.Controls.Add(tableLayoutPanel1);
            groupBoxTarget.Dock = DockStyle.Fill;
            groupBoxTarget.Location = new Point(3, 133);
            groupBoxTarget.Name = "groupBoxTarget";
            groupBoxTarget.Size = new Size(378, 59);
            groupBoxTarget.TabIndex = 5;
            groupBoxTarget.TabStop = false;
            groupBoxTarget.Text = "Target";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(radioButtonCurrentView, 1, 0);
            tableLayoutPanel1.Controls.Add(radioButtonEntireMap, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(372, 37);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // radioButtonCurrentView
            // 
            radioButtonCurrentView.Anchor = AnchorStyles.Left;
            radioButtonCurrentView.AutoSize = true;
            radioButtonCurrentView.Location = new Point(189, 9);
            radioButtonCurrentView.Name = "radioButtonCurrentView";
            radioButtonCurrentView.Size = new Size(93, 19);
            radioButtonCurrentView.TabIndex = 7;
            radioButtonCurrentView.TabStop = true;
            radioButtonCurrentView.Text = "Current View";
            radioButtonCurrentView.UseVisualStyleBackColor = true;
            // 
            // radioButtonEntireMap
            // 
            radioButtonEntireMap.Anchor = AnchorStyles.Right;
            radioButtonEntireMap.AutoSize = true;
            radioButtonEntireMap.Checked = true;
            radioButtonEntireMap.Location = new Point(101, 9);
            radioButtonEntireMap.Name = "radioButtonEntireMap";
            radioButtonEntireMap.RightToLeft = RightToLeft.No;
            radioButtonEntireMap.Size = new Size(82, 19);
            radioButtonEntireMap.TabIndex = 6;
            radioButtonEntireMap.TabStop = true;
            radioButtonEntireMap.Text = "Entire Map";
            radioButtonEntireMap.UseVisualStyleBackColor = true;
            // 
            // RandomFillDialog
            // 
            AcceptButton = buttonConfirm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(384, 261);
            Controls.Add(tableLayoutPanel);
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RandomFillDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Random Fill";
            Load += RandomFillDialog_Load;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanelDensity.ResumeLayout(false);
            tableLayoutPanelDensity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDensity).EndInit();
            tableLayoutPanelSeed.ResumeLayout(false);
            tableLayoutPanelSeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSeed).EndInit();
            tableLayoutPanelButtons.ResumeLayout(false);
            groupBoxTarget.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private TableLayoutPanel tableLayoutPanelDensity;
        private TableLayoutPanel tableLayoutPanelSeed;
        private TableLayoutPanel tableLayoutPanelButtons;
        private GroupBox groupBoxTarget;
        private Label labelDensity;
        private NumericUpDown numericUpDownDensity;
        private Button buttonSeed;
        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton radioButtonCurrentView;
        private RadioButton radioButtonEntireMap;
        private Button buttonConfirm;
        private Button buttonCancel;
        private CheckBox checkBoxSeed;
        private NumericUpDown numericUpDownSeed;
    }
}