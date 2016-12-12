using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Farmacia.Gui
{
    public partial class ProductoLote : Farmacia.Gui.BaseDialog
    {
        public ProductoLote()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductoLote_Load(object sender, EventArgs e)
        {
            dgvProducto.DataSource = Data.ProductoLote.Get();
        }

        private void dgvProducto_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                Data.ProductoLote plote = ((BindingList<Data.ProductoLote>) dgvProducto.DataSource)[e.RowIndex];
                dgvDetalle.DataSource = plote.Detalle;
            }
        }
    }
}
