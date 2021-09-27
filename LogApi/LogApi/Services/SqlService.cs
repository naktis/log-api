using LogApi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace LogApi.Services
{
    public class SqlService : Service
    {
          
    public override void Create(LogDto log)
        {
            using var db = new LoggingContext();
            db.Add(new Log {
           Timestamp = log.Timestamp,
                Level = log.Level,
                MessageTemplate = log.MessageTemplate,
                Renderedmessage = log.Renderedmessage,
                Properties = JsonSerializer.Serialize(log.Properties)
        });
            db.SaveChanges();

        }

        public override bool ReadsAllowed()
        {
            return true;
        }

        public override LogDto Read(int id)
        {
            using var db = new LoggingContext();
            var log = db.Logs
                    .OrderBy(b => b.LogId)
                    .First();
            return null;

        }

        public override IEnumerable<LogDto> ReadAll()
        {
            using var db = new LoggingContext();
            var logs = db.Logs.ToList<Log>();
            var dtoLogs = new List<ReadLogDto>();
            foreach (var log in logs)
            {
                var readLogDto = new ReadLogDto
                {
                    LogId = log.LogId,
                    Timestamp = log.Timestamp,
                    Level = log.Level,
                    MessageTemplate = log.MessageTemplate,
                    Renderedmessage = log.Renderedmessage,
                    Properties = JsonSerializer.Deserialize<object>(log.Properties)
                };
                dtoLogs.Add(readLogDto);
            }

            return dtoLogs;
        }

        public override bool Exists(int id)
        {
            return true;
        }
    }
}
