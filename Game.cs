

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Game
{
    public class Game
    {
        //modified Step7
        //modified in master
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Team1Score { get; set; }
        public int Team2Score { get; set; }
        //modified in branch
        public Game()
        {

        }

        
        //step 11 branch_1
=======
        //step 11

        public Game(string Team1, string Team2, int Team1Score, int Team2Score)
        
        {
            this.Team1 = Team1;
            this.Team2 = Team2;
            this.Team1Score = Team1Score;
            this.Team2Score = Team2Score;
        }

        public override string ToString()
        {
            return Team1 + " (" + Team1Score + ") - " + Team2 + " (" + Team2Score + ")";
        }
    }
}
