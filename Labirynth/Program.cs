using System;
using System.Collections.Generic;


namespace Labirynth
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> map = new List<string>();
            string path = @"C:\Users\paatryyk7\Desktop\olc3DProject\map.txt";
            map = Upload.UploadMap(path);
            foreach(string maped in map)
            {
                Console.WriteLine(maped);
            }
            
        }
    }
}
