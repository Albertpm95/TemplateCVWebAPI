using System.Numerics;

namespace TemplateCVWebAPI
{
    public class Curriculum
    {
        public string Nombre { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string DNI { get; set; } = string.Empty;
        public string NumeroTelefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string UrlLinkedIn { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; } = DateTime.Now;
    }
}
