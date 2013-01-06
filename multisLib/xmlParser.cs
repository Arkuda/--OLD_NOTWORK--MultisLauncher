using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace multisLib
{
    class xmlParser
    {

        public ModPack parseModpack(string xml)
        {

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);


            //public ModPack(String name, String author, String version, String logo, String url,
            //String image, String dir, String mcVersion, String serverUrl, String info, String mods,
            //String oldVersions, String xml)


            ModPack mp = null;

            try
            {

                    mp = new ModPack(
                    doc.GetElementsByTagName("name").ToString(),
                    doc.GetElementsByTagName("author").ToString(),
                    doc.GetElementsByTagName("version").ToString(),
                    doc.GetElementsByTagName("logo").ToString(),
                    doc.GetElementsByTagName("url").ToString(),
                    doc.GetElementsByTagName("image").ToString(),
                    doc.GetElementsByTagName("dir").ToString(),
                    doc.GetElementsByTagName("version").ToString(),
                    doc.GetElementsByTagName("serverurl").ToString(),
                    doc.GetElementsByTagName("info").ToString(),
                    doc.GetElementsByTagName("mods").ToString(),
                    doc.GetElementsByTagName("oldVersions").ToString(),
                    xml);


            }
            catch (NullReferenceException ex)
            {
                
            }
            
            return mp;


        }


    }
}
