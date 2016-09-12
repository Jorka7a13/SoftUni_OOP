using System;
using System.IO;
using _01.Point3D;

namespace _03.Paths
{
    static class Storage
    {
        public static void SavePathToFile(Path3D path, string file)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(file, true))
                {
                    foreach (var point in path.Path)
                    {
                        writer.WriteLine(point.X + "|" + point.Y + "|" + point.Z); 
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be written to:");
                Console.WriteLine(e.Message);
            }
        }

        public static void LoadPathFromFile(Path3D path, string file)
        {
            string line;
            string[] input;

            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    while((line = sr.ReadLine()) != null)
                    {
                        input = line.Split('|');
                        path.AddPoint(new Point3D(Convert.ToDouble(input[0]), 
                            Convert.ToDouble(input[1]), 
                            Convert.ToDouble(input[2])));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}