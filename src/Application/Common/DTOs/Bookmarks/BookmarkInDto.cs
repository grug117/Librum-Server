using System.ComponentModel.DataAnnotations;
using Application.Common.DTOs.Highlights;

namespace Application.Common.DTOs.Bookmarks;

public class BookmarkInDto
{
    [Required]
    public Guid Guid { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public int PageNumber { get; set; }
    
    [Required]
    public float YOffset { get; set; }
}