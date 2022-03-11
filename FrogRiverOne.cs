using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int[] A) {
        var jumps = new HashSet<int>();
        for (int i = 1; i <= X; i++)
        {
            jumps.Add(i);
        }
        for (int i = 0; i < A.Length; i++)
        {
            if (jumps.Remove(A[i]))
            {
                if (jumps.Count == 0)
                {
                    return i;
                }
            }
        }
        return -1;
    }
}
