using HospitaFlow.Application.Common.Responses;
using HospitaFlow.Application.DTOs.Application.PatientFile;
using HospitaFlow.Application.Interfaces.Common;
using HospitaFlow.Core.Entities.Application;

using System.Threading.Tasks;

namespace HospitaFlow.Application.Interfaces.Application
{
    public interface IPatientFileRepository : IGenericRepository<PatientFile>
    {
        IQueryable<PatientFile> GetFiltered(PatientFileFilterDto filter);
    }
}
