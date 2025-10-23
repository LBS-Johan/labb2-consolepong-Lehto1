using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Ball
    {
        int y;
        int x;
        int xVelocity;
        int yVelocity;

        public Ball(int y, int x, int yVelocity, int xVelocity)
        {
            this.y = y;
            this.x = x;
            this.yVelocity = yVelocity;
            this.xVelocity = xVelocity;
        }

        void Move()
        {



        }
    }
}
