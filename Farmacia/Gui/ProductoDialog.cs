using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Open.Data;

namespace Farmacia.Gui
{
    public partial class ProductoDialog : Farmacia.Gui.BaseDialog
    {
        public ProductoDialog()
        {
            InitializeComponent();
        }

        private void ProductoDialog_Load(object sender, EventArgs e)
        {

        }

        private void Load(Record record)
        {
            dynamic entity = record;
            
        }
    }
}
