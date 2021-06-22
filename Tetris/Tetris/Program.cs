using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowPosition(40, 30);
            Console.SetBufferSize(40, 30);
            int x1 = 3;
            int y1 = 4;
            char c1 = '*';
            int y2 = 5;
            int y3 = 6;

            Draw(x1, y1, c1);
            Draw(x1, y2, c1);
            Draw(x1, y3, c1);


            Console.ReadLine();

        }
        static void Draw(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);

            Console.Write(c);
        }
    }
}
