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

        // isi atau ga

        bool isiMethod = false;
        bool isiKemungkinan = false;
        bool isiRoot = false;
        bool isiFile = false;
        public Form1()
        {
            InitializeComponent();
 
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (bfsRadio.Checked)
            {
                metode = true;
                isiMethod = true;
            }
            if (dfsRadio.Checked)
            {
                metode = false;
                isiMethod = true;
            }
        }

        
        private void startButton_Click(object sender, EventArgs e)
        {
            file baru = new file(dicari, kemungkinan);
            if (isiMethod ==  false || isiKemungkinan == false)
            {
                MessageBox.Show("Isi method atau occurence!");
                return;
            }
            if (!isiFile)
            {
                MessageBox.Show("Tidak ada file yang dicari!");
                return;
            }
            if (!isiRoot)
            {
                MessageBox.Show("Pilih root folder!");
                return;
            }
            if (metode == true)
            {
                baru.BFS(rootPath);
                baru.show_graf_BFS();
            }
            else if (metode == false)
            {
                baru.DFS(rootPath);
                baru.show_graph_DFS();
                
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                rootPath = folderBrowserDialog1.SelectedPath;
                directoryBox.Text = rootPath;
                isiRoot = true;
                
            }
        }

        private void boxFile_TextChanged(object sender, EventArgs e)
        {
            dicari = boxFile.Text.ToLower();
            isiFile = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void radioYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioYes.Checked)
            {
                kemungkinan = "Y";
                isiKemungkinan = true;
            }
            if (radioNo.Checked)
            {
                kemungkinan = "N";
                isiKemungkinan = true;
            }
        }

        private void directoryBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
