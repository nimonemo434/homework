using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool _letOut = false;
            int posY = 0;
            CursorVisible = false;

            SetCursorPosition(15, 9);
            WriteLine("시작");
            SetCursorPosition(15, 10);
            WriteLine("종료");

            do
            {
                for (int k = 0; k < 4; k++)
                {
                    SetCursorPosition(10, k + 9);
                    Write("  ");
                }
                SetCursorPosition(10, posY + 9);
                Write("▶");

                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        posY--;
                        if (posY < 0)
                        {
                            posY = 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        posY++;
                        if (posY > 1)
                        {
                            posY = 0;
                        }
                        break;
                    case ConsoleKey.Enter:
                        _letOut = true;
                        break;
                }

            } while (!_letOut);

            SetCursorPosition(0, 0);
        }
    }
}
