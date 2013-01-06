using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using multisLib;

namespace multisLauncher
{
    public partial class MultisLauncherMain : Form
    {
        public MultisLauncherMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("НИЕТ НИ ВЫХАДИ, ПАЗАЛУЙСТА, ПАИГРАЙ ИСО ЧУТОК!11");
            Application.Exit();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("by Андрей и Джигурда");
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            LoginBox lb = new LoginBox();
            lb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TESTFORM ts = new TESTFORM();
            ts.Show();
        }

    }
}
