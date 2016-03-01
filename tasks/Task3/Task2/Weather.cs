using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public interface IWeather
    {
        /// <summary>
        /// Gets the clouds.
        /// </summary>
        string Clouds { get; }

        Unit Unit { get; set; }

        /// <summary>
        /// Gets the temperature in a given unit.
        /// </summary>
        double GetTemperature(Unit unit);

        /// <summary>
        /// Updates the temperature.
        /// </summary>
        /// <param name="newTemperature">Temperature.</param>
        /// <param name="newUnit">Unit.</param>
        void UpdateTemperature(double newTemperature, Unit unit);
    }
}
