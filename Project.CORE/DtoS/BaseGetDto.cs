using Project.CORE.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.DtoS
{
    public abstract class BaseGetDto
    {
        public virtual ResultStatus Status { get; set; }
        public string Message { get; set; }
    }
}
