using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace CVS
{
    public class Restorer
    {
        readonly DataKeeper dataKeeper;
        public Logger logger;
        public string _path;

        public List<DirectorySnapShot> history;

        public Restorer(string path)
        {
            dataKeeper = new DataKeeper(path);
            logger = new Logger(path);
            _path = path;
            history = dataKeeper.history;
        }

        public void Restore()
        {
            if (history.Count == 0)
            {
                Console.WriteLine("History not found!");
                Thread.Sleep(TimeSpan.FromSeconds(2));
                return;
            }

            while (true)
            {
                Console.Clear();
                int counter = 0;

                Console.WriteLine("Choose state for recovering:"  + Environment.NewLine);

                foreach (var i in history)
                {
                    Console.WriteLine(++counter + " - " + i.date);
                }

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice >=0 && choice <= history.Count)
                    {
                        Console.Clear();
                        Console.WriteLine("Recovering...");
                        RestoreDirectoryState(history[choice - 1]);
                        logger.AddLog("Directory recovered to " + history[choice - 1].date);
                        logger.SaveLog();
                        break;
                    }
                }

                Console.WriteLine("Wrong input!");
                Thread.Sleep(TimeSpan.FromMilliseconds(500));
            }
            
        }
        public static void RestoreDirectoryState(DirectorySnapShot snapShot)
        {
            var path = snapShot.path;

            DeleteAllFiles(path, "*.txt");

            DeleteEmptyDerictories(path);

            foreach (var i in snapShot.snapShots)
            {
                try
                {
                    File.Create(i.fullPath).Close();

                    using (StreamWriter writer = new StreamWriter(i.fullPath))
                    {
                        writer.Write(i.text);
                    }
                }
                catch
                {
                    Console.WriteLine($"File recovery error ({i.fullPath})");
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                }
                
            }
            
            
        }

        private static void DeleteEmptyDerictories(string path)
        {
            foreach (var i in Directory.GetDirectories(path, "*", SearchOption.AllDirectories))
            {

                try
                {
                    if (Directory.GetFileSystemEntries(i).Length == 0)
                        Directory.Delete(i);
                }
                catch
                {
                    continue;
                }
            }
        }

        private static void DeleteAllFiles(string path, string searchPattern)
        {
            foreach (var i in Directory.GetFiles(path, searchPattern, SearchOption.AllDirectories))
            {
                if (i == path + @"\CVSlog.txt")
                    continue;

                try
                {
                    File.Delete(i);
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
