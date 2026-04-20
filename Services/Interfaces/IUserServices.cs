using HealthyFyMe.Core.DTO_s.Requests;

namespace HealthyFyMe.Services.Interfaces
{
    public interface IUserServices
    {
        public Task<> AddUserAsync(AddUserRequest adduserRequest);
    }
}
