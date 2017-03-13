using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Software_Game
{
    public class Cell
    {
        //fields
        private Point Index;
        private Point Position;
        private Type Celltype;

        enum enumCeltype
        {
            Normal,
            Goal,
            Wall
        }

        //constructor
        public Cell(Point index, Point position, Type celType)
        {
            Index = index;
            Position = position;
            Celltype = celType;
        }

        //methodes
        private void draw(Graphics g)
        {

        }
    }
}
