using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Farmacia.Utils;

namespace Farmacia.Gui
{
    public class ActivityButton
    {
        private string m_Title;
        private Image m_Icon;
        public Image Icon { get { return m_Icon; } }
        public string Title { get { return m_Title; } }

        private Type m_Type;
        private Form m_Window;
        public ActivityButton(Form window,Type type)
        {
            m_Type = type;
            m_Window = window;
            m_Icon = Image.FromFile("Icon/Default.png",false);
            m_Title = "Actividad";
            foreach (var att in type.GetCustomAttributes(typeof(ActivityAttribute), false))
            {
                var aa = att as ActivityAttribute;
                m_Icon = Image.FromFile("Icon/" + aa.IconName);
                m_Title = aa.Title;
            }
        }

        public void Activate()
        {
            foreach (var w in m_Window.MdiChildren)
            {
                if (w.GetType() == m_Type)
                {
                    w.Activate();
                    return;
                }
            }
            Activity activity = Activator.CreateInstance(m_Type) as Activity;
            activity.MdiParent = m_Window;
            activity.Show();
        }
    }
}
