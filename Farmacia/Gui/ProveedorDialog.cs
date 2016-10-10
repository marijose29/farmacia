using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Farmacia.Gui
{
    public partial class ProveedorDialog : Farmacia.Gui.BaseDialog
    {
        private Data.Proveedor entity;
        public ProveedorDialog()
        {
            InitializeComponent();
            entity = new Data.Proveedor();
            entity.Nombre = "";
            entity.Direccion = "";
            entity.Telefono = "";
            entity.Contacto = "";
            entity.Email = "";
            Load();
        }

        public ProveedorDialog(Data.Proveedor record)
        {
            InitializeComponent();
            entity = record;
            Load();
        }

        private void Load()
        {
            txtNombre.Text = entity.Nombre;
            txtDireccion.Text = entity.Direccion;
            txtTelefono.Text = entity.Telefono;
            txtContacto.Text = entity.Contacto;
            txtEmail.Text = entity.Email;
            
        }

        public void Save()
        {
            entity.Nombre = txtNombre.Text;
            entity.Direccion = txtDireccion.Text;
            entity.Contacto = txtContacto.Text;
            entity.Telefono = txtTelefono.Text;
            entity.Email = txtEmail.Text;
        }

        public Data.Proveedor Record
        {
            get
            {
                return entity;
            }
        }

    }
}
