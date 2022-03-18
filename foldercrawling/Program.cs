using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using cariBFS;
using cariDFS;

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
            Console.WriteLine("Pilih directory : ");
            string rootPath = @Console.ReadLine();

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

            Queue<string> pencarian = new Queue<string>();

            if (metode == "1")
                pencarianDFS.DFS(kemungkinan, dicari, rootPath);
            else if (metode == "2")
                pencarianBFS.BFS(kemungkinan, dicari, rootPath);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            

        }

    }
}
