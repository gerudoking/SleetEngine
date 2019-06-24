using System;
using OpenTK;

namespace SleetEngine
{
    class Program
    {
        public static void Main(string[] args)
        {
            GameWindow window = new GameWindow(800, 600);
            enginewindow gm = new enginewindow(window);
        }
    }
}
