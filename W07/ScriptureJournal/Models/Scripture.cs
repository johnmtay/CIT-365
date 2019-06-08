using System;
using System.ComponentModel.DataAnnotations;

namespace ScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Book { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Reference { get; set; }

        [StringLength(200, MinimumLength = 3)]
        [Required]
        public string Passage { get; set; }
        public string Note { get; set; }

        [Display(Name = "Date Added")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
    }
}
