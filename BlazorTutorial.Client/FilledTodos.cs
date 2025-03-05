using BlazorTutorial.Client.Models;

namespace BlazorTutorial.Client
{
    public class FilledTodos
    {
        public List<TodoItem> GetFilledTodoItems()
        {
            return new List<TodoItem>()
            {
                new TodoItem()
                {
                    IsDone=false,
                    Title="First Todo"
                },
                new TodoItem()
                {
                    IsDone=false,
                    Title="Second Todo"
                },
                new TodoItem()
                {
                    IsDone=false,
                    Title="Third todo"
                }
            };
        }
    }
}
