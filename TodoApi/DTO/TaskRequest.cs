namespace TodoApi.DTO
{
    public class TaskRequest
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataEstimada { get; set; }
        public DateTime? DataFinalizacao { get; set; }
        public bool Ativa { get; set; }
    }
}
