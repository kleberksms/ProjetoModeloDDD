using AutoMapper;
using ProjectModeloDDD.Domain.Entities;
using ProjectModeloDDD.MVC.ViewModels;

namespace ProjectModeloDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainProfile"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
        }
    }
}