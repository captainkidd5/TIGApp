using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TigApp.Models;

namespace TigApp.Services.Data
{
    public class WorkDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public WorkDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Work>().Wait();
        }

        public Task<List<Work>> GetNotesAsync()
        {
            return _database.Table<Work>().ToListAsync();
        }

        public Task<Work> GetNoteAsync(int id)
        {
            return _database.Table<Work>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveNoteAsync(Work note)
        {
            if (note.Id != 0)
            {
                return _database.UpdateAsync(note);
            }
            else
            {
                return _database.InsertAsync(note);
            }
        }

        public Task<int> DeleteNoteAsync(Work note)
        {
            return _database.DeleteAsync(note);
        }
    }
}
