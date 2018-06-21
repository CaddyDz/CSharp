using Microsoft.Win32;
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

namespace WpfTutorial
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

        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.ShowDialog();
        }

        private void MenuSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.ShowDialog();
        }

        private void MenuFontTimes_Click(object sender, RoutedEventArgs e)
        {
            menuFontCourier.IsChecked = false;
            menuFontArial.IsChecked = false;
            txtBoxDoc.FontFamily = new FontFamily("Times New Roman");
        }

        private void MenuFontCourier_Click(object sender, RoutedEventArgs e)
        {
            menuFontTimes.IsChecked = false;
            menuFontArial.IsChecked = false;
            txtBoxDoc.FontFamily = new FontFamily("Courier");
        }

        private void MenuFontArial_Click(object sender, RoutedEventArgs e)
        {
            menuFontCourier.IsChecked = false;
            menuFontTimes.IsChecked = false;
            txtBoxDoc.FontFamily = new FontFamily("Arial");
        }

        private bool comboFSClosed = true;

        private void ComboFontSize_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            comboFSClosed = !comboBox.IsDropDownOpen;
            ChangeTBFontSize();
        }

        private void ComboFontSize_DropDownClosed(object sender, System.EventArgs e)
        {
            if (comboFSClosed)
            {
                ChangeTBFontSize();
            }
            comboFSClosed = true;
        }

        private void ChangeTBFontSize()
        {
            string fontSize = comboFontSize.SelectedItem.ToString();

            fontSize = fontSize.Substring(fontSize.Length - 2);

            switch (fontSize)
            {
                case "10":
                    txtBoxDoc.FontSize = 10;
                    break;
                case "12":
                    txtBoxDoc.FontSize = 12;
                    break;
                case "14":
                    txtBoxDoc.FontSize = 14;
                    break;
                case "16":
                    txtBoxDoc.FontSize = 16;
                    break;
                default:
                    break;
            }
        }
    }
}