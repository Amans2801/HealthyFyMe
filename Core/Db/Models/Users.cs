namespace HealthyFyMe.Core.Db.Models
{
    public class Users
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string MobileNumber { get; set; } = string.Empty;

        public string HashPassword { get; set; } = string.Empty;

        public string Goal { get; set; } = string.Empty;

        public decimal Height { get; set; }

        public decimal Weight { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
