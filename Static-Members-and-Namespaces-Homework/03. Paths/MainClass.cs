// Problem 3.* Paths

// Create a class Path3D to hold a sequence of points in the 3D space.
// Create a static class Storage with static methods to save and load paths from a text file.

namespace _03.Paths
{
    class MainClass
    {
        public static void Main()
        {
            Path3D path = new Path3D();
            Storage.LoadPathFromFile(path, "..\\..\\txts\\load.txt");
            Storage.SavePathToFile(path, "..\\..\\txts\\save.txt");
        }
    }
}