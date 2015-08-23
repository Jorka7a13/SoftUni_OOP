using System.Collections.Generic;
using _01.Point3D;

namespace _03.Paths
{
    class Path3D
    {
        private List<Point3D> path = new List<Point3D>();

        public List<Point3D> Path
        {
            get { return this.path; }
        }

        public void AddPoint(Point3D point)
        {
            path.Add(point);
        }
    }
}