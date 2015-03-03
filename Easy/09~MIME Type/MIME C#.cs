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
        int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
        string[] E = new string [N];
        string[] M = new string [N];
        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            string EXT = inputs[0]; // file extension
            string MT = inputs[1]; // MIME type.
            E[i] = EXT.ToUpper();
            M[i] = MT;
            
        }
        string[] A = new string[Q];
        string[] R = new string[Q];
        for (int i = 0; i < Q; i++)
        {
            string ext;
            string FNAME = Console.ReadLine(); // One file name per line.
            int P = FNAME.LastIndexOf('.') +1;
            if (P == 0){
                R[i] = "UNKNOWN";
            }else{
                ext = FNAME.Substring(P, FNAME.Length - P).ToUpper();
                // ext = String.Copy(FNAME, P,  FNAME.Length - P);
                string res = "UNKNOWN";
                for (int j=0; j < N; j++){
                    if(E[j] == ext){
                        res = M[j];
                        break;
                    }
                }
                R[i] = res;
                // Console.Error.WriteLine(res);
            }
        }
        for (int i=0; i < Q; i++) {
            Console.WriteLine(R[i]);
        }
    }
}