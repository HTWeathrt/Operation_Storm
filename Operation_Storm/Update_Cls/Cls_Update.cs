using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Operation_Storm.FormKD;
using Operation_Storm.SQL;

namespace Operation_Storm.Update_Cls
{
    internal class Cls_Update
    {
        public void Cls_Name(string name_cls ,string Foder_Link,string Line , string User_Name)
        {
            
            SQLUpdate sqlupdate_x = new SQLUpdate();

            string FileSourc = $"{Foder_Link}\\ClassifierRecipe\\{name_cls}";
            if (File.Exists(FileSourc))
            {
                string AXMC = File.ReadAllText(FileSourc);
                
                //JObject jsonObject = JObject.Parse(jsonString);
                OpenFileClassifier updateflecls = JsonConvert.DeserializeObject<OpenFileClassifier>(AXMC);
                string Version = updateflecls.Version;
                foreach (var item in updateflecls.ClassifierRecipe.Rules)
                {
                    string Name = item.Name;
                    string Scrip = item.Script;
                    string Priority = item.Priority;
                    string GUID = item.GUID;
                    string DefectTypeID = item.DefectTypeID;

                    sqlupdate_x.Cls_Update_SQL(Line, Name, GUID, DefectTypeID, Scrip, Priority, Version, User_Name, name_cls, FileSourc);

                }
                //string Line ,  Name ,  GUID ,  DefectypeID ,  Scrip , int Priority,  Version, User, Foderlink)

            }


        }
        public void LinkFoder()
        {
            
        }


    }
    class OpenFileClassifier
    {
        public Openx ClassifierRecipe { get; set; }
        public string Version { get; set; }

    }
    class Openx
    {
        public List<Rulesx> Rules { get; set; }

    }
    class Rulesx
    {
        public string Priority { get; set; }
        public string Name { get; set; }
        public string GUID { get; set; }
        public string DefectTypeID { get; set; }
        public string Script { get; set; }

    }
}
