using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DupDetector.Models
{
    public class Product
    {
        [Column("action")]
        public string Action { get; set; }

        [Column("rank")]
        public string Rank { get; set; }

        [Column("sku")]
        public string SKU { get; set; }

        [Column("base_sku")]
        public string BaseSKU { get; set; }

        [Column("product_type")]
        public string ProductType { get; set; }

        [Column("molecule")]
        public string Molecule { get; set; }

        [Column("original_molecule_identifier")]
        public string OriginalMolecule { get; set; }

        [Column("manufacturer_common_name")]
        public string ManufacturerCommonName { get; set; }

        [Column("species")]
        public string Species { get; set; }

        [Column("size")]
        public string Size { get; set; }

        [Column("size_n")]
        public string SizeN { get; set; }

        [Column("protein_or_immunogen_sequence")]
        public string ProteinImmmunogenSequence { get; set; }

        [Column("tag")]
        public string Tag { get; set; }

        [Column("host")]
        public string Host { get; set; }

        [Column("isotype")]
        public string Isotype { get; set; }

        [Column("clonality")]
        public string Clonality { get; set; }

        [Column("clone")]
        public string Clone { get; set; }

        [Column("bioactive")]
        public bool Bioactive { get; set; }

        [Column("animal_free")]
        public bool AnimalFree { get; set; }

        [Column("percent_purity")]
        public string PercentPurity { get; set; }

        [Column("applications")]
        public string Applications { get; set; }

        [Column("lead_time_weeks")]
        public string LeadTime { get; set; }

        [Column("price")]
        public string Price { get; set; }

        [Column("image_number")]
        public int ImageNumber { get; set; }

        [Column("supplier")]
        public string Supplier { get; set; }

        [Column("order_history")]
        public string OrderHistory { get; set; }

        [Column("buffer")]
        public string Buffer { get; set; }

        [Column("supplier_catalog_number")]
        public string SupplierCatalogNumber { get; set; }
    }
}
