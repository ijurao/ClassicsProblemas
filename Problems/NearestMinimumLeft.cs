using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmos.Problems
{
    class NearestMinimumLeft
    {

       
      
        public static int [] SequenceNearestMinimumLeft (int [] entry)
        {
            Stack<int> s = new Stack<int>();
            
            int[] result = new int[entry.Length];

            for(int i = 0; i < entry.Length;i++)
            {
                var m = -1;
                var n=0;
                var lcambio = false;
                while (s.TryPeek(out n) & entry[i] < n)
                {
                     m = s.Pop();
                    lcambio = true;
                }
                if (s.Count == 0 &&  lcambio == false) result[i] = -1;
                else result[i] = s.Peek();

                s.Push(entry[i]);
            }
            return result;

        }
    }
}
