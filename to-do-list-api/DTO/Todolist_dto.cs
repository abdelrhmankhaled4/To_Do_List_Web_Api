using System.ComponentModel.DataAnnotations;

namespace to_do_list_api.DTO
{
    public class Todolist_dto
    {
        public string? Name { get; set; }
        public bool? IsComplete { get; set; }
    }
}
