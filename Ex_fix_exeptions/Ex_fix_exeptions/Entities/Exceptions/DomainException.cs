using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_fix_exeptions.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(String message) : base(message)
        {

        }
    }
}
