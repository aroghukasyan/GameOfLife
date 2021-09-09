using System;

namespace GameOfLife
{
    class Program
    {
        public static object Aplication { get; private set; }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(40,10);
            Console.WriteLine("PLAY NOW ? YES - Y, NO - N");
            Console.ResetColor();
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Game game = new Game();
                game.DrawField();
            }
            else
            {
                Environment.Exit(0);
            }
          
            //                                how dont work ???
            //game.body.CellIsDies();
            //game.body.CellIsAnimate();
            //game.body.AcceptChanges();
        }
    }
}
