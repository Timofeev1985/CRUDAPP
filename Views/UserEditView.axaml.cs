using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CRUDAPP.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPP.Views;

public partial class UserEditView : UserControl
{
    public User User { get; set; }
     TestContext context;
    public UserEditView( User user)
    {
        InitializeComponent();
        User = user;
        context = new TestContext();
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
    private void SaveButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (User.Id == 0)
            context.Users.Add(User);
        else
            context.Entry(User).State = EntityState.Modified;
            context.SaveChanges();
            App.MainWindow.MainContentControl.Content = new UsersView();
    }
}