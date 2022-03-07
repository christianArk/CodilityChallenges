using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A, int K) {
        for (int i = 0; i < K; i++) 
		{
			if (A.Length > 1)
			{
				var current = A[0];
				var next = A[1];
				for (int j = 0; j < A.Length - 1; j++) 
				{
					next = A[j + 1];
					A[j + 1] = current;
					current = next;
				}
				A[0] = next;
			}
		}
		return A;
    }
}
