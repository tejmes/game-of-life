namespace GameOfLife.Dialogs
{
    partial class ExportDialog
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
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonConfirm = new Button();
            buttonCancel = new Button();
            labelScope = new Label();
            labelType = new Label();
            groupBoxScope = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            radioButtonCurrentView = new RadioButton();
            radioButtonEntireMap = new RadioButton();
            groupBoxType = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            radioButtonImage = new RadioButton();
            radioButtonState = new RadioButton();
            tableLayoutPanel1.SuspendLayout();
            groupBoxScope.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBoxType.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonConfirm, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonCancel, 1, 2);
            tableLayoutPanel1.Controls.Add(labelScope, 0, 0);
            tableLayoutPanel1.Controls.Add(labelType, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBoxScope, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBoxType, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(284, 211);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Anchor = AnchorStyles.Right;
            buttonConfirm.DialogResult = DialogResult.OK;
            buttonConfirm.Location = new Point(62, 179);
            buttonConfirm.Margin = new Padding(2);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(78, 20);
            buttonConfirm.TabIndex = 6;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Left;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(144, 179);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(78, 20);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelScope
            // 
            labelScope.Anchor = AnchorStyles.Right;
            labelScope.AutoSize = true;
            labelScope.Location = new Point(97, 34);
            labelScope.Name = "labelScope";
            labelScope.Size = new Size(42, 15);
            labelScope.TabIndex = 0;
            labelScope.Text = "Scope:";
            // 
            // labelType
            // 
            labelType.Anchor = AnchorStyles.Right;
            labelType.AutoSize = true;
            labelType.Location = new Point(105, 118);
            labelType.Name = "labelType";
            labelType.Size = new Size(34, 15);
            labelType.TabIndex = 3;
            labelType.Text = "Type:";
            // 
            // groupBoxScope
            // 
            groupBoxScope.Controls.Add(tableLayoutPanel2);
            groupBoxScope.Dock = DockStyle.Fill;
            groupBoxScope.Location = new Point(145, 3);
            groupBoxScope.Name = "groupBoxScope";
            groupBoxScope.Size = new Size(136, 78);
            groupBoxScope.TabIndex = 2;
            groupBoxScope.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(radioButtonCurrentView, 0, 1);
            tableLayoutPanel2.Controls.Add(radioButtonEntireMap, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(130, 56);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // radioButtonCurrentView
            // 
            radioButtonCurrentView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButtonCurrentView.AutoSize = true;
            radioButtonCurrentView.Location = new Point(3, 34);
            radioButtonCurrentView.Name = "radioButtonCurrentView";
            radioButtonCurrentView.Size = new Size(93, 19);
            radioButtonCurrentView.TabIndex = 2;
            radioButtonCurrentView.TabStop = true;
            radioButtonCurrentView.Text = "Current View";
            radioButtonCurrentView.UseVisualStyleBackColor = true;
            // 
            // radioButtonEntireMap
            // 
            radioButtonEntireMap.AutoSize = true;
            radioButtonEntireMap.Checked = true;
            radioButtonEntireMap.Location = new Point(3, 3);
            radioButtonEntireMap.Name = "radioButtonEntireMap";
            radioButtonEntireMap.Size = new Size(82, 19);
            radioButtonEntireMap.TabIndex = 1;
            radioButtonEntireMap.TabStop = true;
            radioButtonEntireMap.Text = "Entire Map";
            radioButtonEntireMap.UseVisualStyleBackColor = true;
            // 
            // groupBoxType
            // 
            groupBoxType.Controls.Add(tableLayoutPanel3);
            groupBoxType.Dock = DockStyle.Fill;
            groupBoxType.Location = new Point(145, 87);
            groupBoxType.Name = "groupBoxType";
            groupBoxType.Size = new Size(136, 78);
            groupBoxType.TabIndex = 3;
            groupBoxType.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(radioButtonImage, 0, 0);
            tableLayoutPanel3.Controls.Add(radioButtonState, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(130, 56);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // radioButtonImage
            // 
            radioButtonImage.AutoSize = true;
            radioButtonImage.Checked = true;
            radioButtonImage.Location = new Point(3, 3);
            radioButtonImage.Name = "radioButtonImage";
            radioButtonImage.Size = new Size(93, 19);
            radioButtonImage.TabIndex = 4;
            radioButtonImage.TabStop = true;
            radioButtonImage.Text = "Image (PNG)";
            radioButtonImage.UseVisualStyleBackColor = true;
            // 
            // radioButtonState
            // 
            radioButtonState.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            radioButtonState.AutoSize = true;
            radioButtonState.Location = new Point(3, 34);
            radioButtonState.Name = "radioButtonState";
            radioButtonState.Size = new Size(51, 19);
            radioButtonState.TabIndex = 5;
            radioButtonState.TabStop = true;
            radioButtonState.Text = "State";
            radioButtonState.UseVisualStyleBackColor = true;
            // 
            // ExportDialog
            // 
            AcceptButton = buttonConfirm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(284, 211);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ExportDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Export";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBoxScope.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBoxType.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelScope;
        private Label labelType;
        private GroupBox groupBoxScope;
        private RadioButton radioButtonCurrentView;
        private RadioButton radioButtonEntireMap;
        private GroupBox groupBoxType;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private RadioButton radioButtonImage;
        private RadioButton radioButtonState;
        private Button buttonConfirm;
        private Button buttonCancel;
    }
}