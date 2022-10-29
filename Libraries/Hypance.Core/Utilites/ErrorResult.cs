using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hypance.Core.Utilites
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message)
        {
        }

        public ErrorResult() : base(false)
        {
        }
    }
}