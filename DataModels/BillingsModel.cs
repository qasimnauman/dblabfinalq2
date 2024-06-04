namespace DataModels
{
    public class BillingModel
    {
        public int bid { get; set; }
        public int aid { get; set; }
        public decimal amount { get; set; }
        public DateOnly bdate { get; set; }
    }
}
