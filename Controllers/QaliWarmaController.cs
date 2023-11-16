using Microsoft.AspNetCore.Mvc;
using GeomidisSystem.Context;
using NetTopologySuite.Geometries;
using GeomidisSystem.Models.Qali_Warma;
using GeomidisSystem.Services;
using GeomidisSystem.Models.Juntos;

namespace GeomidisSystem.Controllers
{
    [ApiController]
    [Route("qali_warma")]
    public class QaliWarmaController : Controller
    {
        private readonly ApplicationDbContext _context;
        public QaliWarmaController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("almaprov")]
        public async Task<IActionResult> RegisterAlmaprov(List<SpgQwAlmaprov> spgQwAlmaprov)
        {
            try
            {
                for (int i = 0; i < spgQwAlmaprov.Count; i++)
                {
                    _context.Add(spgQwAlmaprov[i]);
                    float Long = (float)spgQwAlmaprov[i].COUBIX;
                    float Lat = (float)spgQwAlmaprov[i].COUBIY;
                    spgQwAlmaprov[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgQwAlmaprov[i]);
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
        [Route("entrprod")]
        public async Task<IActionResult> RegisterEntrprod(List<SpgQwEntrprod> spgQwEntrprod)
        {
            try
            {
                for (int i = 0; i < spgQwEntrprod.Count; i++)
                {
                    _context.Add(spgQwEntrprod[i]);
                    float Long = (float)spgQwEntrprod[i].COUBEX;
                    float Lat = (float)spgQwEntrprod[i].COUBEY;
                    spgQwEntrprod[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgQwEntrprod[i]);
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
        [Route("supeiiee")]
        public async Task<IActionResult> RegisterSupeiiee(List<SpgQwSupeiiee> spgQwSupeiiee)
        {
            try
            {
                for (int i = 0; i < spgQwSupeiiee.Count; i++)
                {
                    _context.Add(spgQwSupeiiee[i]);
                    float Long = (float)spgQwSupeiiee[i].COUBIX;
                    float Lat = (float)spgQwSupeiiee[i].COUBIY;
                    spgQwSupeiiee[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgQwSupeiiee[i]);
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
        [Route("unteqawa")]
        public async Task<IActionResult> Create(List<SpgQwUnteqawaObtener> spgQwUnteqawaObtener)
        {
            try
            {
                // EJEMPLO PARA LINESTRING
                //Coordinate coord1 = new(74.6523332, 21.213213);
                //Coordinate coord2 = new(80.2321312, 25.563213);
                //Coordinate coord3 = new(85.6522352, 25.983223);
                //Coordinate[] coordArr = new Coordinate[] { coord1, coord2, coord3 };
                //spgQwUnteqawa.IDEASG = new LineString(coordArr);
                for (int i = 0; i < spgQwUnteqawaObtener.Count; i++)
                {
                    SpgQwUnteqawa spgQwUnteqawa = new();
                    Coordinate[] newCoordinate = Array.Empty<Coordinate>();
                    var tempList = newCoordinate.ToList();

                    for (int j = 0; j < spgQwUnteqawaObtener[i].COORDENADAS.Length; j++)
                    {
                        tempList.Add(new Coordinate(spgQwUnteqawaObtener[i].COORDENADAS[j][0], spgQwUnteqawaObtener[i].COORDENADAS[j][1]));
                    }

                    newCoordinate = tempList.ToArray();

                    spgQwUnteqawa.IDEASG = new Polygon(new LinearRing(newCoordinate)) { SRID = 4326 };

                    spgQwUnteqawa.COUNTE = spgQwUnteqawaObtener[i].COUNTE;
                    spgQwUnteqawa.NOUNTE = spgQwUnteqawaObtener[i].NOUNTE;
                    spgQwUnteqawa.CANALM = spgQwUnteqawaObtener[i].CANALM;
                    spgQwUnteqawa.CACEED = spgQwUnteqawaObtener[i].CACEED;
                    spgQwUnteqawa.JEUNTE = spgQwUnteqawaObtener[i].JEUNTE;
                    spgQwUnteqawa.DIRECC = spgQwUnteqawaObtener[i].DIRECC;

                    //spgQwUnteqawa.GEOMTR = spgQwUnteqawaObtener[i].GEOMTR;

                    spgQwUnteqawa.FECREA = spgQwUnteqawaObtener[i].FECREA;
                    spgQwUnteqawa.FEMODIF = spgQwUnteqawaObtener[i].FEMODIF;
                    spgQwUnteqawa.FELIMIN = spgQwUnteqawaObtener[i].FELIMIN;

                    _context.Add(spgQwUnteqawa);
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
