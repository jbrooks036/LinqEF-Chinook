using System.Linq;
using LinqEF_Chinook.Models;
using System.Data.Entity;

namespace LinqEF_Chinook
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer<ChinookContext>(null);

            ChinookContext dbContext = new ChinookContext();
            var artistSearch = "Sabbath";
            var artists = dbContext.Artist.Where(a => a.Name.Contains(artistSearch));

        }
    }
}
