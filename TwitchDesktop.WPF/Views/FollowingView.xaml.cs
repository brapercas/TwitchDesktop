﻿using System;
using System.Windows;
using System.Windows.Controls;
using TwitchDesktop.Common.Enumerables;
using TwitchDesktop.ViewModel.ViewModels;

namespace TwitchDesktop.WPF.Views
{
    /// <summary>
    /// Lógica de interacción para FollowingView.xaml
    /// </summary>
    public partial class FollowingView : Page
    {
        public FollowingViewModel FollowingViewModel
        {
            get { return (FollowingViewModel)DataContext; }
        }

        public FollowingView()
        {
            InitializeComponent();
            FollowingViewModel.RadioPressedEvent += Radio_Pressed;
        }

        #region Private Methods

        private void FollowingView_Loaded(object sender, RoutedEventArgs e)
        {
            FollowingViewModel.Loaded();
        }

        private void ListView_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            double maxScroll = e.ExtentHeight - e.ViewportHeight;
            FollowingViewModel.UpdateScroll(e.VerticalOffset, maxScroll);
        }

        private void Radio_Pressed()
        {
            ((MainView)Application.Current.MainWindow).MainViewModel.SelectButton(OptionButton.Home);
        }

        #endregion
    }
}
