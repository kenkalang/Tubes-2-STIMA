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
using System.Diagnostics;

namespace foldercrawling
{
    public partial class Form1 : Form
    {
        string rootPath;
        string dicari;
        string kemungkinan;
        bool metode;
        Stopwatch durasi = new Stopwatch();
        List<string> list = new List<string>(); 

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
            if (isiMethod == false)
            {
                MessageBox.Show("Isi method!");
                return;
            }
            if (!isiKemungkinan)
            {
                MessageBox.Show("Isi occurence!");
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
                panel1.Controls.Clear();
                durasi.Start();
                baru.BFS(rootPath);
                durasi.Stop();
                string ExecutionTimeTaken = string.Format("Minutes :{0} Seconds :{1} Mili seconds :{2}",
                    durasi.Elapsed.Minutes, durasi.Elapsed.Seconds, durasi.Elapsed.TotalMilliseconds);
                labelTaken.Text = ExecutionTimeTaken;
                baru.show_graf_BFS();
                panel1.SuspendLayout();
                baru.viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                panel1.Controls.Add(baru.viewer);
                panel1.ResumeLayout();

                //Bikin hyperlink(s)

                foreach (var obj in baru.displayHasil())
                {
                    linkLabel1.Text = obj.ToString();
                    list.Add(obj.ToString());
                }

                int currentRow = 0;
                foreach (var link in list)
                {
                    LinkLabel linkLabel = new LinkLabel();
                    linkLabel.Text = link;
                    linkLabel.Links.Add(0, link.Length, link);
                    linkLabel.LinkClicked += OnLinkClicked;
                    panel.Controls.Add(linkLabel);
                }
                this.Controls.Add(panel);



            }
            else if (metode == false)
            {
                panel1.Controls.Clear();
                durasi.Start();
                baru.DFS(rootPath);
                durasi.Stop();
                string ExecutionTimeTaken = string.Format("Minutes :{0} Seconds :{1} Mili seconds :{2}",
                    durasi.Elapsed.Minutes, durasi.Elapsed.Seconds, durasi.Elapsed.TotalMilliseconds);
                labelTaken.Text = ExecutionTimeTaken;
                baru.show_graph_DFS();
                panel1.SuspendLayout();
                baru.viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                panel1.Controls.Add(baru.viewer);
                panel1.ResumeLayout();

                //Bikin hyperlink(s)

                foreach (var obj in baru.displayHasil())
                {
                    linkLabel1.Text = obj.ToString();
                    list.Add(obj.ToString());
                }
                
                int currentRow = 0;
                foreach (var link in list)
                {
                    LinkLabel linkLabel = new LinkLabel();
                    linkLabel.Text = link;
                    linkLabel.Links.Add(0, link.Length, link);
                    linkLabel.LinkClicked += OnLinkClicked;
                    panel.Controls.Add(linkLabel);
                }
                this.Controls.Add(panel);


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

        private void dfsRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (dfsRadio.Checked)
            {
                metode = false;
                isiMethod = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void OnLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer",linkLabel1.Text);
        }

        

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
