namespace GameOfLife.WinForms
{
    partial class GameOfLifeForm
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
            components = new System.ComponentModel.Container();
            pictureBox = new PictureBox();
            buttonStart = new Button();
            buttonPause = new Button();
            timer = new System.Windows.Forms.Timer(components);
            buttonStep = new Button();
            statusStrip = new StatusStrip();
            toolStripStatusLabelGeneration = new ToolStripStatusLabel();
            toolStripStatusLabelAliveCells = new ToolStripStatusLabel();
            tableLayoutPanelWhole = new TableLayoutPanel();
            tableLayoutPanelControlls = new TableLayoutPanel();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            mapToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            resizeToolStripMenuItem = new ToolStripMenuItem();
            randomFillToolStripMenuItem = new ToolStripMenuItem();
            wrappedEdgesToolStripMenuItem = new ToolStripMenuItem();
            simulationToolStripMenuItem = new ToolStripMenuItem();
            startToolStripMenuItem = new ToolStripMenuItem();
            pauseToolStripMenuItem = new ToolStripMenuItem();
            stepToolStripMenuItem = new ToolStripMenuItem();
            stepNToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            speedToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            zoomsToolStripMenuItem = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            defaultZoomtoolStripMenuItem = new ToolStripMenuItem();
            colorsToolStripMenuItem = new ToolStripMenuItem();
            gridToolStripMenuItem = new ToolStripMenuItem();
            centerOnResizeToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            statusStrip.SuspendLayout();
            tableLayoutPanelWhole.SuspendLayout();
            tableLayoutPanelControlls.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(699, 409);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.MouseUp += pictureBox_MouseUp;
            pictureBox.Resize += pictureBox_Resize;
            // 
            // buttonStart
            // 
            buttonStart.Dock = DockStyle.Fill;
            buttonStart.Location = new Point(3, 3);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(67, 130);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonPause
            // 
            buttonPause.Dock = DockStyle.Fill;
            buttonPause.Location = new Point(3, 139);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new Size(67, 130);
            buttonPause.TabIndex = 2;
            buttonPause.Text = "Pause";
            buttonPause.UseVisualStyleBackColor = true;
            buttonPause.Click += buttonPause_Click;
            // 
            // timer
            // 
            timer.Interval = 300;
            timer.Tick += timer_Tick;
            // 
            // buttonStep
            // 
            buttonStep.Dock = DockStyle.Fill;
            buttonStep.Location = new Point(3, 275);
            buttonStep.Name = "buttonStep";
            buttonStep.Size = new Size(67, 131);
            buttonStep.TabIndex = 3;
            buttonStep.Text = "Step";
            buttonStep.UseVisualStyleBackColor = true;
            buttonStep.Click += buttonStep_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelGeneration, toolStripStatusLabelAliveCells });
            statusStrip.Location = new Point(0, 439);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(784, 22);
            statusStrip.TabIndex = 4;
            statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabelGeneration
            // 
            toolStripStatusLabelGeneration.Name = "toolStripStatusLabelGeneration";
            toolStripStatusLabelGeneration.Size = new Size(65, 17);
            toolStripStatusLabelGeneration.Text = "Generation";
            // 
            // toolStripStatusLabelAliveCells
            // 
            toolStripStatusLabelAliveCells.Name = "toolStripStatusLabelAliveCells";
            toolStripStatusLabelAliveCells.Size = new Size(33, 17);
            toolStripStatusLabelAliveCells.Text = "Alive";
            // 
            // tableLayoutPanelWhole
            // 
            tableLayoutPanelWhole.ColumnCount = 2;
            tableLayoutPanelWhole.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanelWhole.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanelWhole.Controls.Add(pictureBox, 0, 0);
            tableLayoutPanelWhole.Controls.Add(tableLayoutPanelControlls, 1, 0);
            tableLayoutPanelWhole.Dock = DockStyle.Fill;
            tableLayoutPanelWhole.Location = new Point(0, 24);
            tableLayoutPanelWhole.Name = "tableLayoutPanelWhole";
            tableLayoutPanelWhole.RowCount = 1;
            tableLayoutPanelWhole.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelWhole.Size = new Size(784, 415);
            tableLayoutPanelWhole.TabIndex = 7;
            // 
            // tableLayoutPanelControlls
            // 
            tableLayoutPanelControlls.ColumnCount = 1;
            tableLayoutPanelControlls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelControlls.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelControlls.Controls.Add(buttonStep, 0, 2);
            tableLayoutPanelControlls.Controls.Add(buttonPause, 0, 1);
            tableLayoutPanelControlls.Controls.Add(buttonStart, 0, 0);
            tableLayoutPanelControlls.Dock = DockStyle.Fill;
            tableLayoutPanelControlls.Location = new Point(708, 3);
            tableLayoutPanelControlls.Name = "tableLayoutPanelControlls";
            tableLayoutPanelControlls.RowCount = 3;
            tableLayoutPanelControlls.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelControlls.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelControlls.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelControlls.Size = new Size(73, 409);
            tableLayoutPanelControlls.TabIndex = 6;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, mapToolStripMenuItem, simulationToolStripMenuItem, viewToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(4, 1, 0, 1);
            menuStrip.Size = new Size(784, 24);
            menuStrip.TabIndex = 8;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 22);
            fileToolStripMenuItem.Text = "&File";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            importToolStripMenuItem.Size = new Size(180, 22);
            importToolStripMenuItem.Text = "&Import...";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            exportToolStripMenuItem.Size = new Size(180, 22);
            exportToolStripMenuItem.Text = "&Export...";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // mapToolStripMenuItem
            // 
            mapToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearToolStripMenuItem, resizeToolStripMenuItem, randomFillToolStripMenuItem, wrappedEdgesToolStripMenuItem });
            mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            mapToolStripMenuItem.Size = new Size(43, 22);
            mapToolStripMenuItem.Text = "&Map";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            clearToolStripMenuItem.Size = new Size(201, 22);
            clearToolStripMenuItem.Text = "&Clear...";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // resizeToolStripMenuItem
            // 
            resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            resizeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            resizeToolStripMenuItem.Size = new Size(201, 22);
            resizeToolStripMenuItem.Text = "&Resize...";
            resizeToolStripMenuItem.Click += resizeToolStripMenuItem_Click;
            // 
            // randomFillToolStripMenuItem
            // 
            randomFillToolStripMenuItem.Name = "randomFillToolStripMenuItem";
            randomFillToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            randomFillToolStripMenuItem.Size = new Size(201, 22);
            randomFillToolStripMenuItem.Text = "Random &Fill...";
            randomFillToolStripMenuItem.Click += randomFillToolStripMenuItem_Click;
            // 
            // wrappedEdgesToolStripMenuItem
            // 
            wrappedEdgesToolStripMenuItem.Checked = true;
            wrappedEdgesToolStripMenuItem.CheckOnClick = true;
            wrappedEdgesToolStripMenuItem.CheckState = CheckState.Checked;
            wrappedEdgesToolStripMenuItem.Name = "wrappedEdgesToolStripMenuItem";
            wrappedEdgesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.W;
            wrappedEdgesToolStripMenuItem.Size = new Size(201, 22);
            wrappedEdgesToolStripMenuItem.Text = "&Wrapped Edges";
            wrappedEdgesToolStripMenuItem.Click += wrappedEdgesToolStripMenuItem_Click;
            // 
            // simulationToolStripMenuItem
            // 
            simulationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startToolStripMenuItem, pauseToolStripMenuItem, stepToolStripMenuItem, stepNToolStripMenuItem, toolStripSeparator2, speedToolStripMenuItem });
            simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            simulationToolStripMenuItem.Size = new Size(76, 22);
            simulationToolStripMenuItem.Text = "&Simulation";
            // 
            // startToolStripMenuItem
            // 
            startToolStripMenuItem.Name = "startToolStripMenuItem";
            startToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Space;
            startToolStripMenuItem.Size = new Size(187, 22);
            startToolStripMenuItem.Text = "&Start";
            startToolStripMenuItem.Click += startToolStripMenuItem_Click;
            // 
            // pauseToolStripMenuItem
            // 
            pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            pauseToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            pauseToolStripMenuItem.Size = new Size(187, 22);
            pauseToolStripMenuItem.Text = "&Pause";
            pauseToolStripMenuItem.Click += pauseToolStripMenuItem_Click;
            // 
            // stepToolStripMenuItem
            // 
            stepToolStripMenuItem.Name = "stepToolStripMenuItem";
            stepToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            stepToolStripMenuItem.Size = new Size(187, 22);
            stepToolStripMenuItem.Text = "&Step";
            stepToolStripMenuItem.Click += stepToolStripMenuItem_Click;
            // 
            // stepNToolStripMenuItem
            // 
            stepNToolStripMenuItem.Name = "stepNToolStripMenuItem";
            stepNToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            stepNToolStripMenuItem.Size = new Size(187, 22);
            stepNToolStripMenuItem.Text = "Step × &N...";
            stepNToolStripMenuItem.Click += stepNToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(184, 6);
            // 
            // speedToolStripMenuItem
            // 
            speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            speedToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            speedToolStripMenuItem.Size = new Size(187, 22);
            speedToolStripMenuItem.Text = "&Speed...";
            speedToolStripMenuItem.Click += speedToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomsToolStripMenuItem, colorsToolStripMenuItem, gridToolStripMenuItem, centerOnResizeToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 22);
            viewToolStripMenuItem.Text = "&View";
            // 
            // zoomsToolStripMenuItem
            // 
            zoomsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem, defaultZoomtoolStripMenuItem });
            zoomsToolStripMenuItem.Name = "zoomsToolStripMenuItem";
            zoomsToolStripMenuItem.Size = new Size(234, 22);
            zoomsToolStripMenuItem.Text = "&Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Up;
            zoomInToolStripMenuItem.Size = new Size(194, 22);
            zoomInToolStripMenuItem.Text = "Zoom &In";
            zoomInToolStripMenuItem.Click += zoomInToolStripMenuItem_Click;
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Down;
            zoomOutToolStripMenuItem.Size = new Size(194, 22);
            zoomOutToolStripMenuItem.Text = "Zoom &Out";
            zoomOutToolStripMenuItem.Click += zoomOutToolStripMenuItem_Click;
            // 
            // defaultZoomtoolStripMenuItem
            // 
            defaultZoomtoolStripMenuItem.Name = "defaultZoomtoolStripMenuItem";
            defaultZoomtoolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            defaultZoomtoolStripMenuItem.Size = new Size(194, 22);
            defaultZoomtoolStripMenuItem.Text = "&Default";
            defaultZoomtoolStripMenuItem.Click += defaultZoomtoolStripMenuItem_Click;
            // 
            // colorsToolStripMenuItem
            // 
            colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            colorsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.C;
            colorsToolStripMenuItem.Size = new Size(234, 22);
            colorsToolStripMenuItem.Text = "&Colors...";
            colorsToolStripMenuItem.Click += colorsToolStripMenuItem_Click;
            // 
            // gridToolStripMenuItem
            // 
            gridToolStripMenuItem.Checked = true;
            gridToolStripMenuItem.CheckOnClick = true;
            gridToolStripMenuItem.CheckState = CheckState.Checked;
            gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            gridToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.G;
            gridToolStripMenuItem.Size = new Size(234, 22);
            gridToolStripMenuItem.Text = "&Grid";
            gridToolStripMenuItem.Click += gridToolStripMenuItem_Click;
            // 
            // centerOnResizeToolStripMenuItem
            // 
            centerOnResizeToolStripMenuItem.Checked = true;
            centerOnResizeToolStripMenuItem.CheckOnClick = true;
            centerOnResizeToolStripMenuItem.CheckState = CheckState.Checked;
            centerOnResizeToolStripMenuItem.Name = "centerOnResizeToolStripMenuItem";
            centerOnResizeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.R;
            centerOnResizeToolStripMenuItem.Size = new Size(234, 22);
            centerOnResizeToolStripMenuItem.Text = "Center on &Resize";
            centerOnResizeToolStripMenuItem.Click += centerOnResizeToolStripMenuItem_Click;
            // 
            // GameOfLifeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(tableLayoutPanelWhole);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            KeyPreview = true;
            MainMenuStrip = menuStrip;
            Name = "GameOfLifeForm";
            Text = "Game of Life";
            Load += GameOfLifeForm_Load;
            MouseWheel += GameOfLifeForm_MouseWheel;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            tableLayoutPanelWhole.ResumeLayout(false);
            tableLayoutPanelWhole.PerformLayout();
            tableLayoutPanelControlls.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Button buttonStart;
        private Button buttonPause;
        private System.Windows.Forms.Timer timer;
        private Button buttonStep;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabelGeneration;
        private ToolStripStatusLabel toolStripStatusLabelAliveCells;
        private TableLayoutPanel tableLayoutPanelWhole;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem mapToolStripMenuItem;
        private ToolStripMenuItem resizeToolStripMenuItem;
        private ToolStripMenuItem wrappedEdgesToolStripMenuItem;
        private ToolStripMenuItem randomFillToolStripMenuItem;
        private ToolStripMenuItem simulationToolStripMenuItem;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem pauseToolStripMenuItem;
        private ToolStripMenuItem stepToolStripMenuItem;
        private ToolStripMenuItem stepNToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem zoomsToolStripMenuItem;
        private ToolStripMenuItem gridToolStripMenuItem;
        private ToolStripMenuItem colorsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem defaultZoomtoolStripMenuItem;
        private ToolStripMenuItem centerOnResizeToolStripMenuItem;
        private ToolStripMenuItem speedToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanelControlls;
    }
}
