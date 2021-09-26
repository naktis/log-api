using LogApi.Dto;

namespace LogApi.Services
{
    public class ExampleService : Service
    {
        public override void Create(LogDto log) { }

        public override bool ReadsAllowed()
        {
            return true;
        }
    }
}
