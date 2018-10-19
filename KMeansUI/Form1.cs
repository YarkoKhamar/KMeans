using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using KMeansConsole;
using System.Windows.Forms;
using System.IO;

namespace KMeansUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }
        double[][] raw;
        int[] vector;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private IEnumerable<PointF> onScreenPoints(IEnumerable<PointF> Points)
        {
            var padding = 15;
            var minX = Points.Min(p => p.X);
            var minY = Points.Min(p => p.Y);
            var maxX = Points.Max(p => p.X);
            var maxY = Points.Max(p => p.Y);
            foreach (var i in Points)
            {
                var p = i;
                var x = padding + (float)((p.X - minX) / (maxX - minX)) * (pictureBox1.Width - 2 * padding);
                var y = padding + (float)((p.Y - minY) / (maxY - minY)) * (pictureBox1.Height - 2 * padding);
                yield return new PointF(x, y);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void myChart_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (raw != null)
            {

                Graphics g = e.Graphics;
                SolidBrush brush = new SolidBrush(Color.LimeGreen);
                int dots = raw.GetLength(0);//int.Parse(textBoxDotsQuantity.Text);
                PointF[] p = new PointF[dots];
                for (int i = 0; i < dots; i++)
                {
                    p[i] = new PointF((float)raw[i][0], (float)raw[i][1]);
                }
                p = onScreenPoints(p).ToArray(); //?????
                for (int i = 0; i < p.Length; ++i)
                {
                    var pnt = p[i];
                    //var vector = Cluster.ClusterMethod(raw, (int)numericUpDownClusters.Value);
                    if (vector != null)
                    {
                        var cluster = vector[i];
                        switch (cluster)
                        {
                            case 0: brush.Color = Color.Red; break;
                            case 1: brush.Color = Color.Green; break;
                            case 2: brush.Color = Color.Blue; break;
                            case 3: brush.Color = Color.Yellow; break;
                            case 4: brush.Color = Color.Black; break;
                            case 5: brush.Color = Color.Gold; break;
                            case 6: brush.Color = Color.Gray; break;
                            case 7: brush.Color = Color.LightSalmon; break;
                            case 8: brush.Color = Color.MistyRose; break;
                            case 9: brush.Color = Color.Orange; break;
                        }
                    }
                    RectangleF rectf = new RectangleF(new PointF(pnt.X - 8, pnt.Y - 8), new Size(16, 16));
                    g.FillEllipse(brush, rectf);
                }
                //vector = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
        }

        private void loadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                raw = HelpersDisplay.LoadFromFilePath(openFileDialog1.FileName);
                textBoxDotsQuantity.Text = raw.ToArray().Length.ToString();
                pictureBox1.Invalidate();
            }

            openFileDialog1.Dispose();

        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (textBoxDotsQuantity.Text != string.Empty)
            {
                if (int.Parse(textBoxDotsQuantity.Text) > 0)
                {
                    raw = RandomExtensions.GenerateRandom(int.Parse(textBoxDotsQuantity.Text));
                    pictureBox1.Invalidate();
                    vector = null;
                }
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonCluster_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDownClusters.Value <= int.Parse(textBoxDotsQuantity.Text))
            {
                vector = Cluster.ClusterMethod(raw, (int)numericUpDownClusters.Value);
                pictureBox1.Invalidate();
            }
        }
    }
}
