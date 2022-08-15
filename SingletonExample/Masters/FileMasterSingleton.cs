using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample.Masters
{
    internal class FileMasterSingleton
    {
        private static Lazy<FileMasterSingleton> instance =
            new Lazy<FileMasterSingleton>(() => new FileMasterSingleton());
        public static FileMasterSingleton Instance { get { return instance.Value; } }

        public string text { get; private set; }
        public string filePath { get; private set; }

        private FileMasterSingleton()
        {
            filePath = "FileSingleton.txt";
            ReadFile();
        }

        private void ReadFile()
        {
            if(File.Exists(filePath) == false) { text = ""; return; }

            using (var reader = new StreamReader(filePath))
            {
                text = reader.ReadToEnd();
            }
        }

        public void WriteText(string _text) => text += _text;

        public void SaveTextToFile()
        {
            using (var writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(text);
            }
        }
    }
}
