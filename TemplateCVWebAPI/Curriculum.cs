using System.Numerics;

namespace TemplateCVWebAPI
{
    public class Curriculum
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string DNI { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string UrlLinkedIn { get; set; } = string.Empty;
        public string UrlGithub { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; } = DateTime.Now;
        public string Address { get; set; } = string.Empty;

        public List<WorkExperience> Experiences { get; set; } = new List<WorkExperience>();

    }
}
