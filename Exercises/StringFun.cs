using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public static class StringFun
    {
        public static string GetOccurrencesEachChar(string s)
        {
            Dictionary<char, int> occurence = new Dictionary<char, int>();
            var occurrences = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(s))
            {
                int count = 0;
                foreach (char curr in s)
                {
                    if (occurence.ContainsKey(curr))
                    {
                        continue;
                    }

                    foreach (char c in s)
                    {
                        if (curr == c)
                        {
                            count++;
                        }
                    }

                    occurence.Add(curr, count);

                    //reset for next char
                    count = 0;
                }

                occurence.ToList().ForEach(x => occurrences.Append(x.Key + ":" + x.Value));
            }

            return occurrences.ToString();
        }

        public static string RemoveOccurrences(string s, char val)
        {
            StringBuilder removed = new StringBuilder();
            foreach (char c in s)
            {
                if (c != val)
                    removed.Append(c);

            }

            return removed.ToString();
        }
    }
}
