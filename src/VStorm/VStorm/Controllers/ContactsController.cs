using System.Linq;
using System.Web.Http;
using Breeze.ContextProvider.EF6;
using Breeze.WebApi2;
using VStorm.Models;

namespace VStorm.Controllers
{
    [BreezeController]
    public class ContactsController : ApiController
    {
        private readonly IContextProvider<ContactsContext> _provider;

        readonly EFContextProvider<ContactsContext> _contextProvider =
            new EFContextProvider<ContactsContext>();

        public ContactsController(IContextProvider<ContactsContext> provider)
        {
            _provider = provider;
        }

        // ~/breeze/todos/Metadata 
        [HttpGet]
        public string Metadata()
        {
            return _provider.Metadata();
        }

        // ~/breeze/contacts/Contacts
        [HttpGet]
        public IQueryable<ContactItem> Contacts()
        {
            return _provider.Context.Contacts;
        }
    }
}
