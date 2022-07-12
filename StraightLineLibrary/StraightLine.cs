using System;
using matr_try2;

namespace StraightLineLibrary
{
    public class StraightLine
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }

        public Func<double, double> X { get; set; }
        public Func<double, double> Y { get; set; }
        public Func<double, double> Z { get; set; }

        public Vector DirectiveVector { get; set; }


        public StraightLine(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;

            var m = p2.X - p1.X;
            var n = p2.Y - p1.Y;
            var p = p2.Z - p1.Z;

            this.DirectiveVector = new Vector(m, n, p);
            SetParametricEquations();
        }

        public StraightLine(Func<double, double> x, Func<double, double> y, Func<double, double> z)
        {
            X = x;
            Y = y;
            Z = z;

            //todo: initialize points
        }

        public StraightLine(Point point, Vector directiveVector)
        {
            P1 = point;
            DirectiveVector = directiveVector;

            P2 = new Point(DirectiveVector.M + P1.X, DirectiveVector.N + P1.Y, DirectiveVector.P + P1.Z);
            SetParametricEquations();
        }

        private void SetParametricEquations()
        {
            X = t => DirectiveVector.M * t + P1.X;
            Y = t => DirectiveVector.N * t + P1.Y;
            Z = t => DirectiveVector.P * t + P1.Z;
        }

        public static Point Intersect(StraightLine line, Plane plane)
        {
            var point = new Point();

            (double x, double y, double z) = (line.P1.X, line.P1.Y, line.P1.Z);
            (double A, double B, double C, double D) = (plane.A, plane.B, plane.C, plane.D);
            (double m, double n, double p) = (line.DirectiveVector.M, line.DirectiveVector.N, line.DirectiveVector.P);

            try
            {
                double t = (-A * x + -B * y + -C * z - D) / (A * m + B * n + C * p);
                (point.X, point.Y, point.Z) = (line.X(t), line.Y(t), line.Z(t));
            }
            catch (Exception e)
            {
                return new Point(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity);
            }


            return point;
        }

        public static string RelationBetweenLines(StraightLine line1, StraightLine line2)
        {
            string relation = "Nan";

            var matrix = new Matrix.SquareMatrix(new double[3, 3]
            {
                { line2.P1.X - line1.P1.X, line2.P1.Y - line1.P1.Y, line2.P1.Z - line1.P1.Z },
                { line1.DirectiveVector.M, line1.DirectiveVector.N, line1.DirectiveVector.P },
                { line2.DirectiveVector.M, line2.DirectiveVector.N, line2.DirectiveVector.P }
            });

            double det = matrix.Det;

            if (det != 0)
                relation = "Lines are crossing";

            else
            {
                int rang1 = new Matrix(new double[2, 3]
                {
                    { line1.DirectiveVector.M, line1.DirectiveVector.N, line1.DirectiveVector.P },
                    { line2.DirectiveVector.M, line2.DirectiveVector.N, line2.DirectiveVector.P }
                }).Rang;

                if (det == 0 && rang1 == 2) relation = "Lines intersect";
                else
                {
                    int rang2 = new Matrix(new double[2, 3]
                    {
                        { line2.P1.X - line1.P1.X, line2.P1.Y - line1.P1.Y, line2.P1.Z - line1.P1.Z },
                        { line1.DirectiveVector.M, line1.DirectiveVector.N, line1.DirectiveVector.P }
                    }).Rang;
                    if (rang1 == 1 && rang2 == 2) relation = "Lines are parallel";
                    else if (matrix.Rang == 1) relation = "Lines match";
                }
            }


            return relation;
        }
    }
}