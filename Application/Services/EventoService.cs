using Application.DTOs;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Application.Interfaces.Services.Generic;
using Application.Models.Eventos;
using Application.Services.Generic;
using AutoMapper;
using Domain.Entities;

namespace Application.Services
{
    public class EventoService : GenericService<EventoModel, EventoModel, Evento>, IEventoService
    {
        private readonly IEventoRepository _repository;
        private readonly IMapper _mapper;

        public EventoService(IEventoRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}
