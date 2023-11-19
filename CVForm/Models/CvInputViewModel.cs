namespace CVForm.Models
{
    public class CvInputViewModel
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Site { get; set; }
        public string? Summary { get; set; }
        public string? WorkPeriods { get; set; }
        public string? Certification { get; set; }
        public IFormFile? Avatar { get; set; }
    }
}
