using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cariDFS
{
    internal class pencarianDFS
    {
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
    }
}
