namespace CCR.Models
{
    public class Certificate
    {
        public string Label { get; set; }
        public string ExpirationDateString { get; set; }
        public string KeyAlgorithm { get; set; }
        public string PublicKey { get; set; }
    }
}
