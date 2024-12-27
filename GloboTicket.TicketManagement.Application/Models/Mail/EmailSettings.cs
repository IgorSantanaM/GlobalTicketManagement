namespace GloboTicket.TicketManagement.Application.Features.Models.Mail
{
    public class EmailSettings
    {
        public string ApiKey { get; set; } = string.Empty;
        public string FromAddress { get; set; } = string.Empty;  
        public string FromName { get; set; } = string.Empty;
    }
}
