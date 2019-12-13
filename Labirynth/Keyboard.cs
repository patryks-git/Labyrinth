using System;
using System.Collections.Generic;
using System.Text;

namespace Labyrinth
{
    public static class Keyboard
    {
        public static char Key { get; private set; }
        public static char GetKeyMove()
        {
            return Convert.ToChar(Console.Read());
        }        
        public static int[] GetHorizonData()
        {

            return [1, 2, 3];
        }
    }
}
