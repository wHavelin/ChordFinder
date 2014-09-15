using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    static class Chord_Finder
    {

        public static int test = 0;

        public static Chord Find_Chord(int root_note, int type){
            ++test;
            int[] frets = Get_Frets_For_Chord(root_note, type);
            return new Chord(frets);
        }

        public static int[] Get_Frets_For_Chord(int root_note, int type){
            bool[] string_not_played = { false, false, false, false, false, false };
            int[] frets = new int[6];
            if (!check_for_special_fingering(frets, root_note, type, string_not_played)) { 
                int[] pattern = Get_Fret_Pattern(root_note, type, string_not_played);
                frets[0] = root_note - pattern[0];
                frets[0] = frets[0] % 12;
                int start_point = frets[0];
                if (string_not_played[0])
                    frets[0] = 999; // this is just an arbitrary big number
                for (int i = 1; i < 6;)
                {
                    if (string_not_played[i])
                        frets[i] = Int32.MaxValue;
                    else
                        frets[i] = start_point + pattern[i];
                    ++i;
                }
        }
                return frets;
        }

        public static bool check_for_special_fingering(int[] frets, int root, int type, bool[] string_not_played)
        {
            if (root == 11 && type == 1) //G-Major
            {
                frets[0] = 3;
                frets[1] = 2;
                frets[2] = 0;
                frets[3] = 0;
                frets[4] = 0;
                frets[5] = 3;
                return true;
            }
            if(root == 4 && type == 1) // C-Major
            {
                string_not_played[0] = true;
                frets[0] = 999;
                frets[1] = 3;
                frets[2] = 2;
                frets[3] = 0;
                frets[4] = 1;
                frets[5] = 0;
                return true;
            }
            if (root == 6) // D Major or Minor
            {
                string_not_played[0] = true;
                string_not_played[1] = true;
                frets[0] = 999;
                frets[1] = 999;
                frets[2] = 0;
                frets[3] = 2;
                frets[4] = 3;
                if (type == 1)
                    frets[5] = 2;
                else
                    frets[5] = 1;
                return true;
            }
            return false;
        }
        public static int[] Get_Fret_Pattern(int root, int type, bool[] string_not_played)
        {
            int[] return_array = {-4, 2, 2, 1, 0, 0}; //E-String Major
            if (root < 8) //this means it would be better to use the A string
            {
                string_not_played[0] = true;
                return_array[0] = 1;
                return_array[1] = 0;
                return_array[3] = 2;
                if (type == 1) // Major
                    return_array[4] = 2;
                else
                    return_array[4] = 1;
            }
            else if (type == 2) // E-string Minor
                return_array[3] = 0;
            return return_array;
        }
    }
}
