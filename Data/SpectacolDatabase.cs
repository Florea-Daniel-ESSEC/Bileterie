using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bileterie.Models;
namespace Bileterie.Data
{
    public class SpectacolDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public SpectacolDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Spectacol>().Wait();
        }
        public Task<List<Spectacol>> GetSpectacolAsync()
        {
            return _database.Table<Spectacol>().ToListAsync();
        }
        public Task<Spectacol> GetSpectacolAsync(int id)
        {
            return _database.Table<Spectacol>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveSpectacolAsync(Spectacol slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteSpectacolAsync(Spectacol slist)
        {
            return _database.DeleteAsync(slist);
        }
    }
}
