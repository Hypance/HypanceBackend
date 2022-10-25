using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hypance.Services.Utilites
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {
        }

        public SuccessDataResult(T data) :base(data, true)
        {
        }

        public SuccessDataResult(string message) : base(default, true, message)
        {
            
        }

        public SuccessDataResult() : base(default, true)
        {

        }
    }
}