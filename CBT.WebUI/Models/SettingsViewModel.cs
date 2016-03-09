using System.ComponentModel.DataAnnotations;

namespace CBT.WebUI.Models
{
    public class SettingsViewModel
    {
        public bool SortQuestion { get; set; }
        public bool SortOptions { get; set; }
        [Required]
        public string Name { get; set; }
    }
}