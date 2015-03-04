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
class TPoint{
    public int X;
    public int Y;
    public TPoint(int cX, int cY){
        X = cX;
        Y = cY;
    }
}

class CellType{
    public TPoint GetNext(TPoint Current, int rt, string Pos){
        int[] AD = new int [7] {1,3,7,8,9,12,13};
        int IPos = 1;
        if (Pos == "LEFT"){
            IPos = 2;
        }else if (Pos == "RIGHT"){
            IPos = 3;
        }
        TPoint Res = new TPoint(Current.X, Current.Y);
        //Always down:
        // 1, 3, 7, 8, 9, 12 ,13
        if (AD.Contains(rt)){
            Res.Y = Res.Y + 1;
        }else if (rt == 2 || rt == 6){
            if (IPos == 2){
                return new TPoint(Res.X+1, Res.Y);
            }else if (IPos == 3){
                return new TPoint(Res.X-1, Res.Y);
            }
        }else if (rt == 4){
            if (IPos == 1){
                return new TPoint(Res.X-1, Res.Y);
            }else{
                return new TPoint(Res.X, Res.Y+1);
            }
        }else if (rt == 5){
            if (IPos == 1){
                return new TPoint(Res.X+1, Res.Y);
            }else{
                return new TPoint(Res.X, Res.Y+1);
            }
        }else{
            if (rt == 10){
                return new TPoint(Res.X-1, Res.Y);
            }else if (rt == 11){
                return new TPoint(Res.X+1, Res.Y);
            }
        }
        return Res;
    }
}

class Grid{
    public int Width;
    public int Height;
    public static int[,] T;
    
    public Grid(int W,int H){
        Width = W;
        Height = H;
        T = new int[H,W];
    }
    
    static void AddCell(int x, int y, string Val){
        TPoint P = new TPoint(x,y);
        T[y,x] = int.Parse(Val);
    }
    
    public void ParseLine(int index, string Ln){
        string[] Nums = Ln.Split(' ');
        for (int i=0; i<Nums.Length; i++){
            AddCell(i,index, Nums[i]);
        }
    }
    
    public int GetRT(TPoint Pt){
        return T[Pt.Y, Pt.X];
    }
}

class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // number of columns.
        int H = int.Parse(inputs[1]); // number of rows.
        Grid G = new Grid(W,H);
        for (int i = 0; i < H; i++)
        {
            G.ParseLine(i,Console.ReadLine());
        }
        int EX = int.Parse(Console.ReadLine()); // the coordinate along the X axis of the exit (not useful for this first mission, but must be read).
        CellType C = new CellType();
        // game loop
        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int XI = int.Parse(inputs[0]);
            int YI = int.Parse(inputs[1]);
            string POS = inputs[2];
            Console.Error.WriteLine(String.Format("{0} {1} {2}",XI,YI, POS));
            
            TPoint cPt = new TPoint(XI, YI);
            int tst = G.GetRT(cPt);
            // G.GetRT(cPt);
            Console.Error.WriteLine(tst);
            TPoint Nxt = C.GetNext(cPt, tst, POS);

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine("{0} {1}", Nxt.X, Nxt.Y); // One line containing the X Y coordinates of the room in which you believe Indy will be on the next turn.
        }
    }
}