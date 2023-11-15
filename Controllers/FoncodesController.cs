using Microsoft.AspNetCore.Mvc;
using GeomidisSystem.Context;
using NetTopologySuite.Geometries;
using GeomidisSystem.Models.Foncodes;
using GeomidisSystem.Services;
using GeomidisSystem.Models.Cuna_Mas;

namespace GeomidisSystem.Controllers
{
    [ApiController]
    [Route("foncodes")]
    public class FoncodesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public FoncodesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("cepohawi")]
        public async Task<IActionResult> RegisterCepohawi(List<SpgFcdCepohawi> spgFcdCepohawi)
        {
            try
            {
                for (int i = 0; i < spgFcdCepohawi.Count; i++)
                {
                    _context.Add(spgFcdCepohawi[i]);
                    float Long = (float)spgFcdCepohawi[i].COOUBX;
                    float Lat = (float)spgFcdCepohawi[i].COOUBY;
                    spgFcdCepohawi[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgFcdCepohawi[i]);
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
        [Route("cepomiab")]
        public async Task<IActionResult> RegisterCepomiab(List<SpgFcdCepomiab> spgFcdCepomiab)
        {
            try
            {
                for (int i = 0; i < spgFcdCepomiab.Count; i++)
                {
                    _context.Add(spgFcdCepomiab[i]);
                    float Long = (float)spgFcdCepomiab[i].COOUBX;
                    float Lat = (float)spgFcdCepomiab[i].COOUBY;
                    spgFcdCepomiab[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgFcdCepomiab[i]);
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
        [Route("cobhawi")]
        public async Task<IActionResult> Create(List<SpgFcdCobhawiObtener> spgFcdCobhawiObtener)
        {
            try
            {
                // EJEMPLO PARA LINESTRING
                //Coordinate coord1 = new(74.6523332, 21.213213);
                //Coordinate coord2 = new(80.2321312, 25.563213);
                //Coordinate coord3 = new(85.6522352, 25.983223);
                //Coordinate[] coordArr = new Coordinate[] { coord1, coord2, coord3 };
                //spgFcdCobhawi.IDEASG = new LineString(coordArr);
                for (int i = 0; i < spgFcdCobhawiObtener.Count; i++)
                {
                    SpgFcdCobhawi spgFcdCobhawi = new();
                    Coordinate[] newCoordinate = Array.Empty<Coordinate>();
                    var tempList = newCoordinate.ToList();

                    for (int j = 0; j < spgFcdCobhawiObtener[i].COORDENADAS.Length; j++)
                    {
                        tempList.Add(new Coordinate(spgFcdCobhawiObtener[i].COORDENADAS[j][0], spgFcdCobhawiObtener[i].COORDENADAS[j][1]));
                    }

                    newCoordinate = tempList.ToArray();

                    spgFcdCobhawi.IDEASG = new Polygon(new LinearRing(newCoordinate)) { SRID = 4326 };

                    spgFcdCobhawi.UBIGEO = spgFcdCobhawiObtener[i].UBIGEO;
                    spgFcdCobhawi.CANHOG = spgFcdCobhawiObtener[i].CANHOG;
                    spgFcdCobhawi.CACEPO = spgFcdCobhawiObtener[i].CACEPO;

                    //spgFcdCobhawi.GEOMTR = spgCumsDistfocaObtener[i].GEOMTR;

                    spgFcdCobhawi.FECREA = spgFcdCobhawiObtener[i].FECREA;
                    spgFcdCobhawi.FEMODIF = spgFcdCobhawiObtener[i].FEMODIF;
                    spgFcdCobhawi.FELIMIN = spgFcdCobhawiObtener[i].FELIMIN;


                    _context.Add(spgFcdCobhawi);
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
        [Route("nuejhawi")]
        public async Task<IActionResult> RegisterNuejhawi(List<SpgFcdNuejhawi> spgFcdNuejhawi)
        {
            try
            {
                for (int i = 0; i < spgFcdNuejhawi.Count; i++)
                {
                    _context.Add(spgFcdNuejhawi[i]);
                    float Long = (float)spgFcdNuejhawi[i].COOUBX;
                    float Lat = (float)spgFcdNuejhawi[i].COOUBY;
                    spgFcdNuejhawi[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgFcdNuejhawi[i]);
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
        [Route("pragumas")]
        public async Task<IActionResult> RegisterPragumas(List<SpgFcdPragumas> spgFcdPragumas)
        {
            try
            {
                for (int i = 0; i < spgFcdPragumas.Count; i++)
                {
                    _context.Add(spgFcdPragumas[i]);
                    float Long = (float)spgFcdPragumas[i].COOUBX;
                    float Lat = (float)spgFcdPragumas[i].COOUBY;
                    spgFcdPragumas[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgFcdPragumas[i]);
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
        [Route("proyinfr")]
        public async Task<IActionResult> RegisterProyinfr(List<SpgFcdProyinfr> spgFcdProyinfr)
        {
            try
            {
                for (int i = 0; i < spgFcdProyinfr.Count; i++)
                {
                    _context.Add(spgFcdProyinfr[i]);
                    float Long = (float)spgFcdProyinfr[i].COOUBX;
                    float Lat = (float)spgFcdProyinfr[i].COOUBY;
                    spgFcdProyinfr[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgFcdProyinfr[i]);
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
        [Route("resiestu")]
        public async Task<IActionResult> RegisterResiestu(List<SpgFcdResiestu> spgFcdResiestu)
        {
            try
            {
                for (int i = 0; i < spgFcdResiestu.Count; i++)
                {
                    _context.Add(spgFcdResiestu[i]);
                    float Long = (float)spgFcdResiestu[i].COOUBX;
                    float Lat = (float)spgFcdResiestu[i].COOUBY;
                    spgFcdResiestu[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgFcdResiestu[i]);
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
        [Route("unterfon")]
        public async Task<IActionResult> Create(List<SpgFcdUnterfonObtener> spgFcdUnterfonObtener)
        {
            try
            {
                // EJEMPLO PARA LINESTRING
                //Coordinate coord1 = new(74.6523332, 21.213213);
                //Coordinate coord2 = new(80.2321312, 25.563213);
                //Coordinate coord3 = new(85.6522352, 25.983223);
                //Coordinate[] coordArr = new Coordinate[] { coord1, coord2, coord3 };
                //spgFcdUnterfon.IDEASG = new LineString(coordArr);
                for (int i = 0; i < spgFcdUnterfonObtener.Count; i++)
                {
                    SpgFcdUnterfon spgFcdUnterfon = new();
                    Coordinate[] newCoordinate = Array.Empty<Coordinate>();
                    var tempList = newCoordinate.ToList();

                    for (int j = 0; j < spgFcdUnterfonObtener[i].COORDENADAS.Length; j++)
                    {
                        tempList.Add(new Coordinate(spgFcdUnterfonObtener[i].COORDENADAS[j][0], spgFcdUnterfonObtener[i].COORDENADAS[j][1]));
                    }

                    newCoordinate = tempList.ToArray();

                    spgFcdUnterfon.IDEASG = new Polygon(new LinearRing(newCoordinate)) { SRID = 4326 };

                    spgFcdUnterfon.COUNTE = spgFcdUnterfonObtener[i].COUNTE;
                    spgFcdUnterfon.NOUNTE = spgFcdUnterfonObtener[i].NOUNTE;
                    spgFcdUnterfon.CANDIS = spgFcdUnterfonObtener[i].CANDIS;

                    //spgFcdUnterfon.GEOMTR = spgFcdUnterfonObtener[i].GEOMTR;

                    spgFcdUnterfon.FECREA = spgFcdUnterfonObtener[i].FECREA;
                    spgFcdUnterfon.FEMODIF = spgFcdUnterfonObtener[i].FEMODIF;
                    spgFcdUnterfon.FELIMIN = spgFcdUnterfonObtener[i].FELIMIN;

                    _context.Add(spgFcdUnterfon);
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
        [Route("usdemiab")]
        public async Task<IActionResult> RegisterUsdemiab(List<SpgFcdUsdemiab> spgFcdUsdemiab)
        {
            try
            {
                for (int i = 0; i < spgFcdUsdemiab.Count; i++)
                {
                    _context.Add(spgFcdUsdemiab[i]);
                    float Long = (float)spgFcdUsdemiab[i].COOUBX;
                    float Lat = (float)spgFcdUsdemiab[i].COOUBY;
                    spgFcdUsdemiab[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgFcdUsdemiab[i]);
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
        [Route("ushakwin")]
        public async Task<IActionResult> RegisterUshakwin(List<SpgFcdUshakwin> spgFcdUshakwin)
        {
            try
            {
                for (int i = 0; i < spgFcdUshakwin.Count; i++)
                {
                    _context.Add(spgFcdUshakwin[i]);
                    float Long = (float)spgFcdUshakwin[i].COUBIX;
                    float Lat = (float)spgFcdUshakwin[i].COUBIY;
                    spgFcdUshakwin[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgFcdUshakwin[i]);
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
