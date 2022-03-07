using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
        // convert N to binary
        var currRemainder = 0;
        Stack<int> remainders = new Stack<int>();
        do {
            currRemainder = N % 2;
            N = N / 2;
            remainders.Push(currRemainder);
        } while (N > 0);

        int counter = 0;
        var zeros = new List<int>();
        var check = remainders.ToArray();
        for (int i = 0; i < remainders.Count; i++)
        {
            if (check[i] == 0) {
                counter++;
            } else {
                zeros.Add(counter);
                counter = 0;
            }
        }
        
        return zeros.Max(x => x);
    }
}
