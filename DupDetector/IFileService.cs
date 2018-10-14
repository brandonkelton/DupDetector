using System.Collections.Generic;
using System.Threading.Tasks;
using DupDetector.ViewModels;

namespace DupDetector
{
    public interface IFileService
    {
        List<ProductViewModel> Products { get; }

        Task LoadProducts(string fileName);
    }
}