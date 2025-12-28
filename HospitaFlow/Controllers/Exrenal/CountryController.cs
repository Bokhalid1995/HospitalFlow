using HospitaFlow.Application.Features.External.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api")]
public class CountriesController(ISender sender) : ControllerBase
{

    [HttpGet("countries")]
    public async Task<IActionResult> Get()
    {
        var result = await sender.Send(new GetCountries());
        return Ok(result);
    }
}
