using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Epn.Data;
using Farmacia.Utils;

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

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
