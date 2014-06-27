﻿using System.Linq;
using System.Web.Http;
using Breeze.ContextProvider.EF6;
using Breeze.WebApi2;
using VStorm.Models;

namespace VStorm.Controllers
{
    [BreezeController]
    public class ContactsController : ApiController
    {
        readonly EFContextProvider<ContactsContext> _contextProvider =
            new EFContextProvider<ContactsContext>();

        public ContactsController()
        {
            
        }

        // ~/breeze/todos/Metadata 
        [HttpGet]
        public string Metadata()
        {
            return _contextProvider.Metadata();
        }

        // ~/breeze/contacts/Contacts
        [HttpGet]
        public IQueryable<ContactItem> Contacts()
        {
            return _contextProvider.Context.Contacts;
        }
    }
}
