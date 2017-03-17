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
        public void attack(Player player)
        {
            Random random = new Random();            
            player.update(random.Next(1, 10));
        }

        public void move()
        {
            Random random = new Random();
            int direction = random.Next(1, 5);

            switch (direction)
            {
                default:
                    break;
                case 1:
                    Position = new Point(Position.X +5, Position.Y);
                    break;
                case 2:
                    Position = new Point(Position.X - 5, Position.Y);
                    break;
                case 3:
                    Position = new Point(Position.X, Position.Y + 5);
                    break;
                case 4:
                    Position = new Point(Position.X, Position.Y - 5);
                    break;

            }

        }
    }
}
