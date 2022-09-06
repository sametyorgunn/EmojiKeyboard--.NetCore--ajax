using System.ComponentModel.DataAnnotations;

namespace emojikeyboard.Models
{
    public class Emoji
    {
        [Key]
        public int Id { get; set; }
        public string emoji_kod { get; set; }
    }
}
