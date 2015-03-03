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
class Player
{
    static void Main(string[] args)
    {
        int R = int.Parse(Console.ReadLine()); // the length of the road before the gap.
        int G = int.Parse(Console.ReadLine()); // the length of the gap.
        int L = int.Parse(Console.ReadLine()); // the length of the landing platform.
        string C;
        int WS = G+1;
        bool J=false;
        
        // game loop
        while (true)
        {
            C="WAIT";
            int S = int.Parse(Console.ReadLine()); // the motorbike's speed.
            int X = int.Parse(Console.ReadLine()); // the position on the road of the motorbike.
            

            if(S<G+1){
                C = "SPEED";
            }else if (S>G+1){
                C="SLOW";
            }
            if(!J && R-X<2){
                C="JUMP";
            }
            
            if(X>R){
                C="SLOW";
            }
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(C); // A single line containing one of 4 keywords: SPEED, SLOW, JUMP, WAIT.
        }
    }
}