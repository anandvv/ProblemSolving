using System;
using System.Collections.Generic;
using System.Text;

namespace DesignQuestions
{
    class StringCompressor
    {
        int sum;
        StringBuilder output;

        public StringCompressor()
        {
            sum = 1;
            output = new StringBuilder();
        }

        public string compress(string inputString)
        {
            for(int i=0; i<inputString.Length -1; i++)
            {
                if (inputString[i] == inputString[i + 1])
                    this.sum++;
                else
                {
                    this.output.Append(inputString[i].ToString() + this.sum);
                    this.sum = 1;
                }
            }

            this.output.Append(inputString[inputString.Length - 1].ToString() + this.sum);

            return (inputString.Length < output.ToString().Length) ? inputString : output.ToString();
        }
    }
}
