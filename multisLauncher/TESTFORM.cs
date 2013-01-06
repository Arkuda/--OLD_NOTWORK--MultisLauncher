using multisLauncher.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace multisLauncher
{
    public partial class TESTFORM : Form
    {
        public TESTFORM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ioWorker iow = new ioWorker();
            textBox2.Text = iow.getCrpHostLink("MagicWorld.zip");
            
        }
    }
}
