using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MySpaceApi.Models
{
    public class Note
    {
        public int NoteID { get; set; }
        [Required]
        //public String UserID { get; set; }
        //[Required]
        public String SectionID { get; set; }
        public String Content { get; set; }
        [StringLength(500)]
        public String Priority { get; set; }
        [Required]
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;


    }
}