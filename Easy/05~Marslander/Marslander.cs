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
        string[] inputs;
        int[] A1 = {7,9,13};
        int[] A2 = {15,20,21};
        int[] A3 = {24,26,28};
        int[] A4 = {30,35,40,43};
        int N = int.Parse(Console.ReadLine()); // the number of points used to draw the surface of Mars.
        for (int i = 0; i < N; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int LAND_X = int.Parse(inputs[0]); // X coordinate of a surface point. (0 to 6999)
            int LAND_Y = int.Parse(inputs[1]); // Y coordinate of a surface point. By linking all the points together in a sequential fashion, you form the surface of Mars.
        }
        int C=0;
        int IA=-1;
        // game loop
        while (true)
        {
            
            inputs = Console.ReadLine().Split(' ');
            int X = int.Parse(inputs[0]);
            int Y = int.Parse(inputs[1]);
            int HS = int.Parse(inputs[2]); // the horizontal speed (in m/s), can be negative.
            int VS = int.Parse(inputs[3]); // the vertical speed (in m/s), can be negative.
            int F = int.Parse(inputs[4]); // the quantity of remaining fuel in liters.
            int R = int.Parse(inputs[5]); // the rotation angle in degrees (-90 to 90).
            int P = int.Parse(inputs[6]); // the thrust power (0 to 4).
            C++;
            IA=5;
            
            if(VS < -39){
                IA=4;
            }else if(VS < -32){
                IA=5;
            }else if(VS < -32){
                IA=2;
            }else if(VS < 0){
                IA=5;
            }

            string S="0 0";
            switch(IA){
                case 1:S="0 1";break;
                case 2:S="0 2";break;
                case 3:S="0 3";break;
                case 4:S="0 4";break;
                default:S="0 0";break;
            }
            
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            // if(Y<=1500)
            // if(Y <=2300){
            //     Console.WriteLine("0 2"); // R P. R is the desired rotation angle. P is the desired thrust power.
            // }else{
            //     Console.WriteLine("0 0"); // R P. R is the desired rotation angle. P is the desired thrust power.
            // }
            Console.WriteLine(S);
            
        }
    }
}