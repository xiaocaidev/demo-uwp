using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.UWP.ViewModels
{
	public class MineViewModel : MyViewModel
	{
		public string Title { get; set; }
		public MineViewModel()
		{

		}

		public override string ToString()
		{
			return "我的";
		}
	}
}
