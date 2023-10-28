
using Microsoft.AspNetCore.Mvc;
using GeomidisSystem.Context;
using NetTopologySuite.Geometries;
using GeomidisSystem.Models.Pais;
using GeomidisSystem.Services;

namespace GeomidisSystem.Controllers
{
    [ApiController]
    [Route("pais")]
    public class PaisController : Controller

    {
        private readonly ApplicationDbContext _context;
        private readonly PaisServices paisServices = new();
        public PaisController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("caratambs")]
        public async Task<IActionResult> RegisterCaratambs(List<SpgPsCaratamb> spgPsCaratamb)
        {
            try
            {
                for (int i = 0; i < spgPsCaratamb.Count; i++)
                {
                    _context.Add(spgPsCaratamb[i]);
                    float Long = (float)spgPsCaratamb[i].COUBIX;
                    float Lat = (float)spgPsCaratamb[i].COUBIY;
                    spgPsCaratamb[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgPsCaratamb[i]);
                    await _context.SaveChangesAsync();
                }
                return StatusCode(200, "Registro correcto!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        // EJEMPLO CON SERVICIOS
        [HttpPost]
        [Route("puatpias")]
        public async Task<IActionResult> RegisterPuatpias()
        {
            try
            {
                var spgPsPuatpias = await paisServices.Puatpias();

                for (int i = 0; i < spgPsPuatpias.Count; i++)
                {
                    _context.Add(spgPsPuatpias[i]);
                    float Long = (float)spgPsPuatpias[i].COUBIX;
                    float Lat = (float)spgPsPuatpias[i].COUBIY;
                    spgPsPuatpias[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
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
        [Route("sumontam")]
        public async Task<IActionResult> RegisterSumontam(List<SpgPsSumontam> SpgPsSumontam)
        {
            try
            {
                for (int i = 0; i < SpgPsSumontam.Count; i++)
                {
                    _context.Add(SpgPsSumontam[i]);
                    float Long = (float)SpgPsSumontam[i].COUBIX;
                    float Lat = (float)SpgPsSumontam[i].COUBIY;
                    SpgPsSumontam[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(SpgPsSumontam[i]);
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
        [Route("tambos")]
        public async Task<IActionResult> RegisterTambos(List<SpgPsTambos> spgPsTambos)
        {
            try
            {
                for (int i = 0; i < spgPsTambos.Count; i++)
                {
                    _context.Add(spgPsTambos[i]);
                    float Long = (float)spgPsTambos[i].COUBIX;
                    float Lat = (float)spgPsTambos[i].COUBIY;
                    spgPsTambos[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgPsTambos[i]);
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
        [Route("unidterr")]
        public async Task<IActionResult> RegisterUnidterr(List<SpgPsUnidterr> spgPsUnidterrs)
        {
            try
            {
                for (int i = 0; i < spgPsUnidterrs.Count; i++)
                {
                    _context.Add(spgPsUnidterrs[i]);
                    float Long = (float)spgPsUnidterrs[i].COUBIX;
                    float Lat = (float)spgPsUnidterrs[i].COUBIY;
                    spgPsUnidterrs[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgPsUnidterrs[i]);
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
