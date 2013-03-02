using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

            // Initialize reservation array, 5 rows 2 seats per row
            Reservations = Enumerable.Repeat<bool>(true, 10).ToList();
            UpdateButtons();
        }

        public List<bool> Reservations { get; set; }

        /// <summary>
        /// Click handler for the Help menu item, opens the help explanation dialog
        /// </summary>
        private void Help_Click(object sender, RoutedEventArgs args)
        {
            MessageBox.Show("This is a simple seat reservation program." + Environment.NewLine + "Click a seat to reserve it, use the File menu to save, load and clear reservations.");
        }

        /// <summary>
        /// Click handler for the Save menu item, opens the save file dialog
        /// </summary>
        private void Save_Click(object sender, RoutedEventArgs args)
        {
            // Open a save dialog to get the filename
            string filename = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = ".txt";
            saveDialog.Filter = "Text documents (.txt)|*.txt";
            if (saveDialog.ShowDialog() == true)
                filename = saveDialog.FileName;

            // Use the obtained filename to save the contents of the reservations list to a file
            using (StreamWriter writer = new StreamWriter(filename, false))
            {
                foreach (bool seat in Reservations)
                    writer.WriteLine(seat);
            }
        }

        /// <summary>
        /// Click handler for the Load menu item, opens the load file dialog
        /// </summary>
        private void Load_Click(object sender, RoutedEventArgs args)
        {
            // Open a load dialog to get the filename
            string filename = "";
            OpenFileDialog loadDialog = new OpenFileDialog();
            loadDialog.DefaultExt = ".txt";
            loadDialog.Filter = "Text documents (.txt)|*.txt";
            if (loadDialog.ShowDialog() == true)
                filename = loadDialog.FileName;

            // Use the obtained filename to load the contents of the file to the reservations list
            using (StreamReader reader = new StreamReader(filename))
            {
                int index = 0;
                while (!reader.EndOfStream)
                {
                    Reservations[index] = bool.Parse(reader.ReadLine());
                    index++;
                }
            }
            UpdateButtons();
        }

        /// <summary>
        /// Click handler for the Clear menu item, clears all reservations
        /// </summary>
        private void Clear_Click(object sender, RoutedEventArgs args)
        {
            Reservations = Enumerable.Repeat<bool>(true, 10).ToList();
            UpdateButtons();
        }

        /// <summary>
        /// Method to update the state of the buttons to correspond to the current seat reservations
        /// </summary>
        private void UpdateButtons()
        {
            OneA.IsEnabled = Reservations[0];
            OneB.IsEnabled = Reservations[1];
            TwoA.IsEnabled = Reservations[2];
            TwoB.IsEnabled = Reservations[3];
            ThreeA.IsEnabled = Reservations[4];
            ThreeB.IsEnabled = Reservations[5];
            FourA.IsEnabled = Reservations[6];
            FourB.IsEnabled = Reservations[7];
            FiveA.IsEnabled = Reservations[8];
            FiveB.IsEnabled = Reservations[9];
        }

        /// <summary>
        /// Click handler for the 1A button, reserves the seat and updates the buttons
        /// </summary>
        private void Button1A_Click(object sender, RoutedEventArgs args)
        {
            Reservations[0] = false;
            UpdateButtons();
        }

        /// <summary>
        /// Click handler for the 1B button, reserves the seat and updates the buttons
        /// </summary>
        private void Button1B_Click(object sender, RoutedEventArgs args)
        {
            Reservations[1] = false;
            UpdateButtons();
        }

        /// <summary>
        /// Click handler for the 2A button, reserves the seat and updates the buttons
        /// </summary>
        private void Button2A_Click(object sender, RoutedEventArgs args)
        {
            Reservations[2] = false;
            UpdateButtons();
        }

        /// <summary>
        /// Click handler for the 2B button, reserves the seat and updates the buttons
        /// </summary>
        private void Button2B_Click(object sender, RoutedEventArgs args)
        {
            Reservations[3] = false;
            UpdateButtons();
        }

        /// <summary>
        /// Click handler for the 3A button, reserves the seat and updates the buttons
        /// </summary>
        private void Button3A_Click(object sender, RoutedEventArgs args)
        {
            Reservations[4] = false;
            UpdateButtons();
        }

        /// <summary>
        /// Click handler for the 3B button, reserves the seat and updates the buttons
        /// </summary>
        private void Button3B_Click(object sender, RoutedEventArgs args)
        {
            Reservations[5] = false;
            UpdateButtons();
        }

        /// <summary>
        /// Click handler for the 4A button, reserves the seat and updates the buttons
        /// </summary>
        private void Button4A_Click(object sender, RoutedEventArgs args)
        {
            Reservations[6] = false;
            UpdateButtons();
        }

        /// <summary>
        /// Click handler for the 4B button, reserves the seat and updates the buttons
        /// </summary>
        private void Button4B_Click(object sender, RoutedEventArgs args)
        {
            Reservations[7] = false;
            UpdateButtons();
        }

        /// <summary>
        /// Click handler for the 5A button, reserves the seat and updates the buttons
        /// </summary>
        private void Button5A_Click(object sender, RoutedEventArgs args)
        {
            Reservations[8] = false;
            UpdateButtons();
        }

        /// <summary>
        /// Click handler for the 5B button, reserves the seat and updates the buttons
        /// </summary>
        private void Button5B_Click(object sender, RoutedEventArgs args)
        {
            Reservations[9] = false;
            UpdateButtons();
        }
    }
}
