using System.Collections.Generic;

namespace LogApi.Services
{
    public interface IService
    {
        public void Create(object log);

        public bool ReadsAllowed();

        public object Read(int id);

        public List<object> ReadAll();

        public bool Exists(object log);
    }
}
