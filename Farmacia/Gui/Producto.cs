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
    [Activity("Producto","pills-2.png")]
    public partial class Producto : Farmacia.Gui.Activity
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoDialog dialog = new ProductoDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
                
            }
            dialog.Dispose();
        }
    }
}
