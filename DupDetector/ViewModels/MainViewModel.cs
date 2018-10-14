using DupDetector.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DupDetector.ViewModels
{
    public class MainViewModel : ViewModel
    {
        public MainViewModel()
        {
            SelectFileCommand = new RelayCommand(x => SelectFile(), x => true);
            ShowGridWindowCommand = new RelayCommand(async x => await ShowGridWindow(), x => true);
            DetailsCommand = new RelayCommand(async x => await ShowGridWindow(), x => true);
        }

        public ICommand SelectFileCommand { get; }
        private void SelectFile()
        {
            var dlg = new OpenFileDialog();
            var result = dlg.ShowDialog();

            if (result == true)
            {
                string filename = dlg.FileName;
                FileName = filename;
            }
        }

        public ICommand DetailsCommand { get; }


        public ICommand ShowGridWindowCommand { get; }
        private async Task ShowGridWindow()
        {
            // Temp code to see if file loading works
            var fileProcessor = new FileProcessor();
            var rowCollection = await fileProcessor.Extract(FileName);
            await fileProcessor.Translate(rowCollection);

            var gridWindow = new GridWindow();
            gridWindow.Products = new ObservableCollection<Product>(fileProcessor.Products);
            gridWindow.Show();
        }

        private string _fileName;
        public string FileName
        {
            get => _fileName;
            set
            {
                _fileName = value;
                OnPropertyChanged(() => FileName);
            }
        }
    }
}
