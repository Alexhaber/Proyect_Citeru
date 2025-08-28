namespace Domain.Entities
{
    public class Evento
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string? Ubicacion { get; set; }
        public string? ImagenUrl { get; set; }
    }
}
