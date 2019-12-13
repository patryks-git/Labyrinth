using System;
using System.Collections;
using System.Collections.Generic;


namespace Labyrinth
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> map = new List<string>();
            string path = @"C:\Users\paatryyk7\Desktop\olc3DProject\map.txt";
            map = UploadFromFile.UploadMap(path);
            //foreach(string maped in map)
            //{
            //    Console.WriteLine(maped);
            //}

            var player = new Entity();
            player.EntityChar = 'O';

            for(int i = 0; i < 3; i++)
            {
            Console.WriteLine(map[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine(map[0]);
            Console.WriteLine(player.MoveHorizonMapLine(1, map[1], false));
            Console.WriteLine(map[2]);
        }
    }
}
