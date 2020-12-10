using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CVS
{
    public class DataKeeper
    {

        private const string dataFileName = @"\history.dat";

        public string directoryPath;
        public string dataFilePath;

        public List<DirectorySnapShot> history;


        public DataKeeper(string path)
        {
            directoryPath = path;
            dataFilePath = directoryPath + dataFileName;
            LoadHistory();
        }
        public void SaveHistory()
        {
            var formatter = new BinaryFormatter();

            using (var stream = new FileStream(dataFilePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, history);
            }
        }

        public void LoadHistory()
        {
            if (!File.Exists(dataFilePath))
            {
                var data = new FileInfo(dataFilePath);
                data.Create().Close();
                data.Attributes = FileAttributes.Hidden;
                history = new List<DirectorySnapShot>();
                return;
            }

            var formatter = new BinaryFormatter();

            using (var stream = new FileStream(dataFilePath, FileMode.OpenOrCreate))
            {
                if (stream.Length < 1)
                {
                    history = new List<DirectorySnapShot>();
                    return;
                }

                history = (List<DirectorySnapShot>)formatter.Deserialize(stream);
            }
        }

        
        public void UpgradeHistory(DirectorySnapShot snapShot)
        {
            history.Add(snapShot);
        }

        public void AddNewSnapShot()
        {
            history.Add(new DirectorySnapShot(directoryPath));
        }


    }
}
