using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigOn.WebUI.AppCode.Infrastructure
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

    }
}
