using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Labirynth
{
    public static class Upload
    {
        
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
