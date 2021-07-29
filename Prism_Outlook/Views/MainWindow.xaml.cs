using Infragistics.Windows.Ribbon;
using System;
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
    }
}
