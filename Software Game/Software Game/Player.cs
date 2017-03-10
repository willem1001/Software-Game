using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Software_Game
{
    class Player
    {
        //fields
        private Point Position;
        private Boolean PowerUp;
        private int Hitpoints;

        //constructor
         public Player(Point position, Boolean powerUp, int hitpoints)
        {
            Position = position;
            PowerUp = powerUp;
            Hitpoints = hitpoints;
        }


        //methodes
        public void update()
        {

        }

        public void draw(Graphics g)
        {

        }

        public void interaction(int keyCode)
        {

        }
    }
}
