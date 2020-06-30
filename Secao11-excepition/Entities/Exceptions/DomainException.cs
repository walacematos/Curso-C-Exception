using System;
using System.Collections.Generic;
using System.Text;

namespace Secao11_excepition.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}
