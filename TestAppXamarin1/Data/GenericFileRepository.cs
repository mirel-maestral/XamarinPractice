using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Linq;

namespace TestAppXamarin1.Data
{
    public class GenericFileRepository<T> where T: IEntity
    {
        private string filename;
        public GenericFileRepository(string fileName)
        {
            filename = fileName;
        }

        public T Get(int id){
            var items = LoadAllEntities();
            return items.FirstOrDefault(item => item.ID == id);
        }

        public IEnumerable<T> GetAll()
        {
            return LoadAllEntities();
        }

        private IEnumerable<T> LoadAllEntities()
        {
            var savedJson = DependencyService.Get<IFile>().LoadText(filename);
            return JsonConvert.DeserializeObject<IEnumerable<T>>(savedJson);
        }

        public void Save(T entity)
        {
            List<T> items;
            if (DependencyService.Get<IFile>().FileExists(filename))
            {
                items = LoadAllEntities().ToList();
                var item = items.FirstOrDefault(i => i.ID == entity.ID);
                if (item != null)
                    items.Remove(item);
            }
            else
            {
                items = new List<T>();
            }

            StoreEntities(items);
        }

        private void StoreEntities(IEnumerable<T> entities)
        {
            var serializedJson = JsonConvert.SerializeObject(entities);
            DependencyService.Get<IFile>().SaveText(filename, serializedJson);
        }

        public Save(IEnumerable<T> entities)
        {
            StoreEntities(entities);
        }

        public void Delete(int id)
        {
            var items = LoadAllEntities().ToList();
            var item = items.FirstOrDefault(i => i.ID == entity.ID);
            if (item != null)
            {
                items.Remove(item);

                StoreEntities(items);
            }
        }
    }
}
