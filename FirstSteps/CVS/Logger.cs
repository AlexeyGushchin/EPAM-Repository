using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVS
{
    public class Logger
    {
        const string name =  @"\CVSlog.txt";
        readonly string filePath;
        readonly List<string> logs;

        public Logger(string path)
        {
            filePath = path + name;
            CreateLogFile();
            logs = new List<string>();
        }

        private void CreateLogFile()
        {
            if (File.Exists(filePath))
                return;

            File.Create(filePath).Close();
        }


        public void SaveLog()
        {
            using (var stream = new StreamWriter(filePath, true))
            {
                foreach (var i in logs)
                    stream.WriteLine(i);
            }
        }

        public void AddLog(string message)
        {
            logs.Add(message);
        }

        
    }
}
