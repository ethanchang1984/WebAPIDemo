using System.Linq;
using Newtonsoft.Json.Linq;
using Breeze.ContextProvider;

namespace WebAPIDemo.Models
{
    public interface IRepository
    {
        string MetaData { get; }

        IQueryable<Book> Books();
        SaveResult SaveChanges(JObject saveBundle);
        IQueryable<Order> Orders();
    }
}