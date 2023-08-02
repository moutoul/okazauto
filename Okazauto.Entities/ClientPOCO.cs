using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okazauto.Entities
{
    public class ClientPOCO
    {

        [Key]
  
        public int Id { get; set; }

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        
        [Required]
        public string Email { get; set; }
        public string Adresse { get; set; }

    }
}
