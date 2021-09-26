using LogApi.Dto;
using System.Collections.Generic;

namespace LogApi.Services
{
    public interface IService
    {
        public void Create(LogDto log);

        public bool ReadsAllowed();

        public LogDto Read(int id);

        public List<LogDto> ReadAll();

        public bool Exists(LogDto log);
    }
}
