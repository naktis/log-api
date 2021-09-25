using System.Collections.Generic;

namespace LogApi.Services
{
    public abstract class Service : IService
    {
        public abstract void Create(object log);

        public virtual bool Exists(object log)
        {
            return false;
        }

        public virtual object Read(int id)
        {
            return null;
        }

        public virtual List<object> ReadAll()
        {
            return new List<object>();
        }

        public virtual bool ReadsAllowed()
        {
            return false;
        }
    }
}
