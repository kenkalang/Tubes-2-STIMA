using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using foldercrawling;
using pencarian;

namespace foldercrawling
{
    public partial class Form1 : Form
    {
        string rootPath;
        string dicari;
        string kemungkinan;
        bool metode;
        public Form1()
        {
            InitializeComponent();
 
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (bfsRadio.Checked)
            {
                metode = true;
            }
            if (dfsRadio.Checked)
            {
                metode = false;
            }
        }

        
        private void startButton_Click(object sender, EventArgs e)
        {
            file baru = new file(dicari, kemungkinan);
            if (metode == true)
            {
                label4.Text = kemungkinan;
                baru.DFS(rootPath);
                baru.show_graph_DFS();
            }
            else if (metode == false)
            {
                label4.Text = kemungkinan;

                baru.BFS(rootPath);
                baru.show_graf_BFS();
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                rootPath = folderBrowserDialog1.SelectedPath;
                directoryBox.Text = rootPath;
                
            }
        }

        private void boxFile_TextChanged(object sender, EventArgs e)
        {
            dicari = boxFile.Text.ToLower();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void radioYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioYes.Checked)
            {
                kemungkinan = "Y";
            }
            if (radioNo.Checked)
            {
                kemungkinan = "N";
            }
        }
    }
}
