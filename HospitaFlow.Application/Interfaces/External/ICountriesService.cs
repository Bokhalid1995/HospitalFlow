using HospitaFlow.Application.DTOs.External;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Application.Interfaces.External
{
    public interface ICountriesService
    {
        Task<IReadOnlyList<CountryDto>> GetAllAsync();
    }
}
