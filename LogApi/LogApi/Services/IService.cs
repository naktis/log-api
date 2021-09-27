using LogApi.Dto;
using System.Collections.Generic;

namespace LogApi.Services
{
    public interface IService
    {
        public void Create(LogDto log);

        public bool ReadsAllowed();

        public ReadLogDto Read(int id);

        public IEnumerable<ReadLogDto> ReadAll();

        public bool Exists(int id);
    }
}
