using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    // O(N) // O(N * log(N))
    public int solution(int[] A) {
        Array.Sort(A);
        for (int i = 0; i <= A.Length - 1; i++)
        {
            if (A[i] != i + 1)
            {
                return 0;
            }
        }
        return 1;
    }
    
    // O(N**2)
    public int solution2(int[] A) {
        for (int i = 1; i <= A.Length; i++)
        {
            if (!A.Contains(i))
            {
                return 0;
            }
        }
        return 1;
    }
}
