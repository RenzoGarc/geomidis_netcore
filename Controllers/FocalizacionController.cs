using Microsoft.AspNetCore.Mvc;
using GeomidisSystem.Context;
using NetTopologySuite.Geometries;
using GeomidisSystem.Models.Focalizacion;
using GeomidisSystem.Services;
using GeomidisSystem.Models.Diseno_Arte;

namespace GeomidisSystem.Controllers
{
    [ApiController]
    [Route("focalizacion")]
    public class FocalizacionController : Controller
    {
        private readonly ApplicationDbContext _context;
        public FocalizacionController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("cpdgfi")]
        public async Task<IActionResult> RegisterCpdgfi(List<SpgFclCpdgfi> spgFclCpdgfi)
        {
            try
            {
                for (int i = 0; i < spgFclCpdgfi.Count; i++)
                {
                    _context.Add(spgFclCpdgfi[i]);
                    float Long = (float)spgFclCpdgfi[i].COUBIX;
                    float Lat = (float)spgFclCpdgfi[i].COUBIY;
                    spgFclCpdgfi[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgFclCpdgfi[i]);
                    await _context.SaveChangesAsync();
                }
                return StatusCode(200, "Registro correcto!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        [Route("hogdgfis")]
        public async Task<IActionResult> RegisterHogdgfis(List<SpgFclHogdgfis> spgFclHogdgfis)
        {
            try
            {
                for (int i = 0; i < spgFclHogdgfis.Count; i++)
                {
                    _context.Add(spgFclHogdgfis[i]);
                    float Long = (float)spgFclHogdgfis[i].COORX;
                    float Lat = (float)spgFclHogdgfis[i].COORY;
                    spgFclHogdgfis[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgFclHogdgfis[i]);
                    await _context.SaveChangesAsync();
                }
                return StatusCode(200, "Registro correcto!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
