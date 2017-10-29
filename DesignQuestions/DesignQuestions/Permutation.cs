using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignQuestions
{
    class Permutation
    {
        List<List<int>> result;
        int[] count;

        public Permutation()
        {
            result = new List<List<int>>();
        }

        public List<List<int>> Permute(int[] nums)
        {
            //int index = 0;
            int depth = 0;
            int[] resultArray = new int[nums.Length];

            int[] inputArray = setupCountArray(nums);

            getPermutations(inputArray, count, resultArray, depth);

            return result;
        }

        private void getPermutations(int[] nums, int[] count, int[] resultArray, int level)
        {
            if(level == resultArray.Length)
            {
                List<int> entry = new List<int>();
                foreach(int num in resultArray)
                {
                    entry.Add(num);
                }
                this.result.Add(entry);
                return;
            }

            for(int i =0; i<nums.Length; i++)
            {
                if (count[i] == 0) continue;

                resultArray[level] = nums[i];
                count[i]--;
                getPermutations(nums, count, resultArray, level + 1);
                count[i]++;
            }
        }

        private int[] setupCountArray(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach(var num in nums)
            {
                //add item and count to the dictionary
                if (dict.ContainsKey(num))
                {
                    //get the value and increment it
                    var val = dict[num];
                    dict[num] = ++val;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }

            //iterate over the dict and add it to a new array
            int[] input = new int[dict.Count];
            int[] tempCount = new int[dict.Count];

            int i = 0;
            foreach(var de in dict)
            {
                input[i] = de.Key;
                tempCount[i] = de.Value;
                i++;
            }

            count = tempCount;

            return input;
        }
    }
}
