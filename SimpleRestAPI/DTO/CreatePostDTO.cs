using System.ComponentModel.DataAnnotations;

namespace SimpleRestAPI.DTO;

public record class CreatePostDTO
{
    [Required][StringLength(50)]public string Title {get;set;}
    [Required][StringLength(1000)]public string Content {get;set;}
}
