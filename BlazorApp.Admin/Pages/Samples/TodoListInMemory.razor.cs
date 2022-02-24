using BlazorApp.Models;

namespace BlazorApp.Admin.Pages.Samples
{
    public partial class TodoListInMemory
    {
        private string newTodo = "";
        private IList<TodoItem> todos = new List<TodoItem>();

        /// <summary>
        /// 
        /// </summary>
        protected override void OnInitialized()
        {
            todos.Add(new TodoItem() { Id = 1, Title = "할일1", IsDone = true });
        }

        /// <summary>
        /// 
        /// </summary>
        protected void Save()
        {
            todos.Add(new TodoItem() { Title = newTodo });
            newTodo = null;
        }
    }
}
