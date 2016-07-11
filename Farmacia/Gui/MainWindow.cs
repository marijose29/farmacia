using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Farmacia.Gui;

namespace Farmacia
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            //Cargar Actividades Disponibles
            Assembly assembly = Assembly.GetEntryAssembly();
            Type m_ActivityType = typeof(Activity);
            foreach(var type in assembly.GetTypes())
            {
                if (m_ActivityType.IsAssignableFrom(type) && (m_ActivityType != type))
                {
                    ActivityButton button = new ActivityButton(this, type);
                    ToolStripMenuItem item = new ToolStripMenuItem()
                    {
                        Image = button.Icon,
                        Text = button.Title,
                        Tag = button
                    };
                    item.Click += item_Click;
                    menuToolStripMenuItem.DropDownItems.Insert(menuToolStripMenuItem.DropDownItems.Count -2, item);
                }
            }
        }

        void item_Click(object sender, EventArgs e)
        {
            ActivityButton button = (sender as ToolStripMenuItem).Tag as ActivityButton;
            button.Activate();
        }


        private void m_Actividad_DoubleClick(object sender, EventArgs e)
        {
         /*   if (m_Actividad.SelectedItem != null)
                (m_Actividad.SelectedItem as ActivityButton).Activate();*/
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
