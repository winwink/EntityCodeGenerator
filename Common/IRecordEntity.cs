using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWF.CommonService.Entity
{
   public interface IRecordEntity
    {
        DateTime CreateTime { get; set; }
        string CreateBy { get; set; }
        DateTime UpdateTime { get; set; }
        string UpdateBy { get; set; }
    }
}
