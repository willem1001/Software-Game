using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Software_Game
{
    class Enemy
    {
        //fields
        private Point Position;
        private int HitPoints;

        //constructor
        public Enemy(Point position, int hitPoints)
        {
            Position = position;
            HitPoints = hitPoints;
        }

        //methodes
        private void update()
        {

        }

        private void draw(Graphics g)
        {
            
        }

        private void attack(Player player)
        {
            
        }
    }
}
