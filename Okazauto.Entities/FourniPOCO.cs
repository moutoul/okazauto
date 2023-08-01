using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okazauto.Entities
{
    public class FourniPOCO
    {

        public int Id { get; set; }
        public int IdVoiture { get; set; }
        public int IdFournisseur { get; set; }
        public int Kilometrage { get; set; }
        public int PrixAchat { get; set; }
        public DateOnly DateAchat { get; set; }

    }
}
