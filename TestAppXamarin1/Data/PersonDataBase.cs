using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using TestAppXamarin1.Models;

namespace TestAppXamarin1.Data
{
    public class PersonDataBase
    {
        readonly SQLiteAsyncConnection database;

        public PersonDataBase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Person>().Wait();
        }

        public Task<List<Person>> GetPeopleAsync(){
            return database.Table<Person>().ToListAsync();
        }

        public Task<Person> GetPersonAsync(int id)
        {
            return database.Table<Person>().Where(prop => prop.ID == id)
                           .FirstOrDefaultAsync();
        }

        public Task<int> SavePersonAsync(Person person)
        {
            if (person.ID == 0)
            {
                return database.InsertAsync(person);
            }
            else
            {
                return database.UpdateAsync(person);
            }
        }

        public Task<int> DeleteAsync(Person person)
        {
            return database.DeleteAsync(person);
        }
    }
}
