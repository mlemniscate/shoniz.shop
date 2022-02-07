using shoniz.Framework.Domain;
using System;

namespace shoniz.shop.CustomerContext.Domain.Customers
{
    public class Address : EntityBase
    {
        public Address(Guid customerId, int cityId, string postalCode, string addressLine)
        {
            CustomerId = customerId;
            CityId = cityId;
            SetPostalCode(postalCode);
            SetAddressLine(addressLine);
        }

        public string PostalCode { get; private set; }
        public string AddressLine { get; private set; }
        public int CityId { get; private set; }
        public Guid CustomerId { get; private set; }
        public string Telephone { get; set; }
        public string Coordinate { get; set; }

        private void SetAddressLine(string addressLine)
        {
            if(string.IsNullOrWhiteSpace(addressLine))
            {
                // 
            }
            AddressLine = addressLine;
        }

        private void SetPostalCode(string postalCode)
        {
            if (string.IsNullOrWhiteSpace(postalCode))
            {
                //
            }
            PostalCode = postalCode;
        }
    }
}
