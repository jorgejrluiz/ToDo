using ToDoRepository.Models;

namespace ToDoRepository.Interfaces
{
    public interface ITarefaRepository
    {
        Task<int> CreateTaskAsync(Tarefa task);
        Task<List<ToDoRepository.Models.Task>> GetTasksAsync();
    }
}
