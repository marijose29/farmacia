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
        private List<ActivityButton> m_Activities = new List<ActivityButton>();
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
                    m_Activities.Add(button);
                    m_Actividad.Items.Add(button);
                }
            }
        }

        private void m_Actividad_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            e.DrawBackground();
            e.DrawFocusRectangle();
            ActivityButton button = m_Actividad.Items[e.Index] as ActivityButton;
            Rectangle IconSurface = new Rectangle(e.Bounds.Location.X + 2,e.Bounds.Y + 2, 28, 28);
            e.Graphics.DrawImage(button.Icon, IconSurface);
            e.Graphics.DrawString(button.Title, m_Actividad.Font, new Pen(e.ForeColor).Brush,new PointF(IconSurface.Right,(IconSurface.Y + (e.Font.Height /4))));
        }

        private void m_Actividad_DoubleClick(object sender, EventArgs e)
        {
            if (m_Actividad.SelectedItem != null)
                (m_Actividad.SelectedItem as ActivityButton).Activate();
        }
    }
}
