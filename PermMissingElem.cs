using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // get max num in A
        // get lat num in A
        // Sum nums in between including first and last - tot1
        // Sum all numbers in A - to
        // subtract tot2 from tot1
        if (A.Length == 0)
            return 1;
        var tot1 = A.Max();
        var tot2 = 0;
        for (int i = tot1; i >= 1; i--)
        {
            tot1 +=  i - 1;
        }
        
        for (int i = 0; i <= A.Length - 1; i++)
        {
            tot2 += A[i];
        }
        var diff = tot1 - tot2;
        if (diff == 0)
            return A.Max() + 1;
        return tot1 - tot2;
    }
}
