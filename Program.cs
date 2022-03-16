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
            string rootPath = @"D:\Semester 4";

            Console.WriteLine("Masukkan file : ");
            string dicari = Console.ReadLine();

            Console.WriteLine("Cari semua kemungkinan? (Y/N)");
            string kemungkinan = Console.ReadLine();

            // string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            //  Console.WriteLine("Hello World!");


            var files = Directory.GetFiles(rootPath, "*.*");


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
                DFS(kemungkinan, dicari,subfolder);

            }

        }

        public static void BFS(string kemungkinan, string dicari, string path)
        {
            Queue<DirectoryInfo> visited = new Queue<DirectoryInfo>();
            visited.Enqueue(new DirectoryInfo(path));
            while (visited.Count > 0)
            {
                DirectoryInfo current = visited.Dequeue();
                Console.WriteLine(current.FullName);
                var isi = Directory.GetFiles(current.FullName, "*.*");
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

                DirectoryInfo[] children = current.GetDirectories();
                foreach (DirectoryInfo child in children)
                {
                    visited.Enqueue(child);
                }
            }

        }




    }
}
