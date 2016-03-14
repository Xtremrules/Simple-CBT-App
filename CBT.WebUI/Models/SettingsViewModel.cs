using System.ComponentModel.DataAnnotations;

namespace CBT.WebUI.Models
{
    public class SettingsViewModel : Named
    {
        [Required]
        public bool SortQuestion { get; set; }
        [Required]
        public bool SortOptions { get; set; }
    }
}