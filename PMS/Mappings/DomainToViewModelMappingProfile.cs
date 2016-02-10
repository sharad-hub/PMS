using AutoMapper;
using Core.Entites.Models;
using PMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMS.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Tasks,TaskViewModel>();
           // Mapper.CreateMap<Gadget, GadgetViewModel>();
        }
    }
}