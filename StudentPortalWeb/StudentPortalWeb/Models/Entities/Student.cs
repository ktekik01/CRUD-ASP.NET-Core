namespace StudentPortalWeb.Models.Entities
{
    public class Student
    {
        public Guid Id { get; set; } // Guid is a type that represents a globally unique identifier (GUID).

        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public bool Subscribed { get; set; }




    }
}
