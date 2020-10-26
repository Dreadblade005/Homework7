using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Part2
{
	public class Temperature
	{
		private double temperature;
		private char scale;
		//constructors
		public Temperature()
		{
			// Set to zero degrees Celsius.
			temperature = 0;
			scale = 'C';
		}


		public Temperature(char scale)
		{
			this.scale = scale;
			// Assume zero degrees if no value is specified.
			temperature = 0;
		}
		public Temperature(double temperature)
		{
			this.temperature = temperature;
			// Assume Celsius, if no scale is specified
			scale = 'C';
		}

		public Temperature(double temperature, char scale)
		{
			this.temperature = temperature;
			this.scale = scale;
		}
		//accessors 
		public double getCelsius()
		{
			if (scale == 'C' || scale == 'c')
			{
				return temperature;
			}
			else //returns even if incorrect accessor was used
			{
				// Round to the nearest tenth
				return ((double)(Math.Round((5 * (temperature - 32.0) / 9.0) * 10.0)) / 10);
			}
		}

		// Create an accessor to return the degrees Fahrenheit
		public double getFahrenheit()
		{
			if (scale == 'F' || scale == 'f')
			{
				return temperature;
			}
			else //returns even if incorrect accessor was used
			{
				// Round to the nearest tenth
				return (Math.Round((9 * (temperature / 5) + 32) * 10) / 10);
			}
		}

		// Create three setters
		public void setTemperature(double temperature)
		{
			this.temperature = temperature;
		}

		public void setScale(char scale)
		{
			this.scale = scale;
		}

		public void setTemperatureScale(double temperature, char scale)
		{
			this.temperature = temperature;
			this.scale = scale;
		}
		//tostring
		public String toString()
		{
			if (scale == 'C' || scale == 'c')
			{
				return String.Format(temperature + " degrees C = " + getFahrenheit() + " degrees F: " );
			}
			else // if F
			{
				return String.Format(temperature + " degrees F = " + getCelsius() + " degrees C" );
			}

		}
		public bool equals(Temperature other)
		{
			return (this.getCelsius() == other.getCelsius()) && (this.getFahrenheit() == other.getFahrenheit());
		}
	}
}
