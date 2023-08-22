using System;
using System.IO;
using System.Windows.Forms;
using MySqlConnector;
using System.Timers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Operation_Storm.FormKD;

namespace Operation_Storm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Checklogin();
        }
        private void Checklogin()
        {

        }
        private void Succeslogin()
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                string FileUser = "Preference.json";
                if (File.Exists(FileUser))
                {
                    Update_User();
                    BaseForm form = new BaseForm();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No File Preference");
                }
            }
            else
            {
                MessageBox.Show("Pls Input Data");
            }

        }
        private void Update_User()
        {
            string FileUser = "Preference.json";
            if (File.Exists(FileUser))
            {
                try
                {
                    string jsonString = File.ReadAllText(FileUser);
                    JObject jsonObject = JObject.Parse(jsonString);
                    jsonObject["User"]["Administrator"] = textBox1.Text;
                    jsonObject["User"]["ID_VH"] = textBox2.Text;

                    string UpdateJson = jsonObject.ToString();
                    File.WriteAllText(FileUser, UpdateJson);
                }
                catch
                {
                    return;
                }
                
            }
            else
            {
                return;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        
    }
    class OpenPrefence
    {
        public OpenUser User { get; set; }

    }
    class OpenUser
    {
        public string Administrator { get; set; }
        public string ID_VH { get; set; }
    }
    class SeverUpload
    {

        public string SeverHost { get; set; }
        public Database_Upload Database { get; set; }
        public string table { get; set; }
    }
    class Database_Upload
    {
        public string ink_aoi { get; set; }
        public string mcl_sr_aoi { get; set; }
        public string cg_aoi { get; set; }
        public string assy_aoi { get; set; }
        public string assy_ami { get; set; }
        public string lt_ami { get; set; }

    }
}
