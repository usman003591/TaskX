using System.ComponentModel.DataAnnotations;

namespace TaskX.Models
{
    public class TodoTask
    {
        //[Key] //is not necessary here as the Id property is already the primary key by convention
        public int Id { get; set; } //As the name of the attribute is Id or includes the Id word in it, it will be used as the primary key by default

        [Required(ErrorMessage ="Please enter a title!")]
        public required string Title { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; } //Adding a question mark makes this property nullable or you can use this method as well

        //public string Description { get; set; } = string.Empty; //This is another way to make the property nullable. In this method is being initialized with an empty string
        [Required]
        public bool Bookmarked { get; set; } = false; //This is the default value for this property

        public DateTime CreatedAt { get; set; } = DateTime.Now; //This is the default value for this property

    }
}
