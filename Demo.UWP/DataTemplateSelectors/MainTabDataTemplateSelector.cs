using Demo.UWP.Models;
using Demo.UWP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Demo.UWP.DataTemplateSelectors
{
	public class MainTabDataTemplateSelector : DataTemplateSelector
	{

		public DataTemplate HomeTabTemplate { get; set; }
		public DataTemplate CouponTabTemplate { get; set; }
		public DataTemplate FindTabTemplate { get; set; }
		public DataTemplate MineTabTemplate { get; set; }

		protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
		{
			var bean = item as MyViewModel;
			if (1 == bean.Type)
			{
				return HomeTabTemplate;
			}
			else if (2 == bean.Type)
			{
				return CouponTabTemplate;
			}
			else if (3 == bean.Type)
			{
				return FindTabTemplate;
			}
			else if (4 == bean.Type)
			{
				return MineTabTemplate;
			}
			return HomeTabTemplate;
		}
	}
}
