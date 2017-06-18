using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.UWP.Models
{
	public class AdBean : ItemData
	{
		public string Title { get; set; }
		public string ImgUrl { get; set; }

		//private string _ImgUrl;
		//public string ImgUrl
		//{
		//	get { return _ImgUrl; }
		//	set { Set<string>(ref _ImgUrl, value); }
		//}
	}
}
