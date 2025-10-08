using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory2
{
    /// <summary>
    /// Represents a point in 2D space with integer coordinates.
    /// </summary>
    internal class Point
    {
        private int _x;
        private int _y;

        /// <summary>
        /// Gets or sets the x-coordinate of the point.
        /// </summary>
        public int X 
        { 
            get => _x;
            set => _x = value;
        }

        /// <summary>
        /// Gets or sets the x-coordinate of the point.
        /// </summary>
        public int Y 
        {
            get => _y;
            set => _y = value;
        }

        // Либо можно так, но тогда приватные поля генерируются автоматически
        //public int X { get; set; }
        //public int Y { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class with default coordinates (0, 0).
        /// </summary>
        public Point()
        {
            X = 0;
            Y = 0;
        }

        // Либо
        //public Point() : this(0, 0) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class with specified coordinates.
        /// </summary>
        /// <param name="x">The x-coordinate of the point.</param>
        /// <param name="y">The y-coordinate of the point.</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Returns a string representation of the point in the format "{x;y}".
        /// </summary>
        /// <returns>A string representation of the point.</returns>
        public override string ToString()
        {
            return $"{{{X};{Y}}}";
        }
    }
}
