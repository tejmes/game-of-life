using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife.Dialogs
{
    public partial class ColorsDialog : Form
    {
        public Color AliveCellColor { get; set; }
        public Color GridColor { get; set; }
        public Color BackgroundColor { get; set; }

        public ColorsDialog()
        {
            InitializeComponent();
        }

        private void ColorsDialog_Load(object sender, EventArgs e)
        {
            panelAliveCell.BackColor = AliveCellColor;
            panelGrid.BackColor = GridColor;
            panelBackground.BackColor = BackgroundColor;
        }

        private void buttonAliveCell_Click(object sender, EventArgs e)
        {
            using (var dialog = new ColorDialog())
            {
                dialog.Color = panelAliveCell.BackColor;

                if (dialog.ShowDialog() == DialogResult.OK) panelAliveCell.BackColor = dialog.Color;
            }
        }

        private void buttonGrid_Click(object sender, EventArgs e)
        {
            using (var dialog = new ColorDialog())
            {
                dialog.Color = panelGrid.BackColor;

                if (dialog.ShowDialog() == DialogResult.OK) panelGrid.BackColor = dialog.Color;
            }
        }

        private void buttonBackgroud_Click(object sender, EventArgs e)
        {
            using (var dialog = new ColorDialog())
            {
                dialog.Color = panelBackground.BackColor;

                if (dialog.ShowDialog() == DialogResult.OK) panelBackground.BackColor = dialog.Color;
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            AliveCellColor = panelAliveCell.BackColor;
            GridColor = panelGrid.BackColor;
            BackgroundColor = panelBackground.BackColor;
        }
    }
}
