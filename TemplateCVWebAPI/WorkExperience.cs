namespace TemplateCVWebAPI
{
    public class WorkExperience
    {
        public string CompanyName { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public string JobDescription { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; } = string.Empty;
        public string CompanyUrl { get; set; } = string.Empty;
        public List<string> Achievements { get; set; } = new List<string>();
    }
}
