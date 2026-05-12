using System.Security.Claims;

namespace House_renting_system_Project.Extentions
{
    public static class UserExtensions
    {
        extension(ClaimsPrincipal user)
        {
            public string? GetId()
                => user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
