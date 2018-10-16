using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DupDetector.ViewModels
{
    public class ProductViewModel : ViewModel
    {
        [DisplayName("Action")]
        public string Action
        {
            get => _action;
            set
            {
                _action = value;
                OnPropertyChanged(() => Action);
            }
        }
        private string _action;

        [DisplayName("Rank")]
        public string Rank
        {
            get => _rank;
            set
            {
                _rank = value;
                OnPropertyChanged(() => Rank);
            }
        }
        private string _rank;

        [DisplayName("SKU")]
        public string SKU
        {
            get => _sku;
            set
            {
                _sku = value;
                OnPropertyChanged(() => SKU);
            }
        }
        private string _sku;

        [DisplayName("Base SKU")]
        public string BaseSKU
        {
            get => _baseSKU;
            set
            {
                _baseSKU = value;
                OnPropertyChanged(() => BaseSKU);
            }
        }
        private string _baseSKU;

        [DisplayName("Product Type")]
        public string ProductType
        {
            get => _productType;
            set
            {
                _productType = value;
                OnPropertyChanged(() => ProductType);
            }
        }
        private string _productType;


        [DisplayName("Molecule")]
        public string Molecule
        {
            get => _molecule;
            set
            {
                _molecule = value;
                OnPropertyChanged(() => Molecule);
            }
        }
        private string _molecule;

        [DisplayName("Original Molecule")]
        public string OriginalMolecule
        {
            get => _originalMolecule;
            set
            {
                _originalMolecule = value;
                OnPropertyChanged(() => OriginalMolecule);
            }
        }
        private string _originalMolecule;

        [DisplayName("Manufacturer Name")]
        public string ManufacturerCommonName
        {
            get => _manufactureCommonName;
            set
            {
                _manufactureCommonName = value;
                OnPropertyChanged(() => ManufacturerCommonName);
            }
        }
        private string _manufactureCommonName;

        [DisplayName("Species")]
        public string Species { get; set; }

        [DisplayName("Size")]
        public string Size { get; set; }

        [DisplayName("Size n")]
        public string SizeN { get; set; }

        [DisplayName("Protein / Immmunogen Sequence")]
        public string ProteinImmmunogenSequence { get; set; }

        [DisplayName("Tag")]
        public string Tag { get; set; }

        [DisplayName("Host")]
        public string Host { get; set; }

        [DisplayName("Isotype")]
        public string Isotype { get; set; }

        [DisplayName("Clonality")]
        public string Clonality { get; set; }

        [DisplayName("Clone")]
        public string Clone { get; set; }

        [DisplayName("Bioactive")]
        public bool Bioactive { get; set; }

        [DisplayName("Animal Free")]
        public bool AnimalFree { get; set; }

        [DisplayName("Percent Purity")]
        public string PercentPurity { get; set; }

        [DisplayName("Applications")]
        public string Applications { get; set; }

        [DisplayName("Lead Time")]
        public string LeadTime { get; set; }

        [DisplayName("Price")]
        public string Price { get; set; }

        [DisplayName("Image Number")]
        public int ImageNumber { get; set; }

        [DisplayName("Supplier")]
        public string Supplier { get; set; }

        [DisplayName("Order History")]
        public string OrderHistory { get; set; }

        [DisplayName("Buffer")]
        public string Buffer { get; set; }

        [DisplayName("Supplier Catalog #")]
        public string SupplierCatalogNumber { get; set; }
    }
}
