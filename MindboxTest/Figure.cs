namespace MindboxTest
{
    public abstract class Figure
    {
        /// <summary>
        /// Calculates area of the figure.
        /// </summary>
        /// <returns>NaN, if the figure does not exist.</returns>
        public abstract double CalculateArea();

        protected abstract bool ValidateFigure();
    }
}