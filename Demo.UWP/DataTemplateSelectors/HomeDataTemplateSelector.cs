using Demo.UWP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Demo.UWP.DataTemplateSelectors
{
	public class HomeDataTemplateSelector : DataTemplateSelector
	{

		public DataTemplate AdTemplate { get; set; }
		public DataTemplate NewsTemplate { get; set; }

		protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
		{
			var bean = item as ItemData;
			if (1 == bean.ItemType)
			{
				return AdTemplate;
			}
			else if (2 == bean.ItemType)
			{
				return NewsTemplate;
			}
			return NewsTemplate;
		}
	}
}
