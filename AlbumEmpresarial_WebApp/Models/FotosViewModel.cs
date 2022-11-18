using AlbumEmpresarial_WebApp.Context;
using System.ComponentModel.DataAnnotations;

namespace AlbumEmpresarial_WebApp.Models
{
    public class FotosViewModel
    {
        public string Descripcion { get; set; }
        [Required]
        public string Fecha_Evento { get; set; }
        [Required]
        public string Lugar { get; set; }
        [Required]
        public string Descripcion_Evento { get; set; }
        [Required]
        public byte[] Imagen { get; set; }
    }

   
}
