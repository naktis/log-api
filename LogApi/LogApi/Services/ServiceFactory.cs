using System;
using System.Collections.Generic;

namespace LogApi.Services
{
    public class ServiceFactory
    {
        private readonly string _destination;
        private readonly IDictionary<string, Func<IService>> _services;

        public ServiceFactory(string destination)
        {
            _destination = destination.ToLower();

            _services = new Dictionary<string, Func<IService>>()
            {
                {"console", () => new ConsoleService() },
                {"email", () => new SqlService() },
                {"file", () => new SqlService() },
                {"sql", () => new SqlService() }
            };
        }

        public IService GetService()
        {
            _services.TryGetValue(_destination, out Func<IService> creationFun);
            return creationFun();
        }
    }
}
