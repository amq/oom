﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class History : IWeather
    {
        private double m_temperature;

        /// <summary>
        /// Creates a new weather object.
        /// </summary>
        /// <param name="country">Country must not be empty.</param>
        /// <param name="city">City must not be empty.</param>
        /// <param name="clouds">The state of clouds.</param>
        /// <param name="temperature">Temperature.</param>
        public History(string country, string city, DateTime date, string clouds, double temperature, Unit unit)
        {
            if (string.IsNullOrWhiteSpace(country)) throw new ArgumentException("Country must not be empty.", nameof(country));
            if (string.IsNullOrWhiteSpace(city)) throw new ArgumentException("City must not be empty.", nameof(city));
            if (date == DateTime.MinValue) throw new ArgumentException("Date must not be empty.", nameof(date));

            Country = country;
            City = city;
            Date = date;
            Clouds = clouds;
            UpdateTemperature(temperature, unit);
        }

        /// <summary>
        /// Gets the country.
        /// </summary>
        public string Country { get; }

        /// <summary>
        /// Gets the city.
        /// </summary>
        public string City { get; }

        /// <summary>
        /// Gets the day.
        /// </summary>
        public DateTime Date { get; }

        /// <summary>
        /// Gets the clouds.
        /// </summary>
        public string Clouds { get; }

        /// <summary>
        /// Gets the unit.
        /// </summary>
        public Unit Unit { get; set; }

        /// <summary>
        /// Gets the temperature in a given unit.
        /// </summary>
        public double GetTemperature(Unit unit)
        {
            if (unit == Unit) return m_temperature;
            if (unit == Unit.Celsius) return (m_temperature - 32) * 5/9;
            if (unit == Unit.Fahrenheit) return m_temperature * 9/5 + 32;
            return m_temperature;
        }

        /// <summary>
        /// Updates the temperature.
        /// </summary>
        /// <param name="newTemperature">Temperature.</param>
        /// <param name="newUnit">Unit.</param>
        public void UpdateTemperature(double newTemperature, Unit unit)
        {
            m_temperature = newTemperature;
            Unit = unit;
        }
    }
}
