using ToDo_List.Models;

namespace ToDo_List.Data.Repository
{
    public class SQLRepository : IRepository
    {
        private readonly ApplicationDbContext _context;

        public SQLRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Create(string toDoName, bool isDone)
        {
            ToDoItem newItem = new ToDoItem()
            {
                Title = toDoName,
                IsDone = false,
            };
            _context.ToDoItems.Add(newItem);
            _context.SaveChanges();
        }

        public IEnumerable<ToDoItem> Read()
        {
            return _context.ToDoItems;
        }

        public void Update(ToDoItem updatedItem)
        {
            var item = _context.ToDoItems.Attach(updatedItem);
            item.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var deletedItem = _context.ToDoItems.Find(id);

            if (deletedItem != null)
            {
                _context.ToDoItems.Remove(deletedItem);
            }

            _context.SaveChanges();
        }


    }
}
