using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace multisLauncher.Lib
{
    class ioWorker
    {


        public bool isUptodate(string verFile, string version)
        {
            int icurrVer, iverFile;

            if (File.Exists(verFile))
            {
                try
                {
                    icurrVer = int.Parse(version);
                    iverFile = int.Parse(File.ReadAllText(verFile));
                }
                catch (IOException ioex)
                {
                    //showErooor
                    return false;
                }

                if (icurrVer <= iverFile)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            else
            {
                return false;
            }

        }





        public string getCrpHostLink(string filename, string modpackname)
        {
            string dateUrl = "http://www.creeperrepo.net/getdate";
            WebClient wc = new WebClient();
            string date = wc.DownloadString(dateUrl);
            MD5 md5Hash = MD5.Create();
            string hash = GetMd5Hash(md5Hash, "mcepoch1" + date);
            // "http://" + server + "/direct/FTB2/" + currentmd5 + "/" + file;

            return "http://www.creeperrepo.net/direct/FTB2/" + hash + "/" + "/modpacks/" + modpackname + "/" + filename;


            //http://www.creeperrepo.net/direct/FTB2/87dd9b7114ba62c1eca8dfbbc5567e52/modpacks%5EMagic_World%5E5%5EMagicWorld.zip

        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
