using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //black because we are using it, otherwise gray
//input-output

namespace assignment9
{
    public class WriteFile
    {
        private StreamWriter writer;
        //if you don't make it private it will be protected, can be read by anything in the same executable
        string filepath = null;

        public WriteFile(string path) //constructor
        {
            try
            {
                filepath = path;
                writer = new StreamWriter(path, true);
                //true means it keeps adding to the file, if false it will overwrite
            }
            
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddText(string line)
        {
            writer.Write(line);
        }

        public void CloseFile()
        {
            writer.Close();
            //if you don't close the file you can't read it, it will say in use
        }

        //in classes try to avoid any direct input within class
    }//class
}//namespace
