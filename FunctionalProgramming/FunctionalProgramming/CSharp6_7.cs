using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace FunctionalProgramming
{
    public class Circle
    {
        public Circle(double radius) => Radius = radius;

        /// <summary>
        /// Getter only autoproperty
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Expression bodied property
        /// </summary>
        public double Circumference => PI * 2 * Radius;
        public double Area
        {
            get
            {
                double Square(double d) => Pow(d, 2);
                return PI * Square(Radius);
            }
        }
        /// <summary>
        /// C# 7 Tuple Syntax with named elements
        /// </summary>
        public (double Circumference, double Area) Stats
        => (Circumference, Area);
    }
}

