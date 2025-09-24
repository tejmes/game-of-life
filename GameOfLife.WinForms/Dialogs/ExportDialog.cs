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
    public partial class ExportDialog : Form
    {
        public bool EntireMap => radioButtonEntireMap.Checked;
        public bool Image => radioButtonImage.Checked;

        public ExportDialog()
        {
            InitializeComponent();
        }
    }
}
