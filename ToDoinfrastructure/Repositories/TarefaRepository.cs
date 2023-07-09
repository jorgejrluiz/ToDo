using Mapster;
using Microsoft.EntityFrameworkCore;
using ToDoInfrastructure.Context;
using ToDoInfrastructure.Models;
using ToDoRepository.Interfaces;
using ToDoRepository.Models;

namespace ToDoInfrastructure.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private TarefaContext _tarefaContext;

        public TarefaRepository(TarefaContext tarefaContext)
        {
            _tarefaContext = tarefaContext;
        }

        public Task<int> CreateTaskAsync(ToDoRepository.Models.Tarefa task)
        {
            try
            {
                await _tarefaContext.Tarefas.AddAsync(task);
                _tarefaContext.SaveChanges();

                return task.Id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<ToDoRepository.Models.Task>> GetTasksAsync()
        {
            var retorno = _tarefaContext.Tarefas.ToListAsync().Adapt<List<ToDoRepository.Models.Task>>();

            return retorno;
        }
    }
}
