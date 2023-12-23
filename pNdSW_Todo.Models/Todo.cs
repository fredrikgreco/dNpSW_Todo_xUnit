namespace Models_Todo
{
    public class Todo
    {
        public int Id {  get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsDone { get; set; }
        public bool IsDeleted { get; set; }
    }
}
