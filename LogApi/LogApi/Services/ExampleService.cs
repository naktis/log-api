namespace LogApi.Services
{
    public class ExampleService : Service
    {
        public override void Create(object log) { }

        public override bool ReadsAllowed()
        {
            return true;
        }
    }
}
