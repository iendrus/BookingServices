using BookingServices.Domain.Common;
using System;


namespace BookingServices.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public string? Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Number { get; set; }

        public Address()
        {
                
        }
        public Address(string street, string city, string zipcode, string number)
        {
            Street = street;
            City = city;
            ZipCode = zipcode;
            Number = number;
        }

        public override string ToString()
        {
            string cityStreet = Street == null ? City : $"{City}, {Street}";
            return $"{ZipCode} {cityStreet} {Number}";
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            // Using a yield return statement to return each element one at a time
            yield return Street;
            yield return City;
            yield return ZipCode;
            yield return Number;
        }
    }
}
