
using HospitaFlow.Application.Common.Responses;
using HospitaFlow.Application.DTOs.External;
using HospitaFlow.Application.Interfaces.External;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Infrastructure.Services.External
{

    public class CountriesService : ICountriesService
    {
        private readonly HttpClient _httpClient;

        public CountriesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IReadOnlyList<CountryDto>> GetAllAsync()
        {
            var response = await _httpClient
                .GetFromJsonAsync<List<RestCountryResponse>>("all?fields=name,cca2,region");

            return response!.Select(c => new CountryDto
            {
                Name = c.name.common,
                Code = c.cca2,
                Region = c.region
            }).ToList();

           
        }
    }

}
