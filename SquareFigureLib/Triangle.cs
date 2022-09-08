using System;
using System.Collections.Generic;
using System.Text;

namespace SquareFigureLib
{
    public class Triangle : Figure
    {
        private double leg_a;
        private double leg_b;
        private double leg_c;
        public double Leg_c
        {
            get
            {
                return leg_c;
            }
            set
            {
                leg_c = value;
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
            Leg_c = 0;
            Leg_a = 0;
            Leg_b = 0;
        }

        public Triangle(double Leg_c, double Leg_a, double Leg_b)
        {
            this.Leg_c = Leg_c;
            this.Leg_a = Leg_a;
            this.Leg_b = Leg_b;
        }

        public override double GetSquare()
        {
            if (Leg_c <= 0 || Leg_b <= 0 || Leg_a <= 0)
            {
                return 0;
            }

            double p_Semiperimeter = (Leg_c + Leg_a + Leg_b) / 2;
            double s_square = Math.Sqrt(p_Semiperimeter * (p_Semiperimeter - Leg_a) *
                (p_Semiperimeter - Leg_b) * (p_Semiperimeter - Leg_c));

            return Math.Round(s_square, 2);
        }
    }
}
