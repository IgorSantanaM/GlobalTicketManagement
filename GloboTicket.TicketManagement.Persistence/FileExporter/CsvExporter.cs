using CsvHelper;
using GloboTicket.TicketManagement.Application.Contracts.Infrastructure;
using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsExport;

namespace GloboTicket.TicketManagement.Persistence.FileExporter
{
    public class CsvExporter : ICsvExporter 
    {
        public byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos)
        {
            using var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream, leaveOpen: true))
            {
                using var csvWriter = new CsvWriter(streamWriter, System.Globalization.CultureInfo.InvariantCulture);
                csvWriter.WriteRecords(eventExportDtos);
            }

            memoryStream.Position = 0;

            return memoryStream.ToArray();
        }
    }
}
