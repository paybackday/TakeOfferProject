using Project.CORE.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Utilities.Abstract
{
    public interface IResult
    {
        public ResultStatus Status { get; }
        public string Message { get; }
        public Exception Exception { get;}
    }
}
