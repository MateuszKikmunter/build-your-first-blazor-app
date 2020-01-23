namespace FirstBlazorApp.Data
{
    public class TodoItem
    {
        public TodoItem(string title, bool isDone = false)
        {
            Title = title;
            IsDone = isDone;
        }

        public string Title { get; }
        public bool IsDone { get; }
    }
}
