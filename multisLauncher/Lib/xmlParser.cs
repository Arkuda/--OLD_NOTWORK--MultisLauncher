using multisLauncher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace multisLib
{

    class xmlParser
    {













        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //! IT"S OLD FILE TO PARSE FTB XML - IT"S NOT WORKING KOMING SOOON !
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!















        private ModPack mp;

        public ModPack parseModpack(string xml, LogWindow console, int i)
        {

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);


            //public ModPack(String name, String author, String version, String logo, String url,
            //String image, String dir, String mcVersion, String serverUrl, String info, String mods,
            //String oldVersions, String xml)

            
           // try
           // {

            

             
                bool isFTBModPack = true;

                XmlNode xl =  doc.GetElementsByTagName("modpack")[i];

                ModPack modPack = new ModPack(
                xl.Attributes["name"].Value.ToString(),
                xl.Attributes["author"].Value.ToString(),
                xl.Attributes["version"].Value.ToString(),
                xl.Attributes["logo"].Value.ToString(),
                xl.Attributes["url"].Value.ToString(),
                xl.Attributes["image"].Value.ToString(),
                xl.Attributes["dir"].Value.ToString(),
                xl.Attributes["mcVersion"].Value.ToString(),
                xl.Attributes["serverPack"].Value.ToString(),
                xl.Attributes["description"].Value.ToString(),
                xl.Attributes["mods"].Value.ToString(),
                xl.Attributes["oldVersions"].Value.ToString(),
                xml,
                isFTBModPack);
 

             return modPack;
           }
         /*  catch (NullReferenceException ex)
           {
                console.printErr(ex.Message);
                Console.WriteLine(ex.Message);
                return null;
           }
        
            */

        }


    }

