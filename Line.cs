using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory2
{
    internal class Line
    {
        private Point _start;
        private Point _end;

        public Point StartPoint 
        { 
            get { return _start; } 
            set { _start = value; }
        }

        public Point EndPoint
        {
            get { return _end; }
            set { _end = value; }
        }

        /// <summary>
        /// Creates a line with start and end points at coordinates (0, 0).
        /// </summary>
        public Line()
        {
            StartPoint = new Point(0, 0);
            EndPoint = new Point(1, 1);
        }

        /// <summary>
        /// Creates a line with the given start and end points.
        /// </summary>
        /// <param name="start">Set the starting point of the line.</param>
        /// <param name="end">Set the end point of the line.</param>
        public Line(Point start, Point end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        /// <summary>
        /// Creates a line with the specified start and end coordinates along the x and y axes.
        /// </summary>
        /// <param name="x1">Specifies the starting point of the x-axis coordinates.</param>
        /// <param name="y1">Specifies the starting point of the y-axis coordinates.</param>
        /// <param name="x2">Specifies the end point of the x-axis coordinates.</param>
        /// <param name="y2">Specifies the end point of the y-axis coordinates.</param>
        public Line(int x1, int y1, int x2, int y2)
        {
            StartPoint = new Point(x1, y1);
            EndPoint = new Point(x2, y2);
        }

        /// <summary>S
        /// Returns the length of the line.
        /// </summary>
        public int Length()
        {
            return (int)Math.Round(Math.Sqrt(
                Math.Pow(EndPoint.X - StartPoint.X, 2) +
                Math.Pow(EndPoint.Y - StartPoint.Y, 2)));
        }

        /// <summary>S
        /// Returns a string in the format "Point {name} with coordinates {x: {x} y: {y}}"
        /// </summary>
        public override string ToString()
        {
            return $"Line from {StartPoint.ToString()} to {EndPoint.ToString()}";
        }
    }
}
