﻿using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.Configuration;

namespace Call_of_Duty_HQ.Views;

public partial class MainView : UserControl
{
    private string SteamDir = Program.Configuration["AppSettings:SteamPath"];
    
    public MainView()
    {
        InitializeComponent();
    }

    private void StartCoDExecutor(int steamId)
    {
        CoDExecutor.Views.MainWindow view = new()
        {
            steamPath = SteamDir
        };
        view.StartCoD(steamId);
        view.Show();
        if (Application.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.Shutdown();
        }
    }
    
    private void CoDHQ_OnClick(object? sender, RoutedEventArgs e)
    {
        StartCoDExecutor(1938090);
    }
}