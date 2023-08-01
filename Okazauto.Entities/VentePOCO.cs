using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okazauto.Entities
{
    public class VentePOCO
    {


        public int Id { get; set; }
        public float PrixVente { get; set; }
        public DateOnly DateDeVente { get; set; }
        public bool StatutPaiement { get; set; }
        public int IdClient { get; set; }
        public int IdVendeur {get; set; }
        public int IdVoiture { get; set; }

    }
}
