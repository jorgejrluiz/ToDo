using Microsoft.EntityFrameworkCore;
using ToDoInfrastructure.Mapper;
using ToDoInfrastructure.Models;

namespace ToDoInfrastructure.Context
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options)
        {
            
        }

        #region "DBSets"
        public DbSet<Tarefa> Tarefas { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TarefaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
