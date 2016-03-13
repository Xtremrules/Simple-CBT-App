using System.ComponentModel.DataAnnotations;

namespace CBT.WebUI.Models
{
    public class SettingsViewModel
    {
        [Required]
        public bool SortQuestion { get; set; }
        [Required]
        public bool SortOptions { get; set; }
        [Required]
        public string Name { get; set; }
    }
}