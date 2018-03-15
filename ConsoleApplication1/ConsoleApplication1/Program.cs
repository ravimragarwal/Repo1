using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class LongestString
    {
        public string Get(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length == 1) return input;

            var candidateStrIndex = 0;
            var candidateEndIndex = -1;
            var maxLength = -1;
            var maxStrIndex = 0;
            var maxEndIndex = -1;
            var dic = new Dictionary<char, int>();
            for (var currentIndex = 0; currentIndex < input.Length; currentIndex++)
            {
                var c = input[currentIndex];
                if (dic.ContainsKey(c))
                {
                    var oldIndex = dic[c];
                    if (oldIndex >= candidateStrIndex)
                    {
                        if (currentIndex - candidateStrIndex > maxLength)
                        {
                            maxLength = currentIndex - candidateStrIndex;
                            maxStrIndex = candidateStrIndex;
                            maxEndIndex = currentIndex - 1;
                        }
                        candidateStrIndex = oldIndex + 1;
                    }
                }

                dic[c] = currentIndex;
                candidateEndIndex = currentIndex;
            }

            if (candidateEndIndex >= candidateStrIndex)
            {
                if (candidateEndIndex - candidateStrIndex + 1 > maxLength)
                {
                    maxLength = candidateEndIndex - candidateStrIndex + 1;
                    maxStrIndex = candidateStrIndex;
                    maxEndIndex = candidateEndIndex;
                }
            }

            return input.Substring(maxStrIndex, maxEndIndex - maxStrIndex + 1);
        }
    }
}
