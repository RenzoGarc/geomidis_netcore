using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GeomidisSystem.Context;
using GeomidisSystem.Models.Masters;
using NetTopologySuite.Geometries;
using GeomidisSystem.Models.Cuna_Mas;


namespace GeomidisSystem.Controllers
{
    [ApiController]
    [Route("cuna_mas")]
    public class CunaMasController: Controller
    {
        private readonly ApplicationDbContext _context;
        public CunaMasController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("cgseacfa")]
        public async Task<IActionResult> Create(List<SpgCumsCgseacfaObtener> spgCumsCgseacfaObtener)
        {
            try
            {
                // EJEMPLO PARA LINESTRING
                //Coordinate coord1 = new(74.6523332, 21.213213);
                //Coordinate coord2 = new(80.2321312, 25.563213);
                //Coordinate coord3 = new(85.6522352, 25.983223);
                //Coordinate[] coordArr = new Coordinate[] { coord1, coord2, coord3 };
                //spgCumsCgseacfa.IDEASG = new LineString(coordArr);
                for (int i = 0; i < spgCumsCgseacfaObtener.Count; i++)
                {
                    SpgCumsCgseacfa spgCumsCgseacfa = new();
                    Coordinate[] newCoordinate = Array.Empty<Coordinate>();
                    var tempList = newCoordinate.ToList();

                    for (int j = 0; j < spgCumsCgseacfaObtener[i].COORDENADAS.Length; j++)
                    {
                        tempList.Add(new Coordinate(spgCumsCgseacfaObtener[i].COORDENADAS[j][0], spgCumsCgseacfaObtener[i].COORDENADAS[j][1]));
                    }

                    newCoordinate = tempList.ToArray();

                    spgCumsCgseacfa.IDEASG = new Polygon(new LinearRing(newCoordinate)) { SRID = 4326 };

                    spgCumsCgseacfa.CODOBJ = spgCumsCgseacfaObtener[i].CODOBJ;
                    spgCumsCgseacfa.COCOGE = spgCumsCgseacfaObtener[i].COCOGE;
                    spgCumsCgseacfa.NOCOGE = spgCumsCgseacfaObtener[i].NOCOGE;

                    _context.Add(spgCumsCgseacfa);
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
        [Route("cgsecudi")]
        public async Task<IActionResult> Create(List<SpgCumsCgsecudiObtener> spgCumsCgsecudiObtener)
        {
            try
            {
                // EJEMPLO PARA LINESTRING
                //Coordinate coord1 = new(74.6523332, 21.213213);
                //Coordinate coord2 = new(80.2321312, 25.563213);
                //Coordinate coord3 = new(85.6522352, 25.983223);
                //Coordinate[] coordArr = new Coordinate[] { coord1, coord2, coord3 };
                //spgCumsCgsecudi.IDEASG = new LineString(coordArr);
                for (int i = 0; i < spgCumsCgsecudiObtener.Count; i++)
                {
                    SpgCumsCgsecudi spgCumsCgsecudi = new();
                    Coordinate[] newCoordinate = Array.Empty<Coordinate>();
                    var tempList = newCoordinate.ToList();

                    for (int j = 0; j < spgCumsCgsecudiObtener[i].COORDENADAS.Length; j++)
                    {
                        tempList.Add(new Coordinate(spgCumsCgsecudiObtener[i].COORDENADAS[j][0], spgCumsCgsecudiObtener[i].COORDENADAS[j][1]));
                    }

                    newCoordinate = tempList.ToArray();

                    spgCumsCgsecudi.IDEASG = new Polygon(new LinearRing(newCoordinate)) { SRID = 4326 };

                    spgCumsCgsecudi.CODOBJ = spgCumsCgsecudiObtener[i].CODOBJ;
                    spgCumsCgsecudi.COCOGE = spgCumsCgsecudiObtener[i].COCOGE;
                    spgCumsCgsecudi.NOCOGE = spgCumsCgsecudiObtener[i].NOCOGE;

                    _context.Add(spgCumsCgsecudi);
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
        [Route("distfoca")]
        public async Task<IActionResult> Create(List<SpgCumsDistfocaObtener> spgCumsDistfocaObtener)
        {
            try
            {
                // EJEMPLO PARA LINESTRING
                //Coordinate coord1 = new(74.6523332, 21.213213);
                //Coordinate coord2 = new(80.2321312, 25.563213);
                //Coordinate coord3 = new(85.6522352, 25.983223);
                //Coordinate[] coordArr = new Coordinate[] { coord1, coord2, coord3 };
                //spgCumsDistfoca.IDEASG = new LineString(coordArr);
                for (int i = 0; i < spgCumsDistfocaObtener.Count; i++)
                {
                    SpgCumsDistfoca spgCumsDistfoca = new();
                    Coordinate[] newCoordinate = Array.Empty<Coordinate>();
                    var tempList = newCoordinate.ToList();

                    for (int j = 0; j < spgCumsDistfocaObtener[i].COORDENADAS.Length; j++)
                    {
                        tempList.Add(new Coordinate(spgCumsDistfocaObtener[i].COORDENADAS[j][0], spgCumsDistfocaObtener[i].COORDENADAS[j][1]));
                    }

                    newCoordinate = tempList.ToArray();

                    spgCumsDistfoca.IDEASG = new Polygon(new LinearRing(newCoordinate)) { SRID = 4326 };

                    spgCumsDistfoca.CODOBJ = spgCumsDistfocaObtener[i].CODOBJ;

                    _context.Add(spgCumsDistfoca);
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
        [Route("frseacfa")]
        public async Task<IActionResult> RegisterFrseacfa(List<SpgCumsFrseacfa> spgCumsFrseacfa)
        {
            try
            {
                for (int i = 0; i < spgCumsFrseacfa.Count; i++)
                {
                    _context.Add(spgCumsFrseacfa[i]);
                    float Long = (float)spgCumsFrseacfa[i].COUBIX;
                    float Lat = (float)spgCumsFrseacfa[i].COUBIY;
                    spgCumsFrseacfa[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgCumsFrseacfa[i]);
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
        [Route("loceinai")]
        public async Task<IActionResult> RegisterLoceinai(List<SpgCumsLoceinai> spgCumsLoceinai)
        {
            try
            {
                for (int i = 0; i < spgCumsLoceinai.Count; i++)
                {
                    _context.Add(spgCumsLoceinai[i]);
                    float Long = (float)spgCumsLoceinai[i].COUBIX;
                    float Lat = (float)spgCumsLoceinai[i].COUBIY;
                    spgCumsLoceinai[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgCumsLoceinai[i]);
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
        [Route("loserali")]
        public async Task<IActionResult> RegisterLoserali(List<SpgCumsLoserali> spgCumsLoserali)
        {
            try
            {
                for (int i = 0; i < spgCumsLoserali.Count; i++)
                {
                    _context.Add(spgCumsLoserali[i]);
                    float Long = (float)spgCumsLoserali[i].COUBIX;
                    float Lat = (float)spgCumsLoserali[i].COUBIY;
                    spgCumsLoserali[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgCumsLoserali[i]);
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
        [Route("scgsacfa")]
        public async Task<IActionResult> RegisterScgsacfa(List<SpgCumsScgsacfa> spgCumsScgsacfa)
        {
            try
            {
                for (int i = 0; i < spgCumsScgsacfa.Count; i++)
                {
                    _context.Add(spgCumsScgsacfa[i]);
                    float Long = (float)spgCumsScgsacfa[i].COUBIX;
                    float Lat = (float)spgCumsScgsacfa[i].COUBIY;
                    spgCumsScgsacfa[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgCumsScgsacfa[i]);
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
        [Route("scgscudi")]
        public async Task<IActionResult> RegisterScgscudi(List<SpgCumsScgscudi> spgCumsScgscudi)
        {
            try
            {
                for (int i = 0; i < spgCumsScgscudi.Count; i++)
                {
                    _context.Add(spgCumsScgscudi[i]);
                    float Long = (float)spgCumsScgscudi[i].COUBIX;
                    float Lat = (float)spgCumsScgscudi[i].COUBIY;
                    spgCumsScgscudi[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgCumsScgscudi[i]);
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
        public async Task<IActionResult> RegisterSeuniter(List<SpgCumsSeuniter> spgCumsSeuniter)
        {
            try
            {
                for (int i = 0; i < spgCumsSeuniter.Count; i++)
                {
                    _context.Add(spgCumsSeuniter[i]);
                    float Long = (float)spgCumsSeuniter[i].COUBIX;
                    float Lat = (float)spgCumsSeuniter[i].COUBIY;
                    spgCumsSeuniter[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    Console.WriteLine(spgCumsSeuniter[i]);
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
        [Route("cgsecudi")]
        public async Task<IActionResult> Create(List<SpgCumsUntecumaObtener> spgCumsUntecumaObtener)
        {
            try
            {
                // EJEMPLO PARA LINESTRING
                //Coordinate coord1 = new(74.6523332, 21.213213);
                //Coordinate coord2 = new(80.2321312, 25.563213);
                //Coordinate coord3 = new(85.6522352, 25.983223);
                //Coordinate[] coordArr = new Coordinate[] { coord1, coord2, coord3 };
                //spgCumsUntecuma.IDEASG = new LineString(coordArr);
                for (int i = 0; i < spgCumsUntecumaObtener.Count; i++)
                {
                    SpgCumsUntecuma spgCumsUntecuma = new();
                    Coordinate[] newCoordinate = Array.Empty<Coordinate>();
                    var tempList = newCoordinate.ToList();

                    for (int j = 0; j < spgCumsUntecumaObtener[i].COORDENADAS.Length; j++)
                    {
                        tempList.Add(new Coordinate(spgCumsUntecumaObtener[i].COORDENADAS[j][0], spgCumsUntecumaObtener[i].COORDENADAS[j][1]));
                    }

                    newCoordinate = tempList.ToArray();

                    spgCumsUntecuma.IDEASG = new Polygon(new LinearRing(newCoordinate)) { SRID = 4326 };

                    spgCumsUntecuma.CODOBJ = spgCumsUntecumaObtener[i].CODOBJ;

                    _context.Add(spgCumsUntecuma);
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