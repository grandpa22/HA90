using System.ComponentModel.DataAnnotations;

namespace ArtmisNet.Ha90.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}