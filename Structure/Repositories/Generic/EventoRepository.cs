using Domain.Entities;
using Structure.Context;
using Application.Interfaces.Repositories;


namespace Structure.Repositories.Generic
{
    public class EventoRepository: GenericRepository<Evento>, IEventoRepository
    {
        private readonly CiteruContext _context;

        public EventoRepository(CiteruContext context) : base(context)
        {
            _context = context;
        }
    }
}
