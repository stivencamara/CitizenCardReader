﻿namespace CCR.Models
{
    public class Address
    {
        public string Street { get; set; }
        public string District { get; set; }
        public string Building { get; set; }
        public string Country { get; set; }
        public string Type { get; set; }
        public string Door { get; set; }
        /// <summary>
        /// Freguesia
        /// </summary>
        public string Parish { get; set; }
        public string Locality { get; set; }
        public string Floor { get; set; }
        public string ZipCode1 { get; set; }
        public string ZipCode2 { get; set; }
        public string StreetType { get; set; }
        /// <summary>
        /// Localidade Postal
        /// </summary>
        public string Postal { get; set; }
        /// <summary>
        /// Concelho
        /// </summary>
        public string Municipality { get; set; }
        public string Side { get; set; }
        /// <summary>
        /// Lugar
        /// </summary>
        public string Place { get; set; }
    }
}
