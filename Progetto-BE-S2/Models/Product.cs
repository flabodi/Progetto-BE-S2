namespace Progetto_BE_S2.Models
{
    public class Product
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CoverImage { get; set; } 
        public string AdditionalImage1 { get; set; }
        public string AdditionalImage2 { get; set; }
    }
}
