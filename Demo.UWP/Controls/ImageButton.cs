using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Demo.UWP.Controls
{
	public class ImageButton : Button
	{


		public ImageSource ImageSrc
		{
			get { return (ImageSource)GetValue(ImageSrcProperty); }
			set { SetValue(ImageSrcProperty, value); }
		}

		public static readonly DependencyProperty ImageSrcProperty =
			DependencyProperty.Register("ImageSrc", typeof(ImageSource), typeof(ImageButton), null);


	}
}
