using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] players = { "mumu", "soe", "poe", "kai", "mine" };
            string[] callings = {"kai", "kai", "mine", "mine"};
            
            Dictionary<int, string> nameDict = new Dictionary<int, string>();
            Dictionary<string, int> idxDict = new Dictionary<string, int>();

            for (int i = 0; i < players.Length; i++) 
            {
                nameDict[i] = players[i];
                idxDict[players[i]] = i;
            }

            for(int i = 0; i < callings.Length; i++) 
            {
                int curIdx = idxDict[callings[i]];
                string fall = nameDict[curIdx - 1];

                nameDict[curIdx - 1] = callings[i];
                nameDict[curIdx] = fall;

                idxDict[callings[i]] = curIdx - 1;
                idxDict[fall] = curIdx;             
            }

            string[] answer = new string[players.Length];
            for(int i = 0; i < players.Length; i++) 
            {
                answer[i] = nameDict[i];
            }

            foreach(string s in answer) 
            {
                Console.WriteLine(s);
            }
        }
    }
}
