using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Models
{
#pragma warning disable CS8618
    public class JournalEntry
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Entry Date")]
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }
        [RegularExpression(@"^([A-Za-z]{3,50}|([A-Za-z0-9]+\s[A-Za-z]+))$")]
        [DataType(DataType.Text)]
        [StringLength(30)]
        [Required]
        public string Book { get; set; }
     
        public string Reference { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(1000)]
        public string Notes { get; set; }



    }
#pragma warning restore CS8618
}
