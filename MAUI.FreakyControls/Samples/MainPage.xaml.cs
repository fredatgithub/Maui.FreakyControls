﻿using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace Samples;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }

    async void FreakySvgImageView_Tapped(object sender, System.EventArgs e)
    {
        await this.DisplayAlert("Yo", "Hi from the dotnet bot", "Ok");
    }

    void FreakyTextInputLayout_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
        yolo.Text = e.NewTextValue;
    }
}

