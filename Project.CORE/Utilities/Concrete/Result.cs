using Project.CORE.Utilities.Abstract;
using Project.CORE.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Utilities.Concrete
{
    public class Result : IResult
    {
        public Result(ResultStatus resultStatus)
        {
            Status=resultStatus;
        }
        public Result(ResultStatus resultStatus, string message)
        {
            Status = resultStatus;
            Message=message;
        }
        public Result(ResultStatus resultStatus, string message, Exception ex)
        {
            Status = resultStatus;
            Message = message;
            Exception = ex;
        }
        public ResultStatus Status { get; }

        public string Message { get; }

        public Exception Exception { get; }
    }
}
