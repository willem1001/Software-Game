﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Game
{
    class World
    {
        public Boolean GameWon { get; }
        public Boolean GameLost { get; }

        private void update()
        {
           
        }

        private void draw(Graphics g)
        {

        }

        public static World Instance
        {
            get
            {
                if (World.instance == null)
                {
                    World.instance = new World();
                }
                return World.instance;
            }
        }
        private static World instance;
    }
}
