using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Epn.Data;
using Farmacia.Utils;
using System.Linq;

namespace Farmacia.Gui
{
    [Activity("Cliente", "users-1.png")]
    public partial class Cliente : Farmacia.Gui.Activity
    {
        private BindingList<Data.Cliente> source = null;
        public Cliente()
        {
            InitializeComponent();
            LoadSource();
        }

        private void LoadSource()
        {
            source = new BindingList<Data.Cliente>(Data.Default.Db.USPCLIENTESELECCIONAR<RecordSet, Data.Cliente>());
            dgvCliente.DataSource = source;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteDialog dialog = new ClienteDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dialog.Save();
                Data.Cliente record = dialog.Record;
                record.IdCliente = Data.Default.Db.USPCLIENTEINSERTAR<int>(Record.FromInstance(dialog.Record));
                source.Add(record);
                dgvCliente.Update();
                dgvCliente.Refresh();
            }
            dialog.Dispose();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                ClienteDialog dialog = new ClienteDialog(source[dgvCliente.SelectedRows[0].Index]);
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    dialog.Save();
                    dynamic record = dialog.Record;
                    Data.Default.Db.USPCLIENTEACTUALIZAR(Record.FromInstance(dialog.Record));
                    dgvCliente.Update();
                    dgvCliente.Refresh();
                }
                dialog.Dispose();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar el cliente?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    Data.Cliente cliente = source[dgvCliente.SelectedRows[0].Index];
                    dgvCliente.Rows.Remove(dgvCliente.SelectedRows[0]);
                    Data.Default.Db.USPCLIENTEELIMINAR(Record.FromInstance(cliente));
                    source.Remove(cliente);
                    dgvCliente.Update();
                    dgvCliente.Refresh();
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                string search = txtBuscar.Text.ToUpper();
                dgvCliente.DataSource = new BindingList<Data.Cliente>(source.Where(m => (m.Nombre.ToUpper().Contains(search)|| m.Direccion.ToUpper().Contains(search) || m.NTelefono.ToUpper().Contains(search) || m.NCedula.ToUpper().Contains(search))).ToList());
                nuevoToolStripMenuItem.Enabled = false;
                eliminarToolStripMenuItem.Enabled = false;
            }
            else
            {
                dgvCliente.DataSource = source;
                nuevoToolStripMenuItem.Enabled = true;
                eliminarToolStripMenuItem.Enabled = true;
            }
        }
    }
}
