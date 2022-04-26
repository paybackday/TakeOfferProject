using Project.CORE.Utilities.Abstract;
using Project.CORE.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Utilities.Concrete
{
    public class DataResult<T> : IDataResult<T>
    {
        public DataResult(ResultStatus resultStatus, T data)
        {
            Status = resultStatus;
            Data = data;
        }
        public DataResult(ResultStatus resultStatus, T data, string message)
        {
            Status=resultStatus;
            Data=data;
            Message=message;
        }
        public DataResult(ResultStatus resultStatus, T data, string message, Exception ex)
        {
            Status= resultStatus;
            Data= data;
            Message=message;
            Exception=ex;
        }

        //Properties
        public T Data { get; }

        public ResultStatus Status { get; }

        public string Message { get; }

        public Exception Exception { get; }
    }
}
