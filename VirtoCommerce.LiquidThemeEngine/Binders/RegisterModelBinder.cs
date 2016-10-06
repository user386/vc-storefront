using System.Web;
using VirtoCommerce.Storefront.Model;

namespace VirtoCommerce.LiquidThemeEngine.Binders
{
    public class RegisterModelBinder : BaseModelBinder<Register>
    {
        protected override void ComplementModel(Register model, HttpRequestBase request)
        {
            model.FirstName = request["customer[first_name]"];
            model.LastName = request["customer[last_name]"];
            model.Email = request["customer[email]"];
            model.Password = request["customer[password]"];
            model.Division = request["customer[division]"];
            model.District = request["customer[district]"];
            model.PostalCode = request["customer[postal_code]"];
            model.Address = request["customer[address]"];
            model.IsRunningStore = (request["customer[is_running_store]"].Equals("on")) ? true : false;
            model.newMemberType = request["customer[new_member_type]"];
            model.CatalogType = request["customer[catalog_type]"];
            model.CompanyName = request["customer[company_name]"];
            model.TaxId = request["customer[tax_id]"];
            model.BusinessOwner = request["customer[business_owner]"];
            model.ContactNumber = request["customer[contact_number]"];
            model.ContactName = request["customer[contact_name]"];

        }
    }
}
