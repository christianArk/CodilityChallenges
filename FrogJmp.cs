using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int Y, int D) {
        var diff = Y - X;
        return (int)Math.Ceiling(((double)diff/(double)D));
    }
}
