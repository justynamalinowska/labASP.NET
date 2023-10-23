using System.Data.Common;

namespace Laboratorium2.Models
{
    public class Birth
    {
        public string? Name { get; set; }
        public string? Date { get; set; }

        public bool IsValid() => Name != null && DateTime.Now >= DateTime.Parse(Date);

        public int GetAge() => DateTime.Now.Year - DateTime.Parse(Date).Year;
    }
}
