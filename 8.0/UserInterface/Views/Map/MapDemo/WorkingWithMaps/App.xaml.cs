﻿using CommunityToolkit.Maui;

namespace WorkingWithMaps;
public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }
}