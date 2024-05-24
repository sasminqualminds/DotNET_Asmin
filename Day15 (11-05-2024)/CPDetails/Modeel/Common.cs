namespace CPDetails.Modeel
{
    public class Common
    {
        
        
        public string CustomerName { get; set; }
        public int CustomerId { get; set; }
        public List<Product> products { get; set; }

        public Common()
        {
            products = new List<Product>();

        }
    }
}
