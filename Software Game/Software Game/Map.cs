using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Software_Game
{
    public class Map
    {
        //properties
        public Size MapSize { get; private set; }
        public Size CellSize { get; private set; }
        public Size CellCount { get; private set; }
        public Point GoalPosition { get; private set; }

        //constructor
       public Map(Size mapSize, Size cellSize, Size cellCount, Point goalPosition)
        {
            MapSize = mapSize;
            CellSize = cellSize;
            CellCount = cellCount;
            GoalPosition = goalPosition;
        }

        //methods
        public void Draw(Graphics g)
        {

        }

    }
}
