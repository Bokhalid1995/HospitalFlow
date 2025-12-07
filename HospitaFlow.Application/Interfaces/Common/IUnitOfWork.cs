using HospitaFlow.Application.Interfaces.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Application.Interfaces.Common
{
    public interface IUnitOfWork : IDisposable
    {
        IPatientFileRepository PatientFiles { get; }

        IGenericRepository<T> Repository<T>() where T : class;

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }

}
