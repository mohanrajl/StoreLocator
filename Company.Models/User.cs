namespace Company.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public bool Admin { get; set; }

        public bool Active { get; set; }
    }
}
