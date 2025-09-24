using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife.WinForms.Dialogs
{
    public partial class SpeedDialog : Form
    {
        public int Speed
        {
            get => (int)numericUpDownSpeed.Value;
            set => numericUpDownSpeed.Value = value;
        }

        public SpeedDialog()
        {
            InitializeComponent();
        }
    }
}
