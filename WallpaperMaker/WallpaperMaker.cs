using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallpaperMaker
{
    public partial class WallpaperPanel : Form
    {

        public int numAcross;
        public int numDown;
        public BorderStyle currentBorder = BorderStyle.FixedSingle;

        public WallpaperPanel()
        {
            InitializeComponent();
            numAcross = patternPanel.Width / pattern.Width - 1;
            numDown = patternPanel.Height / pattern.Height - 1;
            bordersToolStripMenuItem.Checked = true;
        }

        private void WallpaperPanel_Load(object sender, EventArgs e)
        {

        }

        private void testBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button13_Click(sender, e);
            for (int i = 0; i <= numDown; i++)
            {
                for (int j = 0; j <= numAcross; j++)
                {
                    PictureBox newPattern = new PictureBox();
                    newPattern.Width = pattern.Width;
                    newPattern.Height = pattern.Height;
                    newPattern.Image = pattern.Image;
                    newPattern.BorderStyle = currentBorder;
                    newPattern.Location = new Point(newPattern.Width * j, newPattern.Height * i);
                    newPattern.Parent = patternPanel;
                    if (i + j != 0) newPattern.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button13_Click(sender, e);
            for (int i = 0; i <= numDown; i++)
            {
                for (int j = 0; j <= numAcross; j++)
                {
                    PictureBox newPattern = new PictureBox();
                    newPattern.Width = pattern.Width;
                    newPattern.Height = pattern.Height;
                    if (pattern.Image != null && j % 2 == 1)
                    {
                        Image image = new Bitmap(pattern.Image);
                        //image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        newPattern.Image = image;
                    }
                    else if (pattern.Image != null) newPattern.Image = pattern.Image;
                    if (pattern.Image != null && i % 2 == 1)
                    {
                        Image image = new Bitmap(newPattern.Image);
                        image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        newPattern.Image = image;
                    }
                    newPattern.BorderStyle = currentBorder;
                    newPattern.Location = new Point(newPattern.Width * j, newPattern.Height * i);
                    newPattern.Parent = patternPanel;
                    if (i + j != 0) newPattern.Visible = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button13_Click(sender, e);
            for (int i = 0; i <= numDown; i++)
            {
                for (int j = 0; j <= numAcross; j++)
                {
                    PictureBox newPattern = new PictureBox();
                    newPattern.Width = pattern.Width;
                    newPattern.Height = pattern.Height;
                    if (pattern.Image != null && j % 2 == 1)
                    {
                        Image image = new Bitmap(pattern.Image);
                        image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        newPattern.Image = image;
                    }
                    else if (pattern.Image != null) newPattern.Image = pattern.Image;
                    newPattern.BorderStyle = currentBorder;
                    newPattern.Location = new Point(newPattern.Width * j, newPattern.Height * i);
                    newPattern.Parent = patternPanel;
                    if (i + j != 0) newPattern.Visible = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button13_Click(sender, e);
            for (int i = 0; i <= numDown; i++)
            {
                Image previousAcrossImage = pattern.Image;
                for (int j = 0; j <= numAcross + 1; j++)
                {
                    PictureBox newPattern = new PictureBox();
                    newPattern.Width = pattern.Width;
                    newPattern.Height = pattern.Height;
                    newPattern.Location = new Point(newPattern.Width * j, newPattern.Height * i);
                    if (pattern.Image != null && j % 2 == 1)
                    {
                        Image image = new Bitmap(previousAcrossImage);
                        image.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                        newPattern.Image = image;

                    }
                    else if (pattern.Image != null) newPattern.Image = pattern.Image;
                    if (pattern.Image != null && i % 2 == 1)
                    {
                        Image image = new Bitmap(pattern.Image);
                        image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        newPattern.Image = image;
                        newPattern.Location = new Point(newPattern.Width * j - newPattern.Width / 2, newPattern.Height * i);
                    }
                    newPattern.BorderStyle = currentBorder;
                    newPattern.Parent = patternPanel;
                    if (i + j != 0) newPattern.Visible = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button13_Click(sender, e);
            for (int i = 0; i <= numDown; i++)
            {
                for (int j = 0; j <= numAcross + 1; j++)
                {
                    PictureBox newPattern = new PictureBox();
                    newPattern.Width = pattern.Width;
                    newPattern.Height = pattern.Height;
                    newPattern.Location = new Point(newPattern.Width * j, newPattern.Height * i);
                    if (pattern.Image != null && j % 2 == 1)
                    {
                        Image image = new Bitmap(pattern.Image);
                        image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        newPattern.Image = image;
                    }
                    else if (pattern.Image != null) newPattern.Image = pattern.Image;
                    if (pattern.Image != null && i % 2 == 1)
                    {
                        newPattern.Location = new Point(newPattern.Width * j - newPattern.Width/2, newPattern.Height * i);  
                    }
                    newPattern.BorderStyle = currentBorder;
                    newPattern.Parent = patternPanel;
                    if (i + j != 0) newPattern.Visible = true;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button13_Click(sender, e);
            for (int i = 0; i <= numDown; i++)
            {
                for (int j = 0; j <= numAcross; j++)
                {
                    PictureBox newPattern = new PictureBox();
                    newPattern.Width = pattern.Width;
                    newPattern.Height = pattern.Height;
                    if (pattern.Image != null && j % 2 == 1)
                    {
                        Image image = new Bitmap(pattern.Image);
                        image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        newPattern.Image = image;
                    }
                    else if (pattern.Image != null) newPattern.Image = pattern.Image;
                    if (pattern.Image != null && i % 2 == 1)
                    {
                        Image image = new Bitmap(newPattern.Image);
                        image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                        newPattern.Image = image;
                    }
                    newPattern.BorderStyle = currentBorder;
                    newPattern.Location = new Point(newPattern.Width * j, newPattern.Height * i);
                    newPattern.Parent = patternPanel;
                    if (i + j != 0) newPattern.Visible = true;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button13_Click(sender, e);
            for (int i = 0; i <= numDown; i++)
            {
                for (int j = 0; j <= numAcross + 1; j++)
                {
                    PictureBox newPattern = new PictureBox();
                    newPattern.Width = pattern.Width;
                    newPattern.Height = pattern.Height;
                    newPattern.Location = new Point(newPattern.Width * j, newPattern.Height * i);
                    if (pattern.Image != null && j % 2 == 1)
                    {
                        Image image = new Bitmap(pattern.Image);
                        image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        newPattern.Image = image;
                    }
                    else if (pattern.Image != null) newPattern.Image = pattern.Image;
                    if (pattern.Image != null && i % 2 == 1)
                    {
                        Image image = new Bitmap(newPattern.Image);
                        image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                        newPattern.Image = image;
                        newPattern.Location = new Point(newPattern.Width * j - newPattern.Width/2, newPattern.Height * i);
                    }
                    newPattern.BorderStyle = currentBorder;
                    newPattern.Parent = patternPanel;
                    if (i + j != 0) newPattern.Visible = true;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button13_Click(sender, e);
            for (int i = 0; i <= numDown; i++)
            {
                for (int j = 0; j <= numAcross; j++)
                {
                    PictureBox newPattern = new PictureBox();
                    newPattern.Width = pattern.Width;
                    newPattern.Height = pattern.Height;
                    if (pattern.Image != null && j % 2 == 1)
                    {
                        Image image = new Bitmap(pattern.Image);
                        image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        newPattern.Image = image;
                    }
                    else if (pattern.Image != null) newPattern.Image = pattern.Image;
                    if (pattern.Image != null && i % 2 == 1)
                    {
                        Image image = new Bitmap(newPattern.Image);
                        image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                        newPattern.Image = image;
                    }
                    newPattern.BorderStyle = currentBorder;
                    newPattern.Location = new Point(newPattern.Width * j, newPattern.Height * i);
                    newPattern.Parent = patternPanel;
                    if (i + j != 0) newPattern.Visible = true;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button13_Click(sender, e);
            for (int i = 0; i <= numDown; i++)
            {
                for (int j = 0; j <= numAcross + 1; j++)
                {
                    PictureBox newPattern = new PictureBox();
                    newPattern.Width = pattern.Width;
                    newPattern.Height = pattern.Height;
                    if (pattern.Image != null && j % 2 == 1)
                    {
                        Image image = new Bitmap(pattern.Image);
                        image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        newPattern.Image = image;
                    }
                    else if (pattern.Image != null) newPattern.Image = pattern.Image;
                    if (pattern.Image != null && i % 2 == 1)
                    {
                        Image image = new Bitmap(newPattern.Image);
                        image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                        newPattern.Image = image;
                    }
                    newPattern.Location = new Point(newPattern.Width * j, newPattern.Height * i);
                    newPattern.BorderStyle = currentBorder;
                    newPattern.Parent = patternPanel;
                    if (i + j != 0) newPattern.Visible = true;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button13_Click(sender, e);
            for (int i = 0; i <= numDown; i++)
            {
                for (int j = 0; j <= numAcross; j++)
                {
                    PictureBox newPattern = new PictureBox();
                    newPattern.Width = pattern.Width;
                    newPattern.Height = pattern.Height;
                    newPattern.Image = pattern.Image;
                    newPattern.BorderStyle = currentBorder;
                    newPattern.Location = new Point(newPattern.Width * j, newPattern.Height * i);
                    newPattern.Parent = patternPanel;
                    if (i + j != 0) newPattern.Visible = true;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button13_Click(sender, e);
            Image previous = new Bitmap(pattern.Image);
            for (int i = 0; i <= numDown; i++)
            {
                for (int j = 0; j <= numAcross; j++)
                {
                    PictureBox newPattern = new PictureBox();
                    newPattern.Width = pattern.Width;
                    newPattern.Height = pattern.Height;
                    if (pattern.Image != null && (j % 2 != 0 || j % 3 != 0))
                    {
                        if (pattern.Image != null && i % 2 == 0 && j % 2 == 1)
                        {
                            Image image = new Bitmap(pattern.Image);
                            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            newPattern.Image = image;
                        }
                        else if (pattern.Image != null && i % 2 == 1 && j % 2 == 1)
                        {
                            Image image = new Bitmap(pattern.Image);
                            image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                            newPattern.Image = image;
                        }
                        else if (pattern.Image != null && i % 2 == 1 && j % 2 == 0)
                        {
                            Image image = new Bitmap(pattern.Image);
                            image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                            newPattern.Image = image;
                        }
                    }
                    else if (pattern.Image != null && (i % 2 != 0 || i % 3 != 0))
                    {
                        if (pattern.Image != null && i % 2 == 0 && j % 2 == 1)
                        {
                            Image image = new Bitmap(pattern.Image);
                            image.RotateFlip(RotateFlipType.Rotate180FlipX);
                            newPattern.Image = image;
                        }
                        else if (pattern.Image != null && i % 2 == 1 && j % 2 == 1)
                        {
                            Image image = new Bitmap(pattern.Image);
                            image.RotateFlip(RotateFlipType.Rotate270FlipX);
                            newPattern.Image = image;
                        }
                        else if (pattern.Image != null && i % 2 == 1 && j % 2 == 0)
                        {
                            Image image = new Bitmap(pattern.Image);
                            image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                            newPattern.Image = image;
                        }
                        else if (pattern.Image != null)
                        {
                            Image image = new Bitmap(pattern.Image);
                            image.RotateFlip(RotateFlipType.Rotate90FlipX);
                            newPattern.Image = image;
                        }
                    }
                    newPattern.Location = new Point(newPattern.Width * j, newPattern.Height * i);
                    newPattern.BorderStyle = currentBorder;
                    newPattern.Parent = patternPanel;
                    if (i + j != 0) newPattern.Visible = true;
                }
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "C://";
            openFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            var pictureBoxes = patternPanel.Controls.OfType<PictureBox>().ToList();
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                if (pictureBox.Name != "pattern")
                {
                    pictureBox.Dispose();
                }
            }

            pattern.Image = null;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            pattern.Image = Image.FromFile(openFileDialog1.FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var pictureBoxes = patternPanel.Controls.OfType<PictureBox>().ToList();
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                if (pictureBox.Name != "pattern")
                {
                    pictureBox.Dispose();
                }
            }
        }

        private void bordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentBorder == BorderStyle.FixedSingle) currentBorder = BorderStyle.None;
            else currentBorder = BorderStyle.FixedSingle;
            bordersToolStripMenuItem.Checked = !bordersToolStripMenuItem.Checked;

            var pictureBoxes = patternPanel.Controls.OfType<PictureBox>().ToList();
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.BorderStyle = currentBorder;
            }
        }
    }
}
