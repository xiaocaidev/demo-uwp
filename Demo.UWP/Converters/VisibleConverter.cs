using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Demo.UWP.Converters
{
	public class VisibleConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			int v = (int)value;
			if (v == 1)
			{
				return Visibility.Collapsed;
			}
			else
				return Visibility.Visible;
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			var v = (Visibility)value;
			if (v == Visibility.Collapsed)
			{
				return 1;
			}
			else
				return 0;
		}
	}
}
