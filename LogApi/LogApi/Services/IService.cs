using LogApi.Dto;
using System.Collections.Generic;

namespace LogApi.Services
{
    public interface IService
    {
        public void Create(LogDto log);

        public bool ReadsAllowed();

        public LogDto Read(int id);

        public IEnumerable<LogDto> ReadAll();

        public bool Exists(int id);
    }
}
