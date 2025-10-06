using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_KtrDesignPattern
{
    class SizeVisitor : IVisitor
    {
        public long TotalSize { get; private set; } = 0;

        public void Visit(FileLeaf file)
        {
            var info = new FileInfo(file.Path);
            if (info.Exists)
                TotalSize += info.Length;
        }

        public void Visit(FolderComposite folder)
        {
            // Thư mục không có dung lượng trực tiếp, chỉ cộng dung lượng file con
        }
    }
}
