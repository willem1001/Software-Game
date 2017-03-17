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
        Enemy enemy = new Enemy(new Point(30, 30), 5);

        public Form1()
        {
            InitializeComponent();
            button1.Text = player.Hitpoints.ToString();

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
            enemy.move();
            button2.Top = enemy.Position.Y;
            button2.Left = enemy.Position.X;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enemy.attack(player);
            button1.Text = player.Hitpoints.ToString();
        }
    }
}
