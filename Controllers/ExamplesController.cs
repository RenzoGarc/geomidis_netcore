
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GeomidisSystem.Context;
using GeomidisSystem.Models;
using GeomidisSystem.Models.Masters;
using GeomidisSystem.Models.ObtenerDatos;
using NetTopologySuite.Geometries;
using GeomidisSystem.Models.Pais;

namespace GeomidisSystem.Controllers
{

    [ApiController]
    [Route("pais")]
    public class ExamplesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExamplesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("prueba/{codsap}")]
        public async Task<IActionResult> Post(SpgPsCaratamb datos)
        {
            Respuesta response = new Respuesta();
            try
            {
                string result = "nulo";
                return Json(result);
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }

        [HttpGet]
        [Route("prueba")]
        public async Task<IActionResult> Get()
        {
            //Respuesta response = new Respuesta();
            try
            {
                List<SpgPsCaratamb> resultados = new();
                resultados = await _context.spgPsCaratambs.Where(x=>x.CODTAM == "01").ToListAsync();
                //if (resultados.Count > 0)
                //{
                //    resultados[0].IDEASG = resultados[0].IDEASG
                //}
                //return Ok(resultados);
                return new OkObjectResult(resultados);
            }
            catch (Exception ex)
            {
                return Json(ex);
            }
        }

        [HttpPost]
        [Route("geometry")]
        public async Task<IActionResult> Create(List<SpgPsGeometryObtener> spgPsGeometryObtener)
        {
            try
            {
                // EJEMPLO PARA LINESTRING
                //Coordinate coord1 = new(74.6523332, 21.213213);
                //Coordinate coord2 = new(80.2321312, 25.563213);
                //Coordinate coord3 = new(85.6522352, 25.983223);
                //Coordinate[] coordArr = new Coordinate[] { coord1, coord2, coord3 };
                //spgPsGeometry.IDEASG = new LineString(coordArr);
                for (int i = 0; i < spgPsGeometryObtener.Count; i++)
                {
                    SpgPsGeometry spgPsGeometry = new();
                    Coordinate[] newCoordinate = Array.Empty<Coordinate>();
                    var tempList = newCoordinate.ToList();

                    for (int j = 0; j < spgPsGeometryObtener[i].COORDENADAS.Length; j++)
                    {
                        tempList.Add(new Coordinate(spgPsGeometryObtener[i].COORDENADAS[j][0], spgPsGeometryObtener[i].COORDENADAS[j][1]));
                    }

                    newCoordinate = tempList.ToArray();

                    spgPsGeometry.IDEASG = new Polygon(new LinearRing(newCoordinate)) { SRID = 4326 };

                    spgPsGeometry.NOMTAM = spgPsGeometryObtener[i].NOMTAM;
                    spgPsGeometry.CODTAM = spgPsGeometryObtener[i].CODTAM;
                    spgPsGeometry.UBIGEO = spgPsGeometryObtener[i].UBIGEO;

                    _context.Add(spgPsGeometry);
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
        [Route("caratambsasd")]
        public async Task<IActionResult> Create(List<SpgPsCaratamb> spgPsCaratamb)
        {
            try
            {
                for (int i = 0; i < spgPsCaratamb.Count; i++)
                {
                    _context.Add(spgPsCaratamb[i]);
                    float Long = (float)spgPsCaratamb[i].COUBIX;
                    float Lat = (float)spgPsCaratamb[i].COUBIY;
                    spgPsCaratamb[i].IDEASG = new Point(Long, Lat) { SRID = 4326 };
                    await _context.SaveChangesAsync();
                }
                return StatusCode(200, "Registro correcto!");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
                //return StatusCode(500, "Error al registrar los datos!");
            }
        }

        //// GET: PaisExamples/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.paisExamples == null)
        //    {
        //        return NotFound();
        //    }

        //    var paisExample = await _context.paisExamples.FindAsync(id);
        //    if (paisExample == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(paisExample);
        //}

        //    // GET: PaisExamples
        //    public async Task<IActionResult> Index()
        //    {
        //        return _context.paisExamples != null ?
        //                    View(await _context.paisExamples.ToListAsync()) :
        //                    Problem("Entity set 'ApplicationDbContext.paisExamples'  is null.");
        //    }

        //    // GET: PaisExamples/Details/5
        //    public async Task<IActionResult> Details(int? id)
        //    {
        //        if (id == null || _context.paisExamples == null)
        //        {
        //            return NotFound();
        //        }

        //        var paisExample = await _context.paisExamples
        //            .FirstOrDefaultAsync(m => m.Id == id);
        //        if (paisExample == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(paisExample);
        //    }

        //    // GET: PaisExamples/Create
        //    public IActionResult Create()
        //    {
        //        return View();
        //    }

        //    // POST: PaisExamples/Create
        //    // To protect from overposting attacks, enable the specific properties you want to bind to.
        //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Create([Bind("Id,CANBEN,CANBEN2,CANBEN3,CANBEN4,CANBEN5")] PaisExample paisExample)
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            _context.Add(paisExample);
        //            await _context.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(paisExample);
        //    }

        //    // GET: PaisExamples/Edit/5
        //    public async Task<IActionResult> Edit(int? id)
        //    {
        //        if (id == null || _context.paisExamples == null)
        //        {
        //            return NotFound();
        //        }

        //        var paisExample = await _context.paisExamples.FindAsync(id);
        //        if (paisExample == null)
        //        {
        //            return NotFound();
        //        }
        //        return View(paisExample);
        //    }

        //    // POST: PaisExamples/Edit/5
        //    // To protect from overposting attacks, enable the specific properties you want to bind to.
        //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //    [HttpPost]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> Edit(int id, [Bind("Id,CANBEN,CANBEN2,CANBEN3,CANBEN4,CANBEN5")] PaisExample paisExample)
        //    {
        //        if (id != paisExample.Id)
        //        {
        //            return NotFound();
        //        }

        //        if (ModelState.IsValid)
        //        {
        //            try
        //            {
        //                _context.Update(paisExample);
        //                await _context.SaveChangesAsync();
        //            }
        //            catch (DbUpdateConcurrencyException)
        //            {
        //                if (!PaisExampleExists(paisExample.Id))
        //                {
        //                    return NotFound();
        //                }
        //                else
        //                {
        //                    throw;
        //                }
        //            }
        //            return RedirectToAction(nameof(Index));
        //        }
        //        return View(paisExample);
        //    }

        //    // GET: PaisExamples/Delete/5
        //    public async Task<IActionResult> Delete(int? id)
        //    {
        //        if (id == null || _context.paisExamples == null)
        //        {
        //            return NotFound();
        //        }

        //        var paisExample = await _context.paisExamples
        //            .FirstOrDefaultAsync(m => m.Id == id);
        //        if (paisExample == null)
        //        {
        //            return NotFound();
        //        }

        //        return View(paisExample);
        //    }

        //    // POST: PaisExamples/Delete/5
        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> DeleteConfirmed(int id)
        //    {
        //        if (_context.paisExamples == null)
        //        {
        //            return Problem("Entity set 'ApplicationDbContext.paisExamples'  is null.");
        //        }
        //        var paisExample = await _context.paisExamples.FindAsync(id);
        //        if (paisExample != null)
        //        {
        //            _context.paisExamples.Remove(paisExample);
        //        }

        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }

        //    private bool PaisExampleExists(int id)
        //    {
        //        return (_context.paisExamples?.Any(e => e.Id == id)).GetValueOrDefault();
        //    }
        //}
    }
}
