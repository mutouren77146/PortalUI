using System.ComponentModel.DataAnnotations;

namespace COM.PortalUI.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}