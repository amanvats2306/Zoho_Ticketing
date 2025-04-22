namespace Zoho_Ticketing.Models
{
    public class ZohoTicketRequest
    {
        public string subject { get; set; }
        public string departmentId { get; set; }
        public string description { get; set; }
        public string priority { get; set; } = "High";
        public string status { get; set; } = "Open";
    }

}
