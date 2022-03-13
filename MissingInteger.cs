using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        Array.Sort(A);
        
        var hashSet = new HashSet<int>();
        var max = A[A.Length - 1];

        if (max < 1)
            return 1;

        for(int i = 0; i <= A.Length - 1; i++)
        {
            hashSet.Add(A[i]);
        }

        for(int j = 1; j <= max; j++)
        {
            if (!hashSet.Contains(j))
            {
                return j;
            }
        }

        return max + 1;
    }
}
