using SingletonExample.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Not singleton realisation of file manipulation - file "File.txt"
            var fileMaster1 = new FileMaster();
            var fileMaster2 = new FileMaster();

            fileMaster1.WriteText("Hello! It's FileMaster1. ");
            fileMaster2.WriteText("Hello! It's FileMaster2. ");

            fileMaster1.SaveTextToFile();
            fileMaster2.SaveTextToFile();

            // Singleton realisation of file manipulation - file "FileSingleton.txt"
            var fileMasterS1 = FileMasterSingleton.Instance;
            var fileMasterS2 = FileMasterSingleton.Instance;

            fileMasterS1.WriteText("Hello! It's FileMaster S1. ");
            fileMasterS2.WriteText("Hello! It's FileMaster S2. ");

            fileMasterS1.SaveTextToFile();
            fileMasterS2.SaveTextToFile();
        }
    }
}
