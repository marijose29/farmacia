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
    [Activity("Proveedor", "id-card-2.png")]
    public partial class Proveedor : Farmacia.Gui.Activity
    {
        private BindingList<Data.Proveedor> source = null;
        public Proveedor()
        {
            InitializeComponent();
            LoadSource();
        }

        private void LoadSource()
        {
            source = new BindingList<Data.Proveedor>(Data.Default.Db.USPPROVEEDORSELECCIONAR<RecordSet, Data.Proveedor>());
            dgvProveedor.DataSource = source;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProveedorDialog dialog = new ProveedorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dialog.Save();
                Data.Proveedor record = dialog.Record;
                record.IdProveedor = Data.Default.Db.USPPROVEEDORINSERTAR<int>(Record.FromInstance(dialog.Record));
                source.Add(record);
                dgvProveedor.Update();
                dgvProveedor.Refresh();
            }
            dialog.Dispose();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count > 0)
            {
                ProveedorDialog dialog = new ProveedorDialog(source[dgvProveedor.SelectedRows[0].Index]);
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    dialog.Save();
                    dynamic record = dialog.Record;
                    Data.Default.Db.USPPROVEEDORACTUALIZAR(Record.FromInstance(dialog.Record));
                    dgvProveedor.Update();
                    dgvProveedor.Refresh();
                }
                dialog.Dispose();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar el proveedor?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    Data.Proveedor proveedor = source[dgvProveedor.SelectedRows[0].Index];
                    dgvProveedor.Rows.Remove(dgvProveedor.SelectedRows[0]);
                    Data.Default.Db.USPPROVEEDORELIMINAR(Record.FromInstance(proveedor));
                    source.Remove(proveedor);
                    dgvProveedor.Update();
                    dgvProveedor.Refresh();
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                string search = txtBuscar.Text.ToUpper();
                dgvProveedor.DataSource = new BindingList<Data.Proveedor>(source.Where(m => (m.Nombre.ToUpper().Contains(search)|| m.Direccion.ToUpper().Contains(search) || m.Telefono.ToUpper().Contains(search) || m.Contacto.ToUpper().Contains(search))).ToList());
                nuevoToolStripMenuItem.Enabled = false;
                eliminarToolStripMenuItem.Enabled = false;
            }
            else
            {
                dgvProveedor.DataSource = source;
                nuevoToolStripMenuItem.Enabled = true;
                eliminarToolStripMenuItem.Enabled = true;
            }
        }
    }
}
