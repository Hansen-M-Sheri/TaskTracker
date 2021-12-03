using System;
namespace Tasks.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public bool IsActive { get; set; }

        public string FullName => string.Format("{0} {1}", FirstName, LastName);
            

    }
}
