using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
            reservations = Enumerable.Repeat<bool>(false, 10).ToList();
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
                foreach (bool seat in reservations)
                    writer.WriteLine(seat);
            }
        }

        /// <summary>
        /// Click handler for the Load menu item, opens the load file dialog.
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
                    reservations[index] = bool.Parse(reader.ReadLine());
                    index++;
                }
            }
        }

        private List<bool> reservations;
    }
}
