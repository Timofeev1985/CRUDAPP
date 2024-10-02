using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CRUDAPP.Entities;

namespace CRUDAPP.Views;

public partial class UserEditView : UserControl
{
    public User User { get; set; }
    public UserEditView( User user)
    {
        InitializeComponent();
        User = user;
        DataContext = this;
    }
     private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
     private void CloseButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        App.MainWindow.MainContentControl.Content = new UsersView();
    }
}