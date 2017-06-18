using GalaSoft.MvvmLight;
using Demo.UWP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
using GalaSoft.MvvmLight.Command;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Demo.UWP.Controls;

namespace Demo.UWP.ViewModels
{
	public class MainViewModel : ViewModelBase
	{
		private int _SelectedIndex;

		public int SelectedIndex
		{
			get { return _SelectedIndex; }
			set
			{
				Set<int>(ref _SelectedIndex, value);
			}
		}

		public ObservableCollection<ViewModelBase> Data { get; set; }

		public MainViewModel()
		{
			Data = new ObservableCollection<ViewModelBase>
			{
				new HomeViewModel() {Type = 1, Title = "首页"},
				new CouponTabViewModel() {Type = 2, Title = "品质优惠"},
				new FindTabViewModel() {Type = 3, Title = "发现"},
				new MineViewModel() {Type = 4, Title = "我的"}
			};
			SelectedIndex = 0;
		}

		public string Home => "首页";

		public RelayCommand<RoutedEventArgs> HomeTab_Checked => new RelayCommand<RoutedEventArgs>((e) =>
		{
			//RadioImageButton radio = e.OriginalSource as RadioImageButton;
			//if (radio.IsChecked.Value)
			//{
			//	SelectedIndex = radio.TabIndex;
			//}
			//MessageDialog dlg = new MessageDialog("click." + SelectedIndex);
			//var t = dlg.ShowAsync();
		});

		public void RadioImageButton_Checked(object sender, RoutedEventArgs e)
		{
			//RadioImageButton radio = e.OriginalSource as RadioImageButton;
			//if (radio.IsChecked.Value)
			//{
			//	SelectedIndex = radio.TabIndex;
			//}
			//MessageDialog dlg = new MessageDialog("click." + SelectedIndex);
			//var t = dlg.ShowAsync();
		}
	}
}
