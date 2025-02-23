
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Console;

namespace Lab_6;
internal class Program
{
    public static void Main()
    {
        Program program = new Program();
        
        Blue_4.Team man1 = new Blue_4.Team("mama");
        Blue_4.Team man2 = new Blue_4.Team("bebra");      
        Blue_4.Team man3 = new Blue_4.Team("circkul");      
        

        int[] jump1 = {1,0,0,0,3,0,1,0,1,3,0,0}; 
        int[] jump2 = {0,0,1,3,3,1,0,3,0,3,1,3,3,0,1,1,1,1,0,1}; 
        int[] jump3 = {1,1,1,3,0,3,3,0,3,3,3,1}; 

        foreach(int i in jump1)
            man1.PlayMatch(i);
        foreach(int i in jump2)
            man2.PlayMatch(i);
        foreach(int i in jump3)
            man3.PlayMatch(i);

        Blue_4.Group a = new Blue_4.Group("pipi");
        a.Add(man1);
        Blue_4.Team[] b = {man2,man3};
        a.Add(b);
        // a.Teams[2].Scores
        a.Print();
            
    }
}

