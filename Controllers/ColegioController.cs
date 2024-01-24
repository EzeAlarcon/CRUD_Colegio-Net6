using CRUD_Colegio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Colegio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColegioController : ControllerBase
    {
        private readonly ColegioContext _context;

        public ColegioController(ColegioContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("crearEstudiante")]
        public async Task<IActionResult> CreateEstudiante(Colegio estudiante)
        {
            // Guardar el estudiante en la base de datos
            await _context.Colegio.AddAsync(estudiante);
            await _context.SaveChangesAsync();

            // Devolver un mensaje de éxito
            return Ok();
        }

        [HttpGet]
        [Route("listaEstudiantes")]
        public async Task<ActionResult<IEnumerable<Colegio>>> GetEstudiantes()
        {
            // Obtener la lista de estudiantes de la base de datos
            var estudiantes = await _context.Colegio.ToListAsync();

            // Devolver una lista de estudiantes
            return Ok(estudiantes);
        }

        [HttpGet]
        [Route("verEstudiante")]
        public async Task<IActionResult> GetEstudiante(int id)
        {
            // Obtener el estudiante de la base de datos
            Colegio estudiante = await _context.Colegio.FindAsync(id);

            // Devolver el estudiante
            if (estudiante == null)
            {
                return NotFound();
            }

            return Ok(estudiante);
        }

        [HttpPut]
        [Route("editarEstudiante")]
        public async Task<IActionResult> UpdateEstudiante(int id, Colegio estudiante)
        {
            // Actualizar el estudiante en la base de datos
            var estudianteExistente = await _context.Colegio.FindAsync(id);
            estudianteExistente.Name = estudiante.Name;
            estudianteExistente.GradeLevel = estudiante.GradeLevel;
            estudianteExistente.Course = estudiante.Course;
            estudianteExistente.Grade = estudiante.Grade;

            await _context.SaveChangesAsync();

            // Devolver un mensaje de éxito
            return Ok();
        }

        [HttpDelete]
        [Route("eliminarEstudiante")]
        public async Task<IActionResult> DeleteEstudiante(int id)
        {
            // Eliminar estudiante de la base de datos
            var estudianteBorrado = await _context.Colegio.FindAsync(id);
            _context.Colegio.Remove(estudianteBorrado);

            await _context.SaveChangesAsync();

            // Devolver un mensaje de éxito
            return Ok();
        }
    }
}