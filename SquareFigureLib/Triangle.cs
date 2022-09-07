using System;
using System.Collections.Generic;
using System.Text;

namespace SquareFigureLib
{
    public class Triangle : Figure
    {
        private double hypotenuse;
        private double leg_a;
        private double leg_b;
        public double Hypotenuse
        {
            get
            {
                return hypotenuse;
            }
            set
            {
                hypotenuse = value;
            }
        }
        public double Leg_a
        {
            get
            {
                return leg_a;
            }
            set
            {
                leg_a = value;
            }
        }

        public double Leg_b
        {
            get
            {
                return leg_b;
            }
            set
            {
                leg_b = value;
            }
        }

        public Triangle()
        {
            Hypotenuse = 0;
            Leg_a = 0;
            Leg_b = 0;
        }

        public Triangle(double Hypotenuse, double Leg_a, double Leg_b)
        {
            this.Hypotenuse = Hypotenuse;
            this.Leg_a = Leg_a;
            this.Leg_b = Leg_b;
        }

        public override double GetSquare()
        {
            if (Hypotenuse <= 0 || Leg_b <= 0 || Leg_a <= 0)
            {
                return 0;
            }

            if (Leg_b == leg_a)
            {
                return Math.Round(Leg_a * Leg_b / 2, 2);
            }

            double p_Semiperimeter = (Hypotenuse + Leg_a + Leg_b) / 2;
            double s_square = Math.Sqrt(p_Semiperimeter * (p_Semiperimeter - Leg_a) *
                (p_Semiperimeter - Leg_b) * (p_Semiperimeter - Hypotenuse));

            return Math.Round(s_square, 2);
        }
    }
}
