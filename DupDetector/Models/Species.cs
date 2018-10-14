using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DupDetector.Models
{
    public class Species
    {
        [Column("Name"), DisplayName("Name")]
        public string Name { get; set; }

        [Column("abbreviation"), DisplayName("Abbreviation")]
        public string Abbreviation { get; set; }

        [Column("AltNames"), DisplayName("Alt Names")]
        public string AltNames { get; set; }
    }
}
