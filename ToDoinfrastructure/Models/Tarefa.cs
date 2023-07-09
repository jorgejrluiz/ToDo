using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoInfrastructure.Models
{
    [Table(name:"tarefa")]
    public class Tarefa
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Titulo")]
        public string? Titulo { get; set; }
        [Column("Descricao")]
        public string? Descricao { get; set; }
        [Column("DataInicio")]
        public DateTime DataInicio { get; set; }
        [Column("DataEstimada")]
        public DateTime? DataEstimada { get; set; }
        [Column("DataFinalizacao")]
        public DateTime? DataFinalizacao { get; set; }
        [Column("Ativa")]
        public bool Ativa { get; set; }
    }
}
