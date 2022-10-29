using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hypance.Core.Utilites
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}