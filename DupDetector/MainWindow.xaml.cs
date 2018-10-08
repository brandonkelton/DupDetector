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

namespace DupDetector
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainVM ViewModel { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void ButtonConfirm_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ButtonDetails_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var gridWindow = new GridWindow();
            gridWindow.Show();
        }

        private void ButtonClose_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void ButtonSelectFile_PreviewMouseMouse(object sender, MouseButtonEventArgs e)
        {
            var dlg = new OpenFileDialog();
            var result = dlg.ShowDialog();

            if (result == true)
            {
                string filename = dlg.FileName;
                TextBoxFile.Text = filename;
            }
        }

        private void ButtonDetails_Copy_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
