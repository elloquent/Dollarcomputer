using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dollarcomputer
{
    public partial class splashform : Form
    {
        public splashform()
        {
            InitializeComponent();
        }

        private void splashformtimer_Tick(object sender, EventArgs e)
        {
            Program.startupform.Show();
            this.Hide();
            splashformtimer.Enabled = false;
            
        }
    }
}
