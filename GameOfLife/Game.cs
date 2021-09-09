using System;
using System.Threading;

namespace GameOfLife
{
    class Game
    {
        public static int x;
        public static int y;
        public Body body = new Body();
        public Game()
        {
            x = 25;
            y = 25;
        }
        // Draw game process.
        public void DrawField()
        {
            bool isLife = false;
            while (true) 
            {
                Console.Clear();
                for (int j = 0; j < x; j++)
                {
                    for (int i = 0; i < y; i++)
                    {
                        foreach (var item in body)
                        {
                            if (i == item.x & j == item.y)
                            {
                                Matrix.arr[i, j] = 1;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" * ");
                                Console.ForegroundColor = ConsoleColor.White;
                                isLife = true;
                            }
                        }
                        if (isLife)
                        {
                            isLife = false;
                        }
                        else
                        {
                            Matrix.arr[i, j] = 0;
                            Console.Write(" - ");
                        }
                    }
                    Console.WriteLine();
                }
                body.CellIsDies();
                body.CellIsAnimate();
                body.AcceptChanges();
                Thread.Sleep(300);
            }
        }
    }
}
