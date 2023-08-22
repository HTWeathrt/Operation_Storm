using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Newtonsoft.Json;
using Operation_Storm.FormKD;
using static System.Console;

namespace Operation_Storm.SQL
{
    internal class SQLUpdate
    {

        private void Connection()
        {
            string Connection = "Server =127.0.0.1 ; Database = ink_aoi ; Port =3306 ;User = ami ;Password = protnc ";

            /*try
            {
                connection = new MySqlConnection(Connection);
                connection.Open();
            }
            catch
            {
                return;
            }*/
            using (MySqlConnection connectionopen = new MySqlConnection(Connection))
            {
             
                try
                {
                    connectionopen.Open();
                    if (connectionopen.State == System.Data.ConnectionState.Open)
                    {
                        MySqlCommand CommandSQL = new MySqlCommand(InsertSQLData, connectionopen);
                        CommandSQL.ExecuteNonQuery();
                        connectionopen.Close();
                    }
                }
                catch
                {
                    connectionopen.Close();
                }
            }
        }
        //MySqlConnection connection;
        string InsertSQLData;
        public void SQL_connector(string Classsif , string Qualifier ,string Panel_Spec,string ActiveH, string ActiverV, string Line , string User)
        {
            //BaseForm bsnewform = new BaseForm();
            Datetime();
            InsertSQLData = "INSERT INTO  version (pt_datetime , Classifier , Qualifier , PanelSpec , ActiveH , ActiveV, Line, User) VALUES ('" + Timer + "' , '" + Classsif + "' , '" + Qualifier + "','" + Panel_Spec + "','" + ActiveH + "','" + ActiverV + "','" + Line + "','" + User + "')";
            Connection();
            
            //string LOG_Data = $"-{Timer}-[SQL_Update_Use]-Name_Cls:{Classsif}-NameQual{Qualifier}--Line:{Line}--User{User}";
        }
        private void Database()
        {
            string FileUser = "Preference.json";
            string JsonRead = File.ReadAllText(FileUser);
            
            OpenPrefence jsonObject = JsonConvert.DeserializeObject<OpenPrefence>(JsonRead);
            string Administrator = jsonObject.User.Administrator;
        }
        public void Cls_Update_SQL(string Line , string Name , string GUID , string DefectypeID , string Scrip , string Priority, string Version,string User,string NameFile ,string Foderlink)
        {

            Datetime();
            InsertSQLData = "INSERT INTO classifier (pt_datetime , Line , Name , GUID , DefectTypeID , Script, Priority, Version , User, Name_File ,Linkfoder) VALUES ('" + Timer + "' , '" + Line + "','" + Name + "','" + GUID + "','" + DefectypeID + "','" + Scrip + "','" + Priority + "','" + Version + "','" + User + "','" + NameFile + "','" + Foderlink + "')";

            Connection();
            
            
           // string LOG_Data = $"-{Timer}-[SQL_Update_Cls_Defect]-Line:{Line}-Name_Defect{Name}--Priority:{Priority}--Foder_Link:{Foderlink}";
        }
       
        private void WriteLOG(string LOG)
        {
            
            string LOG_Patch = $"LOG\\Log.txt";
            if (!File.Exists(LOG_Patch))
            {
                File.WriteAllText(LOG_Patch, LOG);
            }
        }
        string Timer;
        private void Datetime()
        {
            Timer = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

    }
}
