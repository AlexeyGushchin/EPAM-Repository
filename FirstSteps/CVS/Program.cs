using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CVS
{
    public class Program
    {

        static void Main()
        {

            Console.CursorVisible = false;
            Console.WriteLine("Welcome to the CVS!!!");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            while (true)
            {

                var mode = ApplicationModeSetter.SetMode();

                switch (mode)
                {
                    case AppMode.Restoring:
                        var pathForRestore = DirectoryExplorer.ChooseDirectory();

                        if (pathForRestore == null)
                            continue;

                        var restorer = new Restorer(pathForRestore);
                        restorer.Restore();
                        break;
                    case AppMode.Watching:
                        var pathForWatching = DirectoryExplorer.ChooseDirectory();

                        if (pathForWatching == null)
                            continue;

                        var watcher = new Watcher(pathForWatching);
                        watcher.Start();
                        break;
                }

            }

        }
    }
}
