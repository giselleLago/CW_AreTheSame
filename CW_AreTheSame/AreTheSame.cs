using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW_AreTheSame
{
    public class AreTheSame
    {
        public bool comp(int[] a, int[] b)
        {
            if (a == null || b == null)
            {
                return false;
            }
            var copy = a.Select(x => x * x).ToArray();
            Array.Sort(copy);
            Array.Sort(b);

            return copy.SequenceEqual(b);


            /*if (a == null || b == null)
            {
                return false;
            }
            var newList = new List<int>();
            foreach (var x in a)
            {
                foreach (var y in b)
                {
                    if (x * x == y)
                    {
                        newList.Add(y);
                        break;
                    }
                }
            }
            var newB = b.ToList();
            newB.Sort();
            newList.Sort();
            if (newList.SequenceEqual(newB) && newList.Count == a.Count() && a != null && b != null)
            {
                return true;
            }
            return false;*/
        }
    }
}
