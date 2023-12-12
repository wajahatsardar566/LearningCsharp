namespace LearningCsharp.Models
{
    internal class Customer
    {
        public string ID { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public int Sales { get; set; }

        public override string ToString()
        {
            return "ID: " + ID + " City: " + City + " Country: " + Country +
            " Region: " + Region + " Sales: " + Sales;
        }
    }
}
