using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        var xor = A[0];
        for (int i = 1; i < A.Length; i++)
        {
            xor = xor ^ A[i];
        }
        return xor;
    }
}
