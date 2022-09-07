using System;
using System.Collections.Generic;
using System.Text;

namespace SquareFigureLib
{
    public class Circle : Figure
    {
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public Circle()
        {
            Radius = 0;
        }

        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public override double GetSquare()
        {
            if (Radius <= 0)
            {
                return 0;
            }

            return Math.Round(Radius * Radius * Math.PI, 2);
        }
    }
}
