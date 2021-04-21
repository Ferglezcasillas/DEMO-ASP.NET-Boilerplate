using System.ComponentModel.DataAnnotations;

namespace Test.MyProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}