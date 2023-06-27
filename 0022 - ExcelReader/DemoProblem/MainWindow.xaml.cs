using System.Windows;
using Microsoft.Win32;

namespace DemoProblem
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

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            var response = openFileDialog.ShowDialog();

            if (response != true) return;

            var filePath = openFileDialog.FileName;
            var excelData = new ExcelData(filePath);
            this.DataGrid1.DataContext = excelData;
        }
    }
}
