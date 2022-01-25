using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongPongClasses
{
    public class TicTacToe
    {
        bool playedBefore = false;
        
        public bool Play(char letter, int number)
        {
            if(playedBefore == true)
            {
                return false;
            }
            
            playedBefore = true;
            return true;
        }
    }
}
