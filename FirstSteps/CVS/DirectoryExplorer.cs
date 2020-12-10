using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CVS
{
    public static class DirectoryExplorer
    {
        private static string CurrentPath { get; set; }

        private static Stack<string> PreviousPaths { get; set; }

        private static List<string> CurrentDirectories { get; set; }

        private static List<string> StartOfSearch { get; set; }


        public static void LoadExplorer()
        {
            CurrentPath = "";
            PreviousPaths = new Stack<string>();

            LoadStartPosition();
            SetStartPosition();

        }


        private static void LoadStartPosition()
        {
            var drives = DriveInfo.GetDrives();

            StartOfSearch = new List<string>(drives.Length);

            foreach (var drive in drives)
            {
                if (drive.DriveType == DriveType.Fixed || drive.DriveType == DriveType.Removable)
                    StartOfSearch.Add(drive.Name);

                else
                    continue;
            }

        }

        private static void SetStartPosition()
        {
            CurrentDirectories = new List<string>(StartOfSearch);
        }


        public static string ChooseDirectory()
        {
            LoadExplorer();

            while (true)
            {
            Start:

                Console.Clear();
                ShowCommands();
                ShowDirectories();

                var choice = Console.ReadLine();

                if (PreviousPaths.Count > 0)
                {
                    switch (choice)
                    {
                        case "c":
                            CreateNewDirectory();
                            goto Start;
                        case "t":
                            return CurrentPath;
                    }
                }

                switch (choice)
                {
                    case "x":
                        return null;
                    default:
                        if (Int32.TryParse(choice, out int directoryNum))
                        {
                            if (directoryNum == 0)
                            {
                                GoBack();
                                continue;
                            }

                            if (directoryNum >= 1 && directoryNum <= CurrentDirectories.Count)
                            {
                                MakeStep(CurrentDirectories[directoryNum - 1]);
                                continue;
                            }

                            Console.WriteLine("Wrong input!");
                            Thread.Sleep(TimeSpan.FromMilliseconds(500));
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Wrong input!");
                            Thread.Sleep(TimeSpan.FromMilliseconds(500));
                            continue;
                        }
                }
            }
        }
        private static void ShowCommands()
        {
            Console.WriteLine("x - stop search");

            if (PreviousPaths.Count > 0)
                Console.WriteLine("t - choose current directory\n" +
                                  "c - create new directory\n");

            Console.WriteLine("Enter a directory number for open!\n");

            if (PreviousPaths.Count > 0)
                Console.WriteLine("0 - return back\n");

        }


        private static void GoBack()
        {
            if (PreviousPaths.Count < 1)
            {
                Console.WriteLine("Wrong input!");
                return;
            }

            if (PreviousPaths.Count == 1)
            {
                SetStartPosition();
                PreviousPaths.Clear();
                return;
            }

            LoadPreviousDirectory(PreviousPaths.Pop());
        }

        private static void LoadPreviousDirectory(string path)
        {
            CurrentPath = path;
            CurrentDirectories.Clear();

            var directories = Directory.EnumerateDirectories(path);

            foreach (var directory in directories)
            {
                try
                {
                    var i = Directory.EnumerateDirectories(directory);
                }
                catch
                {
                    continue;
                }
                var folder = new DirectoryInfo(directory);

                if (folder.Attributes.HasFlag(FileAttributes.Hidden)
                    || folder.Attributes.HasFlag(FileAttributes.System))
                    continue;

                CurrentDirectories.Add(directory);
            }
        }

        private static void ReloadDirectories()
        {
            CurrentDirectories.Clear();

            var directories = Directory.EnumerateDirectories(CurrentPath);

            foreach (var directory in directories)
            {
                try
                {
                    var i = Directory.EnumerateDirectories(directory);
                }
                catch
                {
                    continue;
                }
                var folder = new DirectoryInfo(directory);

                if (folder.Attributes.HasFlag(FileAttributes.Hidden)
                    || folder.Attributes.HasFlag(FileAttributes.System))
                    continue;

                CurrentDirectories.Add(directory);
            }
        }

        private static void MakeStep(string path)
        {
            PreviousPaths.Push(CurrentPath);
            CurrentPath = path;

            CurrentDirectories.Clear();

            var directories = Directory.EnumerateDirectories(path);

            foreach (var directory in directories)
            {
                try
                {
                    var i = Directory.EnumerateDirectories(directory);
                }
                catch
                {
                    continue;
                }
                var folder = new DirectoryInfo(directory);

                if (folder.Attributes.HasFlag(FileAttributes.Hidden)
                    || folder.Attributes.HasFlag(FileAttributes.System))
                    continue;

                CurrentDirectories.Add(directory);
            }
        }

        private static void ShowDirectories()
        {
            int enumerator = 0;

            foreach (var i in CurrentDirectories)
                Console.WriteLine(++enumerator + " - " + i);

        }


        private static void CreateNewDirectory()
        {
            Console.WriteLine("Enter the name of the new directory:");

            var name = Console.ReadLine();

            if (Directory.Exists(CurrentPath + "\\" + name))
            {
                Console.WriteLine("A directiry with the same name already exists!");
                Thread.Sleep(TimeSpan.FromMilliseconds(500));
            }
            else
            {
                Directory.CreateDirectory(CurrentPath + "\\" + name);
                ReloadDirectories();
            }


        }
    }
}
