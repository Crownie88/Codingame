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
    static List<Num> MkList(string S){
        string[] A = S.Split(' ');
        List<Num> R = new List<Num>();
        int N = int.Parse(A[0]);
        Num C = new Num(1,N);

        for (int i=1; i<A.Length; i++){
            if (int.Parse(A[i]) != N){
                R.Add(C);
                C = new Num(1, int.Parse(A[i]));
            }else if(int.Parse(A[i]) == N){
                C.Inc();
            }
            N = int.Parse(A[i]);
        }
        R.Add(C);
        return R;
    }
    static string CS(List<Num> Lst){
        string Re = Lst[0].Conv2Str();
        for (int i=1; i<Lst.Count; i++){
            Re = Re + " " + Lst[i].Conv2Str();
        }
        return Re.Trim();
    }
    static void Main(string[] args)
    {
        int R = int.Parse(Console.ReadLine());
        int L = int.Parse(Console.ReadLine());
        List<List<Num>> Ns = new List<List<Num>>();
        Ns.Add(MkList(R.ToString()));
        Ns[0][0].F = true;
        string str = CS(Ns[0]);
        for (int i=0; i<L-1; i++){
            str = CS(Ns[i]);
            Ns.Add(MkList(str.Trim()));
        }
        Console.WriteLine(CS(Ns.Last()));
    }
}

class Num
{
    public int T;
    public int N;
    public bool F;
    public Num(int cT, int cN){
        T = cT;
        N = cN;
    }
    public void Inc(){
        T++;
    }
    public string Conv2Str(){
        if (F){
            return N.ToString();
        }
        return String.Format("{0} {1}", T, N);
    }
}