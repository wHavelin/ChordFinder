using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{

    public partial class Form1 : Form
    {
        Graphics g;
        Brush b;
        public Form1()
        {
            b = new SolidBrush(Color.Black);
            g = this.CreateGraphics();
            InitializeComponent();
            prepareApp();
        }

        private void RootNote_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prepareApp()
        {
            RootNote.SelectedIndex = 0;
            ChordType.SelectedIndex = 0;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void generateChord(object sender, EventArgs e)
        {
            Random rng = new Random();
            int root = (int)RootNote.SelectedIndex;
            if (root == 0) //this is if they selected random
            {
                root = rng.Next(1, 13);
            }
            int true_root = root; // this is not affected by tuning
            root -= (int)IncrementTuning.Value;
            if (root < 1)
            {
                root = 12  + root;
            }
            if (root > 12)
                root = root % 12;
            int type = ChordType.SelectedIndex;
            if (type == 0)
            {
                type = rng.Next(1, 3);
            }
            setChordDisplayLabels(true_root, type);
            Chord my_Chord = Chord_Finder.Find_Chord(root, type);
            //Chord my_Chord = Chord_Finder.Find_Chord(3, "major");
            drawChordDisplay(my_Chord);
            //MessageBox.Show(my_Chord.ToString());
        }

        private void setChordDisplayLabels(int root, int type)
        {
            //root += (int)IncrementTuning.Value;
            //root = root % 12;
            switch(root){
                case 1:
                    CurrentRoot.Text = "A";
                    break;
                case 2:
                    CurrentRoot.Text = "A#/Bb";
                    break;
                case 3:
                    CurrentRoot.Text = "B";
                    break;
                case 4:
                    CurrentRoot.Text = "C";
                    break;
                case 5:
                    CurrentRoot.Text = "C#/Db";
                    break;
                case 6:
                    CurrentRoot.Text = "D";
                    break;
                case 7:
                    CurrentRoot.Text = "D#/Eb";
                    break;
                case 8:
                    CurrentRoot.Text = "E";
                    break;
                case 9:
                    CurrentRoot.Text = "F";
                    break;
                case 10:
                    CurrentRoot.Text = "F#/Gb";
                    break;
                case 11:
                    CurrentRoot.Text = "G";
                    break;
                case 12:
                    CurrentRoot.Text = "G#/Ab";
                    break;
            }
            switch(type){
                case 1:
                    CurrentType.Text = "Major";
                    break;
                case 2:
                    CurrentType.Text = "Minor";
                    break;
            }
        }

        private void drawChordDisplay(Chord my_Chord)
        {
            Bitmap bmp = new Bitmap(ChordDisplay.Width, ChordDisplay.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                Pen p = new Pen(b, 2);
                Point p1 = new Point(0, 25);
                Point p2 = new Point(0, 150);
                for (int i = 0; i < 5; )
                {
                    g.DrawLine(p, p1, p2);
                    p1.X += 50;
                    p2.X += 50;
                    ++i;
                }
                p1.X = 0;
                p2.X = 200;
                p1.Y = 25;
                p2.Y = 25;
                for (int i = 0; i < 6; )
                {
                    g.DrawLine(p, p1, p2);
                    p1.Y += 25;
                    p2.Y += 25;
                    ++i;
                }
                int[] centers = new int[6];
                int[] temp_notes = my_Chord.get_frets_by_string();
                int root_note = temp_notes.Min();
                //Chord_Finder.test = root_note;
                int fret_adjustment = 0;
                if (root_note > 1)
                {
                    fret_adjustment = root_note - 1;
                }
                this.StartingFret.Text = (fret_adjustment + 1).ToString();
                for (int i = 0; i < 6; )
                {
                    centers[i] = temp_notes[i] - fret_adjustment;
                    if (centers[i] > 100) // This makes an X because the string isn't meant to be played
                    {
                        p1.X = 15;
                        p2.X = 35;
                        p1.Y = 140 - (25 * i);
                        p2.Y = 160 - (25 * i);
                        g.DrawLine(p, p1, p2);
                        p2.X = 15;
                        p1.X = 35;
                        g.DrawLine(p, p1, p2);

                    }
                    else
                    {
                        centers[i] *= 50;
                        g.FillEllipse(b, -35 + centers[i], 140 - (25 * i), 20, 20);
                    }
                    ++i;
                }
            }
            
            ChordDisplay.Image = bmp;
        }



        private void ChordDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
