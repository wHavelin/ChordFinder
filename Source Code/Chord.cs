using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class Chord
    {
        private string name;
        private int[] notes; // 1 = A ... 12 = G# and so on
        private String base_type;
        public Chord()
        {

        }

        public Chord(int[] chord_notes, String type, String chord_name)
        {
            notes = chord_notes;
            name = chord_name;
            base_type = type;
        }

        public override string ToString() 
        {
            return name;
        }

    }
}
