using Mapster;
using Microsoft.AspNetCore.Mvc;
using TodoApi.DTO;
using ToDoInfrastructure.Models;
using ToDoRepository.Interfaces;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase    
    {
        private readonly ITarefaRepository _tarefaRepository;
        private readonly ILogger<WeatherForecastController> _logger;

        public TarefaController(ITarefaRepository tarefaRepository, ILogger<WeatherForecastController> logger)
        {
            _tarefaRepository = tarefaRepository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<List<Tarefa>> Get()
        {
            _logger.Log(LogLevel.Information, "Get Tarefas");
            var tarefas = await _tarefaRepository.GetTasksAsync();

            return tarefas.Adapt<List<Tarefa>>();
        }

        [HttpPost]
        public async Task<List<Tarefa>> Post(TaskRequest taskRequest)
        {
            _logger.Log(LogLevel.Information, "Post Tarefas");
            var tarefas = await _tarefaRepository.CreateTaskAsync(taskRequest.Adapt<ToDoRepository.Models.Task>());

            return tarefas.Adapt<List<Tarefa>>();
        }
    }
}
