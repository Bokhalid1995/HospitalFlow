using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Application.Common.Exceptions
{

    public class CustomValidationException : Exception
    {
        public IDictionary<string, string[]> Errors { get; }

        public CustomValidationException(IEnumerable<ValidationFailure> failures, string message = "Validation failed")
            : base(message)
        {
            Errors = failures
                .GroupBy(f => f.PropertyName)
                .ToDictionary(g => g.Key, g => g.Select(f => f.ErrorMessage).ToArray());
        }
    }
}


