namespace KMeansUI
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCluster = new System.Windows.Forms.Button();
            this.numericUpDownClusters = new System.Windows.Forms.NumericUpDown();
            this.labelClusters = new System.Windows.Forms.Label();
            this.labelDots = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxDotsQuantity = new System.Windows.Forms.TextBox();
            this.loadFromFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClusters)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCluster);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDownClusters);
            this.splitContainer1.Panel2.Controls.Add(this.labelClusters);
            this.splitContainer1.Panel2.Controls.Add(this.labelDots);
            this.splitContainer1.Panel2.Controls.Add(this.buttonGenerate);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDotsQuantity);
            this.splitContainer1.Panel2.Controls.Add(this.loadFromFile);
            this.splitContainer1.Size = new System.Drawing.Size(536, 388);
            this.splitContainer1.SplitterDistance = 381;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 388);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // buttonCluster
            // 
            this.buttonCluster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCluster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCluster.Location = new System.Drawing.Point(10, 286);
            this.buttonCluster.Name = "buttonCluster";
            this.buttonCluster.Size = new System.Drawing.Size(129, 42);
            this.buttonCluster.TabIndex = 11;
            this.buttonCluster.Text = "Кластеризувати";
            this.buttonCluster.UseVisualStyleBackColor = true;
            this.buttonCluster.Click += new System.EventHandler(this.buttonCluster_Click);
            // 
            // numericUpDownClusters
            // 
            this.numericUpDownClusters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownClusters.Location = new System.Drawing.Point(16, 260);
            this.numericUpDownClusters.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownClusters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownClusters.Name = "numericUpDownClusters";
            this.numericUpDownClusters.Size = new System.Drawing.Size(114, 20);
            this.numericUpDownClusters.TabIndex = 10;
            this.numericUpDownClusters.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelClusters
            // 
            this.labelClusters.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelClusters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClusters.Location = new System.Drawing.Point(7, 241);
            this.labelClusters.Name = "labelClusters";
            this.labelClusters.Size = new System.Drawing.Size(132, 16);
            this.labelClusters.TabIndex = 9;
            this.labelClusters.Text = "Кількість кластерів";
            // 
            // labelDots
            // 
            this.labelDots.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDots.Location = new System.Drawing.Point(19, 112);
            this.labelDots.Name = "labelDots";
            this.labelDots.Size = new System.Drawing.Size(106, 16);
            this.labelDots.TabIndex = 7;
            this.labelDots.Text = "Кількість точок";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerate.Location = new System.Drawing.Point(16, 161);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(114, 42);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Згенерувати";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxDotsQuantity
            // 
            this.textBoxDotsQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDotsQuantity.Location = new System.Drawing.Point(16, 131);
            this.textBoxDotsQuantity.Name = "textBoxDotsQuantity";
            this.textBoxDotsQuantity.Size = new System.Drawing.Size(114, 20);
            this.textBoxDotsQuantity.TabIndex = 1;
            // 
            // loadFromFile
            // 
            this.loadFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadFromFile.Location = new System.Drawing.Point(16, 12);
            this.loadFromFile.Name = "loadFromFile";
            this.loadFromFile.Size = new System.Drawing.Size(114, 52);
            this.loadFromFile.TabIndex = 0;
            this.loadFromFile.Text = "Завантажити з файлу";
            this.loadFromFile.UseVisualStyleBackColor = true;
            this.loadFromFile.Click += new System.EventHandler(this.loadFromFile_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(3, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 4);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(2, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 4);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(2, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 4);
            this.panel3.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 388);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(552, 427);
            this.Name = "Form1";
            this.Text = "Кластеризація K-Means";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClusters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loadFromFile;
        private System.Windows.Forms.TextBox textBoxDotsQuantity;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelDots;
        private System.Windows.Forms.NumericUpDown numericUpDownClusters;
        private System.Windows.Forms.Label labelClusters;
        private System.Windows.Forms.Button buttonCluster;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

