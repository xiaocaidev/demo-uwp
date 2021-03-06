﻿using Demo.UWP.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Demo.UWP.ItemViews
{
	public sealed partial class NewsItemView : UserControl
	{
		public NewsBean News => this.DataContext as NewsBean;
		public NewsItemView()
		{
			this.InitializeComponent();
			this.DataContextChanged += (s, e) => Bindings.Update();
		}
	}
}
