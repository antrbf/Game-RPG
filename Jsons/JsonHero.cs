using RPG.Platform.Enums;
using System.ComponentModel.DataAnnotations;

namespace RPG.Jsons
{
    public class JsonHero
    {
        [Required]
        public TypeHero TypeHero { get; set; }

        [Required]
        public string Name { get; set; }
    }
}