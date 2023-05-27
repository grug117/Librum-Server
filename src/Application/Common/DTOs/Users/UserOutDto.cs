using Application.Common.DTOs.Tags;

namespace Application.Common.DTOs.Users;

public class UserOutDto
{
    public string FirstName { get; set; }
    
    public string LastName { get; set; }

    public string Email { get; set; }

    public DateTime AccountCreation { get; set; }
    
    public double usedBookStorage { get; set; }

    public ICollection<TagOutDto> Tags { get; set; } = new List<TagOutDto>();
}
