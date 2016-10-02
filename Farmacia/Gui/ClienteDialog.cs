using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Farmacia.Gui
{
    public partial class ClienteDialog : Farmacia.Gui.BaseDialog
    {
        private Data.Cliente entity;
        //Constructor para uno nuevo
        public ClienteDialog()
        {
            InitializeComponent();
            entity = new Data.Cliente();
            entity.Nombre = "";
            entity.Direccion = "";
            entity.NTelefono = "";
            entity.NCedula = "";
            Load();
        }
        //Constructor para editar
        public ClienteDialog(Data.Cliente record)
        {
            InitializeComponent();
            entity = record;
            Load();
        }

        private void Load()
        {
            txtNombre.Text = entity.Nombre;
            txtDireccion.Text = entity.Direccion;
            txtTelefono.Text = entity.NTelefono;
            txtCedula.Text = entity.NCedula;
        }

        public void Save()
        {
            entity.Nombre = txtNombre.Text;
            entity.Direccion = txtDireccion.Text;
            entity.NCedula = txtCedula.Text;
            entity.NTelefono = txtTelefono.Text;
        }

        public Data.Cliente Record
        {
            get {
                return entity;
            }
        }

    }
}
