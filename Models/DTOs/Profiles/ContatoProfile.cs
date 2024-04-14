using AutoMapper;

namespace ProvaBlue.Models.DTOs.Profiles {
    public class ContatoProfile : Profile {

        public ContatoProfile() {
            CreateMap<ContatoModel, ContatoAutoMapperDTO>().
                ForMember(
                dest => dest.PartialInfo,
                src => src.MapFrom(c => $"O nome du usuário é: {c.Nome}, e o e-mail é {c.Email}")).
                ForMember(
                dest => dest.Number,
                src => src.MapFrom(c => $"O número é: {c.Numero}"
                ));
        }

    }
}
