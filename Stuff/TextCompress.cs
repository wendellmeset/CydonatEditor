using System;
using System.IO;
using System.IO.Compression;

namespace FileCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            string startPath = Directory.GetCurrentDirectory();
            string zipPath = Path.Combine(startPath, "CompressTemp.zip");

            ZipFile.CreateFromDirectory(startPath, zipPath, CompressionLevel.Fastest, true);
            Console.WriteLine("Compression complete!");
        }
    }
}
