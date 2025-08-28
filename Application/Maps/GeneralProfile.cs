using Application.Models.Eventos;
using AutoMapper;
using Domain.Entities;

namespace Application.Maps
{
    public class GeneralProfile : Profile 
    {
        public GeneralProfile()
        {
            CreateMap<Evento, EventoModel>()
                .ReverseMap();
        }
    }
}
