using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;


namespace ClientBankConversion
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtSourceFileDoubleClick(object sender, MouseButtonEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose your source file";
            openFileDialog.Filter = "Data files |*.csv;*.dbf";
            if (openFileDialog.ShowDialog() == true)
                txtSourceFile.Text = openFileDialog.FileName;

        }


        private void txtDestinationFileDoubleClick(object sender, MouseButtonEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose your destination file";
            openFileDialog.Filter = "DBF files |*.dbf";
            if (openFileDialog.ShowDialog() == true)
                txtDestinationFile.Text = openFileDialog.FileName;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Loading Map dictionary
            

        }
    }
}

