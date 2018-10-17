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
        public string Species
        {
            get => _species;
            set
            {
                _species = value;
                OnPropertyChanged(() => Species);
            }
        }
        private string _species;

        [DisplayName("Size")]
        public string Size
        {
            get => _size;
            set
            {
                _size = value;
                OnPropertyChanged(() => Size);
            }
        }
        private string _size;

        [DisplayName("Size n")]
        public string SizeN
        {
            get => _sizeN;
            set
            {
                _sizeN = value;
                OnPropertyChanged(() => SizeN);
            }
        }
        private string _sizeN;

        [DisplayName("Protein / Immmunogen Sequence")]
        public string ProteinImmmunogenSequence
        {
            get => _proteinImmmunogenSequence;
            set
            {
                _proteinImmmunogenSequence = value;
                OnPropertyChanged(() => ProteinImmmunogenSequence);
            }
        }
        private string _proteinImmmunogenSequence;

        [DisplayName("Tag")]
        public string Tag
        {
            get => _tag;
            set
            {
                _tag = value;
                OnPropertyChanged(() => Tag);
            }
        }
        private string _tag;

        [DisplayName("Host")]
        public string Host
        {
            get => _host;
            set
            {
                _host = value;
                OnPropertyChanged(() => Host);
            }
        }
        private string _host;

        [DisplayName("Isotype")]
        public string Isotype
        {
            get => _isotype;
            set
            {
                _isotype = value;
                OnPropertyChanged(() => Isotype);
            }
        }
        private string _isotype;

        [DisplayName("Clonality")]
        public string Clonality
        {
            get => _clonality;
            set
            {
                _clonality = value;
                OnPropertyChanged(() => Clonality);
            }
        }
        private string _clonality;

        [DisplayName("Clone")]
        public string Clone
        {
            get => _clone;
            set
            {
                _clone = value;
                OnPropertyChanged(() => Clone);
            }
        }
        private string _clone;

        [DisplayName("Bioactive")]
        public bool Bioactive
        {
            get => _bioactive;
            set
            {
                _bioactive = value;
                OnPropertyChanged(() => Bioactive);
            }
        }
        private bool _bioactive;

        [DisplayName("Animal Free")]
        public bool AnimalFree
        {
            get => _animalFree;
            set
            {
                _animalFree = value;
                OnPropertyChanged(() => AnimalFree);
            }
        }
        private bool _animalFree;

        [DisplayName("Percent Purity")]
        public string PercentPurity
        {
            get => _percentPurity;
            set
            {
                _percentPurity = value;
                OnPropertyChanged(() => PercentPurity);
            }
        }
        private string _percentPurity;

        [DisplayName("Applications")]
        public string Applications
        {
            get => _applications;
            set
            {
                _applications = value;
                OnPropertyChanged(() => Applications);
            }
        }
        private string _applications;

        [DisplayName("Lead Time")]
        public string LeadTime
        {
            get => _leadTime;
            set
            {
                _leadTime = value;
                OnPropertyChanged(() => LeadTime);
            }
        }
        private string _leadTime;

        [DisplayName("Price")]
        public string Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged(() => Price);
            }
        }
        private string _price;

        [DisplayName("Image Number")]
        public int ImageNumber
        {
            get => _imageNumber;
            set
            {
                _imageNumber = value;
                OnPropertyChanged(() => ImageNumber);
            }
        }
        private int _imageNumber;

        [DisplayName("Supplier")]
        public string Supplier
        {
            get => _supplier;
            set
            {
                _supplier = value;
                OnPropertyChanged(() => Supplier);
            }
        }
        private string _supplier;

        [DisplayName("Order History")]
        public string OrderHistory
        {
            get => _orderHistory;
            set
            {
                _orderHistory = value;
                OnPropertyChanged(() => OrderHistory);
            }
        }
        private string _orderHistory;

        [DisplayName("Buffer")]
        public string Buffer
        {
            get => _buffer;
            set
            {
                _buffer = value;
                OnPropertyChanged(() => Buffer);
            }
        }
        private string _buffer;

        [DisplayName("Supplier Catalog #")]
        public string SupplierCatalogNumber
        {
            get => _supplierCatalogNumber;
            set
            {
                _supplierCatalogNumber = value;
                OnPropertyChanged(() => SupplierCatalogNumber);
            }
        }
        private string _supplierCatalogNumber;
    }
}
