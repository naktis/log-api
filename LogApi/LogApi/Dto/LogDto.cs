using System;

namespace LogApi.Dto
{
    public class LogDto
    {
        public DateTime Timestamp { get; set; }
        public string Level { get; set; }
        public string MessageTemplate { get; set; }
        public string Renderedmessage { get; set; }
        public object Properties { get; set; }
    }
}
