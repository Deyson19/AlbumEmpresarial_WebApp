using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlbumEmpresarial_WebApp.Context;
using System.Drawing;
using AlbumEmpresarial_WebApp.Models;

namespace AlbumEmpresarial_WebApp.Controllers
{
    public class InformacionController : Controller
    {
        private readonly albumfotosempresarialesContext _context;
        public InformacionController(albumfotosempresarialesContext context)
        {
            this._context = context;
        }

        // GET: Informacion
        public async Task<IActionResult> Index()
        {
            return View(await _context.Fotos.ToListAsync());
        }
        
        public static async Task<List<Foto>> TraerDatos()
        {
            albumfotosempresarialesContext context = new albumfotosempresarialesContext();
            List<Foto> fotos = new List<Foto>();
            try
            {
                var datos = await context.Fotos.Select(f => new
                {
                    Descripcion = f.Descripcion,
                    FechaEvento = f.FechaEvento,
                    Lugar = f.Lugar,
                    DescripcionEvento = f.DescripcionEvento,
                    Imagen = f.Imagen
                }).ToListAsync();
            }
            catch (Exception e)
            {

                throw;
            }
            return fotos;
        }
        
        private bool FotoExists(int id)
        {
          return _context.Fotos.Any(e => e.Id == id);
        }
    }
}
