﻿using System.ComponentModel.DataAnnotations;

namespace RegistroDePrioridades.Models
{
    public class Prioridades
    {
        [Key]
        public int PrioridadId { get; set; }
        [Required(ErrorMessage = "El Campo Descripci&oacute;n es obligatorio")]
        public string? Descripcion { get; set; }

        public int DiasCompromiso { get; set; }

    }
}
