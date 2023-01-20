using System.ComponentModel.DataAnnotations;


namespace BookStore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Display(Name = "Display Order")]
        [Range(1,100, ErrorMessage ="Display order must be between 1 and 100 only!")]
        [Required]
        public int DisplayOrder { get; set; }

        [Display(Name = "Time Created")]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
