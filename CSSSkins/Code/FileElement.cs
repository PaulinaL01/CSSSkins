using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSSkins
{
    public class FileElement
    {
        public string Filename { get; }
        public string Path { get; }

        public FileElement(string path)
        {
            Path = path;
            Filename = System.IO.Path.GetFileName(path);
        }

        public override string ToString()
        {
            return Filename;
        }
    }
}
