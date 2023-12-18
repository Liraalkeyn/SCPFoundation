using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SCPFoundation.Context;

public class LoginContext : IdentityDbContext
{
    public LoginContext(DbContextOptions options) : base(options)
    {
    }
}