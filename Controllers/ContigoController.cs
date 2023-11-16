using Microsoft.AspNetCore.Mvc;
using GeomidisSystem.Context;
using NetTopologySuite.Geometries;
using GeomidisSystem.Models.Contigo;
using GeomidisSystem.Services;
using Microsoft.EntityFrameworkCore;
using GeomidisSystem.Models.Pais;

namespace GeomidisSystem.Controllers
{
    [ApiController]
    [Route("contigo")]
    public class ContigoController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ContigoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("usprocon")]
        public async Task<IActionResult> RegisterUsprocon(List<SpgCtgUsprocon> spgCtgUsprocon)
        {
            try
            {
                for (int i = 0; i < spgCtgUsprocon.Count; i++)
                {
                    _context.Add(spgCtgUsprocon[i]);
                    float Long = (float)spgCtgUsprocon[i].CUBVIX;
                    float Lat = (float)spgCtgUsprocon[i].CUBVIY;
                    spgCtgUsprocon[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgCtgUsprocon[i]);
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
        [Route("vidomusu")]
        public async Task<IActionResult> RegisterCaratambs(List<SpgCtgVidomusu> spgCtgVidomusu)
        {
            try
            {
                for (int i = 0; i < spgCtgVidomusu.Count; i++)
                {
                    _context.Add(spgCtgVidomusu[i]);
                    float Long = (float)spgCtgVidomusu[i].CUBVIX;
                    float Lat = (float)spgCtgVidomusu[i].CUBVIY;
                    spgCtgVidomusu[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgCtgVidomusu[i]);
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
