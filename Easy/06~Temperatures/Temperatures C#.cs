using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string TEMPS = Console.ReadLine() ?? ""; // the N temperatures expressed as integers ranging from -273 to 5526
        int R = 20000;
        bool RNeg = false;
        bool Neg = false;
        if(TEMPS.Length >0){
            foreach (string C in TEMPS.Split()){
                int X = Convert.ToInt32(C);
                Neg = X < 0;
                if (Neg){
                    X = X* -1;
                }
                if(X<R){
                    R = X;
                    RNeg = Neg;
                }else if(X==R){
                    if (RNeg && !Neg){
                        RNeg = false;
                    }
                }
                
            }
            if (RNeg){
                    R = R * -1;
                }
        }
        if (R==20000){
            R=0;
        }
            
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        // Console.Error.WriteLine(N);
        // Console.Error.WriteLine(TEMPS);
        // Console.Error.WriteLine(A.Length);
        Console.WriteLine(R);
    }
}