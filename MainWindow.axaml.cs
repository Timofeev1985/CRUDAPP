using Avalonia.Controls;
using CRUDAPP.Views;

namespace CRUDAPP;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        App.MainWindow = this;
        App.MainWindow.MainContentControl.Content = new UsersView();
    }
}