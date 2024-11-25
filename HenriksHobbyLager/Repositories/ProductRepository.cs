using RefactoringExercise.Interfaces;

namespace HenriksHobbyLager.Repositories
{
    internal class ProductRepository : IRepository<T>
    {
        // Remove to another class (Later)
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Stock { get; set; }
            public string Category { get; set; }
            public DateTime Created { get; set; }
            public DateTime? LastUpdated { get; set; }  // Frågetecknet är för att jag är osäker på datumet
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Search(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

      

    }
}
