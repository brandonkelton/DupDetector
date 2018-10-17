using AutoMapper;
using DupDetector.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DupDetector
{
    public class FileService : IFileService
    {
        public List<ProductViewModel> Products { get; private set; } = null;

        public async Task LoadProducts(string fileName)
        {
            var fileProcessor = new FileProcessor();
            var rowCollection = await fileProcessor.Extract(fileName);
            await fileProcessor.Translate(rowCollection);
            Products = Mapper.Map<List<ProductViewModel>>(fileProcessor.Products);
        }
    }
}
