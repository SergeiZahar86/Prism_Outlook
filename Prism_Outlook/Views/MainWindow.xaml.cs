using ModernWpf.Controls;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace Prism_Outlook.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void PresetTimePicker_SelectedTimeChanged(object sender, RoutedPropertyChangedEventArgs<DateTime?> e)
        {
            throw new NotImplementedException();
        }

        private async void MenuItem_ClickAsync(object sender, RoutedEventArgs e)
        {
            UserControl1 dialog = new UserControl1();
            var result = await dialog.ShowAsync();
            if (result == ContentDialogResult.Primary)
            {
                DialogResult.Text = "User saved their work";
            }
            else if (result == ContentDialogResult.Secondary)
            {
                DialogResult.Text = "User did not save their work";
            }
            else
            {
                DialogResult.Text = "User cancelled the dialog";
            }
        }
    }
}
