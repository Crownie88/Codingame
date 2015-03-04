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
    struct MyPoint{
        public int X;
        public int Y;
        public int W0;
        public int H0;
        public int W1;
        public int H1;
        
        public void SetVals(int mx,int my,int bw, int bh){
            X = mx;
            Y = my;
            W0 = 0;
            H0 = 0;
            W1 = bw-1;
            H1 = bh-1;
        }
        
        private void U(){
            H1 = Y;
            int t = Convert.ToInt32(Math.Round((Y-H0)/2.0));
            if (t==0){t++;}
            Y= Y - t;
        } 
        private void R(){
            W0 = X;
            int t = Convert.ToInt32(Math.Round((W1-X)/2.0));
            if (t==0){t++;}
            X = X+t;
        }
        private void D(){
            H0 = Y;
            int t = Convert.ToInt32(Math.Round((H1-Y)/2.0));
            if (t==0){t++;}
            Y= Y+t;
        } 
        private void L(){
            W1 = X;
            int t = Convert.ToInt32(Math.Round((X-W0)/2.0));
            if (t==0){t++;}
            X = X-t;
        }
        
        public void DoDir(char C){
            switch (C){
                case 'U':
                  U();
                  break;
                case 'R':
                  R();
                  break;
                case 'D':
                  D();
                  break;
                 case 'L':
                   L();
                   break;
            }
        }
        
    }
    
    static void Main(string[] args)
    {
        
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // width of the building.
        int H = int.Parse(inputs[1]); // height of the building.
        int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
        inputs = Console.ReadLine().Split(' ');
        int X0 = int.Parse(inputs[0]);
        int Y0 = int.Parse(inputs[1]);
        MyPoint BM = new MyPoint();
        BM.SetVals(X0,Y0,W,H);
        // game loop
        while (true)
        {
            string BOMB_DIR = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)
            BM.DoDir(BOMB_DIR[0]);
            if (BOMB_DIR.Length==2){
                BM.DoDir(BOMB_DIR[1]);
            }
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(String.Format("{0} {1}", BM.X, BM.Y)); // the location of the next window Batman should jump to.
        }
    }
}