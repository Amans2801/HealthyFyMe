namespace HealthyFyMe.Core.DTO_s.Requests
{
    public class AddUserRequest
    {
        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password {  get; set; } = string.Empty;

        public string Goal { get; set; } = string.Empty;

        public decimal Height { get; set; }

        public decimal Weight { get; set; }
    }
}
