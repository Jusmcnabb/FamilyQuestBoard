using System.ComponentModel.DataAnnotations;

namespace FamilyQuestBoard.Models
{
    public class Quest
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime CompletionDate { get; set; }
        [DataType(DataType.Date)]
        public DateTimeOffset CreationDate { get; set; } = DateTimeOffset.UtcNow;
        public int Points { get; set; }

    }
}
