﻿using LogApi.Configuration;
using System;
using System.Collections.Generic;

namespace LogApi.Services
{
    public class ServiceFactory
    {
        private readonly string _destination;
        private readonly IDictionary<string, Func<IService>> _services;
        private readonly OptionsValidator _validator;

        public ServiceFactory(string destination)
        {
            _destination = destination.ToLower();

            _services = new Dictionary<string, Func<IService>>()
            {
                {"console", () => new ExampleService() },
                {"email", () => new ExampleService() },
                {"file", () => new ExampleService() },
                {"sql", () => new ExampleService() }
            };

            _validator = new OptionsValidator();
            _validator.ValidateDestination(_destination, _services.Keys);
        }

        public IService GetService()
        {
            _services.TryGetValue(_destination, out Func<IService> creationFun);
            return creationFun();
        }
    }
}