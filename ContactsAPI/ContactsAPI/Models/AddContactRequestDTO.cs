namespace ContactsAPI.Models
{
    public class AddContactRequestDTO
    {
        public required string Name { get; set; }

        public string? Email { get; set; }

        public required string PhoneNumber { get; set; }

        public bool Favorite { get; set; }
    }
}
