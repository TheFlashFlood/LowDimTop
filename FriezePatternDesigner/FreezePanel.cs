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

namespace FriezePatternDesigner
{
    public partial class FreezePanel : Form
    {

        public int numAcross = 0;
        public bool hasBorder = true;

        public FreezePanel()
        {
            InitializeComponent();
            numAcross = (patternPanel.Width / patternBox.Width);
            bordersToolStripMenuItem.Checked = true;
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set filter for file extension and default file extension
            
            openFileDialog1.DefaultExt = ".png";
            openFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            // Display OpenFileDialog by calling ShowDialog method 
            openFileDialog1.ShowDialog();

            // Open document 
            string filename = openFileDialog1.FileName;
            patternBox.Image = Image.FromFile(filename);
        }

        private void FreezePanel_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreezePanel));
            this.hop_Button = new System.Windows.Forms.Button();
            this.step_Button = new System.Windows.Forms.Button();
            this.sidle_Button = new System.Windows.Forms.Button();
            this.spinhop_Button = new System.Windows.Forms.Button();
            this.spinsidle_Button = new System.Windows.Forms.Button();
            this.jump_Button = new System.Windows.Forms.Button();
            this.spinjump_Button = new System.Windows.Forms.Button();
            this.patternPanel = new System.Windows.Forms.Panel();
            this.patternBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.clear_Button = new System.Windows.Forms.Button();
            this.patternPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patternBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hop_Button
            // 
            this.hop_Button.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hop_Button.Location = new System.Drawing.Point(19, 297);
            this.hop_Button.Name = "hop_Button";
            this.hop_Button.Size = new System.Drawing.Size(292, 93);
            this.hop_Button.TabIndex = 0;
            this.hop_Button.Text = "HOP";
            this.hop_Button.UseVisualStyleBackColor = true;
            this.hop_Button.Click += new System.EventHandler(this.hop_Button_Click_1);
            // 
            // step_Button
            // 
            this.step_Button.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step_Button.Location = new System.Drawing.Point(317, 297);
            this.step_Button.Name = "step_Button";
            this.step_Button.Size = new System.Drawing.Size(292, 93);
            this.step_Button.TabIndex = 1;
            this.step_Button.Text = "STEP";
            this.step_Button.UseVisualStyleBackColor = true;
            this.step_Button.Click += new System.EventHandler(this.step_Button_Click);
            // 
            // sidle_Button
            // 
            this.sidle_Button.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidle_Button.Location = new System.Drawing.Point(615, 297);
            this.sidle_Button.Name = "sidle_Button";
            this.sidle_Button.Size = new System.Drawing.Size(292, 93);
            this.sidle_Button.TabIndex = 2;
            this.sidle_Button.Text = "SIDLE";
            this.sidle_Button.UseVisualStyleBackColor = true;
            this.sidle_Button.Click += new System.EventHandler(this.button3_Click);
            // 
            // spinhop_Button
            // 
            this.spinhop_Button.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinhop_Button.Location = new System.Drawing.Point(913, 297);
            this.spinhop_Button.Name = "spinhop_Button";
            this.spinhop_Button.Size = new System.Drawing.Size(292, 93);
            this.spinhop_Button.TabIndex = 3;
            this.spinhop_Button.Text = "SPIN HOP";
            this.spinhop_Button.UseVisualStyleBackColor = true;
            this.spinhop_Button.Click += new System.EventHandler(this.spinhop_Button_Click);
            // 
            // spinsidle_Button
            // 
            this.spinsidle_Button.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinsidle_Button.Location = new System.Drawing.Point(19, 396);
            this.spinsidle_Button.Name = "spinsidle_Button";
            this.spinsidle_Button.Size = new System.Drawing.Size(292, 93);
            this.spinsidle_Button.TabIndex = 4;
            this.spinsidle_Button.Text = "SPIN SIDLE";
            this.spinsidle_Button.UseVisualStyleBackColor = true;
            this.spinsidle_Button.Click += new System.EventHandler(this.spinsidle_Button_Click);
            // 
            // jump_Button
            // 
            this.jump_Button.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jump_Button.Location = new System.Drawing.Point(317, 396);
            this.jump_Button.Name = "jump_Button";
            this.jump_Button.Size = new System.Drawing.Size(292, 93);
            this.jump_Button.TabIndex = 5;
            this.jump_Button.Text = "JUMP";
            this.jump_Button.UseVisualStyleBackColor = true;
            this.jump_Button.Click += new System.EventHandler(this.jump_Button_Click);
            // 
            // spinjump_Button
            // 
            this.spinjump_Button.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinjump_Button.Location = new System.Drawing.Point(615, 396);
            this.spinjump_Button.Name = "spinjump_Button";
            this.spinjump_Button.Size = new System.Drawing.Size(292, 93);
            this.spinjump_Button.TabIndex = 6;
            this.spinjump_Button.Text = "SPIN JUMP";
            this.spinjump_Button.UseVisualStyleBackColor = true;
            this.spinjump_Button.Click += new System.EventHandler(this.spinjump_Button_Click);
            // 
            // patternPanel
            // 
            this.patternPanel.Controls.Add(this.patternBox);
            this.patternPanel.Location = new System.Drawing.Point(12, 30);
            this.patternPanel.Name = "patternPanel";
            this.patternPanel.Size = new System.Drawing.Size(1200, 250);
            this.patternPanel.TabIndex = 7;
            // 
            // patternBox
            // 
            this.patternBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patternBox.Location = new System.Drawing.Point(0, 25);
            this.patternBox.Name = "patternBox";
            this.patternBox.Size = new System.Drawing.Size(200, 100);
            this.patternBox.TabIndex = 0;
            this.patternBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1227, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.bordersToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click_1);
            // 
            // bordersToolStripMenuItem
            // 
            this.bordersToolStripMenuItem.Name = "bordersToolStripMenuItem";
            this.bordersToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.bordersToolStripMenuItem.Text = "Borders";
            this.bordersToolStripMenuItem.Click += new System.EventHandler(this.bordersToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(913, 396);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(292, 93);
            this.clear_Button.TabIndex = 9;
            this.clear_Button.Text = "CLEAR";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // FreezePanel
            // 
            this.ClientSize = new System.Drawing.Size(1227, 505);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.patternPanel);
            this.Controls.Add(this.spinjump_Button);
            this.Controls.Add(this.jump_Button);
            this.Controls.Add(this.spinsidle_Button);
            this.Controls.Add(this.spinhop_Button);
            this.Controls.Add(this.sidle_Button);
            this.Controls.Add(this.step_Button);
            this.Controls.Add(this.hop_Button);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FreezePanel";
            this.Load += new System.EventHandler(this.FreezePanel_Load_1);
            this.ResizeEnd += new System.EventHandler(this.FreezePanel_ResizeEnd);
            this.patternPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patternBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var pictureBoxes = patternPanel.Controls.OfType<PictureBox>().ToList();
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                if (pictureBox.Name != "patternBox")
                {
                    pictureBox.Dispose();
                }
            }

            for (int iteratorAcross = 1; iteratorAcross <= numAcross; iteratorAcross++)
            {
                PictureBox newPatternBox = new PictureBox();
                newPatternBox.Width = patternBox.Width;
                newPatternBox.Height = patternBox.Height;
                if (patternBox.Image != null && iteratorAcross % 2 == 1) 
                {
                    Image tempImage =  new Bitmap(patternBox.Image);
                    tempImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    newPatternBox.Image = tempImage;
                }
                else
                {
                    newPatternBox.Image = patternBox.Image;
                }
                if (hasBorder) newPatternBox.BorderStyle = BorderStyle.FixedSingle;
                else newPatternBox.BorderStyle = BorderStyle.None;
                newPatternBox.Location = new Point(newPatternBox.Width * iteratorAcross, patternBox.Location.Y);
                newPatternBox.Parent = patternPanel;
                newPatternBox.Visible = true;
            }
        }

        private void importToolStripMenuItem_Click_1(object sender, EventArgs e)
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
                if (pictureBox.Name != "patternBox")
                {
                    pictureBox.Dispose();
                }
            }

            patternBox.Image = null;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            patternBox.Image = Image.FromFile(openFileDialog1.FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void hop_Button_Click_1(object sender, EventArgs e)
        {
            var pictureBoxes = patternPanel.Controls.OfType<PictureBox>().ToList();
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                if (pictureBox.Name != "patternBox")
                {
                    pictureBox.Dispose();
                }
            }

            for (int iteratorAcross = 1; iteratorAcross <= numAcross; iteratorAcross++)
            {
                PictureBox newPatternBox = new PictureBox();
                newPatternBox.Width = patternBox.Width;
                newPatternBox.Height = patternBox.Height;
                newPatternBox.Image = patternBox.Image;
                if (hasBorder) newPatternBox.BorderStyle = BorderStyle.FixedSingle;
                else newPatternBox.BorderStyle = BorderStyle.None;
                newPatternBox.Location = new Point(newPatternBox.Width * iteratorAcross, patternBox.Location.Y);
                newPatternBox.Parent = patternPanel;
                newPatternBox.Visible = true;
            }
        }

        private void FreezePanel_Load_1(object sender, EventArgs e)
        {

        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            var pictureBoxes = patternPanel.Controls.OfType<PictureBox>().ToList();
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                if (pictureBox.Name != "patternBox")
                {
                    pictureBox.Dispose();
                }
            }

            patternBox.Image = null;
        }

        private void jump_Button_Click(object sender, EventArgs e)
        {
            var pictureBoxes = patternPanel.Controls.OfType<PictureBox>().ToList();
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                if (pictureBox.Name != "patternBox")
                {
                    pictureBox.Dispose();
                }
            }

            for (int iteratorAcross = 0; iteratorAcross <= numAcross; iteratorAcross++)
            {
                PictureBox newPatternBox = new PictureBox();
                newPatternBox.Width = patternBox.Width;
                newPatternBox.Height = patternBox.Height;
                newPatternBox.Image = patternBox.Image;

                if (hasBorder) newPatternBox.BorderStyle = BorderStyle.FixedSingle;
                else newPatternBox.BorderStyle = BorderStyle.None;
                newPatternBox.Location = new Point(newPatternBox.Width * iteratorAcross, patternBox.Location.Y);
                newPatternBox.Parent = patternPanel;
                newPatternBox.Visible = true;

                PictureBox botPatternBox = new PictureBox();
                botPatternBox.Width = patternBox.Width;
                botPatternBox.Height = patternBox.Height;

                if (patternBox.Image != null)
                {
                    Image tempImage = new Bitmap(patternBox.Image);
                    tempImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    botPatternBox.Image = tempImage;
                }

                if (hasBorder) botPatternBox.BorderStyle = BorderStyle.FixedSingle;
                else botPatternBox.BorderStyle = BorderStyle.None;
                botPatternBox.Location = new Point(botPatternBox.Width * iteratorAcross, patternBox.Location.Y + botPatternBox.Height);
                botPatternBox.Parent = patternPanel;
                botPatternBox.Visible = true;
            }
        }

        private void spinjump_Button_Click(object sender, EventArgs e)
        {
            var pictureBoxes = patternPanel.Controls.OfType<PictureBox>().ToList();
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                if (pictureBox.Name != "patternBox")
                {
                    pictureBox.Dispose();
                }
            }

            for (int iteratorAcross = 0; iteratorAcross <= numAcross; iteratorAcross++)
            {
                PictureBox newPatternBox = new PictureBox();
                newPatternBox.Width = patternBox.Width;
                newPatternBox.Height = patternBox.Height;

                if (patternBox.Image != null && iteratorAcross % 2 == 1)
                {
                    Image tempImage = new Bitmap(patternBox.Image);
                    tempImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    newPatternBox.Image = tempImage;
                }
                else if (patternBox.Image != null)
                {
                    newPatternBox.Image = patternBox.Image;
                }

                if (hasBorder) newPatternBox.BorderStyle = BorderStyle.FixedSingle;
                else newPatternBox.BorderStyle = BorderStyle.None;
                newPatternBox.Location = new Point(newPatternBox.Width * iteratorAcross, patternBox.Location.Y);
                newPatternBox.Parent = patternPanel;
                newPatternBox.Visible = true;

                PictureBox botPatternBox = new PictureBox();
                botPatternBox.Width = patternBox.Width;
                botPatternBox.Height = patternBox.Height;

                if (patternBox.Image != null && iteratorAcross %2 == 1)
                {
                    Image tempImage = new Bitmap(patternBox.Image);
                    tempImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    tempImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    botPatternBox.Image = tempImage;
                }
                else if (patternBox.Image != null)
                {
                    Image tempImage = new Bitmap(patternBox.Image);
                    tempImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    botPatternBox.Image = tempImage;
                }

                if (hasBorder) botPatternBox.BorderStyle = BorderStyle.FixedSingle;
                else botPatternBox.BorderStyle = BorderStyle.None;
                botPatternBox.Location = new Point(botPatternBox.Width * iteratorAcross, patternBox.Location.Y + botPatternBox.Height);
                botPatternBox.Parent = patternPanel;
                botPatternBox.Visible = true;
            }
        }

        private void spinhop_Button_Click(object sender, EventArgs e)
        {
            var pictureBoxes = patternPanel.Controls.OfType<PictureBox>().ToList();
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                if (pictureBox.Name != "patternBox")
                {
                    pictureBox.Dispose();
                }
            }

            for (int iteratorAcross = 0; iteratorAcross <= numAcross; iteratorAcross++)
            {
                PictureBox newPatternBox = new PictureBox();
                newPatternBox.Width = patternBox.Width;
                newPatternBox.Height = patternBox.Height;
                newPatternBox.Image = patternBox.Image;
                if (hasBorder) newPatternBox.BorderStyle = BorderStyle.FixedSingle;
                else newPatternBox.BorderStyle = BorderStyle.None;
                newPatternBox.Location = new Point(newPatternBox.Width * iteratorAcross, patternBox.Location.Y);
                newPatternBox.Parent = patternPanel;
                newPatternBox.Visible = true;

                PictureBox botPatternBox = new PictureBox();
                botPatternBox.Width = patternBox.Width;
                botPatternBox.Height = patternBox.Height;

                if (patternBox.Image != null)
                {
                    Image tempImage = new Bitmap(patternBox.Image);
                    tempImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    tempImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    botPatternBox.Image = tempImage;
                }

                if (hasBorder) botPatternBox.BorderStyle = BorderStyle.FixedSingle;
                else botPatternBox.BorderStyle = BorderStyle.None;
                botPatternBox.Location = new Point(botPatternBox.Width * iteratorAcross, patternBox.Location.Y + botPatternBox.Height);
                botPatternBox.Parent = patternPanel;
                botPatternBox.Visible = true;
            }
        }

        private void step_Button_Click(object sender, EventArgs e)
        {
            var pictureBoxes = patternPanel.Controls.OfType<PictureBox>().ToList();
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                if (pictureBox.Name != "patternBox")
                {
                    pictureBox.Dispose();
                }
            }

            for (int iteratorAcross = 0; iteratorAcross <= numAcross; iteratorAcross++)
            {
                PictureBox newPatternBox = new PictureBox();
                newPatternBox.Width = patternBox.Width;
                newPatternBox.Height = patternBox.Height;
                newPatternBox.Image = patternBox.Image;

                if (hasBorder) newPatternBox.BorderStyle = BorderStyle.FixedSingle;
                else newPatternBox.BorderStyle = BorderStyle.None;
                newPatternBox.Location = new Point(newPatternBox.Width * iteratorAcross, patternBox.Location.Y);
                newPatternBox.Parent = patternPanel;
                newPatternBox.Visible = true;

                PictureBox botPatternBox = new PictureBox();
                botPatternBox.Width = patternBox.Width;
                botPatternBox.Height = patternBox.Height;

                if (patternBox.Image != null)
                {
                    Image tempImage = new Bitmap(patternBox.Image);
                    tempImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    botPatternBox.Image = tempImage;
                }

                if (hasBorder) botPatternBox.BorderStyle = BorderStyle.FixedSingle;
                else botPatternBox.BorderStyle = BorderStyle.None;
                botPatternBox.Location = new Point(botPatternBox.Width * iteratorAcross - botPatternBox.Width / 2, patternBox.Location.Y + botPatternBox.Height);
                botPatternBox.Parent = patternPanel;
                botPatternBox.Visible = true;
            }
        }

        private void spinsidle_Button_Click(object sender, EventArgs e)
        {
            var pictureBoxes = patternPanel.Controls.OfType<PictureBox>().ToList();
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                if (pictureBox.Name != "patternBox")
                {
                    pictureBox.Dispose();
                }
            }

            for (int iteratorAcross = 0; iteratorAcross <= numAcross; iteratorAcross++)
            {
                PictureBox newPatternBox = new PictureBox();
                newPatternBox.Width = patternBox.Width;
                newPatternBox.Height = patternBox.Height;
                newPatternBox.Image = patternBox.Image;
                if (hasBorder) newPatternBox.BorderStyle = BorderStyle.FixedSingle;
                else newPatternBox.BorderStyle = BorderStyle.None;
                newPatternBox.Location = new Point(newPatternBox.Width * iteratorAcross, patternBox.Location.Y);
                newPatternBox.Parent = patternPanel;

                if (patternBox.Image != null && iteratorAcross % 2 == 1)
                {
                    Image tempImage = new Bitmap(patternBox.Image);
                    tempImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    newPatternBox.Image = tempImage;

                    newPatternBox.BorderStyle = BorderStyle.FixedSingle;
                    newPatternBox.Location = new Point(newPatternBox.Width * iteratorAcross, patternBox.Location.Y);
                    newPatternBox.Parent = patternPanel;
                }
                if (patternBox.Image != null && iteratorAcross % 3 == 2 && iteratorAcross % 5 != 0)
                {
                    Image tempImage = new Bitmap(patternBox.Image);
                    tempImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    newPatternBox.Image = tempImage;

                    newPatternBox.BorderStyle = BorderStyle.FixedSingle;
                    newPatternBox.Location = new Point(newPatternBox.Width * iteratorAcross, patternBox.Location.Y + patternBox.Height);
                    newPatternBox.Parent = patternPanel;
                }
                if (patternBox.Image != null && iteratorAcross % 4 == 3)
                {
                    Image tempImage = new Bitmap(patternBox.Image);
                    tempImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    tempImage.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    newPatternBox.Image = tempImage;

                    newPatternBox.BorderStyle = BorderStyle.FixedSingle;

                    newPatternBox.Location = new Point(newPatternBox.Width * iteratorAcross, patternBox.Location.Y + patternBox.Height);
                    newPatternBox.Parent = patternPanel;
                }
                newPatternBox.Visible = true;
            }
        }

        private void bordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pictureBoxes = patternPanel.Controls.OfType<PictureBox>().ToList();
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                if (hasBorder) {
                    pictureBox.BorderStyle = BorderStyle.None;
                }
                else
                {
                    pictureBox.BorderStyle = BorderStyle.FixedSingle;
                }
            }
            bordersToolStripMenuItem.Checked = !bordersToolStripMenuItem.Checked;
            hasBorder = !hasBorder;
        }

        private void FreezePanel_ResizeEnd(object sender, EventArgs e)
        {  
            numAcross = (patternPanel.Width / patternBox.Width);
        }
    }
}
