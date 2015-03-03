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
        string[] inputs = Console.ReadLine().Split(' ');
        int LX = int.Parse(inputs[0]); // the X position of the light of power
        int LY = int.Parse(inputs[1]); // the Y position of the light of power
        int TX = int.Parse(inputs[2]); // Thor's starting X position
        int TY = int.Parse(inputs[3]); // Thor's starting Y position
        int DX = TX-LX;
        int DY = TY-LY;
        // game loop
        while (true)
        {
            string X="";
            string Y="";
            
            if(DY>0){
                Y="N";
                DY--;
            }else if(DY<0){
                Y="S";
                DY++;
            }
            if(DX>0){
                X="W";
                DX--;
            }else if(DX<0){
                X="E";
                DX++;
            }
            Console.WriteLine(Y+X);
        }
    }
}