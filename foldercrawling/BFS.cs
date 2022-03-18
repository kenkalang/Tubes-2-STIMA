using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cariBFS
{
    internal class pencarianBFS
    {
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
    }
}
