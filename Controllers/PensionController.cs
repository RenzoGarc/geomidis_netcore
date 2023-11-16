using Microsoft.AspNetCore.Mvc;
using GeomidisSystem.Context;
using NetTopologySuite.Geometries;
using GeomidisSystem.Models.Pension;
using GeomidisSystem.Services;

namespace GeomidisSystem.Controllers
{
    [ApiController]
    [Route("pension")]
    public class PensionController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PensionController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("agebanac")]
        public async Task<IActionResult> RegisterAgebanac(List<SpgPsn65Agebanac> spgPsn65Agebanac)
        {
            try
            {
                for (int i = 0; i < spgPsn65Agebanac.Count; i++)
                {
                    _context.Add(spgPsn65Agebanac[i]);
                    float Long = (float)spgPsn65Agebanac[i].COUBIX;
                    float Lat = (float)spgPsn65Agebanac[i].COUBIY;
                    spgPsn65Agebanac[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgPsn65Agebanac[i]);
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
        [Route("emtraval")]
        public async Task<IActionResult> RegisterEmtraval(List<SpgPsn65Emtraval> spgPsn65Emtraval)
        {
            try
            {
                for (int i = 0; i < spgPsn65Emtraval.Count; i++)
                {
                    _context.Add(spgPsn65Emtraval[i]);
                    float Long = (float)spgPsn65Emtraval[i].COUBIX;
                    float Lat = (float)spgPsn65Emtraval[i].COUBIY;
                    spgPsn65Emtraval[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgPsn65Emtraval[i]);
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
        [Route("usupen65")]
        public async Task<IActionResult> RegisterUsupen65(List<SpgPsn65Usupen65> spgPsn65Usupen65)
        {
            try
            {
                for (int i = 0; i < spgPsn65Usupen65.Count; i++)
                {
                    _context.Add(spgPsn65Usupen65[i]);
                    float Long = (float)spgPsn65Usupen65[i].COUBIX;
                    float Lat = (float)spgPsn65Usupen65[i].COUBIY;
                    spgPsn65Usupen65[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgPsn65Usupen65[i]);
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
