using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.NetworkInformation;


namespace multisLauncher
{
    public partial class LoginBox : Form
    {
        public LoginBox()
        {
            InitializeComponent();
        }

        private void ExitLoginFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Ping p = new Ping();
            PingReply pr = p.Send("login.minecraft.net");

            if (pr.Status == IPStatus.Success)
            {
                MessageBox.Show("all right");
            }
            else if (pr.Status == IPStatus.TimedOut)
            {
                MessageBox.Show("timeout");
            }
            else
            {
                MessageBox.Show("You don't have acces to login servers, try later");
            }
            
            //wc.DownloadData("http://login.minecraft.net/");
           
            


          /*  StringBuilder sb = new StringBuilder();

            byte[] buf = new byte[8192];

            HttpWebRequest request = (HttpWebRequest)
            WebRequest.Create("http://yandex.ru");

            HttpWebResponse response = (HttpWebResponse)
            request.GetResponse();

            Stream resStream = response.GetResponseStream();


            string tempString = null;
            int count = 0;


            do
            {
                count = resStream.Read(buf, 0, buf.Length);

                if (count != 0)
                {
                    tempString = Encoding.ASCII.GetString(buf, 0, count);
                    sb.Append(tempString);
                }
            } while (count > 0);

            Console.WriteLine(sb.ToString());
           * 
           */
        }

        

       
    }
}
