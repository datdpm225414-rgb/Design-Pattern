using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_KtrDesignPattern
{
    public abstract class FileSystemComponent
    {
        public string Path { get; set; }
        public FileSystemComponent(string path) { Path = path; }
        public abstract void Accept(IVisitor visitor);
    }
}
