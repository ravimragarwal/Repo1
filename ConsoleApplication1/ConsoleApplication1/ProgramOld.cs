//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1
//{
//    public class LongestString
//    {
//        public string Get(string input) 
//        {
//            if (string.IsNullOrEmpty(input) || input.Length == 1) return input;

//            //var all = new List<Tuple<int, int>>();

//            var candidateStrIndex = 0;
//            var candidateEndIndex = -1;
//            var maxLength = -1;
//            var maxStrIndex = 0;
//            var maxEndIndex = -1;
//            var dic = new Dictionary<char, int>();
//            for (var currentIndex = 0; currentIndex < input.Length; currentIndex++)
//            {
//                char c = input[currentIndex];
//                if (dic.ContainsKey(c))
//                {
//                    var oldIndex = dic[c];
//                    if (oldIndex < candidateStrIndex)
//                    {
//                        candidateEndIndex = currentIndex;
//                    }
//                    else
//                    {
//                        //all.Add(new Tuple<int, int>(candidateStrIndex, currentIndex - 1));
//                        if (currentIndex - candidateStrIndex > maxLength)
//                        {
//                            maxLength = currentIndex - candidateStrIndex;
//                            maxStrIndex = candidateStrIndex;
//                            maxEndIndex = currentIndex - 1;
//                        }
//                        candidateStrIndex = oldIndex + 1;
//                    }
//                    dic[c] = currentIndex;
//                }
//                else
//                {
//                    dic.Add(c, currentIndex);
//                    candidateEndIndex = currentIndex;
//                }
//            }

//            if (candidateEndIndex >= candidateStrIndex)
//            {
//                if (candidateEndIndex - candidateStrIndex + 1 > maxLength)
//                {
//                    maxLength = candidateEndIndex - candidateStrIndex + 1;
//                    maxStrIndex = candidateStrIndex;
//                    maxEndIndex = candidateEndIndex;
//                }
//            }

//            //List<string> allStr = new List<string>();
//            //all.ForEach(t => allStr.Add(input.Substring(t.Item1, t.Item2 - t.Item1 + 1)));
//            //if (candidateEndIndex >= candidateStrIndex)
//            //    allStr.Add(input.Substring(candidateStrIndex, candidateEndIndex - candidateStrIndex + 1));

//            return input.Substring(maxStrIndex, maxEndIndex - maxStrIndex + 1);
//        }
//    }
//}
