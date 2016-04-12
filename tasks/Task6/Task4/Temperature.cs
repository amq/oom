namespace Task4
{
    /// <summary>
    /// Price with currency.
    /// </summary>
    public class Temperature
    {
        /// <summary>
        /// Creates a price in given currency.
        /// </summary>
        public Temperature(double number, Unit unit)
        {
            Number = number;
            Unit = unit;
        }

        /// <summary>
        /// Gets the number.
        /// </summary>
        public double Number { get; }

        /// <summary>
        /// Amount's unit.
        /// </summary>
        public Unit Unit { get; }
    }
}
