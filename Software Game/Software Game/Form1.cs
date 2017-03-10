using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        enum Keycode
        {
            NoAction,
            MoveUp,
            MoveRight,
            MoveDown,
            Moveleft,
            PreformAction
        }


    }
}
