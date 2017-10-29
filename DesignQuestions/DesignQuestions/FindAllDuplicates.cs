using System;
using System.Collections.Generic;
using System.Text;

namespace DesignQuestions
{
    class FindAllDuplicates
    {
        public static List<int> findDups(int[] array)
        {
            List<int> resultSet = new List<int>();

            for(int i=0; i< array.Length; i++)
            {
                int index = Math.Abs(array[i]) - 1;
                if(array[index] < 0)
                {
                    resultSet.Add(Math.Abs(array[i]));
                }
                else
                {
                    //flip the sign of the element at that index
                    array[index] = -array[index];
                }
            }

            return resultSet;
        }
    }
}
