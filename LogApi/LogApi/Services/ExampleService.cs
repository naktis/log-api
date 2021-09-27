using LogApi.Dto;
using System.Collections.Generic;

namespace LogApi.Services
{
    public class ExampleService : Service
    {
        public override void Create(LogDto log) { }

        public override bool ReadsAllowed()
        {
            return true;
        }

        public override LogDto Read(int id)
        {
            return new LogDto{ Level = "divine" };
        }

        public override IEnumerable<LogDto> ReadAll()
        {
            return new List<LogDto>() { 
                new LogDto { Level = "divine" },
                new LogDto { Level = "info" }
            };
        }

        public override bool Exists(int id)
        {
            return true;
        }
    }
}
