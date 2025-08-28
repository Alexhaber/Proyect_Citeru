using Microsoft.AspNetCore.Mvc;

namespace ProyectCiteru.Controllers
{
    [ApiController]
    [Route("/api/v{version:apiverVersion}/[Controller]")]
    public abstract class BaseController : ControllerBase
    {

    }
}