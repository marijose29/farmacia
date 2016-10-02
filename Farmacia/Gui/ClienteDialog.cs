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
           /* entity.Categoria = "";
            entity.Marca = "";
            entity.Nombre = "";
            entity.Descripcion = "";
            entity.Especificaciones = "";
            entity.Precio = 0.0m;*/
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
            /*cmbCategoria.DataSource = Data.Default.Db.USPCATEGORIASELECCIONAR<RecordSet>().ToDataTable();
            cmbMarca.DataSource = Data.Default.Db.USPMARCASELECCIONAR<RecordSet>().ToDataTable();
            cmbCategoria.DisplayMember = "Nombre";
            cmbMarca.DisplayMember = "Nombre";
            cmbCategoria.Text = entity.Categoria;
            cmbMarca.Text = entity.Marca;
            txtNombre.Text = entity.Nombre;
            txtDescripcion.Text = entity.Descripcion;
            txtEspecificaciones.Text = entity.Especificaciones;*/
        }

        public void Save()
        {
            /*entity.Categoria = cmbCategoria.Text;
            entity.Marca = cmbMarca.Text;
            entity.Nombre = txtNombre.Text;
            entity.Descripcion = txtDescripcion.Text;
            entity.Especificaciones = txtEspecificaciones.Text;*/
        }

        public Data.Cliente Record
        {
            get {
                return entity;
            }
        }

    }
}
