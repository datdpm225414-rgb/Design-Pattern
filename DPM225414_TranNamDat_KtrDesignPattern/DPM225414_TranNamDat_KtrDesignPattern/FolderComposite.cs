using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_KtrDesignPattern
{
    public class FolderComposite : FileSystemComponent
    {
        public List<FileSystemComponent> Children = new();
        public FolderComposite(string path) : base(path) { }

        public void Add(FileSystemComponent component) => Children.Add(component);

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var child in Children)
                child.Accept(visitor);
        }
    }
}
