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
        private IFileService _service;

        public MainViewModel(IFileService service)
        {
            _service = service;

            SelectFileCommand = new RelayCommand(x => SelectFile(), x => true);
            ProcessCommand = new RelayCommand(async x => await ProcessFile(), x => true);
            ShowGridWindowCommand = new RelayCommand(x => ShowGridWindow(), x => true);
            DetailsCommand = new RelayCommand(x => ShowGridWindow(), x => true);
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

        public ICommand ProcessCommand { get; }
        private async Task ProcessFile()
        {
            await _service.LoadProducts(FileName);
        }

        public ICommand DetailsCommand { get; }


        public ICommand ShowGridWindowCommand { get; }
        private void ShowGridWindow()
        {
            var gridWindow = new GridWindow();
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
