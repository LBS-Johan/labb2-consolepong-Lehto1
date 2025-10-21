using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Paddle
    {
        int x;
        int y;
        int size;

        public Paddle(int y, int x, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }

        public void Move(int yAmount)
        {
            y =+ yAmount;
        }

        public void Draw()
        {
            Console.SetCursorPosition(y, x);
            Console.Write("|");
        }
    }
}
