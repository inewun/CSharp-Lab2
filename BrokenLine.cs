using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory2
{
    internal class BrokenLine
    {
        private List<Point> _points;

        public List<Point> Points
        {
            get { return _points; }
            set { _points = value; }
        }

        public BrokenLine()
        {
            Points = new List<Point> 
            { 
                new Point(0, 0), 
                new Point(0, 1), 
                new Point(1, 2) 
            };
        }

        public BrokenLine(params Point[] points)
        {
            Points = new List<Point>(points);
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < _points.Count; i++)
            {
                result += _points[i].ToString();
                if (i < _points.Count - 1)
                {
                    result += ", ";
                }
            }
            return $"Line[{result}]";
        }
    }
}
