using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogApi.Dto
{
    public class ReadLogDto :LogDto
    {
        public int LogId { get; set; }
    }
}
