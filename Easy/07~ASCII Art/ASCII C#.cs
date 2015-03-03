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
        
        string A = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();
        string[] B = new string[H];
        string[] Res = new string[H];
        
        for (int i = 0; i < H; i++)
        {
            string ROW = Console.ReadLine();
            B[i] = ROW;
        }
        string S = "";
        
        int RW=0;
        int Ind=0;
        // Console.Error.WriteLine(T);
        // Console.Error.WriteLine(L);
        // Console.Error.WriteLine(H);
        T = T.ToUpper();
        for (int X = 0; X < H; X++){
            Res[RW] = "";
            foreach(Char C in T){
                Ind = A.IndexOf(C);
                if (Ind == -1){
                    Ind = 27;
                }
                // Console.Error.WriteLine(L*Ind);
                if (Ind == 27){
                    Res[RW] = string.Format("{0}{1}", Res[RW],B[RW].Substring((L*Ind)-L,L));
                }else{
                    Res[RW] = string.Format("{0}{1}", Res[RW],B[RW].Substring((L*Ind),L));
                }
            }
            RW++;
        }
        
        for (int X = 0; X < H; X++){
            Console.WriteLine(Res[X]);
        }
    }
}