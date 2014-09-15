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
        private int[] frets_by_string; 
        private String base_type;
        public Chord()
        {

        }

        public Chord(int[] frets)
        {
            frets_by_string = frets;
        }

        public Chord(int[] frets, String type, String chord_name)
        {
            frets_by_string = frets;
            name = chord_name;
            base_type = type;
        }

        public int[] get_frets_by_string()
        {
            return frets_by_string;
        }

        public override string ToString() 
        {
            string return_string = "";
            for (int i = 0; i < 6; )
            {
                return_string += frets_by_string[i];
                return_string += " ";
                ++i;
            }
                return return_string;
        }

    }
}
