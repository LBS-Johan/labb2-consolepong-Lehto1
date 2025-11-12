using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Game
    {
        int width;
        int height;
        Paddle p1;
        Paddle p2;
        public void StartGame()
        {
            // Setup konsol-fönstret
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            Console.CursorVisible = false;

            Paddle p1 = new Paddle(1, 2, 4);
            Paddle p2 = new Paddle(4, 6, 9);
        }

        public bool Run()
        {
            //Töm hela skärmen i början av varje uppdatering.
            Console.Clear();
            p1.Draw();
            p2.Draw();

            if (Input.IsPressed(ConsoleKey.UpArrow))
            {
                //Flytta spelare 1 uppåt
                p1.Move(1);
            }
            if (Input.IsPressed(ConsoleKey.DownArrow))
            {
                //Flytta spelare 1 nedåt
                p1.Move(-1);
            }

            if (Input.IsPressed(ConsoleKey.W))
            {
                //Flytta spelare 2 uppåt
                p2.Move(1);
            }
            if (Input.IsPressed(ConsoleKey.S))
            {
                //Flytta spelare 2 nedåt
                p2.Move(-1);
            }



            //Return true om spelet ska fortsätta
            return true;

        }
    }
}
