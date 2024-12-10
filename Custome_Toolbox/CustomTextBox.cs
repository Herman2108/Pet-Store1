using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custome_Toolbox
{
    public partial class CustomTextBox : Component
    {
        public CustomTextBox()
        {
            InitializeComponent();
        }

        public CustomTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
