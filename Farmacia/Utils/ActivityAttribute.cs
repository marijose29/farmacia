using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farmacia.Utils
{
    public class ActivityAttribute:System.Attribute
    {
        public string IconName { get; set; }
        public string Title { get; set; }

        public ActivityAttribute(string title, string icon_name)
        {
            Title = title;
            IconName = icon_name;
        }
    }
}
