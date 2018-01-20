using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment9
{
    public class ReadFile
    {
        StreamReader reader;
        //stream of bits in memory and you are streaming them into something
        private string filepath = null;

        public ReadFile(string path)
        {
            filepath = path;
        }

        public string GetFile()
        {
            string line = null;
            try //sometimes good not to use try/catch to see where it breaks
            {
                reader = new StreamReader(filepath);
                line = reader.ReadToEnd();
            }
            catch (FileNotFoundException fnfex)
            {
                throw fnfex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return line;
        }
    }
}//namespace
