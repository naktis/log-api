using LogApi.Dto;
using System.Collections.Generic;

namespace LogApi.Services
{
    public abstract class Service : IService
    {
        public abstract void Create(LogDto log);

        public virtual bool Exists(int id)
        {
            return false;
        }

        public virtual ReadLogDto Read(int id)
        {
            return null;
        }

        public virtual IEnumerable<ReadLogDto> ReadAll()
        {
            return null;
        }

        public virtual bool ReadsAllowed()
        {
            return false;
        }
    }
}
