namespace GameOfLife.Dialogs
{
    partial class ColorsDialog
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
            tableLayoutPanel2 = new TableLayoutPanel();
            labelAliveCell = new Label();
            labelGrid = new Label();
            labelBackgroud = new Label();
            panelAliveCell = new Panel();
            panelGrid = new Panel();
            panelBackground = new Panel();
            buttonAliveCell = new Button();
            buttonGrid = new Button();
            buttonBackgroud = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonConfirm = new Button();
            buttonCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.Size = new Size(265, 146);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(labelAliveCell, 0, 0);
            tableLayoutPanel2.Controls.Add(labelGrid, 0, 1);
            tableLayoutPanel2.Controls.Add(labelBackgroud, 0, 2);
            tableLayoutPanel2.Controls.Add(panelAliveCell, 1, 0);
            tableLayoutPanel2.Controls.Add(panelGrid, 1, 1);
            tableLayoutPanel2.Controls.Add(panelBackground, 1, 2);
            tableLayoutPanel2.Controls.Add(buttonAliveCell, 2, 0);
            tableLayoutPanel2.Controls.Add(buttonGrid, 2, 1);
            tableLayoutPanel2.Controls.Add(buttonBackgroud, 2, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 2);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(261, 112);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // labelAliveCell
            // 
            labelAliveCell.Anchor = AnchorStyles.Right;
            labelAliveCell.AutoSize = true;
            labelAliveCell.Location = new Point(29, 11);
            labelAliveCell.Margin = new Padding(2, 0, 2, 0);
            labelAliveCell.Name = "labelAliveCell";
            labelAliveCell.Size = new Size(56, 15);
            labelAliveCell.TabIndex = 0;
            labelAliveCell.Text = "Alive Cell";
            // 
            // labelGrid
            // 
            labelGrid.Anchor = AnchorStyles.Right;
            labelGrid.AutoSize = true;
            labelGrid.Location = new Point(56, 48);
            labelGrid.Margin = new Padding(2, 0, 2, 0);
            labelGrid.Name = "labelGrid";
            labelGrid.Size = new Size(29, 15);
            labelGrid.TabIndex = 2;
            labelGrid.Text = "Grid";
            // 
            // labelBackgroud
            // 
            labelBackgroud.Anchor = AnchorStyles.Right;
            labelBackgroud.AutoSize = true;
            labelBackgroud.Location = new Point(21, 85);
            labelBackgroud.Margin = new Padding(2, 0, 2, 0);
            labelBackgroud.Name = "labelBackgroud";
            labelBackgroud.Size = new Size(64, 15);
            labelBackgroud.TabIndex = 4;
            labelBackgroud.Text = "Backgroud";
            // 
            // panelAliveCell
            // 
            panelAliveCell.Dock = DockStyle.Fill;
            panelAliveCell.Location = new Point(89, 2);
            panelAliveCell.Margin = new Padding(2);
            panelAliveCell.Name = "panelAliveCell";
            panelAliveCell.Size = new Size(83, 33);
            panelAliveCell.TabIndex = 3;
            // 
            // panelGrid
            // 
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(89, 39);
            panelGrid.Margin = new Padding(2);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(83, 33);
            panelGrid.TabIndex = 4;
            // 
            // panelBackground
            // 
            panelBackground.Dock = DockStyle.Fill;
            panelBackground.Location = new Point(89, 76);
            panelBackground.Margin = new Padding(2);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(83, 34);
            panelBackground.TabIndex = 5;
            // 
            // buttonAliveCell
            // 
            buttonAliveCell.Dock = DockStyle.Fill;
            buttonAliveCell.Location = new Point(176, 2);
            buttonAliveCell.Margin = new Padding(2);
            buttonAliveCell.Name = "buttonAliveCell";
            buttonAliveCell.Size = new Size(83, 33);
            buttonAliveCell.TabIndex = 1;
            buttonAliveCell.Text = "Change";
            buttonAliveCell.UseVisualStyleBackColor = true;
            buttonAliveCell.Click += buttonAliveCell_Click;
            // 
            // buttonGrid
            // 
            buttonGrid.Dock = DockStyle.Fill;
            buttonGrid.Location = new Point(176, 39);
            buttonGrid.Margin = new Padding(2);
            buttonGrid.Name = "buttonGrid";
            buttonGrid.Size = new Size(83, 33);
            buttonGrid.TabIndex = 3;
            buttonGrid.Text = "Change";
            buttonGrid.UseVisualStyleBackColor = true;
            buttonGrid.Click += buttonGrid_Click;
            // 
            // buttonBackgroud
            // 
            buttonBackgroud.Dock = DockStyle.Fill;
            buttonBackgroud.Location = new Point(176, 76);
            buttonBackgroud.Margin = new Padding(2);
            buttonBackgroud.Name = "buttonBackgroud";
            buttonBackgroud.Size = new Size(83, 34);
            buttonBackgroud.TabIndex = 5;
            buttonBackgroud.Text = "Change";
            buttonBackgroud.UseVisualStyleBackColor = true;
            buttonBackgroud.Click += buttonBackgroud_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(buttonConfirm, 0, 0);
            tableLayoutPanel3.Controls.Add(buttonCancel, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(2, 118);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel3.Size = new Size(261, 26);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Anchor = AnchorStyles.Right;
            buttonConfirm.DialogResult = DialogResult.OK;
            buttonConfirm.Location = new Point(50, 3);
            buttonConfirm.Margin = new Padding(2);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(78, 20);
            buttonConfirm.TabIndex = 5;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Left;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(132, 3);
            buttonCancel.Margin = new Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(78, 20);
            buttonCancel.TabIndex = 4;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // ColorsDialog
            // 
            AcceptButton = buttonConfirm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(265, 146);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ColorsDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Colors";
            Load += ColorsDialog_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonConfirm;
        private Button buttonCancel;
        private Label labelAliveCell;
        private Label labelGrid;
        private Label labelBackgroud;
        private Panel panelAliveCell;
        private Panel panelGrid;
        private Panel panelBackground;
        private Button buttonAliveCell;
        private Button buttonGrid;
        private Button buttonBackgroud;
    }
}