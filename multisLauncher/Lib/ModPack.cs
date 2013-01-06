using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Web;
using System.Net;
using System.Security.Cryptography;

namespace multisLib
{
    class ModPack
    {
        private string name, author, version, url, dir, mcVersion, serverUrl, logoName, imageName, info, animation, xml;
        private string[] mods, oldVersions;
        private string image, logo;
        private List<ModPack> packs = new List<ModPack>();
        private bool isFTBMP; 



        

        public string downloadXml(String url)
        {
            WebClient wc = new WebClient();
            return wc.DownloadData(url).ToString();
        }


        public ModPack(String name, String author, String version, String logo, String url,
            String image, String dir, String mcVersion, String serverUrl, String info, String mods,
            String oldVersions, String xml, bool _isFTBMP)
        {
            this.name = name;
            this.author = author;
            this.version = version;
            this.logo = logo;
            this.url = url;
            this.image = image;
            this.dir = dir;
            this.mcVersion = mcVersion;
            this.serverUrl = serverUrl;
            this.info = info;

            if (mods.Length == 0)
            {
                this.mods = null;
            }
            else
            {
                this.mods = mods.Split(';');
            }
            

            if (oldVersions.Length == 0)
            {
                this.oldVersions = null;
            }
            else
            {
                this.oldVersions = oldVersions.Split(';');
            }
            this.xml = xml;

            this.isFTBMP = _isFTBMP;
        }


        public bool isUptodate(String verFile)
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

        public bool downloadModPack(string prefAddr)
        {
            WebClient wc = new WebClient();

            try
            {
               wc.DownloadFile(prefAddr, url);
            }
            catch (WebException wexc)
            {
                return false;
                //error message
            }



            return true;
        }

        public string getCrpHostLink(string filename)
        {
            string dateUrl = "http://www.creeperrepo.net/getdate";
            WebClient wc = new WebClient();
            string date = wc.DownloadString(dateUrl);
            MD5 md5Hash = MD5.Create();
            string hash = GetMd5Hash(md5Hash, "mcepoch1" + date);
           // "http://" + server + "/direct/FTB2/" + currentmd5 + "/" + file;

            return "http://www.creeperrepo.net/direct/FTB2/" + hash + "/" + filename;


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
