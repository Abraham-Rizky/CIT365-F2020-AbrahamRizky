using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9_][a-zA-Z0-9_ ]*[a-zA-Z0-9_]$")]
        [StringLength(30)]
        [Required]
        public string Book { get; set; }

        [Required]
        [Range(1, 500)]
        [DataType(DataType.Text)]
        [Column(TypeName = "varchar(3)")]
        public string Chapter { get; set; }

        [Required]
        [Range(1, 500)]
        [DataType(DataType.Text)]
        [Column(TypeName = "varchar(3)")]
        public string Verse { get; set; }
        
        [Required]
        [StringLength(1000)]
        public string Notes { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
