using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Drawing;

namespace Software_Game
{
    public class Character
    {
        public Point Position { get; set; }
        public int Hitpoints { get; set; }

        public void update(int damage)
        {
            Hitpoints -= damage;
        }

        public void draw(Graphics g)
        {

        }

    }
}
