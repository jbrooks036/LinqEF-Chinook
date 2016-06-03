using System.Linq;
using LinqEF_Chinook.Models;
using System.Data.Entity;
using System.Threading.Tasks;

namespace LinqEF_Chinook
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer<ChinookContext>(null);

            ChinookContext dbContext = new ChinookContext();
            var artistSearch = "Sabbath";
            var artist = dbContext.Artist.Where(a => a.Name.Contains(artistSearch)).FirstOrDefault();

            var artistName = artist.Name;
            System.Console.Write(artistName);
            System.Threading.Thread.Sleep(4000);
            System.Console.Read();
            // await Task.Delay(3000);
        }
    }
}
