using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Farmacia.Utils;
using Epn.Data;
using System.Linq;

namespace Farmacia.Gui
{
    [Activity("Producto","pills-2.png")]
    public partial class Producto : Farmacia.Gui.Activity
    {
        private BindingList<Data.Producto> source = null;
        public Producto()
        {
            InitializeComponent();
            LoadSource();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ProductoDialog dialog = new ProductoDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dialog.Save();
                Data.Producto record = dialog.Record;
                record.IdProducto = Data.Default.Db.USPPRODUCTOINSERTAR<int>(Record.FromInstance(dialog.Record));
                source.Add(record);
                dgvProducto.Update();
                dgvProducto.Refresh();
            }
            dialog.Dispose();
        }
        private void LoadSource()
        {
            source = new BindingList<Data.Producto>(Data.Default.Db.USPPRODUCTOSELECCIONAR<RecordSet,Data.Producto>());
            dgvProducto.DataSource = source;
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dgvProducto.SelectedRows.Count > 0)
            {
                ProductoDialog dialog = new ProductoDialog(source[dgvProducto.SelectedRows[0].Index]);
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    dialog.Save();
                    dynamic record = dialog.Record;
                    Data.Default.Db.USPPRODUCTOACTUALIZAR(Record.FromInstance(dialog.Record));
                    dgvProducto.Update();
                    dgvProducto.Refresh();
                }
                dialog.Dispose();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProducto.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    Data.Producto producto = source[dgvProducto.SelectedRows[0].Index];
                    dgvProducto.Rows.Remove(dgvProducto.SelectedRows[0]);
                    Data.Default.Db.USPPRODUCTOELIMINAR(Record.FromInstance(producto));
                    source.Remove(producto);
                    dgvProducto.Update();
                    dgvProducto.Refresh();
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                string search = txtBuscar.Text.ToUpper();
                dgvProducto.DataSource = new BindingList<Data.Producto>(source.Where(m => (m.Descripcion.ToUpper().Contains(search) || m.Especificaciones.ToUpper().Contains(search) || m.Marca.ToUpper().Contains(search) || m.Categoria.ToUpper().Contains(search) || m.Nombre.ToUpper().Contains(search))).ToList());
                nuevoToolStripMenuItem.Enabled = false;
                eliminarToolStripMenuItem.Enabled = false;
            }
            else
            {
                dgvProducto.DataSource = source;
                nuevoToolStripMenuItem.Enabled = true;
                eliminarToolStripMenuItem.Enabled = true;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvProducto_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
