﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okazauto.Models
{
    public class VoitureDTO
    {
        public int Id { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public DateOnly DateImmat { get; set; }
        public bool Disponibilite { get; set; } = true;
    }
}
