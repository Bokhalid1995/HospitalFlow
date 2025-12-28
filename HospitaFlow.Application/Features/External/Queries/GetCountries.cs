using HospitaFlow.Application.Common.Responses;
using HospitaFlow.Application.DTOs.External;
using HospitaFlow.Application.Interfaces.External;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Application.Features.External.Queries
{
    public record GetCountries : IRequest<Result<IReadOnlyList<CountryDto>>>;
    public class GetCountriesHandler(ICountriesService countriesService) : IRequestHandler<GetCountries, Result<IReadOnlyList<CountryDto>>>
    {
        public async Task<Result<IReadOnlyList<CountryDto>>> Handle(GetCountries request, CancellationToken cancellationToken)
        {
            var countries = await countriesService.GetAllAsync();
            return Result<IReadOnlyList<CountryDto>>.Done(countries);
        }
    }
}
