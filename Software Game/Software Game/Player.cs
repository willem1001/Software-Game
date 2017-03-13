using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Software_Game
{
    public class Player : Character
    {


        public Boolean PowerUp { get; private set; }

        //constructor
        public Player(Point position, Boolean powerUp, int hitpoints)
        {
            Position = position;
            PowerUp = powerUp;
            Hitpoints = hitpoints;
        }


        //methodes
        public void interaction(int key)
        { 
            //voor verschillende toetsen is er een bepaalde actie
            switch (key)
            {
                default:
                {
                    break;
                }
                case 1:
                {
                    Position = new Point(Position.X, Position.Y - 1);
                    break;
                }
                case 2:
                {
                    Position = new Point(Position.X + 1, Position.Y);
                    break;
                }
                case 3:
                {
                    Position = new Point(Position.X, Position.Y + 1);
                    break;
                }
                case 4:
                {
                    Position = new Point(Position.X - 1, Position.Y);
                    break;
                }
                case 5:
                {
                    break;
                }
            }
        }
    }
}
