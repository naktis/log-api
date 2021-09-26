using LogApi.Dto;
using System;
using System.Text.Json;

namespace LogApi.Services
{
    public class ConsoleService : Service
    {
        public override void Create(LogDto log)
        {
            string creation = JsonSerializer.Serialize(log);
            Console.WriteLine(creation);
        }
    }
}
