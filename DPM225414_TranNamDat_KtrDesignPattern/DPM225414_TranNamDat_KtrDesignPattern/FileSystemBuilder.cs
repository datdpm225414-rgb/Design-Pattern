using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225414_TranNamDat_KtrDesignPattern
{
    public static class FileSystemBuilder
    {
        public static FileSystemComponent Build(string path)
        {
            if (File.Exists(path))
                return new FileLeaf(path);

            var folder = new FolderComposite(path);
            foreach (var file in Directory.GetFiles(path))
                folder.Add(new FileLeaf(file));

            foreach (var subDir in Directory.GetDirectories(path))
                folder.Add(Build(subDir));

            return folder;
        }
    }
}
