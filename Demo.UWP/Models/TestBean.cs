using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace Demo.UWP.Models
{
	public class TestBean
	{
		public int Type { get; set; }
		public string Title { get; set; }
		public BitmapImage ImageSource { get; set; }

		public override string ToString()
		{
			return Title;
		}
	}
}
