using multisLauncher.Lib;
using multisLib;
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
            LogWindow consl = new LogWindow();
            consl.Show();

            consl.printMsg("Hello - it's a message");
            

        }
    }
}
