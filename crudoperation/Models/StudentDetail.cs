using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace crudoperation.Models
{
    public class StudentDetail
    {
        [Key]
        public int SId { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string SName { get; set; }
        [Required]
        public string Phoneno { get; set; }
        [Required]
        public string Class { get; set; }
    }
}
