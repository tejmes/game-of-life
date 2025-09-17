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
    public partial class RandomFillDialog : Form
    {
        public int Density => (int)numericUpDownDensity.Value;
        public bool SeedChecked => checkBoxSeed.Checked;
        public int? Seed => SeedChecked ? (int?)numericUpDownSeed.Value : null;
        public bool TargetEntireMap => radioButtonEntireMap.Checked;

        private readonly Random rnd = new Random();

        public RandomFillDialog()
        {
            InitializeComponent();
            numericUpDownSeed.Maximum = int.MaxValue;
        }

        private void RandomFillDialog_Load(object sender, EventArgs e)
        {
            checkBoxSeed.Checked = false;
            numericUpDownSeed.Enabled = false;
            buttonSeed.Enabled = false;
        }

        private void checkBoxSeed_CheckedChanged(object sender, EventArgs e)
        {
            bool on = checkBoxSeed.Checked;
            numericUpDownSeed.Enabled = on;
            buttonSeed.Enabled = on;
        }

        private void buttonSeed_Click(object sender, EventArgs e)
        {
            numericUpDownSeed.Value = rnd.Next(0, int.MaxValue);
        }
    }
}
