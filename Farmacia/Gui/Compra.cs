using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Farmacia.Utils;

namespace Farmacia.Gui
{
   [Activity("Compra", "notepad-2.png")]
    public partial class Compra : Farmacia.Gui.Activity
    {
        public Compra()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompraDialog dialog = new CompraDialog();
            dialog.ShowDialog();
        }
    }
}
