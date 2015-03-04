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

class cExit
{
    public int Floor;
    public int Pos;
    public void SetExit(int cFloor, int cPos){
        Floor = cFloor;
        Pos = cPos;
    }
}

class cElevator
{
    public int Floor;
    public int Pos;
    public void SetElevator(int cFloor, int cPos){
        Floor = cFloor;
        Pos = cPos;
    }
}

class Elevators
{
    public List<cElevator> Collection = new List<cElevator>();
    public void Add(int cFloor, int cPos){
        cElevator E = new cElevator();
        E.SetElevator(cFloor, cPos);
        Collection.Add(E);
    }
    public cElevator FindElevator(int cFloor){
        for (int i=0; i< Collection.Count; i++){
            if (Collection[i].Floor == cFloor){
                return Collection[i];
            }
        }
        if (Collection.Count > 0){
            return Collection[0];    
        }else{
            return null;
        }
        
    }
}

class Clone{
    public int Pos;
    public int Floor;
    public string Dir;
    bool CorrectFloor;
    
    public void ParseLn(string Line){
        string[] D = Line.Split(' ');
        Floor = int.Parse(D[0]);
        Pos = int.Parse(D[1]);
        Dir = D[2];
    }
    
    public string DoAction(cExit E, Elevators EL){
        bool MustBlock = false;
        int ELoc;
        if (IsCFloor(E)){
            if (E.Pos > Pos){
                if (Dir == "LEFT"){
                    MustBlock = true;
                }
            }else if (E.Pos < Pos){
                if (Dir == "RIGHT"){
                    MustBlock = true;
                }
            }
        }else{
            cElevator cE = EL.FindElevator(Floor);
            if (cE == null){
                return "WAIT";
            }
            ELoc = cE.Pos;
            if (ELoc > Pos){
                if (Dir == "LEFT"){
                    MustBlock = true;
                }
            }else if (ELoc < Pos){
                if(Dir == "RIGHT"){
                    MustBlock = true;
                }
            }
        }
        string Res = (MustBlock) ? "BLOCK" : "WAIT";
        return Res;
    }
    
    private bool IsCFloor(cExit X){
        return X.Floor == Floor;
    }
}
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int nbFloors = int.Parse(inputs[0]); // number of floors
        int width = int.Parse(inputs[1]); // width of the area
        int nbRounds = int.Parse(inputs[2]); // maximum number of rounds
        int exitFloor = int.Parse(inputs[3]); // floor on which the exit is found
        int exitPos = int.Parse(inputs[4]); // position of the exit on its floor
        int nbTotalClones = int.Parse(inputs[5]); // number of generated clones
        int nbAdditionalElevators = int.Parse(inputs[6]); // ignore (always zero)
        int nbElevators = int.Parse(inputs[7]); // number of elevators
        
        Elevators EV = new Elevators();
        
        for (int i = 0; i < nbElevators; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int Fl = int.Parse(inputs[0]); // floor on which this elevator is found
            int Ps = int.Parse(inputs[1]); // position of the elevator on its floor
            EV.Add(Fl, Ps);
        }

        cExit G = new cExit();
        G.SetExit(exitFloor, exitPos);

        // game loop
        while (true)
        {
            Clone L = new Clone();
            L.ParseLn(Console.ReadLine());
            Console.WriteLine(L.DoAction(G, EV));
        }
    }
}