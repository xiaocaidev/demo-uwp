using Demo.UWP.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.UWP.Models
{
	public class NewsBean : ItemData
	{
		public string PlaceholderSource => Constants.PLACEHOLDER_EMPTY;
		public string ImgUrl { get; set; }
		public string Title { get; set; }
		public string SubTitle { get; set; }
		public string Price { get; set; }
	}
}
