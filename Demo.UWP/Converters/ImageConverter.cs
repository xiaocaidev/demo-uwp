using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;

namespace Demo.UWP.Converters
{
	public class ImageConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			if (string.IsNullOrEmpty(value as string))
			{
				return new BitmapImage(new Uri("ms-appx:///Core/Assets/Default/ic_default_list.png", UriKind.Absolute));
			}
			else return new BitmapImage(new Uri(value as string, UriKind.Absolute));
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			return null;
		}
	}
}
