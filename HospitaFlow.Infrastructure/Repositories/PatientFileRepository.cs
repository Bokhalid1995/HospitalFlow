using AutoMapper;

using HospitaFlow.Application.Common.Responses;
using HospitaFlow.Application.DTOs.Application.PatientFile;
using HospitaFlow.Application.Interfaces.Application;
using HospitaFlow.Core.Entities.Application;
using HospitaFlow.Infrastructure.Data;


namespace HospitaFlow.Infrastructure.Repositories
{
    public class PatientFileRepository : GenericRepository<PatientFile>, IPatientFileRepository
    {
        public PatientFileRepository(AppDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }

        public IQueryable<PatientFile> GetFiltered(PatientFileFilterDto filter)
        {
            var query = _dbSet.AsQueryable();

            if (!string.IsNullOrEmpty(filter.FullName))
                query = query.Where(p => p.FullName.Contains(filter.FullName));

            if (!string.IsNullOrEmpty(filter.Phone))
                query = query.Where(p => p.Phone.Contains(filter.Phone));

            return query;
        }
    }
}
