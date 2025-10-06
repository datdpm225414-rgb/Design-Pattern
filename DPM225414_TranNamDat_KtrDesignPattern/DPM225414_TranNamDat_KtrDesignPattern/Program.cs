using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPM225414_TranNamDat_KtrDesignPattern;


namespace DPM225414_TranNamDat_KtrDesignPattern
{
    public class Program
    {
        static void Main()
        {
            string rootPath = @"Z:/abc"; // thư mục của bạn
            var root = FileSystemBuilder.Build(rootPath);

            var sizeVisitor = new SizeVisitor();
            root.Accept(sizeVisitor);

            Console.WriteLine($"Tong dung luong thu muc: {sizeVisitor.TotalSize / 1024.0:F2} KB");
        }
    }
}
