using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Demo.UWP.Converters
{
	public class RadioImageButtonConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			if (string.Equals(value + "", parameter + ""))
			{
				return true;
			}
			else
				return false;
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			return Int32.Parse(parameter.ToString());
		}
	}
}
