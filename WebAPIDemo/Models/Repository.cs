using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Breeze.ContextProvider;
using Newtonsoft.Json.Linq;
using Breeze.ContextProvider.EF6;

namespace WebAPIDemo.Models
{
    public class Repository : IRepository
    {
        private readonly EFContextProvider<WebAPIDemoContext> _contextProvider = new EFContextProvider<WebAPIDemoContext>();

        public string MetaData
        {
            get { return _contextProvider.Metadata(); }
        }

        public IQueryable<Book> Books()
        {
            return _contextProvider.Context.Books;
        }

        public IQueryable<Order> Orders()
        {
            return _contextProvider.Context.Orders;
        }

        public SaveResult SaveChanges(JObject saveBundle)
        {
            return _contextProvider.SaveChanges(saveBundle);
        }
    }
}