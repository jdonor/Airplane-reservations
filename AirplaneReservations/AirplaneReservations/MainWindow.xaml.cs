using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AirplaneReservations
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click handler for the Help menu item, opens the help explanation dialog.
        /// </summary>
        private void Help_Click(object sender, RoutedEventArgs args)
        {
            MessageBox.Show("This is a simple seat reservation program." + Environment.NewLine + "Click a seat to reserve it, use the File menu to save and load reservations.");
        }

        /// <summary>
        /// Click handler for the Save menu item, opens the save file dialog.
        /// </summary>
        private void Save_Click(object sender, RoutedEventArgs args)
        {
            // TODO: open a save file dialog and save the file
        }

        /// <summary>
        /// Click handler for the Load menu item, opens the load file dialog.
        /// </summary>
        private void Load_Click(object sender, RoutedEventArgs args)
        {
            // TODO: open a load file dialog and load the file
        }
    }
}
