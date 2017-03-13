using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Software_Game
{
    public class Enemy : Character
    {
        //constructor
        public Enemy(Point position, int hitPoints)
        {
            Position = position;
            Hitpoints = hitPoints;
        }

        //methodes
        private void attack(Player player)
        {
            Random random = new Random();            
            player.update(random.Next(0, 10));
        }
    }
}
