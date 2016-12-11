using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Farmacia.Gui
{
    public partial class CompraDialog : Farmacia.Gui.BaseDialog
    {
        public CompraDialog()
        {
            InitializeComponent();
        }

        private void seleccionarButton_Click(object sender, EventArgs e)
        {
            ProductoLote dialog = new ProductoLote();
            dialog.ShowDialog();
        }
    }
}
