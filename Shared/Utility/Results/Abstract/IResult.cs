using Shared.Utility.Results.Complex_Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Utility.Results.Abstract
{
    interface IResult
    {
        //Değiştirilebilir değil bu yüzden set yok.
        public ResultStatus ResultStatus { get; } //ResultStatus.Success//ResultStatus.Error

        public string Message { get;}

        //Exception 
        public Exception Exception { get; }
    }
}
