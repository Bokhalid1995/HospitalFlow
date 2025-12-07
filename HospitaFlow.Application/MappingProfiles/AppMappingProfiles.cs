using AutoMapper;
using HospitaFlow.Application.DTOs.Application.PatientFile;
using HospitaFlow.Core.Entities.Application;
using HospitaFlow.Core.Entities.Billing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Application.MappingProfiles
{
    public class AppMappingProfiles : Profile
    {
        public AppMappingProfiles()
        {
            // Application
            CreateMap<PatientFile, PatientFileDto>();
            CreateMap<PatientFileDto, PatientFile>();


        }
    }
}
