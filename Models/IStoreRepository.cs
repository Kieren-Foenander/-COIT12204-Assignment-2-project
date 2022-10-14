using System.Linq;

namespace Assignment_1.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
