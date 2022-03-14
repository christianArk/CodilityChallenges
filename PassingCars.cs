using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int countEastCars = 0;
        int countPairs = 0;

        for (int i = 0; i <= A.Length - 1; i++)
        {
            if (A[i] == 0)
            {
                countEastCars++;
            } else {
                countPairs += countEastCars;
                if (countPairs > 1000000000)
                    return -1;
            }
        }

        return countPairs;
    }
}
