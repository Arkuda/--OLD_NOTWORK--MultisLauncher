using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Web;
using System.Net;

namespace multisLib
{
    class ModPack
    {
        private string name, author, version, url, dir, mcVersion, serverUrl, logoName, imageName, info, animation, xml;
        private string[] mods, oldVersions;
        private string image, logo;
        private List<ModPack> packs = new List<ModPack>();



        

        String downloadXml(String url)
        {
            WebClient wc = new WebClient();
            return wc.DownloadData(url).ToString();
        }


        public ModPack(String name, String author, String version, String logo, String url,
            String image, String dir, String mcVersion, String serverUrl, String info, String mods,
            String oldVersions, String xml)
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
        }


        public bool isUptodate(String verFile)
        {
            if (File.Exists(verFile))
            {
                File.ReadAllLines(verFile);
                return false; // because i need vodcaaaaaaaaaaaaaaaaaaaa
            }
            else
            {
                return false;
            }
            return false;
        }



    }
}
