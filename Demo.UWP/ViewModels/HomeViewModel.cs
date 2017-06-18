using Demo.UWP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.UWP.ViewModels
{
	public class HomeViewModel : MyViewModel
	{
		public string Title { get; set; }
		public ObservableCollection<ItemData> NewsList { get; set; }

		public HomeViewModel()
		{
			NewsList = new ObservableCollection<ItemData>
			{
				new AdBean() {Title = "美味不能错过", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "美味不能错过", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new NewsBean() {Title = "东北小厨", SubTitle = "[丰庄]午市套餐C，建议6-7人使用", Price = "￥328", ItemType = 2},
				new NewsBean() {Title = "东北小厨", SubTitle = "[丰庄]午市套餐C，建议6-7人使用，建议6-7人使用，建议6-7人使用", Price = "￥328", ItemType = 2},
				new NewsBean() {Title = "东北小厨", SubTitle = "[丰庄]午市套餐C，建议6-7人使用", Price = "￥328", ItemType = 2},
				new NewsBean() {Title = "东北小厨", SubTitle = "[丰庄]午市套餐C，建议6-7人使用", Price = "￥328", ItemType = 2},
				new NewsBean() {Title = "东北小厨", SubTitle = "[丰庄]午市套餐C，建议6-7人使用", Price = "￥328", ItemType = 2},
				new NewsBean() {Title = "东北小厨", SubTitle = "[丰庄]午市套餐C，建议6-7人使用", Price = "￥328", ItemType = 2},
				new NewsBean() {Title = "东北小厨", SubTitle = "[丰庄]午市套餐C，建议6-7人使用", Price = "￥328", ItemType = 2},
				new NewsBean() {Title = "东北小厨", SubTitle = "[丰庄]午市套餐C，建议6-7人使用", Price = "￥328", ItemType = 2},
				new NewsBean() {Title = "东北小厨", SubTitle = "[丰庄]午市套餐C，建议6-7人使用", Price = "￥328", ItemType = 2}
			};

		}

		public override string ToString()
		{
			return "首页";
		}
	}
}
