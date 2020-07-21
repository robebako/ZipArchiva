using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace ZipArchiva
{
    class Program
    {
        static void Main(string[] args)
        {
            string startPath = @"C:\Users\RobertBakota\TEST";
            string zipPath = @"C:\Users\RobertBakota\TEST\zipano\result2.zip";

            ZipFile.CreateFromDirectory(startPath, zipPath);
        }
    }
}
