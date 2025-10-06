using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_KtrDesignPattern
{
    public interface IVisitor
    {
        void Visit(FileLeaf file);
        void Visit(FolderComposite folder);
    }
}
