namespace ProjectManager.Models
{
    public class UserStoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string WorkRemaining { get; set; }
        public bool Completed { get; set; }
    }
}