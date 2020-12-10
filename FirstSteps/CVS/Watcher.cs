using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CVS
{
    public class Watcher
    {
        public DataKeeper dataKeeper;
        public Logger logger;

        public string _path;


        public Watcher(string path)
        {
            _path = path;
            dataKeeper = new DataKeeper(path);
            logger = new Logger(path);
        }


        public void Start()
        {
            using (FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = _path;

                watcher.NotifyFilter = NotifyFilters.LastAccess
                                     | NotifyFilters.LastWrite
                                     | NotifyFilters.FileName
                                     | NotifyFilters.DirectoryName;

                watcher.Filter = "*.txt";

                watcher.Changed += OnChanged;
                watcher.Created += OnChanged;
                watcher.Deleted += OnChanged;
                watcher.Renamed += OnRenamed;

                watcher.IncludeSubdirectories = true;
                watcher.EnableRaisingEvents = true;

                Console.WriteLine("Press 'x' to save state and stop.");
                while (Console.Read() != 'x') ;
            }

            Console.Clear();
            Console.WriteLine("Saving state...");
            Thread.Sleep(TimeSpan.FromSeconds(1));


            dataKeeper.AddNewSnapShot();
            dataKeeper.SaveHistory();
            logger.SaveLog();

            Console.Clear();
            Console.WriteLine("State saved!");
            Thread.Sleep(TimeSpan.FromSeconds(1));
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            var message = $"File: {e.FullPath} {e.ChangeType}";

            Console.WriteLine(message);
            logger.AddLog(message);
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {
            var message = $"File: {e.OldFullPath} renamed to {e.FullPath}";

            Console.WriteLine(message);
            logger.AddLog(message);
        }

    }
}
