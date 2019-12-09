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

            //var wire1Path = "R2,U4";
            //var wire2Path = "U2,R4";

            var wire1 = new Wire(ParseWirePath(wire1Path));
            var wire2 = new Wire(ParseWirePath(wire2Path));

            var shortestDistance = int.MaxValue;

            foreach (var wire1Line in wire1.GetLines())
            {
                foreach (var wire2Line in wire2.GetLines())
                {
                    var intersection = FindIntersection(wire1Line.Point1, wire1Line.Point2, wire2Line.Point1, wire2Line.Point2);
                    if (intersection != Point.Empty)
                    {
                        Console.WriteLine($"Found intersection: X:{intersection.X} Y:{intersection.Y}");
                        var distance = Math.Abs(intersection.X) + Math.Abs(intersection.Y);
                        if (distance < shortestDistance)
                        {
                            shortestDistance = distance;
                        }
                    }
                    //if (wire1Position == wire2Position)
                    //{
                    //    var distance = Math.Abs(wire1Position.X) + Math.Abs(wire1Position.Y);
                    //    if (distance < shortestDistance)
                    //    {
                    //        shortestDistance = distance;
                    //    }
                    //}
                }
            }

            Console.WriteLine($"Shortest distance: {shortestDistance}");
        }

        private static IList<MoveCommand> ParseWirePath(string wirePath)
        {
            return wirePath
                .Split(',')
                .Select(x => new MoveCommand(x[0].ToString(), int.Parse(x.Substring(1))))
                .ToList();
        }

        static Point FindIntersection(Point s1, Point e1, Point s2, Point e2)
        {
            float a1 = (float)e1.Y - s1.Y;
            float b1 = (float)s1.X - e1.X;
            float c1 = a1 * s1.X + b1 * s1.Y;

            float a2 = (float)e2.Y - s2.Y;
            float b2 = (float)s2.X - e2.X;
            float c2 = a2 * s2.X + b2 * s2.Y;

            float delta = a1 * b2 - a2 * b1;
            //If lines are parallel, the result will be (NaN, NaN).
            return delta == 0 
                ? Point.Empty
                : new Point((int)((b2 * c1 - b1 * c2) / delta), (int)((a1 * c2 - a2 * c1) / delta));
        }

        // Given three colinear points p, q, r, the function checks if 
        // point q lies on line segment 'pr' 
        private static Boolean OnSegment(Point p, Point q, Point r)
        {
            if (q.X <= Math.Max(p.X, r.X) && q.X >= Math.Min(p.X, r.X) &&
                q.Y <= Math.Max(p.Y, r.Y) && q.Y >= Math.Min(p.Y, r.Y))
                return true;

            return false;
        }

        // To find orientation of ordered triplet (p, q, r). 
        // The function returns following values 
        // 0 --> p, q and r are colinear 
        // 1 --> Clockwise 
        // 2 --> Counterclockwise 
        private static int Orientation(Point p, Point q, Point r)
        {
            // See https://www.geeksforgeeks.org/orientation-3-ordered-points/ 
            // for details of below formula. 
            int val = (q.Y - p.Y) * (r.X - q.X) -
                      (q.X - p.X) * (r.Y - q.Y);

            if (val == 0) return 0; // colinear 

            return (val > 0) ? 1 : 2; // clock or counterclock wise 
        }

        // The main function that returns true if line segment 'p1q1' 
        // and 'p2q2' intersect. 
        private static bool DoIntersect(Point p1, Point q1, Point p2, Point q2)
        {
            // Find the four orientations needed for general and 
            // special cases 
            int o1 = Orientation(p1, q1, p2);
            int o2 = Orientation(p1, q1, q2);
            int o3 = Orientation(p2, q2, p1);
            int o4 = Orientation(p2, q2, q1);

            // General case 
            if (o1 != o2 && o3 != o4)
                return true;

            // Special Cases 
            // p1, q1 and p2 are colinear and p2 lies on segment p1q1 
            if (o1 == 0 && OnSegment(p1, p2, q1)) return true;

            // p1, q1 and q2 are colinear and q2 lies on segment p1q1 
            if (o2 == 0 && OnSegment(p1, q2, q1)) return true;

            // p2, q2 and p1 are colinear and p1 lies on segment p2q2 
            if (o3 == 0 && OnSegment(p2, p1, q2)) return true;

            // p2, q2 and q1 are colinear and q1 lies on segment p2q2 
            if (o4 == 0 && OnSegment(p2, q1, q2)) return true;

            return false; // Doesn't fall in any of the above cases 
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
    }

    public class Wire
    {
        private Point _currentPosition = Point.Empty;
        private readonly IList<MoveCommand> _moveCommands;

        public Wire(IList<MoveCommand> moveCommands)
        {
            _moveCommands = moveCommands;
        }

        public IEnumerable<Line> GetLines()
        {
            _currentPosition = Point.Empty;
            foreach (var moveCommand in _moveCommands)
            {
                var newPoint = ApplyMoveCommand(_currentPosition, moveCommand);
                if (_currentPosition == Point.Empty || newPoint == Point.Empty)
                {
                    _currentPosition = newPoint;
                    continue;
                }
                yield return new Line(_currentPosition, newPoint);
                _currentPosition = newPoint;
            }
        }

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
}