using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace CRUDAPP.Views;

public partial class UsersView : UserControl
{
    public UsersView()
    {
        InitializeComponent();
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