using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVS
{
    [Serializable]
    public class FileSnapShot
    {
        public string fullPath;
        public string text;

        public static string GetTextFromFile(string path)
        {
            string text;

            using(StreamReader reader = new StreamReader(path))
            {
                if (reader.Peek() == -1)
                    return "";

                text = reader.ReadToEnd();
            }

            return text;
        }
    }
}
