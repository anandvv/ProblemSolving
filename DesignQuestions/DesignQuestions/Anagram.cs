using System;
using System.Collections.Generic;
using System.Text;

namespace DesignQuestions
{
    class Anagram
    {
        int[] array;

        public Anagram()
        {
            array = new int[255];
        }

        public bool isAnagram(string string1, string string2)
        {
            for(int i=0; i< string1.Length; i++)
            {
                array[Convert.ToInt32((string1[i]))]++;
            }

            for (int i = 0; i < string2.Length; i++)
            {
                array[Convert.ToInt32((string1[i]))]--;
            }

            for(int i=0; i<array.Length; i++)
            {
                if (array[i] != 0)
                    return false;
            }

            return true;
        }
    }
}
