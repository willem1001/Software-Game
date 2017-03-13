using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Game
{
    public partial class Form1 : Form
    {
        Player player = new Player(new Point(0,0), false, 100);

        public Form1()
        {
            InitializeComponent();

        }
        public enum Keycode
        {
            NoAction,
            MoveUp,
            MoveRight,
            MoveDown,
            Moveleft,
            PreformAction
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                default:
                {
                    player.interaction(0);
                    break;
                }
                case Keys.W:
                {
                        player.interaction(1);
                        break;
                }
                case Keys.D:
                {
                        player.interaction(2);
                        break;
                }
                case Keys.S:
                {
                        player.interaction(3);
                        break;
                }
                case Keys.A:
                {
                        player.interaction(4);
                        break;
                }
                case Keys.Space:
                {
                        player.interaction(5);
                        break;
                }
            }
            button1.Left = player.Position.X;
            button1.Top = player.Position.Y;
        }
    }
}
