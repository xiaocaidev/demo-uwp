using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Demo.UWP.Controls
{
	public class RadioImageButton : RadioButton
	{
		//默认图片
		public ImageSource Source
		{
			get { return (ImageSource)GetValue(SourceProperty); }
			set { SetValue(SourceProperty, value); }
		}

		// Using a DependencyProperty as the backing store for Source.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty SourceProperty =
			DependencyProperty.Register("Source", typeof(ImageSource), typeof(RadioImageButton), null);

		//选中图片
		public ImageSource SourceChecked
		{
			get { return (ImageSource)GetValue(SourceCheckedProperty); }
			set { SetValue(SourceCheckedProperty, value); }
		}

		// Using a DependencyProperty as the backing store for SourceChecked.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty SourceCheckedProperty =
			DependencyProperty.Register("SourceChecked", typeof(ImageSource), typeof(RadioImageButton), null);

		//选中文字颜色
		public SolidColorBrush ForegroundChecked
		{
			get { return (SolidColorBrush)GetValue(ForegroundCheckedProperty); }
			set { SetValue(ForegroundCheckedProperty, value); }
		}

		// Using a DependencyProperty as the backing store for ForegroundChecked.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty ForegroundCheckedProperty =
			DependencyProperty.Register("ForegroundChecked", typeof(SolidColorBrush), typeof(RadioImageButton), new PropertyMetadata(new SolidColorBrush(Colors.Black)));

		//图片宽度
		public double ImageWidth
		{
			get { return (double)GetValue(ImageWidthProperty); }
			set { SetValue(ImageWidthProperty, value); }
		}

		// Using a DependencyProperty as the backing store for ImageWidth.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty ImageWidthProperty =
			DependencyProperty.Register("ImageWidth", typeof(double), typeof(RadioImageButton), new PropertyMetadata(50));



		public double ImageHeight
		{
			get { return (double)GetValue(ImageHeightProperty); }
			set { SetValue(ImageHeightProperty, value); }
		}

		// Using a DependencyProperty as the backing store for ImageHeight.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty ImageHeightProperty =
			DependencyProperty.Register("ImageHeight", typeof(double), typeof(RadioImageButton), new PropertyMetadata(50));



		public Thickness ImageMargin
		{
			get { return (Thickness)GetValue(ImageMarginProperty); }
			set { SetValue(ImageMarginProperty, value); }
		}

		// Using a DependencyProperty as the backing store for ImageMargin.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty ImageMarginProperty =
			DependencyProperty.Register("ImageMargin", typeof(Thickness), typeof(RadioImageButton), null);


	}
}
