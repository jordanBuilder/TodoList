using Microsoft.EntityFrameworkCore;
using TodoList.Context;
namespace TodoList.Classes

{
    public class TodoService
    {
        private readonly AppDbContext _appDbContext;

        public TodoService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //Les services lets goooooo
        
        //Get all TodoList
        public async Task<List<Todo>> GetAllTodos()
        {
            List<Todo> todos;
            todos = await _appDbContext.Todos.ToListAsync();
            return todos;
        }

        //Add One Todo

        public async Task<bool> AddNewTodo(Todo todo)
        {
            await _appDbContext.Todos.AddAsync(todo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }
        
        //Get on Todo By Id

        public async Task<Todo> GetOneTodoById(int Id)
        {
            Todo todo;
           todo = await _appDbContext.Todos.FirstOrDefaultAsync(x => x.Id == Id);
            return todo;
        }

        //Update a todo 

        public async Task<bool> UpdateTodoDetails(Todo todo)
        {
            _appDbContext.Todos.Update(todo);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        //Delete a todo
            public async Task<bool> DeleteTodoDetails(Todo todo)
        {
            _appDbContext.Todos.Remove(todo);
            await _appDbContext.SaveChangesAsync();
            return true;
        } 

    }

}
