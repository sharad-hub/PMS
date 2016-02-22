using AutoMapper;
using Core.Entites.Models;
using PMS.Models;
using PMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMS.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ProjectViewModel, Project>();
                //.ForMember(g => g.Name, map => map.MapFrom(vm => vm.TaskName))
                //.ForMember(g => g.Description, map => map.MapFrom(vm => vm.TaskDescription));
              //  .ForMember(g => g.Price, map => map.MapFrom(vm => vm.GadgetPrice))
              //  .ForMember(g => g.Image, map => map.MapFrom(vm => vm.File.FileName))
               // .ForMember(g => g., map => map.MapFrom(vm => vm.GadgetCategory));
        }
    }
}