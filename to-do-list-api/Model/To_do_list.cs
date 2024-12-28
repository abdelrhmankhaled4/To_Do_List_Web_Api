using System.ComponentModel.DataAnnotations;

namespace to_do_list_api.Model
{
    public class To_do_list
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public bool? IsComplete { get; set; }
    }
}
