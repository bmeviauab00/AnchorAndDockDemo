using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnchorAndDockDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bAnchorDemo_Click(object sender, EventArgs e)
        {
            var f = new AnchorDemoForm();
            f.ShowDialog();
        }

        private void bDockDemo_Click(object sender, EventArgs e)
        {
            var f = new DockDemoForm();
            f.ShowDialog();

        }
    }
}
