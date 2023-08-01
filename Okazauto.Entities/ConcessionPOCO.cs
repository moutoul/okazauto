using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okazauto.Entities
{
    public class ConcessionPOCO : FourniPOCO
    {
        public string TVA { get; set; }
        public int IdFournisseur { get; set; }
    }
}
