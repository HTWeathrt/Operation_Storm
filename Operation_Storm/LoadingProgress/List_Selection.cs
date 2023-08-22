using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation_Storm.LoadingProgress
{
    internal class List_Selection
    {
        public void LoadingFile()
        {

            string FileShowloading = "Ink\\IS.txt";

            using (StreamReader reader = new StreamReader(FileShowloading))
            {
                string line = reader.ReadLine();


            }
        }

    }
    
}
