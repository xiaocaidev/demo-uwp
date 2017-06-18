﻿using Demo.UWP.ViewModels;
using Windows.UI.Xaml.Controls;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace Demo.UWP.Views
{
	/// <summary>
	/// 可用于自身或导航至 Frame 内部的空白页。
	/// </summary>
	public sealed partial class TabPage : Page
	{
		public MainViewModel ViewModel => this.DataContext as MainViewModel;
		public TabPage()
		{
			this.InitializeComponent();
		}
	}
}
