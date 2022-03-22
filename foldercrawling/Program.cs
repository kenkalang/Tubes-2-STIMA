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

            file baru = new file(dicari, kemungkinan);

            if (metode == "1")
            {
                baru.DFS(rootPath);
                baru.show_queue();
                baru.viewer.Graph = baru.graph;
                //associate the viewer with the form 
                baru.form.SuspendLayout();
                baru.viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                baru.form.Controls.Add(baru.viewer);
                baru.form.ResumeLayout();
                //show the form 
                baru.form.ShowDialog();
            }

            else if (metode == "2")
            {
                baru.BFS(rootPath);
                baru.show_graf_BFS();
            }


        }

    }
}
