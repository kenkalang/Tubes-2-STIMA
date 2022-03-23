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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.directoryBox = new System.Windows.Forms.TextBox();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.radioNo = new System.Windows.Forms.RadioButton();
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
            this.bfsRadio.Location = new System.Drawing.Point(19, 238);
            this.bfsRadio.Margin = new System.Windows.Forms.Padding(4);
            this.bfsRadio.Name = "bfsRadio";
            this.bfsRadio.Size = new System.Drawing.Size(54, 20);
            this.bfsRadio.TabIndex = 3;
            this.bfsRadio.TabStop = true;
            this.bfsRadio.Text = "BFS";
            this.bfsRadio.UseVisualStyleBackColor = true;
            this.bfsRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dfsRadio
            // 
            this.dfsRadio.AutoSize = true;
            this.dfsRadio.Location = new System.Drawing.Point(104, 238);
            this.dfsRadio.Margin = new System.Windows.Forms.Padding(4);
            this.dfsRadio.Name = "dfsRadio";
            this.dfsRadio.Size = new System.Drawing.Size(55, 20);
            this.dfsRadio.TabIndex = 4;
            this.dfsRadio.TabStop = true;
            this.dfsRadio.Text = "DFS";
            this.dfsRadio.UseVisualStyleBackColor = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select method";
            // 
            // panel1
            // 
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
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Location = new System.Drawing.Point(19, 170);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(52, 20);
            this.radioYes.TabIndex = 13;
            this.radioYes.TabStop = true;
            this.radioYes.Text = "Yes";
            this.radioYes.UseVisualStyleBackColor = true;
            this.radioYes.CheckedChanged += new System.EventHandler(this.radioYes_CheckedChanged);
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Location = new System.Drawing.Point(104, 170);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(46, 20);
            this.radioNo.TabIndex = 14;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "No";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 372);
            this.Controls.Add(this.radioNo);
            this.Controls.Add(this.radioYes);
            this.Controls.Add(this.directoryBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.dfsRadio);
            this.Controls.Add(this.bfsRadio);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox directoryBox;
        private System.Windows.Forms.RadioButton radioYes;
        private System.Windows.Forms.RadioButton radioNo;
    }
}

