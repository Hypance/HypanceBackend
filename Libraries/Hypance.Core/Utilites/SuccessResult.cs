using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hypance.Core.Utilites
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message)
        {
        }

        public SuccessResult() : base(true)
        {
        }
    }
}