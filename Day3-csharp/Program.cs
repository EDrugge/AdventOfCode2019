using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Day3_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var wire1Path = "R1010,D422,L354,U494,L686,U894,R212,U777,L216,U9,L374,U77,R947,U385,L170,U916,R492,D553,L992,D890,L531,U360,R128,U653,L362,U522,R817,U198,L126,D629,L569,U300,L241,U145,R889,D196,L450,D576,L319,D147,R985,U889,L941,U837,L608,D77,L864,U911,L270,D869,R771,U132,L249,U603,L36,D328,L597,U992,L733,D370,L947,D595,L308,U536,L145,U318,R55,D773,R175,D505,R483,D13,R780,U778,R445,D107,R490,U245,L587,U502,R446,U639,R150,U35,L455,D522,R866,U858,R394,D975,R513,D378,R58,D646,L374,D675,R209,U228,R530,U543,L480,U677,L912,D164,L573,U587,L784,D626,L994,U250,L215,U985,R684,D79,L877,U811,L766,U617,L665,D246,L408,U800,L360,D272,L436,U138,R240,U735,L681,U68,L608,D59,R532,D808,L104,U968,R887,U819,R346,U698,L317,U582,R516,U55,L303,U607,L457,U479,L510,D366,L583,U519,R878,D195,R970,D267,R842,U784,R9,D946,R833,D238,L232,D94,L860,D47,L346,U951,R491,D745,R849,U273,R263,U392,L341,D808,R696,U326,R886,D296,L865,U833,R241,U644,R729,D216,R661,D712,L466,D699,L738,U5,L556,D693,R912,D13,R48,U63,L877,U628,L689,D929,R74,U924,R612,U153,R417,U425,L879,D378,R79,D248,L3,U519,R366,U281,R439,D823,R149,D668,R326,D342,L213,D735,R504,U265,L718,D842,L565,U105,L214,U963,R518,D681,R642,U170,L111,U6,R697,U572,R18,U331,L618,D255,R534,D322,L399,U595,L246,U651,L836,U757,R417,D795,R291,U759,L568,U965,R828,D570,R350,U317,R338,D173,L74,D833,L650,D844,L70,U913,R594,U407,R674,D684,L481,D564,L128,D277,R851,D274,L435,D582,R469,U729,R387,D818,R443,U504,R414,U8,L842,U845,R275,U986,R53,U660,R661,D225,R614,U159,R477";
            var wire2Path = "L1010,D698,R442,U660,L719,U702,L456,D86,R938,D177,L835,D639,R166,D285,L694,U468,L569,D104,L234,D574,L669,U299,L124,D275,L179,D519,R617,U72,L985,D248,R257,D276,L759,D834,R490,U864,L406,U181,R911,U873,R261,D864,R260,U759,R648,U158,R308,D386,L835,D27,L745,U91,R840,U707,R275,U543,L663,U736,L617,D699,R924,U103,R225,U455,R708,U319,R569,U38,R315,D432,L179,D975,R519,D546,L295,U680,L685,U603,R262,D250,R7,U171,R261,U519,L832,U534,L471,U431,L474,U886,R10,D179,L79,D555,R452,U452,L832,U863,L367,U538,L237,D160,R441,U605,R942,U259,L811,D552,R646,D353,L225,D94,L35,D307,R752,U23,R698,U610,L379,D932,R698,D751,R178,D347,R325,D156,R471,D555,R558,D593,R773,U2,L955,U764,L735,U438,R364,D640,L757,U534,R919,U409,R361,U407,R336,D808,R877,D648,R610,U198,R340,U94,R795,D667,R811,U975,L965,D224,R565,D681,L64,U567,R621,U922,L665,U329,R242,U592,L727,D481,L339,U402,R213,D280,R656,U169,R976,D962,L294,D505,L251,D689,L497,U133,R230,D441,L90,D220,L896,D657,L500,U331,R502,U723,R762,D613,L447,D256,L226,U309,L935,U384,L740,D459,R309,D707,R952,D747,L304,D105,R977,D539,R941,D21,R291,U216,R132,D543,R515,U453,L854,D42,R982,U102,L469,D639,R559,D68,R302,U734,R980,D214,R107,D191,L730,D793,L63,U17,R807,U196,R412,D592,R330,D941,L87,D291,L44,D94,L272,D780,R968,U837,L712,D704,R163,U981,R537,U778,R220,D303,L196,D951,R163,D446,R11,D623,L72,D778,L158,U660,L189,D510,L247,D716,L89,U887,L115,U114,L36,U81,R927,U293,L265,U183,R331,D267,R745,D298,L561,D918,R299,U810,L322,U679,L739,D854,L581,U34,L862,D779,R23";

            //Distance 10
            //Steps 10
            //var wire1Path = "R5,U10";
            //var wire2Path = "U5,R10";

            //Distance 159
            //Steps 610
            //var wire1Path = "R75,D30,R83,U83,L12,D49,R71,U7,L72";
            //var wire2Path = "U62,R66,U55,R34,D71,R55,D58,R83";

            //Distance 135
            //Steps 410
            //var wire1Path = "R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51";
            //var wire2Path = "U98,R91,D20,R16,D67,R40,U7,R15,U6,R7";

            var wire1 = new Wire(ParseWirePath(wire1Path));
            var wire2 = new Wire(ParseWirePath(wire2Path));

            var shortestDistance = int.MaxValue;
            var leastNumberOfSteps = int.MaxValue;

            var accLinesWire1 = new List<Line>();
            var accLinesWire2 = new List<Line>();

            foreach (var wire1Line in wire1.Lines)
            {
                accLinesWire2.Clear();
                foreach (var wire2Line in wire2.Lines)
                {
                    if (LineSegementsIntersect(
                        new Vector(wire1Line.Point1.X, wire1Line.Point1.Y),
                        new Vector(wire1Line.Point2.X, wire1Line.Point2.Y),
                        new Vector(wire2Line.Point1.X, wire2Line.Point1.Y),
                        new Vector(wire2Line.Point2.X, wire2Line.Point2.Y),
                        out var intersection))
                    {
                        if (intersection.X == 0 && intersection.Y == 0)
                        {
                            continue;
                        }
                        var distance = Math.Abs(intersection.X) + Math.Abs(intersection.Y);
                        var numberOfStepsWire1 = CalculateNumberOfSteps(accLinesWire1, wire1Line, intersection.ToPoint());
                        var numberOfStepsWire2 = CalculateNumberOfSteps(accLinesWire2, wire2Line, intersection.ToPoint());
                        var numberOfStepsTotal = numberOfStepsWire1 + numberOfStepsWire2;

                        Console.WriteLine(
                            $"Found intersection: X:{intersection.X} Y:{intersection.Y}. Distance: {distance}. Number of steps: {numberOfStepsTotal}");
                        if (distance < shortestDistance)
                        {
                            shortestDistance = (int) distance;
                        }

                        if (numberOfStepsTotal < leastNumberOfSteps)
                        {
                            leastNumberOfSteps = numberOfStepsTotal;
                        }
                    }
                    accLinesWire2.Add(wire2Line);
                }
                accLinesWire1.Add(wire1Line);
            }

            Console.WriteLine($"Shortest distance: {shortestDistance}");
            Console.WriteLine($"Least number of steps: {leastNumberOfSteps}");
        }

        private static int CalculateNumberOfSteps(List<Line> accLines, Line wireLine, Point intersection)
        {
            var points = new List<Point>();
            foreach (var accLine in accLines)
            {
                points.AddRange(accLine.Points);
            }

            var finalLine = new Line(wireLine.Point1, intersection);
            points.AddRange(finalLine.Points);

            var shortestPointPath = new List<Point>();
            foreach (var point in points)
            {
                shortestPointPath.Add(point);
            }

            return shortestPointPath.Count;
        }

        /// <summary>
        /// Test whether two line segments intersect. If so, calculate the intersection point.
        /// <see cref="http://stackoverflow.com/a/14143738/292237"/>
        /// </summary>
        /// <param name="p">Vector to the start point of p.</param>
        /// <param name="p2">Vector to the end point of p.</param>
        /// <param name="q">Vector to the start point of q.</param>
        /// <param name="q2">Vector to the end point of q.</param>
        /// <param name="intersection">The point of intersection, if any.</param>
        /// <param name="considerOverlapAsIntersect">Do we consider overlapping lines as intersecting?
        /// </param>
        /// <returns>True if an intersection point was found.</returns>
        public static bool LineSegementsIntersect(Vector p, Vector p2, Vector q, Vector q2,
            out Vector intersection, bool considerCollinearOverlapAsIntersect = false)
        {
            intersection = new Vector();

            var r = p2 - p;
            var s = q2 - q;
            var rxs = r.Cross(s);
            var qpxr = (q - p).Cross(r);

            // If r x s = 0 and (q - p) x r = 0, then the two lines are collinear.
            if (rxs.IsZero() && qpxr.IsZero())
            {
                // 1. If either  0 <= (q - p) * r <= r * r or 0 <= (p - q) * s <= * s
                // then the two lines are overlapping,
                if (considerCollinearOverlapAsIntersect)
                    if ((0 <= (q - p) * r && (q - p) * r <= r * r) || (0 <= (p - q) * s && (p - q) * s <= s * s))
                        return true;

                // 2. If neither 0 <= (q - p) * r = r * r nor 0 <= (p - q) * s <= s * s
                // then the two lines are collinear but disjoint.
                // No need to implement this expression, as it follows from the expression above.
                return false;
            }

            // 3. If r x s = 0 and (q - p) x r != 0, then the two lines are parallel and non-intersecting.
            if (rxs.IsZero() && !qpxr.IsZero())
                return false;

            // t = (q - p) x s / (r x s)
            var t = (q - p).Cross(s) / rxs;

            // u = (q - p) x r / (r x s)

            var u = (q - p).Cross(r) / rxs;

            // 4. If r x s != 0 and 0 <= t <= 1 and 0 <= u <= 1
            // the two line segments meet at the point p + t r = q + u s.
            if (!rxs.IsZero() && (0 <= t && t <= 1) && (0 <= u && u <= 1))
            {
                // We can calculate the intersection point using either t or u.
                intersection = p + t * r;

                // An intersection was found.
                return true;
            }

            // 5. Otherwise, the two line segments are not parallel but do not intersect.
            return false;
        }

        private static IList<MoveCommand> ParseWirePath(string wirePath)
        {
            return wirePath
                .Split(',')
                .Select(x => new MoveCommand(x[0].ToString(), int.Parse(x.Substring(1))))
                .ToList();
        }
    }

    public struct Line
    {
        public Line(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        public Point Point1 { get; }
        public Point Point2 { get; }

        public int Length => Math.Abs(Point1.X - Point2.X) + Math.Abs(Point1.Y - Point2.Y);

        public IEnumerable<Point> Points
        {
            get
            {
                if (Point1.X == Point2.X)
                {
                    var currentPoint = new Point(Point1.X, Point1.Y);
                    //yield return currentPoint;
                    do
                    {
                        if (Point1.Y < Point2.Y)
                        {
                            currentPoint.Y += 1;
                        }
                        else
                        {
                            currentPoint.Y -= 1;
                        }
                        yield return currentPoint;
                    } while (currentPoint != Point2);
                }
                else
                {
                    var currentPoint = new Point(Point1.X, Point1.Y);
                    //yield return currentPoint;
                    do
                    {
                        if (Point1.X < Point2.X)
                        {
                            currentPoint.X += 1;
                        }
                        else
                        {
                            currentPoint.X -= 1;
                        }
                        
                        yield return currentPoint;
                    } while (currentPoint != Point2);
                }
            }
        }

        public override string ToString()
        {
            return $"({Point1.X}, {Point1.Y}) - ({Point2.X}, {Point2.Y})";
        }
    }

    public class Wire
    {
        public Wire(IList<MoveCommand> moveCommands)
        {
            Lines = ParseLines(moveCommands);
        }

        public IEnumerable<Line> ParseLines(IList<MoveCommand> moveCommands)
        {
            var currentPosition = Point.Empty;
            foreach (var moveCommand in moveCommands)
            {
                var newPoint = ApplyMoveCommand(currentPosition, moveCommand);

                yield return new Line(currentPosition, newPoint);

                currentPosition = newPoint;
            }
        }

        public IEnumerable<Line> Lines { get; }

        private Point ApplyMoveCommand(Point position, MoveCommand moveCommand)
        {
            switch (moveCommand.Direction)
            {
                case "R":
                    return new Point(position.X + moveCommand.NumberOfSteps, position.Y);
                case "L":
                    return new Point(position.X - moveCommand.NumberOfSteps, position.Y);
                case "U":
                    return new Point(position.X, position.Y + moveCommand.NumberOfSteps);
                case "D":
                    return new Point(position.X, position.Y - moveCommand.NumberOfSteps);
            }

            throw new ArgumentException($"Unknown direction: {moveCommand.Direction}");
        }
    }

    public class MoveCommand
    {
        public string Direction { get; }
        public int NumberOfSteps { get; }

        public MoveCommand(string direction, int numberOfSteps)
        {
            Direction = direction;
            NumberOfSteps = numberOfSteps;
        }
    }

    public class Vector
    {
        public double X;
        public double Y;

        // Constructors.
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Vector() : this(double.NaN, double.NaN)
        {
        }

        public static Vector operator -(Vector v, Vector w)
        {
            return new Vector(v.X - w.X, v.Y - w.Y);
        }

        public static Vector operator +(Vector v, Vector w)
        {
            return new Vector(v.X + w.X, v.Y + w.Y);
        }

        public static double operator *(Vector v, Vector w)
        {
            return v.X * w.X + v.Y * w.Y;
        }

        public static Vector operator *(Vector v, double mult)
        {
            return new Vector(v.X * mult, v.Y * mult);
        }

        public static Vector operator *(double mult, Vector v)
        {
            return new Vector(v.X * mult, v.Y * mult);
        }

        public double Cross(Vector v)
        {
            return X * v.Y - Y * v.X;
        }

        public override bool Equals(object obj)
        {
            var v = (Vector) obj;
            return (X - v.X).IsZero() && (Y - v.Y).IsZero();
        }

        public Point ToPoint()
        {
            return new Point(Convert.ToInt32(X), Convert.ToInt32(Y));
        }
    }

    public static class Extensions
    {
        private const double Epsilon = 1e-10;

        public static bool IsZero(this double d)
        {
            return Math.Abs(d) < Epsilon;
        }
    }
}