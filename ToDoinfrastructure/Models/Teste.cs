using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoInfrastructure.Models
{
    public class Teste
    {
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataEstimada { get; set; }
        public DateTime? DataFinalizacao { get; set; }
        public bool Ativa { get; set; }
    }
}
