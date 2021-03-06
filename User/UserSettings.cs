using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEvaluator
{
	public class UserSettings
	{
		public TemperatureScale TemperatureScalePref { get; private set; }
		public MeasurementSystem MeasurementSystemPref { get; private set; }
		public ConsoleColor FavoriteColor { get; private set; }

		public UserSettings(TemperatureScale temperatureScalePref, MeasurementSystem measurementSystemPref, ConsoleColor favoriteColor)
		{
			this.TemperatureScalePref = temperatureScalePref;
			this.MeasurementSystemPref = measurementSystemPref;
			this.FavoriteColor = favoriteColor;
		}
	}
}
