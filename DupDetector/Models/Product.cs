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
        internal int Id;

        [Column("Action"), DisplayName("Action")]
        public string Action { get; set; }

        [Column("Rank"), DisplayName("Rank")]
        public string Rank { get; set; }

        [Column("SKU"), DisplayName("SKU")]
        public string SKU { get; set; }

        [Column("base_SKU"), DisplayName("Base SKU")]
        public string BaseSKU { get; set; }

        [Column("product_type"), DisplayName("Product Type")]
        public string ProductType { get; set; }

        [Column("molecule"), DisplayName("Molecule")]
        public string Molecule { get; set; }

        [Column("original_molecule_identifier"), DisplayName("Original Molecule")]
        public string OriginalMolecule { get; set; }

        [Column("manufacturer_common_name"), DisplayName("Manufacturer Name")]
        public string ManufacturerCommonName { get; set; }

        [Column("species"), DisplayName("Species")]
        public string Species { get; set; }

        [Column("size"), DisplayName("Size")]
        public string Size { get; set; }

        [Column("size_n"), DisplayName("Size n")]
        public string SizeN { get; set; }

        [Column("protein_or_immmunogen_sequence "), DisplayName("Protein / Immmunogen Sequence")]
        public string ProteinImmmunogenSequence { get; set; }

        [Column("tag"), DisplayName("Tag")]
        public string Tag { get; set; }

        [Column("host"), DisplayName("Host")]
        public string Host { get; set; }

        [Column("isotype"), DisplayName("Isotype")]
        public string Isotype { get; set; }

        [Column("clonality"), DisplayName("Clonality")]
        public string Clonality { get; set; }

        [Column("clone"), DisplayName("Clone")]
        public string Clone { get; set; }

        [Column("bioactive"), DisplayName("Bioactive")]
        public string Bioactive { get; set; }

        [Column("animal_free"), DisplayName("Animal Free")]
        public string AnimalFree { get; set; }

        [Column("percent_purity"), DisplayName("Percent Purity")]
        public string PercentPurity { get; set; }

        [Column("applications"), DisplayName("Applications")]
        public string Applications { get; set; }

        [Column("lead_time_weeks"), DisplayName("Lead Time")]
        public string LeadTime { get; set; }

        [Column("price"), DisplayName("Price")]
        public string Price { get; set; }

        [Column("image_number"), DisplayName("Image Number")]
        public int ImageNumber { get; set; }

        [Column("supplier"), DisplayName("Supplier")]
        public string Supplier { get; set; }

        [Column("order_history"), DisplayName("Order History")]
        public string OrderHistory { get; set; }

        [Column("buffer"), DisplayName("Buffer")]
        public string Buffer { get; set; }

        [Column("supplier_catalog_number"), DisplayName("Supplier Catalog #")]
        public string SupplierCatalogNumber { get; set; }
        public string Name { get; internal set; }
    }
}
