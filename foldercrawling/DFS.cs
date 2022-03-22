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
        //create a form 
        public System.Windows.Forms.Form form = new System.Windows.Forms.Form();
        //create a viewer object 
        public Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        //create a graph object 
        public Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");

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


            //create the graph content
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
                        graph.AddEdge(Path.GetFullPath(path), Path.GetFullPath(file)).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                        graph.FindNode(file).Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
                        graph.FindNode(file).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;

                    }
                    else
                    {
                        Console.WriteLine(Path.GetFullPath(file) + " KETEMU JEMBUOTTTTTTT");
                        graph.AddEdge(Path.GetFullPath(path), Path.GetFullPath(file)).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                        graph.FindNode(file).Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
                        graph.FindNode(file).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
                        graph.FindNode(file).Label.Text = new DirectoryInfo(file).Name;
                        continue;
                    }
                }
                else
                {
                    graph.AddEdge(Path.GetFullPath(path), Path.GetFullPath(file));

                    Console.WriteLine(file);
                }
                graph.FindNode(path).Label.Text = new DirectoryInfo(path).Name;
                graph.FindNode(file).Label.Text = new DirectoryInfo(file).Name;
            }

            string[] folder = Directory.GetDirectories(path);

            foreach (string subfolder in folder)
            {
                if (found == false)
                {
                    Console.WriteLine(subfolder);

                    visited.Enqueue(new folderfile(path, subfolder));
                    graph.AddEdge(Path.GetFullPath(path), Path.GetFullPath(subfolder));
                    graph.FindNode(path).Label.Text = new DirectoryInfo(path).Name;
                    graph.FindNode(subfolder).Label.Text = new DirectoryInfo(subfolder).Name;
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


        public void show_graf_BFS()
        {
            bool ada = false;
            foreach (folderfile cek in penyimpanan)
            {

                FileAttributes attr = File.GetAttributes(cek.anakfolder);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    graph.AddEdge(Path.GetFullPath(cek.parent), Path.GetFullPath(cek.anakfolder));
                }
                else
                {
                    if (Path.GetFileName(cek.anakfolder) == namafile)
                    {
                        if (kemungkinan == "N" && ada == false)
                        {
                            ada = true;
                            graph.AddEdge(cek.parent, cek.anakfolder).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                            graph.FindNode(cek.anakfolder).Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
                            graph.FindNode(cek.anakfolder).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
                            graph.FindNode(cek.anakfolder).Label.Text = new DirectoryInfo(cek.anakfolder).Name;
                            break;

                        }
                        else
                        {
                            graph.AddEdge(cek.parent, cek.anakfolder).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                            graph.FindNode(cek.anakfolder).Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
                            graph.FindNode(cek.anakfolder).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
                            graph.FindNode(cek.anakfolder).Label.Text = new DirectoryInfo(cek.anakfolder).Name;
                            continue;
                        }
                    }
                    else
                    {
                        graph.AddEdge(Path.GetFullPath(cek.parent), Path.GetFullPath(cek.anakfolder));
                    }
                }

                graph.FindNode(cek.parent).Label.Text = new DirectoryInfo(cek.parent).Name;
                graph.FindNode(cek.anakfolder).Label.Text = new DirectoryInfo(cek.anakfolder).Name;

            }
            folderfile tempo;
            while (visited.Count > 0)
            {
                tempo = new folderfile(visited.Dequeue());

                graph.AddEdge(Path.GetFullPath(tempo.parent), Path.GetFullPath(tempo.anakfolder)).Attr.Color = Microsoft.Msagl.Drawing.Color.Maroon;
                graph.FindNode(tempo.anakfolder).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Gray;
                graph.FindNode(tempo.parent).Label.Text = new DirectoryInfo(tempo.parent).Name;
                graph.FindNode(tempo.anakfolder).Label.Text = new DirectoryInfo(tempo.anakfolder).Name;

            }
            viewer.Graph = graph;
            //associate the viewer with the form 
            form.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            //show the form 
            form.ShowDialog();
        }

    }
}
