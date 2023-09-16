using Microsoft.AspNetCore.Mvc;

namespace Devops_Infnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrevisaoDoTempoController : ControllerBase
    {
        private static readonly string[] Resumos = new[]
        {
          "Quente", "Ensolarado", "Escaldante", "Chuvoso", "Frio"
    };

        private readonly ILogger<PrevisaoDoTempoController> _logger;

        public PrevisaoDoTempoController(ILogger<PrevisaoDoTempoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPrevisaoDoTempo")]
        public IEnumerable<PrevisaoDoTempo> Get()
        {
            return Enumerable.Range(1, 3).Select(index => new PrevisaoDoTempo
            {
                Data = DateTime.Now.AddDays(index),
                TemperaturaC = Random.Shared.Next(-20, 55),
                Resumo = Resumos[Random.Shared.Next(Resumos.Length)]
            })
            .ToArray();
        }
    }
}