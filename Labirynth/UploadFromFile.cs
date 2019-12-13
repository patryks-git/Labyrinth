using System;
using System.Collections.Generic;
using System.IO;

namespace Labyrinth
{
    public static class UploadFromFile
    {
        public static string FilePath { get; private set; }
        public static void ChooseFilePath(string filePath)
        {
            if (File.Exists(filePath))
            {
                FilePath = filePath;
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
        public static List<string> UploadMap(string filePath)
        {
            
            if (File.Exists(filePath))
            {
                List<string> map = new List<string>();
                foreach (string mapLine in File.ReadAllLines(filePath))
                {
                    map.Add(mapLine);
                }
                return map;
            }
            else
                Console.WriteLine("File not found.");
                return null;
        }
    }
}
