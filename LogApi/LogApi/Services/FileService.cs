using LogApi.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using LogApi.Models;
using System.Text.Json;

namespace LogApi.Services
{
    public class FileService : Service
    {

        public override void Create(LogDto log)
        {
            string fileName = "../LogApi/Data/Logs.txt";

            var logas = new Log {
                Timestamp = log.Timestamp,
                Level = log.Level,
                MessageTemplate = log.MessageTemplate,
                Renderedmessage = log.Renderedmessage,
                Properties = JsonSerializer.Serialize(log.Properties)

            };

            string row = logas.Timestamp + ";" + logas.Level + ";" + logas.MessageTemplate + ";" + logas.Renderedmessage + ";" + logas.Properties + ";";

            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(row);
            }
        }

        public override bool ReadsAllowed()
        {
            return true;
        }

        public override LogDto Read(int id)
        {
            return new LogDto { Level = "divine" };
        }

        public override IEnumerable<LogDto> ReadAll()
        {
            return new List<LogDto>() {
                new LogDto { Level = "divine" },
                new LogDto { Level = "info" }
            };
        }

        public override bool Exists(int id)
        {
            return true;
        }

    }
}

