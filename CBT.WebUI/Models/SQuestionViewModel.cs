using System.ComponentModel.DataAnnotations;

namespace CBT.WebUI.Models
{
    public class SQuestionViewModel : Named
    {
        [Required]
        public int NumberofOptions { get; set; }
        [Required]
        public int NumberofQuestions { get; set; }
        [Required]
        public int SettingID { get; set; }
    }

    public class Named
    {
        [Required]
        public string Name { get; set; }
    }
}