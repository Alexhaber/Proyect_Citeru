using Application.Interfaces.Services;
using Application.Models.Eventos;
using Microsoft.AspNetCore.Mvc;

namespace ProyectCiteru.Controllers.v1
{
    public class EventoController : BaseController
    {
        private readonly IEventoService _service;

        public EventoController(IEventoService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(EventoModel))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetEventos()
        {
            try
            {
                var data = await _service.GetAll();

                if (data == null || !data.Any())
                {
                    return NotFound("No se encontraron eventos.");
                }
                return Ok(data/*.ToHashSet()*/);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Error al obtener los eventos.");
                return StatusCode(500, "Ocurrió un error interno en el servidor.");
            }
        }
    }
}
