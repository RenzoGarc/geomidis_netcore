using Microsoft.AspNetCore.Mvc;
using GeomidisSystem.Context;
using NetTopologySuite.Geometries;
using GeomidisSystem.Models.Diseno_Arte;
using GeomidisSystem.Services;
using GeomidisSystem.Models.Contigo;

namespace GeomidisSystem.Controllers
{
    [ApiController]
    [Route("diseno_arte")]
    public class DisenoController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DisenoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("comepopu")]
        public async Task<IActionResult> RegisterComepopu(List<SpgDiseartComepopu> spgDiseartComepopu)
        {
            try
            {
                for (int i = 0; i < spgDiseartComepopu.Count; i++)
                {
                    _context.Add(spgDiseartComepopu[i]);
                    float Long = (float)spgDiseartComepopu[i].COUBIX;
                    float Lat = (float)spgDiseartComepopu[i].COUBIY;
                    spgDiseartComepopu[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgDiseartComepopu[i]);
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
        [Route("ollicomu")]
        public async Task<IActionResult> RegisterOllicomu(List<SpgDiseartOllicomu> spgDiseartOllicomu)
        {
            try
            {
                for (int i = 0; i < spgDiseartOllicomu.Count; i++)
                {
                    _context.Add(spgDiseartOllicomu[i]);
                    float Long = (float)spgDiseartOllicomu[i].COUBIX;
                    float Lat = (float)spgDiseartOllicomu[i].COUBIY;
                    spgDiseartOllicomu[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgDiseartOllicomu[i]);
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
