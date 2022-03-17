using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan directory : ");
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
                DFS(kemungkinan, dicari, rootPath);
            else if (metode == "2")
                BFS(kemungkinan, dicari, rootPath);

        }
        public static void DFS(string kemungkinan, string dicari, string path)
        {
            var isi = Directory.GetFiles(path, "*.*");
            foreach (string file in isi)
            {
                if (Path.GetFileName(file) == dicari)
                {
                    if (kemungkinan == "N")
                    {
                        Console.WriteLine(Path.GetFullPath(file) + " KETEMU JEMBUOTTTTTTT");
                        System.Environment.Exit(0);

                    }
                    else
                    {
                        Console.WriteLine(Path.GetFullPath(file) + " KETEMU JEMBUOTTTTTTT");
                        continue;
                    }
                }
                else
                {

                    Console.WriteLine(file);
                }
            }

            var folder = Directory.GetDirectories(path);

            foreach (string subfolder in folder)
            {
                Console.WriteLine(Path.GetFullPath(subfolder));
                DFS(kemungkinan, dicari, subfolder);

            }

        }


        public static void BFS(string kemungkinan, string dicari, string path)
        {
            Queue<DirectoryInfo> visited = new Queue<DirectoryInfo>();
            Queue<string> namafile = new Queue<string>();
            visited.Enqueue(new DirectoryInfo(path));
            while (visited.Any())
            {
                DirectoryInfo current = visited.Dequeue();
                var isi = Directory.GetFiles(current.FullName, "*.*");
                Console.WriteLine(Path.GetFullPath(current.FullName));

                DirectoryInfo[] children = current.GetDirectories();
                foreach (DirectoryInfo child in children)
                {
                    visited.Enqueue(child);
                }
                foreach (string file in isi)
                {
                    if (Path.GetFileName(file) == dicari)
                    {
                        if (kemungkinan == "N")
                        {
                            Console.WriteLine(Path.GetFullPath(file) + " KETEMU JEMBUOTTTTTTT");
                            System.Environment.Exit(0);

                        }
                        else
                        {
                            Console.WriteLine(Path.GetFullPath(file) + " KETEMU JEMBUOTTTTTTT");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine(file);
                    }
                }

            }

        }

        public static void Search(string dir, string dicari, string kemungkinan)
        {
            string[] files = Directory.GetFiles(dir);
            string[] dirs = Directory.GetDirectories(dir);

            List<string> allfiles = new List<string>();
            allfiles.AddRange(files);
            allfiles.AddRange(dirs);
            foreach (string cek in allfiles)
            {
                if (Directory.Exists(cek))
                {
                    Search(cek, dicari, kemungkinan);
                    continue;
                }


                if (Path.GetFileName(cek) == dicari)
                {
                    if (kemungkinan == "N")
                    {
                        Console.WriteLine(Path.GetFullPath(cek) + " KETEMU JEMBUOTTTTTTT");
                        System.Environment.Exit(0);

                    }
                    else
                    {
                        Console.WriteLine(Path.GetFullPath(cek) + " KETEMU JEMBUOTTTTTTT");
                        continue;
                    }
                }
                else if (Path.GetFileName(cek) != dicari)
                {
                    Console.WriteLine(cek);
                }

            }






        }
    }
}
