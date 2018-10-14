using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DupDetector.ViewModels
{
    public class ProductGridViewModel : ViewModel
    {
        private IFileService _service;

        public ProductGridViewModel(IFileService service)
        {
            _service = service;
        }

        public ObservableCollection<ProductViewModel> Products
        {
            get
            {
                if (_service.Products == null)
                {
                    return new ObservableCollection<ProductViewModel>(Enumerable.Empty<ProductViewModel>());
                }
                else
                {
                    return new ObservableCollection<ProductViewModel>(_service.Products);
                }
            }
        }
    }
}
