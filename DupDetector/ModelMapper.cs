using AutoMapper;
using DupDetector.Models;
using DupDetector.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DupDetector
{
    public static class ModelMapper
    {
        private static bool _isInitialized;
        public static void Initialize()
        {
            if (!_isInitialized)
            {
                Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<Product, ProductViewModel>();
                    
                });
                _isInitialized = true;
            }
        }
    }
}
