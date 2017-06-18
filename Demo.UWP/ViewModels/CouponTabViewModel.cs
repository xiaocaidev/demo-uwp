using Demo.UWP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.UWP.ViewModels
{
	public class CouponTabViewModel : MyViewModel
	{
		public string Title { get; set; }
		public ObservableCollection<ItemData> NewsList { get; set; }

		public CouponTabViewModel()
		{
			NewsList = new ObservableCollection<ItemData>
			{
				new NewsBean() {Title = "重庆火锅", SubTitle = "[丰庄]午市套餐C，建议6-7人使用", Price = "￥328", ItemType = 2},
				new NewsBean() {Title = "东北小厨", SubTitle = "[丰庄]午市套餐C，建议6-7人使用，建议6-7人使用，建议6-7人使用", Price = "￥328", ItemType = 2},
				new NewsBean() {Title = "东北小厨", SubTitle = "[丰庄]午市套餐C，建议6-7人使用", Price = "￥328", ItemType = 2},
				new NewsBean() {Title = "东北小厨", SubTitle = "[丰庄]午市套餐C，建议6-7人使用", Price = "￥328", ItemType = 2},
				new NewsBean() {Title = "麻辣香锅", SubTitle = "[丰庄]午市套餐，100元代金券1张。[丰庄]午市套餐，100元代金券1张。[丰庄]午市套餐，100元代金券1张。[丰庄]午市套餐，100元代金券1张。", Price = "￥188", ItemType = 2},
				new NewsBean() {Title = "东北小厨", SubTitle = "[丰庄]午市套餐C，建议6-7人使用", Price = "￥328", ItemType = 2},
				new NewsBean() {Title = "东北小厨", SubTitle = "[丰庄]午市套餐C，建议6-7人使用", Price = "￥328", ItemType = 2},
				new NewsBean() {Title = "东北小厨", SubTitle = "[丰庄]午市套餐C，建议6-7人使用", Price = "￥328", ItemType = 2},
				new NewsBean() {Title = "东北小厨", SubTitle = "[丰庄]午市套餐C，建议6-7人使用", Price = "￥328", ItemType = 2}
			};

		}

		public override string ToString()
		{
			return "优惠";
		}
	}
}
