using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {

    // O(n)
    public int solution1(int[] A) {
        var sumLeft = A[0];
        var sumRight = A.Sum() - sumLeft;
        var diffs = new List<int>();
        for (int i = 1; i <= A.Length - 1; i++)
        {
            diffs.Add(Math.Abs(sumLeft - sumRight));
            sumLeft += A[i];
            sumRight -= A[i];
        }
        return diffs.Min();
    }
    
    // O(n * n)
    public int solution2(int[] A) {
        var diffs = new List<int>();
        for (int i = 1; i < A.Length; i++)
        {
            var left = A.Skip(0).Take(i).Sum();
            var right = A.Skip(i).Take(A.Length - i).Sum();
            diffs.Add(Math.Abs(left - right));
        }
        return diffs.Min();
    }
} 
