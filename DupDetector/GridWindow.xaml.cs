using DupDetector.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace DupDetector
{
    /// <summary>
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();

            //Products.Add(new Product { Action = "Test1", Rank="1", AnimalFree = "Test2" });
            //Products.Add(new Product { Action = "Test3", Rank="2", AnimalFree = "Test4" });
        }

        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>();
    }
}
