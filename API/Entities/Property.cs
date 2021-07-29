using Microsoft.EntityFrameworkCore;


namespace API.Entities
{
    public class Property
    {
        public int Id { get; set; }
        public string ListingUrl { get; set; }
        public string Address { get; set; }
        public int ListPrice { get; set; }
        public float DownPayment { get; set; }
        public float InterestRate { get; set; }
        public int RenovationFurnitureCost { get; set;}
        public int NightlyRate { get; set; }
        public float Occupancy { get; set; }
        public int UtilitiesEtc { get; set; }

        public float NetIncome { get; set; }
    }
}