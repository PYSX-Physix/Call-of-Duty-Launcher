﻿using System.Diagnostics;
using Call_of_Duty_HQ.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Call_of_Duty_HQ.Views;

public sealed partial class BO3Page : Page
{
    public BO3ViewModel ViewModel
    {
        get;
    }

    public BO3Page()
    {
        ViewModel = App.GetService<BO3ViewModel>();
        InitializeComponent();
    }

    private void Button_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        Process.Start("C:\\Program Files (x86)\\Steam\\steam.exe", "steam://rungameid/311210");
    }
}
