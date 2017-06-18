using Demo.UWP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.UWP.ViewModels
{
	public class FindTabViewModel : MyViewModel
	{
		public string Title { get; set; }
		public ObservableCollection<ItemData> NewsList { get; set; }

		public FindTabViewModel()
		{
			NewsList = new ObservableCollection<ItemData>
			{
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1},
				new AdBean() {Title = "只要88", ImgUrl = "ms-appx:///Assets/Main/8b59cca11a991187fcb2c1bd71b3345c220639.png", ItemType = 1}
			};

		}

		public override string ToString()
		{
			return "发现";
		}
	}
}
