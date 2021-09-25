using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogApi.Configuration
{
    public class OptionsValidator
    {
        public void ValidateDestination(string destination, ICollection<string> availableDestinations)
        {
            if (!availableDestinations.Contains(destination))
                throw new Exception("Data destination isn't supported. Change it in appsettings.json under LoggerOptions " +
                    "into a key from ServiceFactory class' _service dictionary");
        }
    }
}
