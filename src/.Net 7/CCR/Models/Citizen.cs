using System.Net;

namespace CCR.Models
{
    public class Citizen
    {
        public string Number { get; set; }
        public string BI { get; set; }
        public string Nationality { get; set; }
        public string ExpirationDate { get; set; }
        public string Genre { get; set; }
        public string Country { get; set; }
        public string SNS { get; set; }
        public string NIF { get; set; }
        public string BirthDate { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }

        /// <summary>
        /// base 64 picture
        /// </summary>
        public string Picture { get; set; }
        public List<Certificate> Certificates { get; set; }
        public Address Address { get; set; }

        public Citizen()
        {
            Address = new Address();
            Certificates = new List<Certificate>();
        }

    }
}
