using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using pencarian;


namespace foldercrawling
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string rootPath = @"D:\testfolder";

            Console.WriteLine("Masukkan file : ");
            string dicari = Console.ReadLine();

            Console.WriteLine("Cari semua kemungkinan? (Y/N)");
            string kemungkinan = Console.ReadLine();

            Console.WriteLine("Metode digunakan : (ketik 1 atau 2)");
            Console.WriteLine("1. DFS ");
            Console.WriteLine("2. BFS ");
            string metode = Console.ReadLine();
            // string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            //  Console.WriteLine("Hello World!");

            var files = Directory.GetFiles(rootPath, "*.*");

            file baru = new file(dicari, kemungkinan);

            Queue<string> pencarian = new Queue<string>();

            if (metode == "1")
                baru.DFS(rootPath);
            else if (metode == "2")
                baru.BFS(rootPath);


        }

    }
}
