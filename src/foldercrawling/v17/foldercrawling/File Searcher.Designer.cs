namespace foldercrawling
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.bfsRadio = new System.Windows.Forms.RadioButton();
            this.dfsRadio = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.browseButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxFile = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.directoryBox = new System.Windows.Forms.TextBox();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTaken = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select starting directory";
            // 
            // bfsRadio
            // 
            this.bfsRadio.AutoSize = true;
            this.bfsRadio.Location = new System.Drawing.Point(12, 22);
            this.bfsRadio.Margin = new System.Windows.Forms.Padding(4);
            this.bfsRadio.Name = "bfsRadio";
            this.bfsRadio.Size = new System.Drawing.Size(51, 20);
            this.bfsRadio.TabIndex = 3;
            this.bfsRadio.TabStop = true;
            this.bfsRadio.Text = "BFS";
            this.bfsRadio.UseVisualStyleBackColor = true;
            this.bfsRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dfsRadio
            // 
            this.dfsRadio.AutoSize = true;
            this.dfsRadio.Location = new System.Drawing.Point(132, 22);
            this.dfsRadio.Margin = new System.Windows.Forms.Padding(4);
            this.dfsRadio.Name = "dfsRadio";
            this.dfsRadio.Size = new System.Drawing.Size(52, 20);
            this.dfsRadio.TabIndex = 4;
            this.dfsRadio.TabStop = true;
            this.dfsRadio.Text = "DFS";
            this.dfsRadio.UseVisualStyleBackColor = true;
            this.dfsRadio.CheckedChanged += new System.EventHandler(this.dfsRadio_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(322, 270);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 28);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Search";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(322, 51);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(100, 28);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hyperlink:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Input file";
            // 
            // boxFile
            // 
            this.boxFile.Location = new System.Drawing.Point(19, 121);
            this.boxFile.Name = "boxFile";
            this.boxFile.Size = new System.Drawing.Size(280, 22);
            this.boxFile.TabIndex = 9;
            this.boxFile.TextChanged += new System.EventHandler(this.boxFile_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(487, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 348);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // directoryBox
            // 
            this.directoryBox.Location = new System.Drawing.Point(19, 54);
            this.directoryBox.Name = "directoryBox";
            this.directoryBox.Size = new System.Drawing.Size(280, 22);
            this.directoryBox.TabIndex = 12;
            this.directoryBox.TextChanged += new System.EventHandler(this.directoryBox_TextChanged);
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Location = new System.Drawing.Point(12, 20);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(49, 20);
            this.radioYes.TabIndex = 13;
            this.radioYes.TabStop = true;
            this.radioYes.Text = "Yes";
            this.radioYes.UseVisualStyleBackColor = true;
            this.radioYes.CheckedChanged += new System.EventHandler(this.radioYes_CheckedChanged);
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Location = new System.Drawing.Point(132, 21);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(43, 20);
            this.radioNo.TabIndex = 14;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "No";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioNo);
            this.groupBox1.Controls.Add(this.radioYes);
            this.groupBox1.Location = new System.Drawing.Point(19, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 54);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find all occurence";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dfsRadio);
            this.groupBox2.Controls.Add(this.bfsRadio);
            this.groupBox2.Location = new System.Drawing.Point(19, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 55);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Time taken : ";
            // 
            // labelTaken
            // 
            this.labelTaken.AutoSize = true;
            this.labelTaken.Location = new System.Drawing.Point(585, 395);
            this.labelTaken.Name = "labelTaken";
            this.labelTaken.Size = new System.Drawing.Size(0, 16);
            this.labelTaken.TabIndex = 18;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(9, 78);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(10, 16);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = ".";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(19, 330);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(403, 100);
            this.panel.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 437);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.labelTaken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.directoryBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.boxFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "File Searcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton bfsRadio;
        private System.Windows.Forms.RadioButton dfsRadio;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox directoryBox;
        private System.Windows.Forms.RadioButton radioYes;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTaken;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.FlowLayoutPanel panel;
    }
}

