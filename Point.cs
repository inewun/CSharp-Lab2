using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory2
{
    internal class Point
    {
        private int _x;
        private int _y;

        public int X 
        { 
            get => _x;
            set => _x = value;
        } 

        public int Y 
        {
            get => _y;
            set => _y = value;
        }

        /// <summary>
        /// Creates a point with coordinates (x, y) = (0, 0).
        /// </summary>
        public Point()
        {
            X = 0;
            Y = 0;
        }

        /// <summary>
        /// Creates a point with coordinates (x, y).
        /// </summary>
        /// <param name="x"> Sets the x-axis coordinate.</param>
        /// <param name="y"> Sets the y-axis coordinate.</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Returns a string in the format "Point {name} with coordinates {x: {x} y: {y}}"
        /// </summary>
        public override string ToString()
        {
            return $"{{{X};{Y}}}";
        }
    }
}
