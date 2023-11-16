using Microsoft.AspNetCore.Mvc;
using GeomidisSystem.Context;
using NetTopologySuite.Geometries;
using GeomidisSystem.Models.Juntos;
using GeomidisSystem.Services;
using GeomidisSystem.Models.Foncodes;

namespace GeomidisSystem.Controllers
{
    [ApiController]
    [Route("juntos")]
    public class JuntosController : Controller
    {
        private readonly ApplicationDbContext _context;
        public JuntosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("hogajunt")]
        public async Task<IActionResult> RegisterHogajunt(List<SpgJtsHogajunt> spgJtsHogajunt)
        {
            try
            {
                for (int i = 0; i < spgJtsHogajunt.Count; i++)
                {
                    _context.Add(spgJtsHogajunt[i]);
                    float Long = (float)spgJtsHogajunt[i].COUBIX;
                    float Lat = (float)spgJtsHogajunt[i].COUBIY;
                    spgJtsHogajunt[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgJtsHogajunt[i]);
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
        [Route("seuniter")]
        public async Task<IActionResult> RegisterSeuniter(List<SpgJtsSeuniter> spgJtsSeuniter)
        {
            try
            {
                for (int i = 0; i < spgJtsSeuniter.Count; i++)
                {
                    _context.Add(spgJtsSeuniter[i]);
                    float Long = (float)spgJtsSeuniter[i].COUBIX;
                    float Lat = (float)spgJtsSeuniter[i].COUBIY;
                    spgJtsSeuniter[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgJtsSeuniter[i]);
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
        [Route("uniterju")]
        public async Task<IActionResult> Create(List<SpgJtsUniterjuObtener> spgJtsUniterjuObtener)
        {
            try
            {
                // EJEMPLO PARA LINESTRING
                //Coordinate coord1 = new(74.6523332, 21.213213);
                //Coordinate coord2 = new(80.2321312, 25.563213);
                //Coordinate coord3 = new(85.6522352, 25.983223);
                //Coordinate[] coordArr = new Coordinate[] { coord1, coord2, coord3 };
                //spgJtsUniterju.IDEASG = new LineString(coordArr);
                for (int i = 0; i < spgJtsUniterjuObtener.Count; i++)
                {
                    SpgJtsUniterju spgJtsUniterju = new();
                    Coordinate[] newCoordinate = Array.Empty<Coordinate>();
                    var tempList = newCoordinate.ToList();

                    for (int j = 0; j < spgJtsUniterjuObtener[i].COORDENADAS.Length; j++)
                    {
                        tempList.Add(new Coordinate(spgJtsUniterjuObtener[i].COORDENADAS[j][0], spgJtsUniterjuObtener[i].COORDENADAS[j][1]));
                    }

                    newCoordinate = tempList.ToArray();

                    spgJtsUniterju.IDEASG = new Polygon(new LinearRing(newCoordinate)) { SRID = 4326 };

                    spgJtsUniterju.COUNTE = spgJtsUniterjuObtener[i].COUNTE;
                    spgJtsUniterju.NOMUT = spgJtsUniterjuObtener[i].NOMUT;
                    spgJtsUniterju.NUMIOB = spgJtsUniterjuObtener[i].NUMIOB;
                    spgJtsUniterju.NUHOAB = spgJtsUniterjuObtener[i].NUHOAB;

                    //spgJtsUniterju.GEOMTR = spgJtsUniterjuObtener[i].GEOMTR;

                    spgJtsUniterju.FECREA = spgJtsUniterjuObtener[i].FECREA;
                    spgJtsUniterju.FEMODIF = spgJtsUniterjuObtener[i].FEMODIF;
                    spgJtsUniterju.FELIMIN = spgJtsUniterjuObtener[i].FELIMIN;

                    _context.Add(spgJtsUniterju);
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
