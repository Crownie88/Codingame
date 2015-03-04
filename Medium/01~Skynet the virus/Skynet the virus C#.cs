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
        inputs = Console.ReadLine().Split(' ');
        int N = int.Parse(inputs[0]); // the total number of nodes in the level, including the gateways
        int L = int.Parse(inputs[1]); // the number of links
        int E = int.Parse(inputs[2]); // the number of exit gateways
        int[,] Ln = new int[L,2];
        for (int i = 0; i < L; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int N1 = int.Parse(inputs[0]); // N1 and N2 defines a link between these nodes
            int N2 = int.Parse(inputs[1]);
            Ln[i,0]= N1;
            Ln[i,1]= N2;
        }
        Dictionary<int, int> Lks = new Dictionary<int, int>();
        int[] X = new int[E];
        for (int i = 0; i < E; i++)
        {
            int EI = int.Parse(Console.ReadLine()); // the index of a gateway node
            X[i] = EI;
        }
        for (int i=0; i< Ln.Length/2; i++){
            if (X.Contains(Ln[i,0]) || X.Contains(Ln[i,1])){
                if (X.Contains(Ln[i,0])){
                    Lks.Add(Ln[i,1], Ln[i,0]);
                }else{
                    Lks.Add(Ln[i,0], Ln[i,1]);
                }
            }
        }

        // game loop
        bool F = true;
        KeyValuePair<int, int> fr= Lks.First();
        
        while (true)
        {
            int SI = int.Parse(Console.ReadLine()); // The index of the node on which the Skynet agent is positioned this turn
            string inp = "";
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            int Val = -1;
            if (Lks.TryGetValue(SI, out Val)){
                inp = String.Format("{0} {1}", SI, Val);
            }
            if (F){
                inp = String.Format("{0} {1}",fr.Key, fr.Value);
                F = false;
            }
            Console.WriteLine(inp); // Example: 0 1 are the indices of the nodes you wish to sever the link between
        }
    }
}