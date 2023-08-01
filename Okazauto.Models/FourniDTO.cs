using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okazauto.Models
{
    public class FourniDTO
    {
        public int Id { get; set; }
        public int IdVoiture { get; set; }
        public int IdFournisseur { get; set; }
        public int Kilometrage { get; set; }
        public int PrixAchat { get; set; }
        public DateOnly DateAchat { get; set; }
    }
}
