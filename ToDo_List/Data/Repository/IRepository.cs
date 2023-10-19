using ToDo_List.Models;

namespace ToDo_List.Data.Repository
{
    public interface IRepository
    {
        void Create(string toDoName, bool isDone);
        IEnumerable<ToDoItem> Read();

        void Update(ToDoItem updatedItem);
        void Delete(int id);
    }
}
