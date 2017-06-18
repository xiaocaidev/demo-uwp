using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.UWP.Models
{
	public class ItemData : ObservableObject
	{
		public string ItemTitle { get; set; }
		public int ItemType { get; set; }
	}
}
