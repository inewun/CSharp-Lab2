using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory2
{
    /// <summary>
    /// Represents a line segment with start and end points.
    /// </summary>
    internal class Line
    {
        private Point _start;
        private Point _end;

        /// <summary>
        /// Gets or sets the starting point of the line.
        /// </summary>
        public Point StartPoint
        {
            get => _start;
            set => _start = value;
        }

        /// <summary>
        /// Gets or sets the ending point of the line.
        /// </summary>
        public Point EndPoint
        {
            get => _end;
            set => _end = value;
        }

        /// <summary>
        /// Gets the length of the line.
        /// </summary>
        public int Length
        {
            get
            {
                return (int)Math.Round(Math.Sqrt(
                Math.Pow(EndPoint.X - StartPoint.X, 2) +
                Math.Pow(EndPoint.Y - StartPoint.Y, 2)));
            }
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Line"/> class with default points.
        /// Start point is (0, 0) and end point is (1, 1).
        /// </summary>
        public Line()
        {
            StartPoint = new Point(0, 0);
            EndPoint = new Point(1, 1);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line"/> class with the specified start and end points.
        /// </summary>
        /// <param name="start">The starting point of the line.</param>
        /// <param name="end">The ending point of the line.</param>
        public Line(Point start, Point end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Line"/> class with the specified coordinates.
        /// </summary>
        /// <param name="x1">The x-coordinate of the starting point.</param>
        /// <param name="y1">The y-coordinate of the starting point.</param>
        /// <param name="x2">The x-coordinate of the ending point.</param>
        /// <param name="y2">The y-coordinate of the ending point.</param>
        public Line(int x1, int y1, int x2, int y2)
        {
            StartPoint = new Point(x1, y1);
            EndPoint = new Point(x2, y2);
        }

        /// <summary>
        /// Returns a string representation of the line in the format "Line from {start} to {end}".
        /// </summary>
        /// <returns>A string representation of the line.</returns>
        public override string ToString()
        {
            return $"Line from {StartPoint} to {EndPoint}";
        }
    }
}
