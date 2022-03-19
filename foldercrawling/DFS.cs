using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pencarian
{

    class folderfile
    {
        public string parent;
        public string anakfolder;

        public folderfile()
        {
            parent = "";
            anakfolder = "";
        }

        public folderfile(string parent, string anakfolder)
        {
            this.parent = parent;
            this.anakfolder = anakfolder;
        }

        public folderfile(folderfile fol)
        {
            parent = fol.parent;
            anakfolder = fol.anakfolder;
        }
    }
    class file : folderfile
    {
        public string namafile { get; set; } = string.Empty;
        public string kemungkinan;
        public bool found;
        public Stack<folderfile> fileDFS;
        public Queue<folderfile> visited;
        public Queue<folderfile> penyimpanan;

        public file(string nama, string kemungkinan)
        {
            namafile = nama;
            found = false;
            this.kemungkinan = kemungkinan;
            visited = new Queue<folderfile>();
            penyimpanan = new Queue<folderfile>();
            fileDFS = new Stack<folderfile>();
        }

        public void BFS(string path)
        {
            FileAttributes attr = File.GetAttributes(path);

            //detect whether its a directory or file
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                string[] children = Directory.GetDirectories(path);
                foreach (var child in children)
                {
                    visited.Enqueue(new folderfile(path, child));
                    penyimpanan.Enqueue(new folderfile(path, child));
                }
                string[] childrenfile = Directory.GetFiles(path);
                foreach (var child in childrenfile)
                {
                    visited.Enqueue(new folderfile(path, child));
                    penyimpanan.Enqueue(new folderfile(path, child));
                }
                Console.WriteLine(path);

            }

            else
            {
                if (Path.GetFileName(path) == namafile)
                {
                    if (kemungkinan == "N" && found == false)
                    {
                        Console.WriteLine(Path.GetFullPath(path) + " KETEMU JEMBUOTTTTTTT");
                        found = true;
                    }
                    else
                    {
                        Console.WriteLine(Path.GetFullPath(path) + " KETEMU JEMBUOTTTTTTT");
                    }
                }
                else
                {
                    Console.WriteLine(path);
                }
            }
            while (visited.Any() && found == false)
            {
                folderfile baru = visited.Dequeue();
                string foldernext = baru.anakfolder;
                BFS(foldernext);
            }

        }

        public void DFS(string path)
        {
            string[] isi = Directory.GetFiles(path, "*.*");
            foreach (string file in isi)
            {
                visited.Enqueue(new folderfile(path, file));
                if (Path.GetFileName(file) == namafile)
                {
                    if (kemungkinan == "N" && found == false)
                    {
                        Console.WriteLine(Path.GetFullPath(file) + " KETEMU JEMBUOTTTTTTT");
                        found = true;

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

            string[] folder = Directory.GetDirectories(path);

            foreach (string subfolder in folder)
            {
                if (found == false)
                {
                    Console.WriteLine(subfolder);
                    visited.Enqueue(new folderfile(path, subfolder));

                    DFS(subfolder);
                }
            }
        }


        public void show_queue()
        {
            folderfile tempo;
            while (penyimpanan.Count > 0)
            {
                tempo = new folderfile(penyimpanan.Dequeue());

                Console.WriteLine(tempo.anakfolder + "       INI SISA QUEUE QUEUEUEUEUEUEUEUEUU");
            }
        }

        public void show_stack()
        {
            folderfile tempo;
            while (visited.Count > 0)
            {
                tempo = new folderfile(fileDFS.Pop());

                Console.WriteLine(tempo.anakfolder + "       INI SISA QUEUE QUEUEUEUEUEUEUEUEUU");
            }
        }

    }
}
