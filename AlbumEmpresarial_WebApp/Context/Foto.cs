using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AlbumEmpresarial_WebApp.Context
{
    public partial class Foto
    {
        public int Id { get; set; }
        [Display(Name ="Descripción")]
        public string Descripcion { get; set; } = null!;
        [Display(Name ="Fecha")]
        public string FechaEvento { get; set; } = null!;
        [Display(Name ="Lugar del Evento")]
        public string Lugar { get; set; } = null!;
        [Display(Name ="Descripción del Evento")]
        public string DescripcionEvento { get; set; } = null!;
        public byte[] Imagen { get; set; } = null!;
    }

    
}
