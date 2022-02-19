using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOFOK_System.Component
{
    public partial class widget : Component
    {
        public widget()
        {
            InitializeComponent();
        }

        public widget(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
