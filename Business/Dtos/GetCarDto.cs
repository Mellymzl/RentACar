namespace Business.Dtos
{
    public class GetCarDto
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
