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
    public partial class ResizeDialog : Form
    {
        public int NewWidth
        {
            get => (int)numericUpDownWidth.Value;
            set => numericUpDownWidth.Value = value;
        }

        public int NewHeight
        {
            get => (int)numericUpDownHeight.Value;
            set => numericUpDownHeight.Value = value;
        }

        public ResizeDialog()
        {
            InitializeComponent();
        }
    }
}
