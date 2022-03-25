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
            public Queue<folderfile> ketemuhasil;
            public Queue<string> hasilpath;
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
                ketemuhasil = new Queue<folderfile>();
                hasilpath = new Queue<string>();
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
                        hasilpath.Enqueue(Path.GetFullPath(path));
                        cari_bapak(path);
                    
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

            public void cari_bapak(string anak)
            {
                foreach (folderfile cek in penyimpanan)
                {
                    if (cek.anakfolder == anak)
                    {
                        string bapak = cek.parent;
                        ketemuhasil.Enqueue(new folderfile(cek.parent, cek.anakfolder));
                        cari_bapak(cek.parent);
                    }
                }
            }

            public void DFS(string path)
            {
                string[] isi = Directory.GetFiles(path, "*.*");
                foreach (string file in isi)
                {
                    penyimpanan.Enqueue(new folderfile(path, file));


                    if (Path.GetFileName(file) == namafile)
                    {
                        if (kemungkinan == "N" && found == false)
                        {
                            Console.WriteLine(Path.GetFullPath(file) + " KETEMU JEMBUOTTTTTTT");
                            found = true;
                            hasilpath.Enqueue(Path.GetFullPath(file));
                            cari_bapak(file);
                        }
                        else
                        {
                            Console.WriteLine(Path.GetFullPath(file) + " KETEMU JEMBUOTTTTTTT");
                            hasilpath.Enqueue(Path.GetFullPath(file));
                            cari_bapak(file);
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

                        penyimpanan.Enqueue(new folderfile(path, subfolder));
                        DFS(subfolder);
                    }
                }
            }

            public void show_graph_DFS()
            {

                bool ada = false;
                bool jabingan;
                foreach (folderfile cek in penyimpanan)
                {
                    jabingan = false;

                    FileAttributes attr = File.GetAttributes(cek.anakfolder);
                    if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        foreach (folderfile gajetot in ketemuhasil)
                        {
                            if (Path.GetFullPath(gajetot.parent) == cek.anakfolder || Path.GetFullPath(gajetot.anakfolder) == cek.anakfolder)
                            {
                                graph.AddEdge(Path.GetFullPath(cek.parent), Path.GetFullPath(cek.anakfolder)).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                                jabingan = true;
                                break;
                            }
                        }
                        if (jabingan == false)
                        {
                            graph.AddEdge(Path.GetFullPath(cek.parent), Path.GetFullPath(cek.anakfolder)).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                            graph.FindNode(cek.anakfolder).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                        }
                    }
                    else
                    {
                        if (Path.GetFileName(cek.anakfolder) == namafile)
                        {
                            if (kemungkinan == "N" && ada == false)
                            {
                                graph.AddEdge(Path.GetFullPath(cek.parent), Path.GetFullPath(cek.anakfolder)).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                                graph.FindNode(cek.anakfolder).Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
                                graph.FindNode(cek.anakfolder).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
                                ada = true;
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
                            graph.AddEdge(Path.GetFullPath(cek.parent), Path.GetFullPath(cek.anakfolder)).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                            graph.FindNode(cek.anakfolder).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                        }
                    }

                    graph.FindNode(cek.parent).Label.Text = new DirectoryInfo(cek.parent).Name;
                    graph.FindNode(cek.anakfolder).Label.Text = new DirectoryInfo(cek.anakfolder).Name;
                }

                folderfile warnajalur;
                while (ketemuhasil.Count > 0)
                {
                    warnajalur = new folderfile(ketemuhasil.Dequeue());
                    graph.FindNode(warnajalur.parent).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;
                    graph.FindNode(warnajalur.anakfolder).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;
                    graph.FindNode(warnajalur.parent).Label.Text = new DirectoryInfo(warnajalur.parent).Name;
                    graph.FindNode(warnajalur.anakfolder).Label.Text = new DirectoryInfo(warnajalur.anakfolder).Name;

                }
                viewer.Graph = graph;
                //associate the viewer with the form 

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
                bool jabingan;
                foreach (folderfile cek in penyimpanan)
                {
                    jabingan = false;

                    FileAttributes attr = File.GetAttributes(cek.anakfolder);
                    if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                    {
                        foreach (folderfile gajetot in ketemuhasil)
                        {
                            if (Path.GetFullPath(gajetot.parent) == cek.anakfolder || Path.GetFullPath(gajetot.anakfolder) == cek.anakfolder)
                            {
                                graph.AddEdge(Path.GetFullPath(cek.parent), Path.GetFullPath(cek.anakfolder)).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                                jabingan = true;
                                break;
                            }
                        }
                        if (jabingan == false)
                        {
                            graph.AddEdge(Path.GetFullPath(cek.parent), Path.GetFullPath(cek.anakfolder)).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                            graph.FindNode(cek.anakfolder).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                        }
                    }
                    else
                    {
                        if (Path.GetFileName(cek.anakfolder) == namafile)
                        {
                            if (kemungkinan == "N" && ada == false)
                            {
                                graph.AddEdge(Path.GetFullPath(cek.parent), Path.GetFullPath(cek.anakfolder)).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                                graph.FindNode(cek.anakfolder).Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
                                graph.FindNode(cek.anakfolder).Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
                                ada = true;
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
                            graph.AddEdge(Path.GetFullPath(cek.parent), Path.GetFullPath(cek.anakfolder)).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                            graph.FindNode(cek.anakfolder).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                        }
                    }

                    graph.FindNode(cek.parent).Label.Text = new DirectoryInfo(cek.parent).Name;
                    graph.FindNode(cek.anakfolder).Label.Text = new DirectoryInfo(cek.anakfolder).Name;

                }
                folderfile tempo;
                while (visited.Count > 0)
                {
                    tempo = new folderfile(visited.Dequeue());

                    graph.AddEdge(Path.GetFullPath(tempo.parent), Path.GetFullPath(tempo.anakfolder)).Attr.Color = Microsoft.Msagl.Drawing.Color.Gray;
                    graph.FindNode(tempo.anakfolder).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Gray;
                    graph.FindNode(tempo.parent).Label.Text = new DirectoryInfo(tempo.parent).Name;
                    graph.FindNode(tempo.anakfolder).Label.Text = new DirectoryInfo(tempo.anakfolder).Name;

                }

                folderfile warnajalur;
                while (ketemuhasil.Count > 0)
                {
                    warnajalur = new folderfile(ketemuhasil.Dequeue());
                    graph.FindNode(warnajalur.parent).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;
                    graph.FindNode(warnajalur.anakfolder).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;
                    graph.FindNode(warnajalur.parent).Label.Text = new DirectoryInfo(warnajalur.parent).Name;
                    graph.FindNode(warnajalur.anakfolder).Label.Text = new DirectoryInfo(warnajalur.anakfolder).Name;

                }


                viewer.Graph = graph;

            }


        }
}
