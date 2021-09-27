using LogApi.Dto;
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

        public override ReadLogDto Read(int id)
        {
            return new ReadLogDto { Level = "test" };
        }

        public override IEnumerable<ReadLogDto> ReadAll()
        {
            return new List<ReadLogDto>() {
                new ReadLogDto { Level = "test1" },
                new ReadLogDto { Level = "test2" }
            };
        }

        public override bool Exists(int id)
        {
            return true;
        }

    }
}

