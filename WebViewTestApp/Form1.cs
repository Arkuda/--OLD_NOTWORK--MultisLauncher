using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebViewTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Document.GetElementById("logo").Click += Form1_Click;
        }

        void Form1_Click(object sender, HtmlElementEventArgs e)
        {

            MessageBox.Show("HEHEY HEY");
            throw new NotImplementedException();
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
           // MessageBox.Show(e.Url.ToString()); 
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
              //MessageBox.Show(e.Url.ToString());  
        }



        
           
        

    
    }
}
