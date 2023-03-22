namespace MindboxTest
{
    public class Circle : Figure
    {
        public int Radius { get; private set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        protected override bool ValidateFigure()
        {
            if (Radius > 0)
                return true;

            return false;
        }

        public override double CalculateArea()
        {
            if (!ValidateFigure()) return double.NaN;

            return Math.PI * Radius * Radius;
        }
    }
}
