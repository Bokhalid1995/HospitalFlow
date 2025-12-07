using AutoMapper;
using HospitaFlow.Application.Interfaces.Application;
using HospitaFlow.Application.Interfaces.Common;
using HospitaFlow.Infrastructure.Data;
using HospitaFlow.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IServiceProvider _serviceProvider;

        public IPatientFileRepository PatientFiles { get; }

        public UnitOfWork(AppDbContext context, IServiceProvider serviceProvider, IMapper mapper)
        {
            _context = context;
            _serviceProvider = serviceProvider;
            _mapper = mapper;
            PatientFiles = new PatientFileRepository(_context, _mapper);
        }

        public IGenericRepository<T> Repository<T>() where T : class
        {
            return _serviceProvider.GetRequiredService<IGenericRepository<T>>();
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
