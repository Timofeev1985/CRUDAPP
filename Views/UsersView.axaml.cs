using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CRUDAPP.Entities;

namespace CRUDAPP.Views;

public partial class UsersView : UserControl
{
    public List<User> Users { get; set; }
    TestContext context;
    public UsersView()
    {
        InitializeComponent();
        context = new TestContext();
        Users = context.Users.ToList(); 
        DataContext = this; 

    }
private void InitializeComponent()
{
    AvaloniaXamlLoader.Load(this);
}  
private void AddButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
            }
private void EditButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
            }
private void RemoveButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
            }
private void PrintButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
            }
}