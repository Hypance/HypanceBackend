using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hypance.Services.Utilites
{
    public interface IDataResult<out T> : IResult
    {
        T Data { get; }
    }
}