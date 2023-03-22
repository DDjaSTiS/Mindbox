namespace MindboxTest
{
    public class Triangle : Figure
    {
        public int[] Lengths { get; private set; }

        public Triangle(int sideA, int sideB, int sideC)
        {
            var lengths = new int[] { sideA, sideB, sideC };
            Lengths = lengths.OrderBy(x => x).ToArray();
        }

        protected override bool ValidateFigure()
        {
            if (Lengths[0] > 0 &&
                Lengths[1] > 0 &&
                Lengths[2] > 0 &&
                (Lengths[0] + Lengths[1]) > Lengths[2] &&
                (Lengths[0] + Lengths[2]) > Lengths[1] &&
                (Lengths[1] + Lengths[2]) > Lengths[0])
                return true;

            return false;
        }

        public override double CalculateArea()
        {
            if (!ValidateFigure()) return double.NaN;
            
            if (IsRightTriangle())
                return Lengths[0] * Lengths[1] / 2;

            double halfPerimeter = (Lengths[0]
                                    + Lengths[1]
                                    + Lengths[2]) / 2.0;
            return Math.Sqrt(halfPerimeter
                * (halfPerimeter - Lengths[0])
                * (halfPerimeter - Lengths[1])
                * (halfPerimeter - Lengths[2]));
        }

        private bool IsRightTriangle()
        {
            var squaredLengths = Lengths.Select(x => x * x).ToArray();
            if (squaredLengths[2] == squaredLengths[0] + squaredLengths[1])
                return true;

            return false;
        }
    }
}
