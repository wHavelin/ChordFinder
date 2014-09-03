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
            StartingString.SelectedIndex = 0;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void generateChord(object sender, EventArgs e)
        {
            //ChordDisplay.SendToBack();
            g.FillEllipse(b, 200f, 80f, 20f, 20f);
            //ChordDisplay.SendToBack();
            MessageBox.Show(Chord_Finder.Find_Chord().ToString());
            //ChordDisplay.SendToBack();
        }
    }
}
