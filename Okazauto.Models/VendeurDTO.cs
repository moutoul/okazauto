using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okazauto.Models
{
    public class VendeurDTO
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public int NombreDeVentes { get; set; }
        public string Email { get; set; }

        public string MotDePasse { get; set; }
    }
}
