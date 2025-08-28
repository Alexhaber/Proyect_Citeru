using Application.Interfaces.Services.Generic;
using Application.DTOs;
using Domain.Entities;
using Application.Models.Eventos;

namespace Application.Interfaces.Services
{
    public interface IEventoService : IGenericService<EventoModel, EventoModel, Evento>
    {
    }
}
