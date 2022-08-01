namespace TodoList.Models
{
    public class TodoItem 
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public int Password { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
