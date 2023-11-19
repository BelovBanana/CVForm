namespace CVForm.Models
{
    public class CvViewModel
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Site { get; set; }
        public string? Summary { get; set; }
        public List<string>? WorkPeriods { get; set; }
        public string? Certification { get; set; }
        public byte[]? Avatar { get; set; }
    }
}
