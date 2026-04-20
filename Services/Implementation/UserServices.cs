using HealthyFyMe.Core.Db.Models;
using HealthyFyMe.Core.DTO_s.Requests;
using HealthyFyMe.Services.Interfaces;

namespace HealthyFyMe.Services.Implementation
{
    public class UserServices : IUserServices
    {
        public async Task<> AddUserAsync(AddUserRequest adduserRequest)
        {
            try
            {
                Users newUser = new Users
                {
                    Email = adduserRequest.Email,
                    Name = adduserRequest.Name,
                    Height = adduserRequest.Height,
                    Weight = adduserRequest.Weight,
                    Goal = adduserRequest.Goal,
                    HashPassword = BCrypt.Net.BCrypt.HashPassword(adduserRequest.Password),
                    CreatedAt = DateTime.UtcNow
                };

                await
            }
        }
    }
}
