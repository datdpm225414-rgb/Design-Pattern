using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_KtrDesignPattern
{
    public class FileLeaf : FileSystemComponent
    {
        public FileLeaf(string path) : base(path) { }
        public override void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
