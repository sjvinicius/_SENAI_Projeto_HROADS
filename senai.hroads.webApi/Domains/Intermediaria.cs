﻿using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Intermediaria
    {
        public int IdIntermediaria { get; set; }
        public int? IdClasse { get; set; }
        public int? IdHabilidade { get; set; }

        public virtual Class IdClasseNavigation { get; set; }
        public virtual Habilidade IdHabilidadeNavigation { get; set; }
    }
}
