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
    // List <string> Res = New List <string>();
    public static byte[] ConvertToByteArray(string str, Encoding encoding)
    {
        return encoding.GetBytes(str);
    }
    public static String ToBinary(Byte[] data)
    {
        return string.Join("", data.Select(byt => Convert.ToString(byt, 2).PadLeft(7, '0')));
    }

    static void Main(string[] args)
    {
        List<string> Re = new List<string>(); 
        string MESSAGE = Console.ReadLine();
        bool IsOne = false;
        string Bin = ToBinary(ConvertToByteArray(MESSAGE, Encoding.ASCII));
        char[] BA = Bin.ToCharArray();
        char C = '!';
        
        string S="";
        foreach (char CH in Bin){
            if (CH != C){
                if (S != ""){
                    Re.Add(S);
                    S = "";                    
                }
                C = CH;
            }
            S = S + C;
        }
        if(S!=""){
            Re.Add(S);    
        }
        string RS = "";
        string T;
        // Console.Error.WriteLine(Re.Count);
        for (int i=0; i < Re.Count; i++){
            // Console.Error.WriteLine(Re[i]);
            T = new String('0',Re[i].Length);
            if (Re[i].StartsWith("1")){
                RS = RS + String.Format(" {0} {1}","0", T);
            }else{
                RS = RS + String.Format(" {0} {1}","00", T);
            }
        }
        RS = RS.TrimStart();        
        Console.WriteLine(RS);
    }
}