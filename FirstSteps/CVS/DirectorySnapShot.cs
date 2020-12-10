using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVS
{
    [Serializable]
    public class DirectorySnapShot
    {
        public string path;

        public DateTime date;

        public List<FileSnapShot> snapShots;

        public DirectorySnapShot()
        {

        }

        public DirectorySnapShot(string path)
        {
            this.path = path;
            date = DateTime.Now;
            snapShots = new List<FileSnapShot>();

            foreach (var i in Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories))
            {
                if (i == path + @"\CVSlog.txt")
                    continue;

                var file = new FileSnapShot
                {
                    fullPath = i,
                    text = FileSnapShot.GetTextFromFile(i)
                };

                snapShots.Add(file);
            }
        }
    }
}
