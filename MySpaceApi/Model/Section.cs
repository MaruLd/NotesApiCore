using MySpaceApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MySpaceApi.Model
{
    public class Section
    {
        public int SectionID { get; set; }
        [Required]
        //public String UserID { get; set; }
        //[Required]
        public String SectionName { get; set; }
        [Required]
        [StringLength(50)]
        public String Status { get; set; }
        [Required]
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        
    }
}