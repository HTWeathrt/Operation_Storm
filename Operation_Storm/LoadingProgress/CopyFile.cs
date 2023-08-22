using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Operation_Storm.FormKD;
using Operation_Storm.SQL;
using Operation_Storm.Update_Cls;

namespace Operation_Storm.LoadingProgress
{
    internal class CopyFile
    {
        public string Cls_version { get => cls_version; set => cls_version = value; }
        public string Cls_Quanlty { get => cls_Quanlty; set => cls_Quanlty = value; }

        public void CopyfileXA()
        {


            string LinkFileOpen = "Product\\IS.txt";

            BaseForm baseForm = new BaseForm();
            using (StreamReader reader = new StreamReader(LinkFileOpen))
            {
                int i = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    string[] components = line.Split(',');
                    //
                    string IP_Connect = components[0];
                    string User = components[1];
                    string Password = components[2];
                    string ShowFoder = components[3];
                    string FileOPtion = components[4];
                    string Name_DXXX = components[5];
                    string Line = components[6];
                    //
                    string FileFODER = $"\\\\{IP_Connect}\\{ShowFoder}\\{FileOPtion}\\{Name_DXXX}";
                    //
                    //
                    string FileConnect = $"\\\\{IP_Connect}\\{ShowFoder}";
                    SQLUpdate update = new SQLUpdate();
                    Cls_Update cls_update = new Cls_Update();
                    string User_Name = User_login();
                    string AXMC;
                    i++;

                    baseForm.ReportProgress(i);

                    if (File.Exists(FileFODER))
                    {
                        AXMC = File.ReadAllText(FileFODER);
                        //JObject jsonObject = JObject.Parse(jsonString);
                        Openjson classifier = JsonConvert.DeserializeObject<Openjson>(AXMC);
                        // Xuat du lieu ra 
                        cls_version = classifier.EqpRecipe.Classifier;
                        cls_Quanlty = classifier.EqpRecipe.Qualifier;
                        string panelSpec = classifier.EqpRecipe.PanelSpec;
                        string activerH = classifier.EqpRecipe.ActiveH;
                        string activerV = classifier.EqpRecipe.ActiveV;
                        //
                        cls_update.Cls_Name(cls_version, FileConnect, Line, User_Name);
                        //
                        update.SQL_connector(cls_version, cls_Quanlty, panelSpec, activerH, activerV, Line, User_Name);
                    }
                    else
                    {
                        /*Sercurity sercurity1 = new Sercurity();
                        sercurity1.User_Login(User,Password, FileConnect, Line);*/
                        update.SQL_connector("Null", "Null", "Null", "00", "00", Line, User_Name);
                    }
                }
            }
            //
        }
        private static int CouterLine(string FilePatch)
        {
            int counter = 0;
            using (StreamReader stream = new StreamReader(FilePatch))
            {
                while (stream.ReadLine() != null)
                {
                    counter++;
                }
            }
            return counter;
        }
        private static string User_login()
        {
            string FileUser = "Preference.json";
            string JsonRead = File.ReadAllText(FileUser);
            OpenPrefence jsonObject = JsonConvert.DeserializeObject<OpenPrefence>(JsonRead);
            string Administrator = jsonObject.User.Administrator;
            string VH_ID = jsonObject.User.ID_VH;
            string User_ID = "" + Administrator + "_" + VH_ID + "";
            return User_ID;

        }
        private string cls_version;
        private string cls_Quanlty;
        private void Hehe()
        {
            string filePath = "data.json";
            string jsonString = File.ReadAllText(filePath);
            // Chuyển đổi chuỗi JSON thành đối tượng JObject (Newtonsoft.Json)
            JObject jsonObject = JObject.Parse(jsonString);
            // Truy cập vào mảng "people" trong JSON
            JArray peopleArray = (JArray)jsonObject["Common"];
            // Tìm người có tên "Alice" và thay đổi giá trị của trường "age" thành 28
            foreach (JObject person in peopleArray)
            {
                if (person["Id"].ToString() == "1")
                {
                    person["LastName"] = "B";
                    break; // Khi tìm thấy người có tên "Alice", thoát vòng lặp
                }
            }
            // Chuyển đối tượng JObject thành chuỗi JSON mới đã thay đổi
            string updatedJsonString = jsonObject.ToString();
            // Ghi chuỗi JSON mới vào file
            File.WriteAllText(filePath, updatedJsonString);

        }


    }
    class Openjson
    {
        public Labomalab EqpRecipe { get; set; }
    }
    class Labomalab
    {
        public string Classifier { get; set; }
        public string Qualifier { get; set; }
        public string PanelSpec { get; set; }
        public string ActiveH { get; set; }
        public string ActiveV { get; set; }
    }
    class JsonObject
    {
        public string ClassifierFoder { get; set; }
        public string EqpRecipeFoder { get; set; }
        public string PanelSpecRecipeFoder { get; set; }
        public string Recipe { get; set; }
        public string SystemConfig { get; set; }

    }

    public class Rootobject
    {
        public User User { get; set; }
        public Sever Sever { get; set; }
        public string TimerInterval { get; set; }
        public bool Autoupdate { get; set; }
        public File_FOF[] File_FOF { get; set; }
    }

    public class User
    {
        public string Administrator { get; set; }
        public string ID_VH { get; set; }
    }

    public class Sever
    {
        public string SeverHost { get; set; }
        public Database Database { get; set; }
        public string table { get; set; }
    }

    public class Database
    {
        public string ink_aoi { get; set; }
        public string mcl_sr_aoi { get; set; }
        public string cg_aoi { get; set; }
        public string assy_aoi { get; set; }
        public string assy_ami { get; set; }
        public string lt_ami { get; set; }
    }

    public class File_FOF
    {
        public string FileFolder { get; set; }
        public string Name { get; set; }
        public string Typefile { get; set; }
    }

}
