using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    // O(N ^ 2)
    public int[] solution(int N, int[] A) {
        var counters = new int[N];

        for (int i = 0; i <= A.Length - 1; i++)
        {
            if (A[i] <= N)
            {
                counters[A[i] - 1] += 1;
            } 
            else {
                var max = counters.Max();
                for (int j = 0; j <= counters.Length - 1; j++)
                {
                    counters[j] = max;
                }
            }
        }

        return counters;
    }
    
    // O(N * M)
    public int[] solution2(int N, int[] A) {
        var max = 0;
        var counters = new int[N];

        for (int i = 0; i <= A.Length - 1; i++)
        {
            if (A[i] <= N)
            {
                counters[A[i] - 1] += 1;
            } 
            else {
                max += counters.Max();
                counters = new int[N];
            }
        }

        for (int j = 0; j < counters.Length; j++)
        {
            counters[j] += max;
        }

        return counters;
    }
    
    // O(N * M)
    public int[] solution3(int N, int[] A) {
        var counters = new int[N];
        var max = 0;
        var currMax = 0;

        for (int i = 0; i <= A.Length - 1; i++)
        {
            if (A[i] <= N)
            {
                counters[A[i] - 1] += 1;
                if (counters[A[i] - 1] > currMax)
                    currMax = counters[A[i] - 1];
            } 
            else {
                max += currMax;
                currMax = 0;
                counters = new int[N];
            }
        }

        for (int j = 0; j < counters.Length; j++)
        { 
            counters[j] += max;
        }

        return counters;
    }
}
