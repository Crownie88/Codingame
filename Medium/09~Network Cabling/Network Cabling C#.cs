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
class TPoint
{
    public long X;
    public long Y;
    public TPoint(long cX, long cY){
        X = cX;
        Y = cY;
    }
}
class cParser
{
    public List<TPoint> GenList(int N){
        List<TPoint> R = new List<TPoint>();
        for (int i=0; i<N; i++){
            string[] S = Console.ReadLine().Split(' ');
            TPoint P = new TPoint(long.Parse(S[0]), long.Parse(S[1]));
            R.Add(P);
        }
        return R;
    }
} 
class Solution
{
    static void Main(string[] args)
    {
        cParser c = new cParser();
        int N = int.Parse(Console.ReadLine());
        List<TPoint> Pts = c.GenList(N);
        long[] A = new long[N];
        long[] B = new long[N];
        for (int i=0; i < N; i++){
            A[i] = Pts[i].X;
            B[i] = Pts[i].Y;
        }
        long xMin = A.Min(), xMax = A.Max();
        long yAvg = Convert.ToInt64(B.Average());
        long yC = 0;
        long minDist=long.MaxValue;
        foreach (TPoint Pt in Pts){
            if (Math.Abs(Pt.Y - yAvg) < minDist){
                minDist = Math.Abs(Pt.Y - yAvg);
                yC = Pt.Y;
            }
        }
        long Sol = xMax - xMin;
        foreach (TPoint Pt in Pts){
            Sol += Math.Abs(Pt.Y - yC);
        }
        Console.WriteLine(Sol);
    }
}