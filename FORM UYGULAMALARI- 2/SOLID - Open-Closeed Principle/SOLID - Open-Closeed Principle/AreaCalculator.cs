using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___Open_Closeed_Principle
{
    public partial class AreaCalculator : Component
    {
        public AreaCalculator()
        {
            InitializeComponent();
        }

        public AreaCalculator(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
