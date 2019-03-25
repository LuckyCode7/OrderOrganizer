namespace OrderOrganizer
{
    public class Order
    {
        public string ClientId;
        public long RequestId;
        public string Name;
        public int Quantity;
        public double Price;
        public bool IsCorrect = true;
        public string AsString;
        public override string ToString()
        {
            return 
                "ClientID [" + ClientId + "] "
                + "RequestID [" + RequestId + "] "
                + "Name [" + Name + "] "
                + "Quantity [" + Quantity + "] "
                + "Price [" + Price.ToString("0.00") + "]";
        }
    }
}
