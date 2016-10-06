using VirtoCommerce.Storefront.Model.Common;

namespace VirtoCommerce.Storefront.Model
{
    public class Register : ValueObject<Login>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Division { get; set; }
        public string District { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public bool IsRunningStore { get; set; }
        public string newMemberType { get; set; }
        public string CatalogType { get; set; }
        public string CompanyName { get; set; }
        public string TaxId { get; set; }
        public string BusinessOwner { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
    }
}
