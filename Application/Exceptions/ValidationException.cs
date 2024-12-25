using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace Application.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException() : base("Han ocurrido uno o más errores")
        {
            Errors = new List<string>();

        }
        public List<string> Errors { get; }
        public ValidationException(IEnumerable<ValidationFailure> failures) : this()
        {
            foreach (var failure in failures)
            {
                Errors.Add(failure.ErrorMessage);
            }
        }
    }
}
