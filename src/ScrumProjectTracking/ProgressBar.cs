using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumProjectTracking
{
    public partial class ProgressBar : UserControl
    {
        
        public ProgressBar()
        {
            InitializeComponent();
        }

        public void setValue (double value)
        {
            panel1.Size = new Size((int)(value * this.Width), this.Height);

        }
    }
}
