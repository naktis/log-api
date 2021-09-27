using System;
using System.Collections.Generic;

namespace LogApi.Models

{
    public class Log
    {
        public int LogId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Level { get; set; }
        public string MessageTemplate { get; set; }
        public string Renderedmessage { get; set; }
        public string Properties { get; set; }

        public List<Log> Posts { get; } = new List<Log>();
    }
}
