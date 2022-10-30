using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hypance.Core.Utilites
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }
    }
}